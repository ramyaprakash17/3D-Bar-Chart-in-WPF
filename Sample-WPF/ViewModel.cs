using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_WPF
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GrowthDetails = new ObservableCollection<Sales>();
            GrowthDetails.Add(new Sales { Product ="Pears", Revenue = 10245 });
            GrowthDetails.Add(new Sales { Product ="Apples", Revenue = 14567 });
            GrowthDetails.Add(new Sales { Product ="Tomatoes", Revenue = 32456 });
            GrowthDetails.Add(new Sales { Product ="Peas", Revenue = 31245 });
         
        }

        public ObservableCollection<Sales> GrowthDetails
        {
            get; set;
        }

    }
}
