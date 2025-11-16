namespace GorselProgOdev2.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void GoToCredit(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(CreditPage));
        }

        private void GoToBmi(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(BmiPage));
        }

        private void GoToColor(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ColorPage));
        }
    }
}
