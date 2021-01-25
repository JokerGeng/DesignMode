using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    /// <summary>
    /// 不改变元素类的前提作用于元素的新操作，访问元素的数据结构
    /// 不改变元素类：不在元素类中增加新的代码或操作
    /// </summary>
    public class EquipmentVisitor
    {
        public virtual void VisitFloppyDisk(FloppyDisk floppyDisk)
        {

        }

        public virtual void VisitCard(Card card)
        {

        }
    }
}
