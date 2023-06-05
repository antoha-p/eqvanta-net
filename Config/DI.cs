using Autofac;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Config
{
    public static class DI
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LoggerDecorator>().As<ILogger>().SingleInstance();

            var container = builder.Build();
            ServiceLocator.SetContainer(container);
        }
    }
}
