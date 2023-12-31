namespace GradeManagement
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
            //Application.Run(new LoginForm());
            //Application.Run(new MainForm("11"));
            //Application.Run(new AddStudent());
            //Application.Run(new EditStudent());
            //Application.Run(new BrowseStudent());
            Application.Run(new BrowseStudent());
        }
    }
}