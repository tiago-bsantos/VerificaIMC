using System.Collections.ObjectModel;
using VerificaIMC.Model;
using Xamarin.Forms;

namespace VerificaIMC.View
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {
            ObservableCollection<IMC> listaIMC = new ObservableCollection<IMC>();
            this.Children.Add(new Cadastro(listaIMC));
            this.Children.Add(new Historico(listaIMC));
        }
    }
}
