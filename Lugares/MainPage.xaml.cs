using Lugares.Models;
using System;
using System.Collections.Generic;
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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lugares
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private Lugar lugar;

        public Lugar Lugar
        {
            get {
                if (lugar == null)
                    lugar = new Lugar() { Nombre="Popayan",Descripcion="La Ciudad Blanca"
                        ,Img="http://xpert.co/wp-content/uploads/2008/07/popayan-703186.jpg"};
                return lugar; }
            set { lugar = value; }
        }

        private void cambiarNombre(object sender, RoutedEventArgs e)
        {
            lugar.Nombre = "Parque Caldas";
        }
    }
}
