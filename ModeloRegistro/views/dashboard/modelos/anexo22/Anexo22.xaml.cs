using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo22
{
    /// <summary>
    /// Interaction logic for Anexo22.xaml
    /// </summary>
    public partial class Anexo22:Page
    {
        public Anexo22()
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
