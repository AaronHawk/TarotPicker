using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using TarotPicker.Models;
using TarotPicker.ViewModels;

namespace TarotPicker
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<Card> cardList = new();
        private readonly TarotPickerVM tarotPickerVM = new TarotPickerVM();

        public MainPage()
        {
            InitializeComponent();
            cardCollectionView.ItemsSource = cardList;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int numberOfCardsToPull = (int)numberOfCards.Value;

            // Use the instance to call the method
            Card[] pickedCards = tarotPickerVM.PickSomeCards(numberOfCardsToPull);

            cardList.Clear();
            foreach (Card card in pickedCards)
            {
                cardList.Add(card);
            }
        }
    }
}
