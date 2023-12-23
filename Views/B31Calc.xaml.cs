using MathNet.Numerics;

namespace MauiNavigationpages.Views;

public partial class B31Calc : ContentPage
{
	public B31Calc()
	{
		InitializeComponent();
	}
	NavPage NavPageElement = new NavPage();
	private async void Tcalc_Pressed(object sender, EventArgs e)
	{
		NavPageElement.Color_Change(sender, e);
		try
		{
			double D = double.Parse(Dia_Entry.Text);
			double P = double.Parse(Pressure_Entry.Text);
			double S = double.Parse(Stress_Entry.Text);
			double Y = double.Parse(Y_Entry.Text);
		

		double Treq=(P*D)/(2*(S)+(Y*P));
		double BLow = (P * D) / (2 * S);
		double ST = S;
		if (StressTemp_Entry !=null)
		{
			try
			{
				ST = double.Parse(StressTemp_Entry.Text);
			}
			catch { ST = S; }
		}
		
		double hydroP = 1.5 * P * (S / ST);

		Trequired.Text = $"B31.3 Required thickness = {Treq.ToString("F3")}" +
			$"\nApi 570 Tmin (Barlow Formula) = {BLow.ToString("F3")}" +
			$"\n\nB31.3 Hydrotest pressure = {hydroP.ToString("F0")}";
        }
        catch
        {
            Task task = DisplayAlert("Cannot Calculate", "Fill out all required fields", "I understand");
        }

    }

    private void Tcalc_Released(object sender, EventArgs e)
    {
		NavPageElement.Btn_Released(sender, e);
    }
}