namespace CefsharpRunner
{
    public class Program
    {
        public void Launch(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(new UserInterface());
        }
    }
}