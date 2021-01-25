using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class View
    {
        /// <summary>
        /// 模板方法，由子类实现具体行为
        /// </summary>
        protected virtual void DoDisplay()
        {

        }

        public void Display()
        {
            SetFocus();
            DoDisplay();
            ResetFocus();
        }

        /// <summary>
        /// 公共方法
        /// </summary>
        private void SetFocus()
        {
            //do focus
            Console.WriteLine("set focus");
        }

        /// <summary>
        /// 公共方法
        /// </summary>
        private void ResetFocus()
        {
            //reset focus
            Console.WriteLine("reset focus");
        }
    }
}
