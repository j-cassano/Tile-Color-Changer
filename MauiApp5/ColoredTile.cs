using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp5
{
    public class ColoredTile : ObservableObject
    {
        private Color color;
        private string hexValue;
        private bool canControlAnotherTile;

        public string HexValue
        {
            get => hexValue;
            set => SetProperty(ref hexValue, value);
        }

        public Color Color
        {
            get => color;
            set => SetProperty(ref color, value);
        }

        public bool CanControlAnotherTile
        {
            get => canControlAnotherTile;
            set => SetProperty(ref canControlAnotherTile, value);
        }

        public ColoredTile()
        {
            HexValue = string.Empty;
            Color = Colors.White;
            CanControlAnotherTile = false;
        }
    }
}
