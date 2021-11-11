using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PotatoFactory potatoFactory = new PotatoFactory();
            TomatoFactory tomatoFactory = new TomatoFactory();

            var potato = potatoFactory.Create();
            potato.Print();

            var tomato = tomatoFactory.Create();
            tomato.Print();

            //扩展时，只需实现其它菜单及对应工厂即可

            Console.Read();
        }
    }
}
