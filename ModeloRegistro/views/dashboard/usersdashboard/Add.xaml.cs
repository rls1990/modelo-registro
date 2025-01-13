using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.usersdashboard
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

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new UsersDashboard());
        }
    }
}
