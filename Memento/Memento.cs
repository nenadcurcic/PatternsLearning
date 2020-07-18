﻿namespace Memento
{
    public class Memento
    {
        private string _state;

        // Constructor

        public Memento(string state)
        {
            this._state = state;
        }

        // Gets or sets state

        public string State
        {
            get { return _state; }
        }
    }
}