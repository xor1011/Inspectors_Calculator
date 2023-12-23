namespace MauiNavigationpages.Views;

public partial class NavPage : ContentPage
{
	public NavPage()
	{
		InitializeComponent();
	}

    public async void Btn_Released(object sender, EventArgs e)
    {
        ((Button)sender).BorderWidth = 0;
        ((Button)sender).BorderColor = Color.Parse("Black");
        ((Button)sender).BackgroundColor = Color.FromHex("#AC99EA");

    }

    public async void Color_Change(object sender, EventArgs e)
    {
        ((Button)sender).BorderWidth = 2;
        ((Button)sender).BorderColor = Color.Parse("White");
        ((Button)sender).BackgroundColor = Color.FromRgb(100, 255, 100);
    }
    private void CalcBtn_Clicked(object sender, EventArgs e)
	{
        ((Button)sender).BorderWidth = 2;
        ((Button)sender).BorderColor = Color.Parse("White");
        ((Button)sender).BackgroundColor = Color.FromRgb(100, 255, 100);
        Shell.Current.GoToAsync(nameof(B31Calc));
	}
    private void AboutBtn_Clicked(object sender, EventArgs e)
    {
        ((Button)sender).BorderWidth = 2;
        ((Button)sender).BorderColor = Color.Parse("White");
        ((Button)sender).BackgroundColor = Color.FromRgb(100, 255, 100);
        Shell.Current.GoToAsync(nameof(AboutPage));
    }

    private void Goto_Pressed(object sender, EventArgs e)
    {
        var name=((Button)sender).Text;
        string page=name.Replace(" ", "_");
        //Task task=DisplayAlert("Alert", page, "OK");
        Shell.Current.GoToAsync(page);
    }
}