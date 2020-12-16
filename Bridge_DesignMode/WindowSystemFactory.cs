using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignMode
{
    public class WindowFactory
    {
        static WindowFactory instatce;
        private WindowFactory()
        {

        }
        static object lk = new object();
        public static WindowFactory GetInstance()
        {
            if(instatce==null)
            {
                lock(lk)
                {
                    if(instatce==null)
                    {
                        instatce = new WindowFactory();
                    }
                }
            }
            return instatce;
        }
        public WindowImp MakeWindowImp(WindowSystemFactory factory)
        {
            return factory.MakeWindowImp();
        }
    }

    public class WindowSystemFactory
    {
        public virtual WindowImp MakeWindowImp()
        {
            return new WindowImp();
        }
    }

    public class WindowFactoryXWindowImp: WindowSystemFactory
    {
        public override WindowImp MakeWindowImp()
        {
            return new IconWindowImp();
        }
    }

    public class WindowFactoryApplicationWindowImp : WindowSystemFactory
    {
        public override WindowImp MakeWindowImp()
        {
            return new ApplicationWindowImp();
        }
    }

}
