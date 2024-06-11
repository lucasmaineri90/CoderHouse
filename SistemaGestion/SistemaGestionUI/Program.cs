namespace SistemaGestionUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Inicio inicio;
        public static Form1 form1;
        public static Form3 form3;
        public static Form5 form5;
        public static Form7 form7;
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            form1 = new Form1();
            form3 = new Form3();
            form5 = new Form5();
            form7 = new Form7();
            Application.Run(inicio = new Inicio());
        }
    }
}