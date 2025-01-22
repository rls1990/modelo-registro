using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo4
{
    /// <summary>
    /// Interaction logic for Anexo4.xaml
    /// </summary>
    public partial class Anexo4:Page
    {
        private model.Anexo4_m manager = new model.Anexo4_m(Global.sqlite);
        public List<model.Anexo4_e> lista { get; set; }
        public Anexo4()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo4_e>();
            else
                lista.Clear();

            List<model.Anexo4_e> lm = manager.list();
            lm.Reverse();
            lista.AddRange(lm);

            listadg.Items.Refresh();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Add());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            if(listadg.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla.","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            } else
            {
                Global.entity=listadg.SelectedItem;
                PageService.toPage(new Upd());
            }
        }

        private void Button_Click_2( object sender,RoutedEventArgs e )
        {
            var res = MessageBox.Show("Está seguro que desea eliminar esta fila?","Confirmación",MessageBoxButton.YesNo,MessageBoxImage.Question);

            if(res==MessageBoxResult.Yes)
            {
                model.Anexo4_e entity = (model.Anexo4_e)listadg.SelectedItem;
                manager.delete(entity.id);
                InitList();
            }
        }

        private void Button_Click_3( object sender,RoutedEventArgs e )
        {

        }
    }
}
