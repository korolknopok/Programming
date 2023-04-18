﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует интерфес для реалицазии отгрузки данных
    /// </summary>
    public class SaveCommand : ICommand
    {
        
        public SaveCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }

        public MainVM MainVM { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainVM.Save();
        }

        public event EventHandler? CanExecuteChanged;
        
    }
}