using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using AxWMPLib;
using Timer = System.Windows.Forms.Timer;

namespace tiyatro {
    public partial class MainForm :Form {
        private bool isPlaying = false; // Ses çalma durumunu takip eden değişken
        private bool isPlayingVideo = false; // Video oynatma durumunu takip eden değişken
        private bool isPauseVideo = false; // Video PAUSE durumunu takip eden değişken
        private VideoForm videoForm = new(); // VideoForm örneği
        private bool otomatikDuraklama = false; // Video nun otomatik duraklaması için oluşturulan değişken
        private bool videoZamanOgrenmeModu = false; // video zaman çizelgesi çıkarma değişkeni
        private string? resourceName = null;
        private string? videoFileName = null;

        private List<double> defaultTimeLine = new() { 3.5373279, 5.0073256, 9.0573285, 14.0273299, 19.1173312, 25.9673297, 28.957325, 34.6273253, 42.9173308, 85.7873282, 91.1262496, 110.1463034, 116.4763213, 135.6963753, 137.5163776, 197.123666, 200.8336807, 217.5137315, 232.33377, 234.0686982, 253.0687519, 255.3687548, 257.5687575, 259.5087699, 261.3887723, 271.2787947, 272.8688066, 295.2988647, 304.8088966, 314.0089181, 323.9689505, 332.8089716, 350.3890235, 360.329046, 367.8790754, 374.5479124, 378.2263325, 388.5963655, 400.9164008, 409.056421, 417.806452, 435.3564939, 467.1665837, 484.4366352, 497.6166717, 538.0067822 };

        private List<double> videoPauseIntervals;

        private Timer playAndVolumeTimer;
        private int playTime = 0;
        private int volumeDecreaseStep = 1; // Her adımda sesin ne kadar azalacağı
        private int volumeDecreaseInterval = 1000; // Her adımın süresi (milisaniye)
        private int targetVolume = 0;
        private int volumeDecreaseStart = 0;
        private int volumeDecreaseEnd = 3;

        public MainForm() {
            InitializeComponent();
            InitializeTimer();

            audioPlayer.PlayStateChange += AudioPlayer_PlayStateChanged;
            audioPlayer.settings.volume = 100;

            videoForm.axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
            videoForm.Show();

            videoPauseIntervals = new List<double>(defaultTimeLine); // Yeni liste oluşturuldu;
        }

        private void btn_video_from_full_screen_Click(object sender, EventArgs e) {
            if (videoForm.WindowState == FormWindowState.Maximized) {
                videoForm.WindowState = FormWindowState.Normal;
                videoForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                btn_video_from_full_screen.Text = "Video Tam Ekran";
                videoForm.axWindowsMediaPlayer1.uiMode = "full";
            }
            else {
                videoForm.WindowState = FormWindowState.Maximized;
                videoForm.FormBorderStyle = FormBorderStyle.None;
                btn_video_from_full_screen.Text = "Video Küçült";
                videoForm.axWindowsMediaPlayer1.uiMode = "none";
            }
        }

        private void bnt_video_control_Click(object sender, EventArgs e) {
            VideoPlayStartOrStop();
        }

