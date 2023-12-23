using MauiNavigationpages.Views;

namespace MauiNavigationpages
{
    public partial class Repair : ContentPage
    {
        bool c = false;
        NavPage NavPageElement=new NavPage();
        public Repair()
        {
            InitializeComponent();
            
             
            
        }
        /*
         * NominalEntry
         * TminEntry
         * ServiceLifeEntry
         * RemainingLifeEntry asking for next inspection interval so double that
         */

        private async void Btn_Release(object sender, EventArgs e)
        {
            NavPageElement.Btn_Released(sender, e);
        }
        private async void CalculateBtn_Clicked(object sender, EventArgs e)
        {
            NavPageElement.Color_Change(sender, e);
            double tmin = Convert.ToDouble(TminEntry.Text);
            double nominal= Convert.ToDouble(NominalEntry.Text);
            double ServiceLife= Convert.ToDouble(ServiceLifeEntry.Text);
            double RemainingLife= Convert.ToDouble(RemainingLifeEntry.Text);
            double repairthickness=
                nominal-(((nominal-tmin)/(ServiceLife+RemainingLife))*(ServiceLife));
            
            RepairLabel.Text = $"Restore anything below:\n {repairthickness:F3}";
            if (c==false)
                await DisplayAlert("Caution", "Use this calc at your own risk\nApp developer assumes no risk for your use of these calculations", "I understand");
            c = true;
        }
       
       
 
    }

}
