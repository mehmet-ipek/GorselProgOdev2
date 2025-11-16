using Microsoft.Maui.Controls;

namespace GorselProgOdev2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToHome(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(Pages.HomePage));
        }
    }
}
