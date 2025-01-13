using ModeloRegistro.services;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo24
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,System.Windows.RoutedEventArgs e )
        {
            PageService.toPage(new Anexo24());
        }
    }
}
