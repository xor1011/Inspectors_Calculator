namespace MauiNavigationpages.Views;

public partial class Section_VIII : ContentPage
{
    NavPage NavPageElement = new NavPage();
    public Section_VIII()
	{
		InitializeComponent();
	}

    private void shell_thickness_calc()
    {
        try
        {
            double E = double.Parse(Shell_E.Text);
            double R = double.Parse(Shell_R.Text);
            double S = double.Parse(Shell_S.Text);
            double P = double.Parse(Shell_P.Text);
            double t = (P * R) / ((S * E) - (0.6 * P));
            double lt = (P * R) / ((2 * S * E) + (.4 * P));
            Circ_Press.Text = $"t= {t.ToString("F3")}";
            Long_Press.Text = $"t= {lt.ToString("F3")}";

        }
        catch (Exception ex)
        {
            Task task = DisplayAlert("Alert", ex.Message, "Try again");
        }
    }

    private void shell_pressure_calc()
    {
        try
        {
            double T = double.Parse(Shell_T.Text);
            double E = double.Parse(Shell_E.Text);
            double R = double.Parse(Shell_R.Text);
            double S = double.Parse(Shell_S.Text);
            double p = (S * E * T) / ((R + (0.6 * T)));
            double lp = (2 * S * T) / ((R - (0.4 * T)));
            Circ_Press.Text = $"p= {p.ToString("F0")}";
            Long_Press.Text = $"p= {lp.ToString("F0")}";
        }
        catch (Exception ex)
        {
            Task task = DisplayAlert("Alert", ex.Message, "Try again");
        }
    }
    private void Shell_Pressure_Pressed(object sender, EventArgs e)
    {
        NavPageElement.Color_Change(sender, e);
        if (Shell_P.Text.Length > 0 && Shell_T.Text.Length > 0)
        {
            Task task = DisplayAlert("Alert", "Leave P or T blank", "Got it");
        }
        else
        {
            if (Shell_P.Text.Length > 0 && Shell_T.Text.Length < 1)
            {
                shell_thickness_calc();
            }
            else
            {
                shell_pressure_calc();
            }
        }

    }
	private void Btn_Released(object sender, EventArgs e)
	{
        NavPageElement.Btn_Released(sender, e);
    }
}