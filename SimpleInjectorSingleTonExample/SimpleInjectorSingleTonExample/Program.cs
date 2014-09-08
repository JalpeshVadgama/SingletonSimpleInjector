using SimpleInjector;

namespace SimpleInjectorSingleTonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            //container.RegisterSingle<ILogger, Logger>();
            var registartion = Lifestyle.Singleton.CreateRegistration<ILogger,Logger>(container);
            container.AddRegistration(typeof(ILogger),registartion);
            var logger = container.GetInstance<ILogger>();
            logger.Log("This is a sample Log");
        }
    }
}
