﻿using System;
using System.Windows.Input;

namespace StudyAssist.ViewModel
{
    public class XCommand : ICommand
    {

        Action _action = null;

        bool _canExecute = true;

        public XCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecuteProperty
        {
            get
            {
                return _canExecute;
            }
            set
            {
                _canExecute = value;
                if (CanExecuteChanged != null)
                    CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();
        }
    }

}
