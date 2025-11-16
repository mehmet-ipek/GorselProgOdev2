using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace GorselProgOdev2.Pages
{
    public partial class ColorPage : ContentPage
    {
        public ColorPage()
        {
            InitializeComponent();
        }

        private void RgbSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            int r = (int)sliderR.Value;
            int g = (int)sliderG.Value;
            int b = (int)sliderB.Value;

            lblR.Text = r.ToString();
            lblG.Text = g.ToString();
            lblB.Text = b.ToString();

            string hex = $"#{r:X2}{g:X2}{b:X2}";
            lblHex.Text = hex;

            this.BackgroundColor = Color.FromArgb(hex);
        }

        private async void BtnCopy_Clicked(object sender, EventArgs e)
        {
            string renk_kodu = lblHex.Text;

            await Clipboard.SetTextAsync(renk_kodu);
            await DisplayAlert("Kopyalandý", $"{renk_kodu}", "OK");
        }

        private void BtnRandom_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();

            sliderR.Value = rnd.Next(0, 256);
            sliderG.Value = rnd.Next(0, 256);
            sliderB.Value = rnd.Next(0, 256);

            UpdateColor();
        }
    }
}
