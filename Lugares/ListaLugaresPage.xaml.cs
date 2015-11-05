using Lugares.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace Lugares
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ListaLugaresPage : Page
    {
        public ListaLugaresPage()
        {
            this.InitializeComponent();
        }

        private ObservableCollection<Lugar> lugares;

        public ObservableCollection<Lugar> Lugares
        {
            get {
                if (lugares == null) {
                    lugares = new ObservableCollection<Lugar>();

                    Lugar pasto = new Lugar() { Nombre="Pasto", Descripcion="Parque de Nariño"
                        , Img= "http://www.hotelsanmiguelpasto.com/wp-content/uploads/2012/07/Pasto-al-atardece.jpg" };

                    Lugar medellin = new Lugar() { Nombre="Medellin",Descripcion="Metro",
                          Img= "http://www.hotelportonmedellin.com/wp-content/uploads/2013/03/medellin.jpg"
                    };
                    Lugar popayan = new Lugar()
                    {
                        Nombre = "Popayan",
                        Descripcion = "La Ciudad Blanca",
                        Img = "http://xpert.co/wp-content/uploads/2008/07/popayan-703186.jpg"
                    };

                    lugares.Add(pasto);
                    lugares.Add(medellin);
                    lugares.Add(popayan);

                }
                return lugares; }
            set { lugares = value; }
        }

        private void deleteItem(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex >= 0) {
                lugares.RemoveAt(list.SelectedIndex);
            }
        }

        private void editItem(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex >= 0) {
                Frame rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(MainPage),list.SelectedItem); 
            }
        }
    }
}
