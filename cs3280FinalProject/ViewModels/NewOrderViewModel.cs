using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using cs3280FinalProject.Models;
using System.Diagnostics;

namespace cs3280FinalProject.ViewModels
{
    class NewOrderViewModel
    {
        private NewOrder newOrder;
        public NewOrder _newOrder
        {
            get
            {
                return newOrder;
            }
            set
            {
                newOrder = value;
            }
        }

        public NewOrderViewModel() {
            _newOrder = new NewOrder();
            UpdateCommand = new NewOrderUpdateCommand();
        }

        public ICommand UpdateCommand()
        {
            get;
            private set;
        }

        public void SaveChanges()
        {
            Debug.Assert(false, string.Format("{0} was Updated", _newOrder.purchaserName));
        }
    }
}
