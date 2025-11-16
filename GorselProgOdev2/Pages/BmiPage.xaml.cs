namespace GorselProgOdev2.Pages
{
    public partial class BmiPage : ContentPage
    {
        public BmiPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double kg = sliderWeight.Value;
            double boy = sliderHeight.Value / 100;

            lblWeight.Text = $"Kilo: {kg:N0}";
            lblHeight.Text = $"Boy: {sliderHeight.Value:N0}";

            double bmi = kg / (boy * boy);

            lblBmi.Text = $"VKÝ: {bmi:N2}";

            if (bmi < 16)
                lblBmiCategory.Text = "Ýleri derecede zayýf";
            else if (bmi < 17)
                lblBmiCategory.Text = "Orta düzeyde zayýf";
            else if (bmi < 18.49)
                lblBmiCategory.Text = "Hafif düzeyde zayýf";
            else if (bmi < 24.9)
                lblBmiCategory.Text = "Normal kilolu";
            else if (bmi < 29.99)
                lblBmiCategory.Text = "Hafif þiþman / fazla kilolu";
            else if (bmi < 34.99)
                lblBmiCategory.Text = "1. derece obez";
            else if (bmi < 39.99)
                lblBmiCategory.Text = "2. derece obez";
            else
                lblBmiCategory.Text = "3. derece obez / morbid obez";
        }
    }
}
