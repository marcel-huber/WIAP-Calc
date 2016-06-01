using App4.Command;
using App4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App4.ViewModel
{
    public class CalcViewModel : INotifyPropertyChanged
    {
        
        public ICommand AddCommand { get; set; }
        public ICommand SubtractCommand { get; set; }
        public ICommand MultiplyCommand { get; set; }
        public ICommand DivideCommand { get; set; }
        private Calc C;

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public CalcViewModel()
        {
            C = new Calc();
            AddCommand = new CalcAddCommand(this);
            SubtractCommand = new CalcSubtractCommand(this);
            MultiplyCommand = new CalcMultiplyCommand(this);
            DivideCommand = new CalcDivideCommand(this);
        }

        public String A
        {
            get { return C.A.ToString(); }
            set
            {
                C.A = Int32.Parse(value);
            }
        }

        public String B
        {
            get { return C.B.ToString(); }
            set
            {
                C.B = Int32.Parse(value);
            }
        }

        public String Result
        {
            get { return C.Result.ToString(); }
        }

        public void Add()
        {
            C.Add();
            RaisePropertyChanged("Result");
        }

        public void Sub()
        {
            C.Sub();
            RaisePropertyChanged("Result");
        }

        public void Div()
        {
            C.Div();
            RaisePropertyChanged("Result");
        }

        public void Mult()
        {
            C.Mult();
            RaisePropertyChanged("Result");
        }
    }
}
