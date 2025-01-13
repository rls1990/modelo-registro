using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo9
{
    /// <summary>
    /// Interaction logic for Anexo9.xaml
    /// </summary>
    public partial class Anexo9:Page
    {
        public Anexo9()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Add());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Upd());
        }

        private void Button_Click_2( object sender,RoutedEventArgs e )
        {

        }

        private void Button_Click_3( object sender,RoutedEventArgs e )
        {

        }
    }
}
