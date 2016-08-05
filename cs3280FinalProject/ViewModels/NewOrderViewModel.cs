using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace cs3280FinalProject.ViewModels
{
    class NewOrderViewModel
    {
        private string orderNumber;
        private DateTime createDate = new DateTime();
        private string purchaserName;
        private List<Object> orderItems;

        public void setCreateDate(DateTime value){createDate = value;}

        public DateTime getCreateDate(){ return createDate;}

        public void setPurchaserName(string value) { purchaserName = value; }

        public string getPurchaserName() { return purchaserName; }



        public NewOrderViewModel() {

        }
    }
}
