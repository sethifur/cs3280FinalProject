using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using cs3280FinalProject.Views;
using InventoryData;

namespace cs3280FinalProject.ViewModels
{
    public class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public MainViewModel()
        {
            this.DisplayName = "";
            Orders();
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            Orders();
        }

        public void Orders()
        {
            //var ordersVM = IoC.Get<OrdersViewModel>();
            //ActivateItem(ordersVM);
            ActivateItem(new OrdersViewModel());
        }
    }
}
