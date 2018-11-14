using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewItemTest.Models
{
    public class NumbersList
    {
        public ObservableCollection<Number> NumsList { get; set; }

        

        public NumbersList()
        {
            NumsList = new ObservableCollection<Number>();
            for(int i=0; i<5; i++)
            {
                var number = new Number(i);
                NumsList.Add(number);
            }

        }
    }
}
