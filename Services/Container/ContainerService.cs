using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtSimpleDemo.Services.Container
{
    public class ContainerService : IContainerService
    {
        public IContainer Container { get; private set; }

        public ContainerService(IContainer container)
        {
            Container = container;
        }

        public T Resolve<T>()
        {
            var dependency = Container.Resolve<T>();
            return dependency;
        }
    }
}
