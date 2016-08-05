using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs3280FinalProject.Models
{
    class NewOrder
    {
        private static int _orderNumber;
        private DateTime _createDate;
        private string _purchaserName;
        public string purchaserName
        {
            get
            {
                return _purchaserName;
            }
            set
            {
                _purchaserName = value;
                OnPropertyChanged("purchaserName");
            }
        }
        public DateTime createDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                _createDate = value;
                OnPropertyChanged("createDate");
            }
        }
        public int orderNumber
        {
            get
            {
                return _orderNumber;
            }
        }

        public NewOrder()
        {
            _orderNumber++;
            _purchaserName = "New Name";
            _createDate = new DateTime();
        }
        public NewOrder(DateTime cd, string pn)
        {
            _orderNumber++;
            _createDate = cd;
            _purchaserName = pn;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
