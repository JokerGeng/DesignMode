using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyMode
{
    public class ConcreteStrategyA : IStrategy
    {
        public object ExcuteAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
