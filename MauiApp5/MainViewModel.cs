using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp5
{
    public class MainViewModel : ObservableObject
    {
        private readonly List<Color> backgroundColors;

        public ObservableCollection<ColoredTile> ColoredTiles { get; } = new ObservableCollection<ColoredTile>
            {
                new ColoredTile
                {
                    CanControlAnotherTile = true,
                    HexValue = Colors.Orange.ToHex(),
                    Color = Colors.Orange
                },
                new ColoredTile
                {
                    HexValue = Colors.Red.ToHex(),
                    Color = Colors.Red
                },
                new ColoredTile
                {
                    HexValue = Colors.Green.ToHex(),
                    Color = Colors.Green
                }
            };

        public IAsyncRelayCommand ChangeColorCommand { get; }

        public MainViewModel()
        {
            ChangeColorCommand = new AsyncRelayCommand(ChangeColor);
            backgroundColors = new List<Color>
            {
                Colors.Red,
                Colors.Green,
                Colors.Blue,
                Colors.Aqua,
                Colors.Azure
            };
        }

        private async Task ChangeColor()
        {
            var random = new Random();
            int randomNumber = random.Next(0, 4);
            
            var randomColor = backgroundColors[randomNumber];
            ColoredTiles[1].Color = randomColor;
            ColoredTiles[1].HexValue = randomColor.ToHex();
        }
    }
}
