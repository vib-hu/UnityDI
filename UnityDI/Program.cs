using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using UnityDI.ClassesAndInterfaces;

namespace UnityDI
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer Container = UnityRegistration.GetContainer();
            //var obj = Container.Resolve<IDataContext>();
            var obj = Container.Resolve<IProductRepository>(new ParameterOverride("TestString","Hello" ));

        }
    }
}
