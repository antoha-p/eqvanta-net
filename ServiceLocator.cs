using Autofac;

namespace ConsoleApp1
{
    public static class ServiceLocator
    {
        private static IContainer _container;

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        public static void SetContainer(IContainer container)
        {
            _container = container;
        }
    }
}
