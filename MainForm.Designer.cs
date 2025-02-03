namespace tiyatro {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn_video_from_full_screen = new Button();
            btn_emel_sahne = new Button();
            bnt_video_control = new Button();
            btn_5_geri = new Button();
            btn_5_ileri = new Button();
            btn_10_ileri = new Button();
            btn_10_geri = new Button();
            btn_kamil_acilma_sesi = new Button();
            btn_giris_muzigi = new Button();
            audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            btn_kamil_dogrulma_sesi = new Button();
            btn_3_kamil_kalkarken = new Button();
            btn_4_kamil_yurumesi = new Button();
            btn_5_kamil_dans = new Button();
            btn_6_aysel_dans = new Button();
            btn_7_kamil_sarj_sesi = new Button();
            btn_8_kamil_error_sesi = new Button();
            btn_kamil_donusum_sesi = new Button();
            btn_kredi_karti_okutma_sesi = new Button();
            btn_kredi_karti_tuslama = new Button();
            btn_oyunumuz_basliyor_muzigi = new Button();
            btn_perde_arasi_giris_cikis_muzigi = new Button();
            btn_selamlama_muzigi = new Button();
            label1 = new Label();
            btn_perde_20_saniye = new Button();
            btn_perde_10_saniye = new Button();
            btn_otomatik_duraklama = new Button();
            lbl_kalan_sure = new Label();
            lbl_mevcut_zaman = new Label();
            label2 = new Label();
            lbl_duraklama_ogren = new Label();
            lbl_duraklama_zamani = new Label();
            ((System.ComponentModel.ISupportInitialize)audioPlayer).BeginInit();
            SuspendLayout();
            // 
            // btn_video_from_full_screen
            // 
            btn_video_from_full_screen.BackColor = Color.Transparent;
            btn_video_from_full_screen.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_video_from_full_screen.ForeColor = Color.Black;
            btn_video_from_full_screen.Location = new Point(11, 388);
            btn_video_from_full_screen.Name = "btn_video_from_full_screen";
            btn_video_from_full_screen.Size = new Size(205, 53);
            btn_video_from_full_screen.TabIndex = 8;
            btn_video_from_full_screen.Text = "Video Tam Ekran";
            btn_video_from_full_screen.UseVisualStyleBackColor = false;
            btn_video_from_full_screen.Click += btn_video_from_full_screen_Click;
            // 
            // btn_emel_sahne
            // 
            btn_emel_sahne.BackColor = Color.LightGray;
            btn_emel_sahne.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_emel_sahne.ForeColor = Color.Black;
            btn_emel_sahne.Location = new Point(222, 388);
            btn_emel_sahne.Name = "btn_emel_sahne";
            btn_emel_sahne.Size = new Size(174, 53);
            btn_emel_sahne.TabIndex = 9;
            btn_emel_sahne.Text = "Emel Video";
            btn_emel_sahne.UseVisualStyleBackColor = false;
            btn_emel_sahne.Click += btn_emel_sahne_Click;
            // 
            // bnt_video_control
            // 
            bnt_video_control.BackColor = Color.LightGray;
            bnt_video_control.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            bnt_video_control.ForeColor = Color.Black;
            bnt_video_control.Location = new Point(11, 447);
            bnt_video_control.Name = "bnt_video_control";
            bnt_video_control.Size = new Size(876, 80);
            bnt_video_control.TabIndex = 10;
            bnt_video_control.Text = "VİDEO SEÇ";
            bnt_video_control.UseVisualStyleBackColor = false;
            bnt_video_control.Click += bnt_video_control_Click;
            // 
            // btn_5_geri
            // 
            btn_5_geri.BackColor = Color.Gray;
            btn_5_geri.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_5_geri.ForeColor = Color.Black;
            btn_5_geri.Location = new Point(549, 388);
            btn_5_geri.Name = "btn_5_geri";
            btn_5_geri.Size = new Size(80, 53);
            btn_5_geri.TabIndex = 11;
            btn_5_geri.Text = "5sn Geri";
            btn_5_geri.UseVisualStyleBackColor = false;
            btn_5_geri.Click += btn_5_geri_Click;
            // 
            // btn_5_ileri
            // 
            btn_5_ileri.BackColor = Color.Gray;
            btn_5_ileri.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_5_ileri.ForeColor = Color.Black;
            btn_5_ileri.Location = new Point(807, 388);
            btn_5_ileri.Name = "btn_5_ileri";
            btn_5_ileri.Size = new Size(80, 53);
            btn_5_ileri.TabIndex = 12;
            btn_5_ileri.Text = "5sn İleri";
            btn_5_ileri.UseVisualStyleBackColor = false;
            btn_5_ileri.Click += btn_5_ileri_Click;
            // 
            // btn_10_ileri
            // 
            btn_10_ileri.BackColor = Color.Gray;
            btn_10_ileri.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_10_ileri.ForeColor = Color.Black;
            btn_10_ileri.Location = new Point(721, 388);
            btn_10_ileri.Name = "btn_10_ileri";
            btn_10_ileri.Size = new Size(80, 53);
            btn_10_ileri.TabIndex = 14;
            btn_10_ileri.Text = "10sn İleri";
            btn_10_ileri.UseVisualStyleBackColor = false;
            btn_10_ileri.Click += btn_10_ileri_Click;
            // 
            // btn_10_geri
            // 
            btn_10_geri.BackColor = Color.Gray;
            btn_10_geri.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_10_geri.ForeColor = Color.Black;
            btn_10_geri.Location = new Point(635, 388);
            btn_10_geri.Name = "btn_10_geri";
            btn_10_geri.Size = new Size(80, 53);
            btn_10_geri.TabIndex = 13;
            btn_10_geri.Text = "10sn Geri";
            btn_10_geri.UseVisualStyleBackColor = false;
            btn_10_geri.Click += btn_10_geri_Click;
            // 
            // btn_kamil_acilma_sesi
            // 
            btn_kamil_acilma_sesi.BackColor = Color.LightGreen;
            btn_kamil_acilma_sesi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_kamil_acilma_sesi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_kamil_acilma_sesi.ForeColor = Color.Black;
            btn_kamil_acilma_sesi.Location = new Point(263, 12);
            btn_kamil_acilma_sesi.Name = "btn_kamil_acilma_sesi";
            btn_kamil_acilma_sesi.Size = new Size(120, 80);
            btn_kamil_acilma_sesi.TabIndex = 16;
            btn_kamil_acilma_sesi.Text = "1 Kamil Açılma \r\nÇAL";
            btn_kamil_acilma_sesi.UseVisualStyleBackColor = false;
            btn_kamil_acilma_sesi.Click += btn_kamil_acilma_sesi_Click;
            // 
            // btn_giris_muzigi
            // 
            btn_giris_muzigi.BackColor = Color.LightGreen;
            btn_giris_muzigi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_giris_muzigi.ForeColor = Color.Black;
            btn_giris_muzigi.Location = new Point(137, 12);
            btn_giris_muzigi.Name = "btn_giris_muzigi";
            btn_giris_muzigi.Size = new Size(120, 80);
            btn_giris_muzigi.TabIndex = 15;
            btn_giris_muzigi.Text = "Giriş Müzigi \r\nÇAL";
            btn_giris_muzigi.UseVisualStyleBackColor = false;
            btn_giris_muzigi.Click += btn_giris_muzigi_Click;
            // 
            // audioPlayer
            // 
            audioPlayer.Enabled = true;
            audioPlayer.Location = new Point(11, 300);
            audioPlayer.Name = "audioPlayer";
            audioPlayer.OcxState = (AxHost.State)resources.GetObject("audioPlayer.OcxState");
            audioPlayer.Size = new Size(876, 82);
            audioPlayer.TabIndex = 17;
            // 
            // btn_kamil_dogrulma_sesi
            // 
            btn_kamil_dogrulma_sesi.BackColor = Color.LightGreen;
            btn_kamil_dogrulma_sesi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_kamil_dogrulma_sesi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_kamil_dogrulma_sesi.ForeColor = Color.Black;
            btn_kamil_dogrulma_sesi.Location = new Point(389, 12);
            btn_kamil_dogrulma_sesi.Name = "btn_kamil_dogrulma_sesi";
            btn_kamil_dogrulma_sesi.Size = new Size(120, 80);
            btn_kamil_dogrulma_sesi.TabIndex = 18;
            btn_kamil_dogrulma_sesi.Text = "2 Kamil Dogrulma \r\nÇAL";
            btn_kamil_dogrulma_sesi.UseVisualStyleBackColor = false;
            btn_kamil_dogrulma_sesi.Click += btn_kamil_dogrulma_sesi_Click;
            // 
            // btn_3_kamil_kalkarken
            // 
            btn_3_kamil_kalkarken.BackColor = Color.LightGreen;
            btn_3_kamil_kalkarken.BackgroundImageLayout = ImageLayout.Stretch;
            btn_3_kamil_kalkarken.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_3_kamil_kalkarken.ForeColor = Color.Black;
            btn_3_kamil_kalkarken.Location = new Point(515, 12);
            btn_3_kamil_kalkarken.Name = "btn_3_kamil_kalkarken";
            btn_3_kamil_kalkarken.Size = new Size(120, 80);
            btn_3_kamil_kalkarken.TabIndex = 19;
            btn_3_kamil_kalkarken.Text = "3 Kamil Kalkarken \r\nÇAL";
            btn_3_kamil_kalkarken.UseVisualStyleBackColor = false;
            btn_3_kamil_kalkarken.Click += btn_3_kamil_kalkarken_Click;
            // 
            // btn_4_kamil_yurumesi
            // 
            btn_4_kamil_yurumesi.BackColor = Color.LightGreen;
            btn_4_kamil_yurumesi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_4_kamil_yurumesi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_4_kamil_yurumesi.ForeColor = Color.Black;
            btn_4_kamil_yurumesi.Location = new Point(641, 12);
            btn_4_kamil_yurumesi.Name = "btn_4_kamil_yurumesi";
            btn_4_kamil_yurumesi.Size = new Size(120, 80);
            btn_4_kamil_yurumesi.TabIndex = 20;
            btn_4_kamil_yurumesi.Text = "4 Kamil Yürümesi \r\nÇAL";
            btn_4_kamil_yurumesi.UseVisualStyleBackColor = false;
            btn_4_kamil_yurumesi.Click += btn_4_kamil_yurumesi_Click;
            // 
            // btn_5_kamil_dans
            // 
            btn_5_kamil_dans.BackColor = Color.LightGreen;
            btn_5_kamil_dans.BackgroundImageLayout = ImageLayout.Stretch;
            btn_5_kamil_dans.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_5_kamil_dans.ForeColor = Color.Black;
            btn_5_kamil_dans.Location = new Point(767, 12);
            btn_5_kamil_dans.Name = "btn_5_kamil_dans";
            btn_5_kamil_dans.Size = new Size(120, 80);
            btn_5_kamil_dans.TabIndex = 21;
            btn_5_kamil_dans.Text = "5 Kamil Dans \r\nÇAL";
            btn_5_kamil_dans.UseVisualStyleBackColor = false;
            btn_5_kamil_dans.Click += btn_5_kamil_dans_Click;
            // 
            // btn_6_aysel_dans
            // 
            btn_6_aysel_dans.BackColor = Color.LightGreen;
            btn_6_aysel_dans.BackgroundImageLayout = ImageLayout.Stretch;
            btn_6_aysel_dans.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_6_aysel_dans.ForeColor = Color.Black;
            btn_6_aysel_dans.Location = new Point(11, 98);
            btn_6_aysel_dans.Name = "btn_6_aysel_dans";
            btn_6_aysel_dans.Size = new Size(120, 80);
            btn_6_aysel_dans.TabIndex = 22;
            btn_6_aysel_dans.Text = "6 Aysel Dans \r\nÇAL";
            btn_6_aysel_dans.UseVisualStyleBackColor = false;
            btn_6_aysel_dans.Click += btn_6_aysel_dans_Click;
            // 
            // btn_7_kamil_sarj_sesi
            // 
            btn_7_kamil_sarj_sesi.BackColor = Color.LightGreen;
            btn_7_kamil_sarj_sesi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_7_kamil_sarj_sesi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_7_kamil_sarj_sesi.ForeColor = Color.Black;
            btn_7_kamil_sarj_sesi.Location = new Point(137, 98);
            btn_7_kamil_sarj_sesi.Name = "btn_7_kamil_sarj_sesi";
            btn_7_kamil_sarj_sesi.Size = new Size(120, 80);
            btn_7_kamil_sarj_sesi.TabIndex = 23;
            btn_7_kamil_sarj_sesi.Text = "7 Kamil Şarj \r\nÇAL";
            btn_7_kamil_sarj_sesi.UseVisualStyleBackColor = false;
            btn_7_kamil_sarj_sesi.Click += btn_7_kamil_sarj_sesi_Click;
            // 
            // btn_8_kamil_error_sesi
            // 
            btn_8_kamil_error_sesi.BackColor = Color.LightGreen;
            btn_8_kamil_error_sesi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_8_kamil_error_sesi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_8_kamil_error_sesi.ForeColor = Color.Black;
            btn_8_kamil_error_sesi.Location = new Point(263, 98);
            btn_8_kamil_error_sesi.Name = "btn_8_kamil_error_sesi";
            btn_8_kamil_error_sesi.Size = new Size(120, 80);
            btn_8_kamil_error_sesi.TabIndex = 24;
            btn_8_kamil_error_sesi.Text = "8 Kamil Error \r\nÇAL";
            btn_8_kamil_error_sesi.UseVisualStyleBackColor = false;
            btn_8_kamil_error_sesi.Click += btn_8_kamil_error_sesi_Click;
            // 
            // btn_kamil_donusum_sesi
            // 
            btn_kamil_donusum_sesi.BackColor = Color.LightGreen;
            btn_kamil_donusum_sesi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_kamil_donusum_sesi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_kamil_donusum_sesi.ForeColor = Color.Black;
            btn_kamil_donusum_sesi.Location = new Point(389, 98);
            btn_kamil_donusum_sesi.Name = "btn_kamil_donusum_sesi";
            btn_kamil_donusum_sesi.Size = new Size(120, 80);
            btn_kamil_donusum_sesi.TabIndex = 25;
            btn_kamil_donusum_sesi.Text = "Kamil Dönüşüm \r\nÇAL";
            btn_kamil_donusum_sesi.UseVisualStyleBackColor = false;
            btn_kamil_donusum_sesi.Click += btn_kamil_donusum_sesi_Click;
            // 
            // btn_kredi_karti_okutma_sesi
            // 
            btn_kredi_karti_okutma_sesi.BackColor = Color.LightGreen;
            btn_kredi_karti_okutma_sesi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_kredi_karti_okutma_sesi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_kredi_karti_okutma_sesi.ForeColor = Color.Black;
            btn_kredi_karti_okutma_sesi.Location = new Point(641, 98);
            btn_kredi_karti_okutma_sesi.Name = "btn_kredi_karti_okutma_sesi";
            btn_kredi_karti_okutma_sesi.Size = new Size(120, 80);
            btn_kredi_karti_okutma_sesi.TabIndex = 26;
            btn_kredi_karti_okutma_sesi.Text = "Kredi Kartı Okutma \r\nÇAL\r\n";
            btn_kredi_karti_okutma_sesi.UseVisualStyleBackColor = false;
            btn_kredi_karti_okutma_sesi.Click += btn_kredi_karti_okutma_sesi_Click;
            // 
            // btn_kredi_karti_tuslama
            // 
            btn_kredi_karti_tuslama.BackColor = Color.LightGreen;
            btn_kredi_karti_tuslama.BackgroundImageLayout = ImageLayout.Stretch;
            btn_kredi_karti_tuslama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_kredi_karti_tuslama.ForeColor = Color.Black;
            btn_kredi_karti_tuslama.Location = new Point(515, 98);
            btn_kredi_karti_tuslama.Name = "btn_kredi_karti_tuslama";
            btn_kredi_karti_tuslama.Size = new Size(120, 80);
            btn_kredi_karti_tuslama.TabIndex = 27;
            btn_kredi_karti_tuslama.Text = "Kredi Kartı Tuşlama \r\nÇAL";
            btn_kredi_karti_tuslama.UseVisualStyleBackColor = false;
            btn_kredi_karti_tuslama.Click += btn_kredi_karti_tuslama_Click;
            // 
            // btn_oyunumuz_basliyor_muzigi
            // 
            btn_oyunumuz_basliyor_muzigi.BackColor = Color.LightGreen;
            btn_oyunumuz_basliyor_muzigi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_oyunumuz_basliyor_muzigi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_oyunumuz_basliyor_muzigi.ForeColor = Color.Black;
            btn_oyunumuz_basliyor_muzigi.Location = new Point(11, 12);
            btn_oyunumuz_basliyor_muzigi.Name = "btn_oyunumuz_basliyor_muzigi";
            btn_oyunumuz_basliyor_muzigi.Size = new Size(120, 80);
            btn_oyunumuz_basliyor_muzigi.TabIndex = 28;
            btn_oyunumuz_basliyor_muzigi.Text = "Oyunumuz\r\nBaşlıyor \r\nÇAL";
            btn_oyunumuz_basliyor_muzigi.UseVisualStyleBackColor = false;
            btn_oyunumuz_basliyor_muzigi.Click += btn_oyunumuz_basliyor_muzigi_Click;
            // 
            // btn_perde_arasi_giris_cikis_muzigi
            // 
            btn_perde_arasi_giris_cikis_muzigi.BackColor = Color.LightGreen;
            btn_perde_arasi_giris_cikis_muzigi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_perde_arasi_giris_cikis_muzigi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_perde_arasi_giris_cikis_muzigi.ForeColor = Color.Black;
            btn_perde_arasi_giris_cikis_muzigi.Location = new Point(641, 214);
            btn_perde_arasi_giris_cikis_muzigi.Name = "btn_perde_arasi_giris_cikis_muzigi";
            btn_perde_arasi_giris_cikis_muzigi.Size = new Size(246, 80);
            btn_perde_arasi_giris_cikis_muzigi.TabIndex = 29;
            btn_perde_arasi_giris_cikis_muzigi.Text = "Hepsini ÇAL";
            btn_perde_arasi_giris_cikis_muzigi.UseVisualStyleBackColor = false;
            btn_perde_arasi_giris_cikis_muzigi.Click += btn_perde_arasi_giris_cikis_muzigi_Click;
            // 
            // btn_selamlama_muzigi
            // 
            btn_selamlama_muzigi.BackColor = Color.LightGreen;
            btn_selamlama_muzigi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_selamlama_muzigi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_selamlama_muzigi.ForeColor = Color.Black;
            btn_selamlama_muzigi.Location = new Point(767, 98);
            btn_selamlama_muzigi.Name = "btn_selamlama_muzigi";
            btn_selamlama_muzigi.Size = new Size(120, 80);
            btn_selamlama_muzigi.TabIndex = 30;
            btn_selamlama_muzigi.Text = "Selamlama Müzigi \r\nÇAL";
            btn_selamlama_muzigi.UseVisualStyleBackColor = false;
            btn_selamlama_muzigi.Click += btn_selamlama_muzigi_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 181);
            label1.Name = "label1";
            label1.Size = new Size(875, 30);
            label1.TabIndex = 31;
            label1.Text = "Perde Arası Giriş Çıkış Müziği";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_perde_20_saniye
            // 
            btn_perde_20_saniye.BackColor = Color.LightGreen;
            btn_perde_20_saniye.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_perde_20_saniye.Location = new Point(389, 214);
            btn_perde_20_saniye.Name = "btn_perde_20_saniye";
            btn_perde_20_saniye.Size = new Size(246, 80);
            btn_perde_20_saniye.TabIndex = 32;
            btn_perde_20_saniye.Text = "20 Saniye ÇAL";
            btn_perde_20_saniye.UseVisualStyleBackColor = false;
            btn_perde_20_saniye.Click += btn_perde_20_saniye_Click;
            // 
            // btn_perde_10_saniye
            // 
            btn_perde_10_saniye.BackColor = Color.LightGreen;
            btn_perde_10_saniye.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_perde_10_saniye.Location = new Point(137, 214);
            btn_perde_10_saniye.Name = "btn_perde_10_saniye";
            btn_perde_10_saniye.Size = new Size(246, 80);
            btn_perde_10_saniye.TabIndex = 33;
            btn_perde_10_saniye.Text = "10 Saniye ÇAL";
            btn_perde_10_saniye.UseVisualStyleBackColor = false;
            btn_perde_10_saniye.Click += btn_perde_10_saniye_Click;
            // 
            // btn_otomatik_duraklama
            // 
            btn_otomatik_duraklama.BackColor = Color.LightGreen;
            btn_otomatik_duraklama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_otomatik_duraklama.Location = new Point(402, 388);
            btn_otomatik_duraklama.Name = "btn_otomatik_duraklama";
            btn_otomatik_duraklama.Size = new Size(141, 53);
            btn_otomatik_duraklama.TabIndex = 34;
            btn_otomatik_duraklama.Text = "Otomatik Duraklama\r\nKAPALI";
            btn_otomatik_duraklama.UseVisualStyleBackColor = false;
            btn_otomatik_duraklama.Click += btn_otomatik_duraklama_Click;
            // 
            // lbl_kalan_sure
            // 
            lbl_kalan_sure.BackColor = SystemColors.ActiveCaption;
            lbl_kalan_sure.BorderStyle = BorderStyle.Fixed3D;
            lbl_kalan_sure.Cursor = Cursors.WaitCursor;
            lbl_kalan_sure.FlatStyle = FlatStyle.Popup;
            lbl_kalan_sure.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            lbl_kalan_sure.Location = new Point(12, 214);
            lbl_kalan_sure.Name = "lbl_kalan_sure";
            lbl_kalan_sure.Size = new Size(119, 80);
            lbl_kalan_sure.TabIndex = 35;
            lbl_kalan_sure.Text = "Geçen Süre \r\n( 0 sn. )";
            lbl_kalan_sure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_mevcut_zaman
            // 
            lbl_mevcut_zaman.BorderStyle = BorderStyle.Fixed3D;
            lbl_mevcut_zaman.FlatStyle = FlatStyle.Popup;
            lbl_mevcut_zaman.Location = new Point(148, 530);
            lbl_mevcut_zaman.Name = "lbl_mevcut_zaman";
            lbl_mevcut_zaman.Size = new Size(196, 23);
            lbl_mevcut_zaman.TabIndex = 36;
            lbl_mevcut_zaman.Text = "0 ms.";
            lbl_mevcut_zaman.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Location = new Point(12, 530);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 37;
            label2.Text = "Video mevcut zamanı";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_duraklama_ogren
            // 
            lbl_duraklama_ogren.BackColor = SystemColors.Control;
            lbl_duraklama_ogren.BorderStyle = BorderStyle.Fixed3D;
            lbl_duraklama_ogren.FlatStyle = FlatStyle.Popup;
            lbl_duraklama_ogren.Location = new Point(350, 530);
            lbl_duraklama_ogren.Name = "lbl_duraklama_ogren";
            lbl_duraklama_ogren.Size = new Size(163, 23);
            lbl_duraklama_ogren.TabIndex = 39;
            lbl_duraklama_ogren.Text = "Planlanan duraklama zamanı";
            lbl_duraklama_ogren.TextAlign = ContentAlignment.MiddleLeft;
            lbl_duraklama_ogren.Click += lbl_duraklama_ogren_Click;
            // 
            // lbl_duraklama_zamani
            // 
            lbl_duraklama_zamani.BorderStyle = BorderStyle.Fixed3D;
            lbl_duraklama_zamani.FlatStyle = FlatStyle.Popup;
            lbl_duraklama_zamani.Location = new Point(515, 530);
            lbl_duraklama_zamani.Name = "lbl_duraklama_zamani";
            lbl_duraklama_zamani.Size = new Size(196, 23);
            lbl_duraklama_zamani.TabIndex = 38;
            lbl_duraklama_zamani.Text = "0 ms.";
            lbl_duraklama_zamani.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(899, 561);
            Controls.Add(lbl_duraklama_ogren);
            Controls.Add(lbl_duraklama_zamani);
            Controls.Add(label2);
            Controls.Add(lbl_mevcut_zaman);
            Controls.Add(lbl_kalan_sure);
            Controls.Add(btn_otomatik_duraklama);
            Controls.Add(btn_perde_10_saniye);
            Controls.Add(btn_perde_20_saniye);
            Controls.Add(label1);
            Controls.Add(btn_selamlama_muzigi);
            Controls.Add(btn_perde_arasi_giris_cikis_muzigi);
            Controls.Add(btn_oyunumuz_basliyor_muzigi);
            Controls.Add(btn_kredi_karti_tuslama);
            Controls.Add(btn_kredi_karti_okutma_sesi);
            Controls.Add(btn_kamil_donusum_sesi);
            Controls.Add(btn_8_kamil_error_sesi);
            Controls.Add(btn_7_kamil_sarj_sesi);
            Controls.Add(btn_6_aysel_dans);
            Controls.Add(btn_5_kamil_dans);
            Controls.Add(btn_4_kamil_yurumesi);
            Controls.Add(btn_3_kamil_kalkarken);
            Controls.Add(btn_kamil_dogrulma_sesi);
            Controls.Add(audioPlayer);
            Controls.Add(btn_kamil_acilma_sesi);
            Controls.Add(btn_giris_muzigi);
            Controls.Add(btn_10_ileri);
            Controls.Add(btn_10_geri);
            Controls.Add(btn_5_ileri);
            Controls.Add(btn_5_geri);
            Controls.Add(bnt_video_control);
            Controls.Add(btn_emel_sahne);
            Controls.Add(btn_video_from_full_screen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trio-Art Tiyatro";
            ((System.ComponentModel.ISupportInitialize)audioPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_video_from_full_screen;
        private Button btn_emel_sahne;
        private Button bnt_video_control;
        public Panel panelVideoController;
        private Button btn_5_geri;
        private Button btn_5_ileri;
        private Button btn_10_ileri;
        private Button btn_10_geri;
        private Button btn_kamil_acilma_sesi;
        private Button btn_giris_muzigi;
        public AxWMPLib.AxWindowsMediaPlayer audioPlayer;
        private Button button1;
        private Button btn_kamil_dogrulma_sesi;
        private Button btn_3_kamil_kalkarken;
        private Button btn_4_kamil_yurumesi;
        private Button btn_5_kamil_dans;
        private Button btn_6_aysel_dans;
        private Button btn_7_kamil_sarj_sesi;
        private Button btn_8_kamil_error_sesi;
        private Button btn_kamil_donusum_sesi;
        private Button btn_kredi_karti_okutma_sesi;
        private Button btn_kredi_karti_tuslama;
        private Button btn_oyunumuz_basliyor_muzigi;
        private Button btn_perde_arasi_giris_cikis_muzigi;
        private Button btn_selamlama_muzigi;
        private Label label1;
        private Button btn_perde_20_saniye;
        private Button btn_perde_10_saniye;
        private Button btn_otomatik_duraklama;
        private Label lbl_kalan_sure;
        private Label lbl_mevcut_zaman;
        private Label label2;
        private Label lbl_duraklama_ogren;
        private Label lbl_duraklama_zamani;
    }
}