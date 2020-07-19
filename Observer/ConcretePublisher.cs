﻿namespace Observer
{
    public class ConcretePublisher : Publisher
    {
        private string _subjectState;

        // Gets or sets subject state

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}