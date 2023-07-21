using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace TarotPicker
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<string> cardList = new();

        public MainPage()
        {
            InitializeComponent();
            cardCollectionView.ItemsSource = cardList;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            cardList.Clear();
            foreach (string card in pickedCards)
            {
                cardList.Add(card);
            }
        }
    }
}