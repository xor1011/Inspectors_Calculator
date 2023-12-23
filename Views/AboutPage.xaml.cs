
using NCalc;
using System.Reflection.Metadata;

namespace MauiNavigationpages.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
	/*Private async void HomeBtn_Clicked(object sender, EventArgs e)
	{
		HomeBtn.BorderColor = Color.Parse("White");
		HomeBtn.BackgroundColor = Color.FromRgb(100, 255, 100);

	}*/
    private async void HomeBtn_Released(object sender, EventArgs e)
    {
           await Shell.Current.GoToAsync("///NavPage");
    }
	String buttonText=string.Empty;
	bool Paren=false;

	private async void Btn_Released(object sender, EventArgs e)
	{
        ((Button)sender).BorderWidth = 0;
        ((Button)sender).BorderColor = Color.Parse("Black");
		((Button)sender).BackgroundColor = Color.FromHex("#AC99EA");

    }
	private async void AnyBtn_Pressed(object sender, EventArgs e)
	{
		((Button)sender).BorderWidth = 2;
		((Button)sender).BorderColor = Color.Parse("White");
        ((Button)sender).BackgroundColor = Color.FromRgb(100, 255, 100);
        if (buttonText == "0")
		{
			buttonText = "";
			FieldCalc.Text = "";
		}
        String btnText = ((Button)sender).Text;
		if (btnText == "()") {
			if (Paren == false)
			{
				btnText = "(";
				Paren = true; 
			}
			else
			{
				btnText = ")";
				Paren = false;
			}
		}
		if (btnText == "C")
		{
			buttonText = "";
		}
		else
		{

            buttonText += btnText;
		}
        //buttonText += AnyBtn.Text;
        
        FieldCalc.Text = buttonText;
	}
	private async void Equals_Released(object sender, EventArgs e)
	{
		if (FieldCalc.Text == "")
			FieldCalc.Text="0";
		String myExpression = FieldCalc.Text;

		var eval = new Expression(myExpression);
		try
		{
			var result = eval.Evaluate();
			result = Convert.ToDouble(result);
            FieldCalc.Text = result.ToString();
				buttonText = FieldCalc.Text;
        }
        catch(Exception ex)
		{
		Task task=DisplayAlert("Error", ex.Message, "OK");
		}
		

	}
}