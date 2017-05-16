using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        UtilityPayment _selectedPayment;

        public ObservableCollection<UtilityPayment> Payments { get; set; }
        public UtilityPayment SelectedPayment
        {
            get { return _selectedPayment; }
            set
            {
                _selectedPayment = value;
                OnPropertyChanged("SelectedPayment");
            }
        }

        public ApplicationViewModel()
        {
            Payments = new ObservableCollection<UtilityPayment>
            {
                new UtilityPayment("Газ", UtilityPayment.Months.Январь, 550.0f ),
                new UtilityPayment("Мусор", UtilityPayment.Months.Январь, 450.5f ),
                new UtilityPayment("Содержание", UtilityPayment.Months.Январь, 1550f),
                new UtilityPayment("Вода", UtilityPayment.Months.Январь, 2050f),
                new UtilityPayment("Отопление", UtilityPayment.Months.Январь, 1250f )

            };
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
