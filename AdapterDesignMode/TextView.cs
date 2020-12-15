using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignMode
{
    /// <summary>
    /// Adaptee
    /// </summary>
    public class TextView
    {
        public TextView()
        {

        }

        public void GetOrigin()
        {

        }

        public void GetExtent()
        {

        }

        public virtual bool IsEmpty()
        {
            return false;
        }
    }
}
