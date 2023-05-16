namespace lab10
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
            Application.Run(new Login());
            //Person p = new Person(1, "Haadiya", "haadiya@nu.edu.pk", "1234", "Student");
            //Application.Run(new StudentNavigate(p, "abc12"));
        }
    }
}