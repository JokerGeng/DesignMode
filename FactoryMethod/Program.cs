﻿using System;

namespace FactoryMethod
{
    //工厂方法只有一个产品抽象类,而抽象工厂具有多个产品抽象类
    //在抽象工厂中只有一个抽象产品时,抽象工厂退化为工厂方法
    //工厂方法模式针对的是一个产品等级结构,而抽象工厂模式则是针对的多个产品等级结构(产品族)
    //产品族，是指位于不同产品等级结构中功能相关联的产品组成的家族
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
