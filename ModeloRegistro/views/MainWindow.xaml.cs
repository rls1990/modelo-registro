using ModeloRegistro.services;
using System;
using System.IO;
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
            Global.sqlite=new model.SQLite("data.db");
            LoadInit();
        }

        public async void LoadInit()
        {
            await PageService.LoadPage(new login.Login(),frame,1500);
        }
    }
}
