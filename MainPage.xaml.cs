namespace Kino
{
    public partial class MainPage : ContentPage
    {
        double cena = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Buy(object sender, EventArgs e)
        {
            cena += 15;
                koszyk.Text = $"Koszyk: {cena} zł";
        }
    }

}
