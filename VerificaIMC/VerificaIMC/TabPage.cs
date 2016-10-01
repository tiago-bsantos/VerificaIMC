using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace VerificaIMC
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
