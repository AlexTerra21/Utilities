using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Utilities
{
    public class UtilityPayment : INotifyPropertyChanged
    {
        public enum Months : byte { Январь = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        private string _utilityType;
        private Months _monthOfPayment;
        private float _summOfPayment;
        private bool _payed;
        private DateTime _dateOfPay;

        public string UtilityType 
        {
            get { return _utilityType; }
            set 
            {
                _utilityType = value;
                OnPropertyChanged("UtilityType");
            }
        }

        public Months MonthOfPayment
        {
            get { return _monthOfPayment; }
            set
            {
                _monthOfPayment = value;
                OnPropertyChanged("MonthOfPayment");
            }
        }
        public float SummOfPayment
        {
            get { return _summOfPayment; }
            set
            {
                _summOfPayment = value;
                OnPropertyChanged("SummOfPayment");
            }
        }
        public bool Payed
        {
            get { return _payed; }
            set
            {
                _payed = value;
                OnPropertyChanged("Payed");
            }
        }
        public DateTime DateOfPay
        {
            get { return _dateOfPay; }
            set
            {
                _dateOfPay = value;
                OnPropertyChanged("DateOfPay");
            }
        }

        public UtilityPayment() { }

        public UtilityPayment(string aUtilityType, Months aMonthOfPayment, float aSummOfPayment, 
                        bool aPayed = false, DateTime aDateOfPay = new DateTime()) 
        {
            UtilityType = aUtilityType;
            MonthOfPayment = aMonthOfPayment;
            SummOfPayment = aSummOfPayment;
            Payed = aPayed;
            DateOfPay = aDateOfPay;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
