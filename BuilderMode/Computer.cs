using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    class Computer
    {
        List<string> parts = new List<string>();
        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void ShowComputer()
        {
            Console.WriteLine("开始组装电脑:");
            foreach (var part in parts)
            {
                Console.WriteLine("组件"+part+"组装完成!");
            }
            Console.WriteLine("电脑组装结束!");
        }
    }
}
