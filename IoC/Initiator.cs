using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class Initiator
    {
        internal static readonly IUnityContainer unity = new UnityContainer();

        public Initiator()
        {
            unity.RegisterInstance<ILogger>(new Logger());
            unity.Resolve<Logger>();
        }



    }
}
