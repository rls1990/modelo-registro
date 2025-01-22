using ModeloRegistro.services;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo24
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo24_m manager = new model.Anexo24_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,System.Windows.RoutedEventArgs e )
        {
            PageService.toPage(new Anexo24());
        }

        private void Button_Click_1( object sender,System.Windows.RoutedEventArgs e )
        {

        }
    }
}
