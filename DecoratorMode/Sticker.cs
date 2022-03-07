using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMode
{
    public class Sticker: Decorator
    {
        public Sticker(VisaulComponent phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();

            // 添加新的行为
            AddSticker();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("现在苹果手机有贴膜了");
        }
    }
}
