using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificaIMC.Model;
using Xamarin.Forms;

namespace VerificaIMC.View
{
    public partial class Historico : ContentPage
    {
        public ObservableCollection<IMC> ListaIMC { get; set; }

        public Historico(ObservableCollection<IMC> listaIMC)
        {
            BindingContext = this;
            ListaIMC = listaIMC;
            InitializeComponent();
        }

        public async void ManipulaItem(object sender, ItemTappedEventArgs e)
        {
            IMC imc = e.Item as IMC;
            var resposta = await DisplayAlert("Remover registro de IMC", "Tem certeza que deseja remover este registro?", "Sim", "Não");
            if (resposta)
            {
                ListaIMC.Remove(imc);
                await DisplayAlert("Remover registro de IMC", "Registro removido com sucesso", "Ok");
            }

        }

    }
}