        private void btn_emel_sahne_Click(object sender, EventArgs e) {
            try {
                if (videoForm == null || videoForm.IsDisposed) {
                    videoForm = new VideoForm();
                    videoForm.Show();
                }

                if (!string.IsNullOrEmpty(resourceName) && !string.IsNullOrEmpty(videoFileName)) {
                    DialogResult result = MessageBox.Show("Video seçilmiş tekrar seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK) {
                        // OK butonuna tıklandığında yapılacak işlemler
                        resourceName = null;
                        videoFileName = null;
                        videoForm.StopVideo();
                        videoPauseIntervals = new List<double>(defaultTimeLine); // Yeni liste oluşturuldu;
                        bnt_video_control.Enabled = true;
                        btn_otomatik_duraklama.Enabled = true;
                    }
                    else
                        return;
                }

                resourceName = @"Properties\Resources\emel_sahne_tum_videolar.mp4";
                videoFileName = "emel_sahne_tum_videolar.mp4";

                btn_emel_sahne.BackColor = Color.LightGreen;
                bnt_video_control.BackColor = Color.GreenYellow;
                bnt_video_control.Text = "VİDEO BAŞLAT";
                isPlayingVideo = false;
                isPauseVideo = false;

            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_5_geri_Click(object sender, EventArgs e) {
            videoForm.RewindVideo(5);
        }

        private void btn_10_geri_Click(object sender, EventArgs e) {
            videoForm.RewindVideo(10);
        }

        private void btn_5_ileri_Click(object sender, EventArgs e) {
            videoForm.ForwardVideo(5);
        }

        private void btn_10_ileri_Click(object sender, EventArgs e) {
            videoForm.ForwardVideo(10);
        }

        private void PlayOrStopAudio(string filePath, Button button) {
            try {
                if (!isPlaying) {
                    // Geçici dosyayı oynat
                    audioPlayer.URL = filePath;
                    audioPlayer.Ctlcontrols.play();
                    audioPlayer.settings.volume = 100;
                    isPlaying = true;
                    button.Text = "Durdur";
                    button.BackColor = Color.LightCoral;
                }
                else {
                    // Ses çalıyorsa, durdur
                    audioPlayer.Ctlcontrols.stop();
                    audioPlayer.URL = string.Empty;
                    audioPlayer.Refresh();

                    DefaultValues();
                    isPlaying = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_giris_muzigi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\aysel_aglama_giris_muzigi.mp3", btn_giris_muzigi);
        }

        private void btn_kamil_acilma_sesi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\1_kamil_acilma_sesi.mp3", btn_kamil_acilma_sesi);
        }

        private void btn_kamil_dogrulma_sesi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\2_kamil_dogrulma_sesi.mp3", btn_kamil_dogrulma_sesi);
        }

        private void btn_3_kamil_kalkarken_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\3_kamil_kalkarken.mp3", btn_3_kamil_kalkarken);
        }

        private void btn_4_kamil_yurumesi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\4_kamil_yurumesi.mp3", btn_4_kamil_yurumesi);
        }

        private void btn_5_kamil_dans_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\5_kamil_dans.mp3", btn_5_kamil_dans);
        }

