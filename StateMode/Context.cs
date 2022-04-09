using System;
using System.Collections.Generic;
using System.Text;

namespace StateMode
{
    public class Context
    {
        private State _state;

        public Context()
        {

        }

        public Context(State state)
        {
            _state = state;
            _state.SetContext(this); 
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
        }

        public void SetState(State state)
        {
            _state = state;
            _state.SetContext(this);
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
