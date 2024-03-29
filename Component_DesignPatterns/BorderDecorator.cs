﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPatterns
{
    public class BorderDecorator:Decorator
    {
        public int Width { get; set; }
        public BorderDecorator( VisualComponent component,int borderWidth):base(component)
        {
            Width = borderWidth;
            Console.WriteLine("new Border");
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Start Draw Border");
            DrawBorder(Width);
            Console.WriteLine("End Draw Border");
        }

        public override void Resize()
        {
            
        }

        void DrawBorder(int width)
        {
            Console.WriteLine("Drawing Border");
        }
    }
}
