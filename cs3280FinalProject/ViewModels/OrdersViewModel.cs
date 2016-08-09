using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Windows;

namespace cs3280FinalProject.ViewModels
{
    class OrdersViewModel : Screen
    {

        public OrdersViewModel()
        {

        }

        protected override void OnActivate()
        {
            base.OnActivate();
            MessageBox.Show("Page Two Activated");
            //InitializeData();
        }
       
        protected async void InitializeData()
        {

        }
    }

    
}
