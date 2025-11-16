namespace GorselProgOdev2.Pages
{
    public partial class CreditPage : ContentPage
    {
        public CreditPage()
        {
            InitializeComponent();
            pickerCreditType.SelectedIndex = 0;
        }

        private void SliderMonths_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblMonths.Text = $"Vade: {Convert.ToInt32(e.NewValue)} Ay";
        }

        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(entryAmount.Text, out double principal)) return;
            if (!double.TryParse(entryInterest.Text, out double annualRate)) return;

            int months = (int)sliderMonths.Value;
            double monthlyRate = annualRate / 100 / 12;

            double monthlyPayment =
                principal * monthlyRate /
                (1 - Math.Pow(1 + monthlyRate, -months));

            double totalPayment = monthlyPayment * months;

            lblMonthlyPayment.Text = $"Aylık: {monthlyPayment:N2} ₺";
            lblTotalPayment.Text = $"Toplam: {totalPayment:N2} ₺";
        }
    }
}
