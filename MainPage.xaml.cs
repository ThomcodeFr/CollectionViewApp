using System.Collections.ObjectModel;
using Microsoft.Maui.Graphics;

namespace CollectionViewApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ColorItem> Colors { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Colors =
            [
                new ColorItem { Name = "Red", Color = Color.FromRgb(255, 0, 0) },
                new ColorItem { Name = "Green", Color = Color.FromRgb(0, 255, 0) },
                new ColorItem { Name = "Blue", Color = Color.FromRgb(0, 0, 255) },
                new ColorItem { Name = "Yellow", Color = Color.FromRgb(255, 255, 0) },
                new ColorItem { Name = "Purple", Color = Color.FromRgb(128, 0, 128) },
                new ColorItem { Name = "Orange", Color = Color.FromRgb(255, 165, 0) },
                new ColorItem { Name = "Pink", Color = Color.FromRgb(255, 192, 203) },
                new ColorItem { Name = "Cyan", Color = Color.FromRgb(0, 255, 255) },
                new ColorItem { Name = "Magenta", Color = Color.FromRgb(255, 0, 255) },
                new ColorItem { Name = "Brown", Color = Color.FromRgb(165, 42, 42) },
            ];

            ColorCollectionView.ItemsSource = Colors;
        }

       
        /// <summary>
        /// Logique quand la couleur est selectionnée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnColorSelected(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (sender as CollectionView)?.SelectedItem as ColorItem;
            if (selectedItem != null)
            {
                await DisplayAlert("Color Details", $"RGB: {selectedItem.Color.Red}, {selectedItem.Color.Green}, {selectedItem.Color.Blue}", "OK");
            }

            (sender as CollectionView).SelectedItem = null;
        }

        /// <summary>
        /// Permet de Bind la couleur et le nom de la couleur.
        /// </summary>
        public class ColorItem
        {
            public required string Name { get; set; }
            public required Color Color { get; set; }
        }
    }
}