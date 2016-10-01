using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace VerificaIMC
{
    public partial class Cadastro : ContentPage
    {
        public string Data;
        public double Peso;
        public double Altura;

        public ObservableCollection<IMC> ListaIMC;

        public Cadastro(ObservableCollection<IMC> listaIMC)
        {
            ListaIMC = listaIMC;
            InitializeComponent();
        }

        public void CalcularIMC(Object sender, EventArgs e)
        {
            Data = DateTime.Now.ToString("dd/MM/yyyy");
            Peso = double.Parse(ValorDoPeso.Text);
            Altura = double.Parse(ValorDaAltura.Text);


            IMC imc = new IMC(Data, Peso, Altura);
            ListaIMC.Add(imc);

            string msg = "IMC: " + imc.ValorIMC.ToString() + "\nResultado: " + imc.Resultado + ".\n\nOs dados foram salvos no Histórico.";
            DisplayAlert("Resultado do IMC", msg, "Ok");
        }
    }
}
