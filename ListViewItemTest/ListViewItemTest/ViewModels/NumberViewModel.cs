using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListViewItemTest.Models;

namespace ListViewItemTest.ViewModels
{
    public class NumberViewModel
    {
        public ReactiveProperty<int> Num { get; set; }

        public NumberViewModel(Number num)
        {
            Num = num.ToReactivePropertyAsSynchronized(x => x.Num);
        }
    }
}
