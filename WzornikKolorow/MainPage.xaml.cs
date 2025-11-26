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
    }
}
