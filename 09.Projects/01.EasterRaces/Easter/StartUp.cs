namespace Easter
{
    using Core;
    using Core.Contracts;
    using System.Globalization;
    using System.Threading;

    public class StartUp
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            // Don't forget to uncomment Controller class in the Engine!
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
