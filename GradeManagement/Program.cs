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
            LoginForm loginForm = new LoginForm();
            MainForm mainForm = new MainForm();
            loginForm.UserLoggedIn += mainForm.HandleUserLoggedIn;

            loginForm.ShowDialog();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                loginForm.Close();
                Application.Run(mainForm);
            }
            Application.Exit();
        }
    }
}