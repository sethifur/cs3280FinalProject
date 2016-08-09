using cs3280FinalProject.ViewModels;
using cs3280FinalProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cs3280FinalProject
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         
            //frame0.Navigate(new Uri("OrderView.xaml"));
            //DataContext = new NewOrderViewModel();
        }
    }
}
