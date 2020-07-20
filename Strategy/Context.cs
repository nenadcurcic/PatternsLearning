﻿namespace Strategy
{
    public class Context
    {
        private Strategy _strategy;

        // Constructor

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}