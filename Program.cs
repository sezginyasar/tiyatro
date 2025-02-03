namespace tiyatro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1 ve VideoForm'u oluþtur
            //Form1 form1 = new();
            MainForm mainForm = new();
            //VideoForm videoForm = new();

            // VideoForm'u göster ve video oynat
            //videoForm.Show();
            //videoForm.PlayVideo("tiyatro.Properties.Resources.EMEL_SAHNE_1.mp4");

            // Form1'i göster
            //form1.Show();
            mainForm.Show();

            // Uygulamanýn ana formunu Form1 olarak ayarla
            //Application.Run(form1);
            Application.Run(mainForm);
        }
    }
}