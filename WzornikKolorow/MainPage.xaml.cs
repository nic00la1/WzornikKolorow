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
            int r = (int)sliderR.Value;
            int g = (int)sliderG.Value;
            int b = (int)sliderB.Value;

            lblSliderRValue.Text = r.ToString();
            lblSliderGValue.Text = g.ToString();
            lblSliderBValue.Text = b.ToString();

            // duży prostokąt zmienia kolor na bieżąco
            bigRectangle.Fill = Color.FromRgb((byte)r, (byte)g, (byte)b);
        }

        public void ZliczWszystkieWartosci()
        {
            // Pobierz wartości z labeli suwaków
            int r = int.Parse(lblSliderRValue.Text);
            int g = int.Parse(lblSliderGValue.Text);
            int b = int.Parse(lblSliderBValue.Text);

            lblKolor.Text = $"{r}, {g}, {b}";
            lblKolor.BackgroundColor = Color.FromRgb((byte)r, (byte)g, (byte)b); // mały prostokąt się zmienia, po kliknięciu przycisku
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            ZliczWszystkieWartosci();
        }
    }
}
