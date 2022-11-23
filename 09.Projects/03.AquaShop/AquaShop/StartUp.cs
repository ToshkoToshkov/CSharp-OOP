namespace AquaShop
{
    using AquaShop.Core;
    using AquaShop.Core.Contracts;
    using System.Globalization;
    using System.Threading;

    public class StartUp
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
