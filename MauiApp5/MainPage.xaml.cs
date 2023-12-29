namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        public static readonly BindableProperty HalfPageHeightProperty = BindableProperty.Create(nameof(HalfPageHeight), typeof(double), typeof(ContentPage));

        public double HalfPageHeight
        {
            get => (double)GetValue(HalfPageHeightProperty);
            set => SetValue(HalfPageHeightProperty, value);
        }

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
        }

        protected override void OnSizeAllocated(double pageWidth, double pageHeight)
        {
            base.OnSizeAllocated(pageWidth, pageHeight);
            HalfPageHeight = pageHeight / 2;
        }
    }

}
