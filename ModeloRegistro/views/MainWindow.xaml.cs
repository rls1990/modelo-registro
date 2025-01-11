using ModeloRegistro.services;
using ModeloRegistro.views.login;
using System.Windows;

namespace ModeloRegistro.views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Global.frame=frame;

            LoadInit();
        }

        public async void LoadInit()
        {
            await PageService.LoadPage(new dashboard.Dashboard(),frame,1500);
        }
    }
}