        private void btn_6_aysel_dans_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\6_aysel_dans.mp3", btn_6_aysel_dans);
        }

        private void btn_7_kamil_sarj_sesi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\7_kamil_sarj_sesi.mp3", btn_7_kamil_sarj_sesi);
        }

        private void btn_8_kamil_error_sesi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\8_kamil_error_sesi.mp3", btn_8_kamil_error_sesi);
        }

        private void btn_kamil_donusum_sesi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\kamil_donusum_sesi.mp3", btn_kamil_donusum_sesi);
        }

        private void btn_kredi_karti_tuslama_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\kredi_karti_tuslama.mp3", btn_kredi_karti_tuslama);
        }

        private void btn_kredi_karti_okutma_sesi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\kredi_karti_okutma_sesi.mp3", btn_kredi_karti_okutma_sesi);
        }

        private void btn_oyunumuz_basliyor_muzigi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\oyunumuz_basliyor_muzigi.mp3", btn_oyunumuz_basliyor_muzigi);
        }

        private void btn_selamlama_muzigi_Click(object sender, EventArgs e) {
            PlayOrStopAudio(@"Properties\Resources\selamlama_muzigi.mp3", btn_selamlama_muzigi);
        }

        private void DefaultValues() {
            btn_giris_muzigi.Text = "Giriş Müziği \r\nÇAL";
            btn_giris_muzigi.BackColor = Color.LightGreen;
            btn_kamil_acilma_sesi.Text = "1 Kamil Açılma \r\nÇAL";
            btn_kamil_acilma_sesi.BackColor = Color.LightGreen;
            btn_kamil_dogrulma_sesi.Text = "2 Kamil Dogrulma \r\nÇAL";
            btn_kamil_dogrulma_sesi.BackColor = Color.LightGreen;
            btn_3_kamil_kalkarken.Text = "3 Kamil Kalkarken \r\nÇAL";
            btn_3_kamil_kalkarken.BackColor = Color.LightGreen;
            btn_4_kamil_yurumesi.Text = "4 Kamil Yürümesi \r\nÇAL";
            btn_4_kamil_yurumesi.BackColor = Color.LightGreen;
            btn_5_kamil_dans.Text = "5 Kamil Dans \r\nÇAL";
            btn_5_kamil_dans.BackColor = Color.LightGreen;
            btn_6_aysel_dans.Text = "6 Aysel Dans \r\nÇAL";
            btn_6_aysel_dans.BackColor = Color.LightGreen;
            btn_7_kamil_sarj_sesi.Text = "7 Kamil Şarj \r\nÇAL";
            btn_7_kamil_sarj_sesi.BackColor = Color.LightGreen;
            btn_8_kamil_error_sesi.Text = "8 Kamil Error \r\nÇAL";
            btn_8_kamil_error_sesi.BackColor = Color.LightGreen;
            btn_kamil_donusum_sesi.Text = "Kamil Dönüşüm \r\nÇAL";
            btn_kamil_donusum_sesi.BackColor = Color.LightGreen;
            btn_kredi_karti_tuslama.Text = "Kredi Kartı Tuşlama \r\nÇAL";
            btn_kredi_karti_tuslama.BackColor = Color.LightGreen;
            btn_kredi_karti_okutma_sesi.Text = "Kredi Kartı Okutma \r\nÇAL";
            btn_kredi_karti_okutma_sesi.BackColor = Color.LightGreen;
            btn_oyunumuz_basliyor_muzigi.Text = "Oyunumuz \r\nBaşlıyor \r\nÇAL";
            btn_oyunumuz_basliyor_muzigi.BackColor = Color.LightGreen;
            btn_selamlama_muzigi.Text = "Selamlama Müzigi \r\nÇAL";
            btn_selamlama_muzigi.BackColor = Color.LightGreen;
        }

        // PERDE ARASI GİRİŞ ÇIKIŞ OTOMASYONU
        private void PerdeArasiPlayOrStopAudio(string filePath, Button button, int audioPlayTime = 0) {
            try {
                if (!isPlaying) {
                    // Geçici dosyayı oynat
                    audioPlayer.URL = filePath;
                    audioPlayer.Ctlcontrols.play();
                    audioPlayer.settings.volume = 100;
                    isPlaying = true;
                    button.Text = "Durdur";
                    button.BackColor = Color.IndianRed;

                    // Çalma süresini ve ses kısma işlemini başlat
                    if (audioPlayTime > 0) {
                        StartPlayAndVolumeDecrease(audioPlayTime); // belirlenen saniye sonunda ses kısılacak
                    }
                }
                else {
                    PerdeArasiStopAudio();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void PerdeArasiStopAudio() {
            // Ses çalıyorsa, durdur
            audioPlayer.Ctlcontrols.stop();
            audioPlayer.URL = string.Empty;
            audioPlayer.Refresh();

            DefaultValuesPerdeArasi();
            isPlaying = false;

            // Timer'ı durdur
            playAndVolumeTimer.Stop();
        }

        private void DefaultValuesPerdeArasi() {
            lbl_kalan_sure.Text = "Geçen Süre  \r\n( 0 sn. )";
            btn_perde_arasi_giris_cikis_muzigi.Text = "Hepsini ÇAL";
            btn_perde_arasi_giris_cikis_muzigi.BackColor = Color.LightGreen;
            btn_perde_20_saniye.Text = "20 Saniye ÇAL";
            btn_perde_20_saniye.BackColor = Color.LightGreen;
            btn_perde_10_saniye.Text = "10 Saniye ÇAL";
            btn_perde_10_saniye.BackColor = Color.LightGreen;
        }

        private void btn_perde_arasi_giris_cikis_muzigi_Click(object sender, EventArgs e) {
            PerdeArasiPlayOrStopAudio(@"Properties\Resources\perde_arasi_giris_cikis_muzigi.mp3", btn_perde_arasi_giris_cikis_muzigi, 0);
            audioPlayer.settings.volume = 100;
        }

        private void btn_perde_20_saniye_Click(object sender, EventArgs e) {
            PerdeArasiPlayOrStopAudio(@"Properties\Resources\perde_arasi_giris_cikis_muzigi.mp3", btn_perde_20_saniye, 20);
        }

        private void btn_perde_10_saniye_Click(object sender, EventArgs e) {
            PerdeArasiPlayOrStopAudio(@"Properties\Resources\perde_arasi_giris_cikis_muzigi.mp3", btn_perde_10_saniye, 10);
        }

        private void btn_otomatik_duraklama_Click(object sender, EventArgs e) {
            if (!otomatikDuraklama) {
                btn_otomatik_duraklama.Text = "Otomatik Duraklama \r\nAÇIK";
                btn_otomatik_duraklama.BackColor = Color.IndianRed;
                otomatikDuraklama = true;
            }
            else {
                btn_otomatik_duraklama.Text = "Otomatik Duraklama \r\nKAPALI";
                btn_otomatik_duraklama.BackColor = Color.LightGreen;
                otomatikDuraklama = false;
                videoPauseIntervals = new List<double>(defaultTimeLine); // Yeni liste oluşturuldu
            }
        }

        private void lbl_duraklama_ogren_Click(object sender, EventArgs e) {
            if (!videoZamanOgrenmeModu && !otomatikDuraklama) {
                videoZamanOgrenmeModu = true;
                lbl_duraklama_ogren.Text = "Ögrenim modu açık";
                lbl_duraklama_ogren.BackColor = Color.IndianRed;
            }
            else {
                videoZamanOgrenmeModu = false;
                lbl_duraklama_ogren.Text = "Planlanan duraklama zamanı";
                lbl_duraklama_ogren.BackColor = SystemColors.Control;
            }
        }

        // HELPER
        private void InitializeTimer() {
            playAndVolumeTimer = new Timer();
            playAndVolumeTimer.Interval = 1000; // 1 saniye
            playAndVolumeTimer.Tick += PlayAndVolumeTimer_Tick;
        }

        private void AudioPlayer_PlayStateChanged(object sender, _WMPOCXEvents_PlayStateChangeEvent e) {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped) {
                isPlaying = false;
                audioPlayer.URL = string.Empty;
                audioPlayer.Refresh();
                DefaultValues();
                DefaultValuesPerdeArasi();
            }
        }

        private void PlayAndVolumeTimer_Tick(object sender, EventArgs e) {
            playTime++;
            lbl_kalan_sure.Text = $"Geçen Süre  \r\n( {playTime} sn. )";

            if (playTime >= volumeDecreaseStart) {
                // Ses seviyesini kademeli olarak azalt
                if (audioPlayer.settings.volume > targetVolume) {
                    audioPlayer.settings.volume -= volumeDecreaseStep;
                    if (audioPlayer.settings.volume < targetVolume) {
                        audioPlayer.settings.volume = targetVolume;
                    }
                }
                else {
                    playAndVolumeTimer.Stop();
                    PerdeArasiStopAudio();
                }
            }
        }

        private void StartPlayAndVolumeDecrease(int totalDuration) {
            playTime = 0;
            volumeDecreaseStart = totalDuration - 1; // 2 saniye önce başlaması için
            volumeDecreaseEnd = totalDuration + 3; // 1 saniye sonra bitmesi için
            double steps = (volumeDecreaseEnd - volumeDecreaseStart) * 1000 / volumeDecreaseInterval;
            volumeDecreaseStep = audioPlayer.settings.volume / (int)steps;
            playAndVolumeTimer.Start();
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e) {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying) {
                bnt_video_control.Text = "Video Duraklat";
                isPauseVideo = false;
                bnt_video_control.BackColor = Color.DodgerBlue;
                if (otomatikDuraklama) {
                    CheckPauseIntervals();
                }
            }
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPaused) {
                bnt_video_control.Text = "Video Devam Et";
                isPauseVideo = true;
                bnt_video_control.BackColor = Color.DeepSkyBlue;
            }
        }
        // Video duraklama sürelerini öğrenme methodu
        private void LogCurrentPosition(double currentPosition) {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pause_intervals.txt");
            try {
                using StreamWriter writer = new(filePath, true);
                writer.WriteLine($"{currentPosition};");
            }
            catch (Exception ex) {
                MessageBox.Show("Dosyaya yazma hatası: " + ex.Message);
            }
        }

        private void CheckPauseIntervals() {
            if (videoPauseIntervals.Count != 0) {
                double stopTimeInSeconds = videoPauseIntervals[0];

                bnt_video_control.Enabled = false;
                while (videoForm.axWindowsMediaPlayer1.Ctlcontrols.currentPosition <= stopTimeInSeconds) {
                    lbl_mevcut_zaman.Text = $"{videoForm.axWindowsMediaPlayer1.Ctlcontrols.currentPosition:F2} ms.";
                    lbl_duraklama_zamani.Text = $"{stopTimeInSeconds:F2} ms.";
                    Application.DoEvents(); // UI donmasını engellemek için
                }

                videoForm.PauseVideo();

                bnt_video_control.Enabled = true;

                if (videoPauseIntervals.Count > 1) {
                    videoPauseIntervals.Remove(stopTimeInSeconds);
                }
            }
        }

        private void VideoPlayStartOrStop() {
            try {
                if (isPauseVideo) {
                    videoForm.PauseVideo();
                }
                else if (isPlayingVideo) {
                    videoForm.PauseVideo();
                    if (videoZamanOgrenmeModu) {
                        // Video duraklama sürelerini öğrenme kaydı
                        LogCurrentPosition(videoForm.axWindowsMediaPlayer1.Ctlcontrols.currentPosition); // Log the current position     
                    }
                }
                else if (!isPlayingVideo && !string.IsNullOrEmpty(resourceName) && !string.IsNullOrEmpty(videoFileName)) {
                    videoForm.PlayVideo(resourceName, videoFileName, true);
                    isPlayingVideo = true;
                    btn_otomatik_duraklama.Enabled = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}