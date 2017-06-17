using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using UnityDI.ClassesAndInterfaces;

namespace UnityDI
{
   public class UnityRegistration
    {
      static IUnityContainer container = new UnityContainer();

       public static IUnityContainer GetContainer()
       {
           container.RegisterType<IDataContext, DataContext>();
           container.RegisterType<IProductRepository, ProductRepository>(new InjectionConstructor(container.Resolve<IDataContext>(), typeof(string)));
           return container;
       }

    }
}
