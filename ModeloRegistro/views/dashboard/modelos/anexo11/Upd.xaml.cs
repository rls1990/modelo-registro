using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo11
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo11());
        }
    }
}
