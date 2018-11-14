using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewItemTest.Models
{
    public class Number : INotifyPropertyChanged
    {
        private int num;
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Num"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Number(int num)
        {
            Num = num;
        }

        
    }
}
