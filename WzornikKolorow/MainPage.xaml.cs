namespace WzornikKolorow
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            int newValue = (int)slider.Value;
            lblSliderRValue.Text = newValue.ToString("");
        }

        private void Slider_ValueChanged_1(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            int newValue = (int)slider.Value;
            lblSliderGValue.Text = newValue.ToString("");
        }

        private void Slider_ValueChanged_2(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            int newValue = (int)slider.Value;
            lblSliderBValue.Text = newValue.ToString("");
        }

        public void ZliczWszystkieWartosci()
        {
            // Pobierz wartości z labeli suwaków
            int r = int.Parse(lblSliderRValue.Text);
            int g = int.Parse(lblSliderGValue.Text);
            int b = int.Parse(lblSliderBValue.Text);

            lblKolor.Text = $"{r}, {g}, {b}";
            lblKolor.BackgroundColor = Color.FromRgb((byte)r, (byte)g, (byte)b);
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            ZliczWszystkieWartosci();
        }
    }
}
