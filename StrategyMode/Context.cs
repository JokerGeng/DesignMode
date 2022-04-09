using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyMode
{
    public class Context
    {
        IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExcuteAlgorithm(/*object data**/)
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var data = new List<string> { "a", "b", "c", "d", "e" };

            var result =_strategy.ExcuteAlgorithm(data);
            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
