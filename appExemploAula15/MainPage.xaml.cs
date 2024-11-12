using appExemploAula15.Models;
using appExemploAula15.Views;
namespace appExemploAula15
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = campoNome.Text;
            p.DataNascimento = campoDataNascimento.Date;

            await Navigation.PushAsync(new NewPage1()
            {
                BindingContext = p
            });
        }
    }

}
