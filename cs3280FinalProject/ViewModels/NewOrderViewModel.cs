using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs3280FinalProject.ViewModels
{
    class NewOrderViewModel
    {
        private string orderNumber;

        Guid g;
        public NewOrderViewModel() {
            g = Guid.NewGuid();
            orderNumber = g.ToString();

            Console.WriteLine(g);
            Console.WriteLine(Guid.NewGuid());
        }
    }
}
