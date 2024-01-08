namespace Vsite.CSharp.DogađajiDelegati
{
    static class DogađajiVirtualneMetode
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KodDvaBotuna());
        }
    }
}
