using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ModeloRegistro.views.dashboard
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard:Page
    {
        public Dashboard()
        {
            InitializeComponent();
            Global.frame_dashboard=frame_dashboard;
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new login.Login(),Global.frame);
        }

        private void TreeViewItem_MouseLeftButtonUp( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo2.Anexo2());
        }

        private void TreeViewItem_MouseLeftButtonUp_1( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo3.Anexo3());
        }

        private void TreeViewItem_MouseLeftButtonUp_2( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo4.Anexo4());
        }

        private void TreeViewItem_MouseLeftButtonUp_3( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo5.Anexo5());
        }

        private void TreeViewItem_MouseLeftButtonUp_4( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo6.Anexo6());
        }

        private void TreeViewItem_MouseLeftButtonUp_5( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo7.Anexo7());
        }

        private void TreeViewItem_MouseLeftButtonUp_6( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo9.Anexo9());
        }

        private void TreeViewItem_MouseLeftButtonUp_7( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo10.Anexo10());
        }

        private void TreeViewItem_MouseLeftButtonUp_8( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo11.Anexo11());
        }

        private void TreeViewItem_MouseLeftButtonUp_9( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo12.Anexo12());
        }

        private void TreeViewItem_MouseLeftButtonUp_10( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo13.Anexo13());
        }

        private void TreeViewItem_MouseLeftButtonUp_11( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo14.Anexo14());
        }

        private void TreeViewItem_MouseLeftButtonUp_12( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo15.Anexo15());
        }

        private void TreeViewItem_MouseLeftButtonUp_13( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo16.Anexo16());
        }

        private void TreeViewItem_MouseLeftButtonUp_14( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo17.Anexo17());
        }

        private void TreeViewItem_MouseLeftButtonUp_15( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo18.Anexo18());
        }

        private void TreeViewItem_MouseLeftButtonUp_16( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo19.Anexo19());
        }

        private void TreeViewItem_MouseLeftButtonUp_17( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo20.Anexo20());
        }

        private void TreeViewItem_MouseLeftButtonUp_18( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo21.Anexo21());
        }

        private void TreeViewItem_MouseLeftButtonUp_19( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo22.Anexo22());
        }

        private void TreeViewItem_MouseLeftButtonUp_20( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo23.Anexo23());
        }

        private void TreeViewItem_MouseLeftButtonUp_21( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo24.Anexo24());
        }

        private void TreeViewItem_MouseLeftButtonUp_22( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo25.Anexo25());
        }

        private void TreeViewItem_MouseLeftButtonUp_23( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo26.Anexo26());
        }

        private void TreeViewItem_MouseLeftButtonUp_24( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo27.Anexo27());
        }

        private void TreeViewItem_MouseLeftButtonUp_25( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo28.Anexo28());
        }

        private void TreeViewItem_MouseLeftButtonUp_26( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo29.Anexo29());
        }

        private void TreeViewItem_MouseLeftButtonUp_27( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo30.Anexo30());
        }

        private void TreeViewItem_MouseLeftButtonUp_28( object sender,MouseButtonEventArgs e )
        {
            PageService.toPage(new modelos.anexo31.Anexo31());
        }

        //private void Button_Click_1( object sender,RoutedEventArgs e )
        //{
        //    PageService.toPage(new users.Users());
        //}

        private void Button_Click_2( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new login
                .Login(),Global.frame);
        }

        private void Button_Click_3( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new usersdashboard.UsersDashboard());
        }
    }
}
