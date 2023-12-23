using NCalc;
using MauiNavigationpages.Views;


namespace MauiNavigationpages
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NavPage), typeof(NavPage));
            Routing.RegisterRoute(nameof(B31Calc), typeof(B31Calc));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(Section_VIII), typeof(Section_VIII));
            Routing.RegisterRoute(nameof(Radiography), typeof(Radiography));
            Routing.RegisterRoute(nameof(Repair), typeof(Repair));

        }
    }
}
