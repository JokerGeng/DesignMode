using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyMode
{
    public interface IStrategy
    {
        object ExcuteAlgorithm(object data);
    }
}
