namespace Music_Player
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
            ApplicationConfiguration.Initialize();
            MusicPlayer player = new MusicPlayer();
            Application.Run(new HomePage(ref player));
            player.getSongPlayer().CloseApp();
        }
    }
}