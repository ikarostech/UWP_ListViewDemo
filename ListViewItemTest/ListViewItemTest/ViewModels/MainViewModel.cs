using System;

using ListViewItemTest.Helpers;
using ListViewItemTest.Models;
using ListViewItemTest.Views;
using Reactive.Bindings;

namespace ListViewItemTest.ViewModels
{
    public class MainViewModel : Observable
    {
        private NumbersList Model { get; set; }
        public ReadOnlyReactiveCollection<NumberViewModel> numbers { get; }
        public ReactiveProperty<String> Output { get; set; }
        public MainViewModel()
        {
            Model = new NumbersList();
            Output = new ReactiveProperty<string>("");
            numbers = Model.NumsList.ToReadOnlyReactiveCollection(x => new NumberViewModel(x)); 
        }

        public void ButtonClick()
        {
            Output.Value = "";

            //LINQで書くべきですねここは…
            for(int i=0; i<Model.NumsList.Count; i++)
            {
                Output.Value += Model.NumsList[i].Num.ToString() + " ";
            }
        }
    }
}
