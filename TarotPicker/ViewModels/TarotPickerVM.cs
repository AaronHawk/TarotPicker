using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TarotPicker.Models;
using TarotPicker.Services;

namespace TarotPicker.ViewModels
{
public class TarotPickerVM : INotifyPropertyChanged
    {
        private TarotService _tarotService = new TarotService();

        public ObservableCollection<Card> PickedCards { get; set; }

       
        public event PropertyChangedEventHandler PropertyChanged;

        //public void PullCards { }
        public ICommand PickCardCommand { get; set; }

        public TarotPickerVM()
        {
            _tarotService = new TarotService();
            PickedCards = new ObservableCollection<Card>();
        }
        public Card[] PickSomeCards(int numberOfCards)
        {
            return _tarotService.PickSomeCards(numberOfCards);
        }

        //internal static Card[] PickSomeCards(Slider numberOfCards)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
