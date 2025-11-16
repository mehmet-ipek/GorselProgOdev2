using GorselProgOdev2.Pages;

namespace GorselProgOdev2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(CreditPage), typeof(CreditPage));
            Routing.RegisterRoute(nameof(BmiPage), typeof(BmiPage));
            Routing.RegisterRoute(nameof(ColorPage), typeof(ColorPage));
        }
    }
}
