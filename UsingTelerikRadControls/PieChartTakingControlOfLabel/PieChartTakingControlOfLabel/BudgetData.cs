using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;


namespace PieChartTakingControlOfLabel
{
    public class BudgetData : INotifyPropertyChanged
    {
        private double millions;
        public double Millions
        {
            get { return millions; }
            set
            {
                millions = value;
                OnPropertyChanged();
            }
        }
   
        private string department;
        public string Department
        {
            get { return department; }
            set
            {
                department = value;
                OnPropertyChanged();
            }
        }
   
        protected virtual void OnPropertyChanged( [CallerMemberName] string caller = "" )
        {
            if ( PropertyChanged != null )
            {
                PropertyChanged( this, new PropertyChangedEventArgs( caller ) );
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
