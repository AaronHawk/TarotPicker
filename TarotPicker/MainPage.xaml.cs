using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using TarotPicker.Models;

namespace TarotPicker
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<Card> cardList = new();

        public MainPage()
        {
            InitializeComponent();
            cardCollectionView.ItemsSource = cardList;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int numberOfCardsToPull = (int)numberOfCards.Value;
            Card[] pickedCards = CardPicker.PickSomeCards(numberOfCardsToPull);
            cardList.Clear();
            foreach (Card card in pickedCards)
            {
                cardList.Add(card);
            }
        }
    }
}
