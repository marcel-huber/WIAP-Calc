﻿using App4.Model;
using App4.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App4.Command
{
    public class CalcMultiplyCommand : ICommand
    {
        private CalcViewModel _viewModel;

        public CalcMultiplyCommand(CalcViewModel ViewModel)
        {
            _viewModel = ViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {            
            return !_viewModel.A.Equals("") && !_viewModel.B.Equals(""); 
        }

        public void Execute(object parameter)
        {
            _viewModel.Mult();
        }
    }
}
