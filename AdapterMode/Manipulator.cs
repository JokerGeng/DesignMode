using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    /// <summary>
    /// 可用工厂方法进行扩展多种操作
    /// </summary>
    abstract class Manipulator
    {
        public abstract void Opearte();
    }
}
