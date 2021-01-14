using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 负责人
    /// 负责管理备忘录
    /// 不能对备忘录的内容进行操作后检查
    /// </summary>
    public class Caretaker
    {
        public Caretaker()
        {

        }

        public Memento Memento { get; set; }
    }
}
