using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiyatro {
    public partial class VideoForm :Form {
        //public AxWindowsMediaPlayer MediaPlayer {
        //    get { return axWindowsMediaPlayer1; }
        //}

        public VideoForm() {
            InitializeComponent();

            axWindowsMediaPlayer1.settings.volume = 100;

            this.Load += VideoForm_Load;
            this.Resize += VideoForm_Resize;    
        }
       
        private void VideoForm_Load(object sender, EventArgs e) {
            // Media Player'ı tam form boyutuna ayarla
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;

            //// Video dosyasını yükle ve oynat
            //axWindowsMediaPlayer1.URL = "video.mp4"; // Video dosyasının yolu
            //axWindowsMediaPlayer1.settings.autoStart = true;

            // Stretch ayarı
            axWindowsMediaPlayer1.stretchToFit = true; // Video tam ekran form boyutunda oynatılır
        }

        private void VideoForm_Resize(object sender, EventArgs e) {
            // Form yeniden boyutlandığında Media Player kontrolü yeniden ayarlanır
            axWindowsMediaPlayer1.Size = this.ClientSize;
        }

        public void PlayVideo(string resourceName, string videoFileName, bool fullScreen=false) {
            try {
                // Assembly'den kaynak dosyasını al
                //var assembly = Assembly.GetExecutingAssembly();

                //using Stream stream = assembly.GetManifestResourceStream(resourceName);
                if (!string.IsNullOrEmpty(resourceName)) {
                    //if (stream != null) {
                    // Stream'i geçici bir dosyaya yaz
                    //string tempFile = Path.Combine(Path.GetTempPath(), videoFileName);
                    //using (FileStream fileStream = new(tempFile, FileMode.Create, FileAccess.Write)) {
                    //    stream.CopyTo(fileStream);
                    //}

                    // Geçici dosyayı oynat
                    //axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = resourceName;
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    // Tam ekran modunu ayarla
                    if (fullScreen) {
                        axWindowsMediaPlayer1.stretchToFit = true;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        //private void AxWindowsMediaPlayer1_PlayStateChange(int NewState) {
        //    if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying) {
        //        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0.002; // 2 milisaniye
        //        axWindowsMediaPlayer1.Ctlcontrols.pause();
        //        axWindowsMediaPlayer1.PlayStateChange -= AxWindowsMediaPlayer1_PlayStateChange;
        //    }
        //}

        public void StopVideo() {
            try {
                // Video oynatılıyorsa, durdur
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                // Mevcut medya öğesini temizle
                //axWindowsMediaPlayer1.currentPlaylist = null;
                axWindowsMediaPlayer1.URL = string.Empty;
                // Oynatıcıyı yeniden başlat
                axWindowsMediaPlayer1.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public void PauseVideo() {
            try {
                if (IsVideoPaused()) {
                    // Video duraklatılmışsa, devam ettir
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else {
                    // Video oynatılıyorsa, duraklat
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public bool IsVideoPaused() {
            try {
                // Video duraklatılmış durumda mı kontrol et
                return axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused;
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
        }

        public void RewindVideo(int seconds) {
            try {
                double newPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition - seconds;
                if (newPosition < 0) {
                    newPosition = 0;
                }
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = newPosition;
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public void ForwardVideo(int seconds) {
            try {
                double newPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition + seconds;
                if (newPosition > axWindowsMediaPlayer1.currentMedia.duration) {
                    newPosition = axWindowsMediaPlayer1.currentMedia.duration;
                }
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = newPosition;
            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
