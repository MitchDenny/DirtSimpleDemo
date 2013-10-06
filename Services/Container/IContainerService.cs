using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtSimpleDemo.Services.Container
{
    public interface IContainerService
    {
        T Resolve<T>();
    }
}
