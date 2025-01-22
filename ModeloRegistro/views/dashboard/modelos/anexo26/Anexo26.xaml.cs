using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo26
{
    /// <summary>
    /// Interaction logic for Anexo26.xaml
    /// </summary>
    public partial class Anexo26:Page
    {
        private model.Anexo26_m manager = new model.Anexo26_m(Global.sqlite);
        public List<model.Anexo26_e> lista { get; set; }
        public Anexo26()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo26_e>();
            else
                lista.Clear();

            List<model.Anexo26_e> lm = manager.list();
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
            if(listadg.SelectedIndex!=-1)
            {
                var res = MessageBox.Show("Está seguro que desea eliminar esta fila?","Confirmación",MessageBoxButton.YesNo,MessageBoxImage.Question);

                if(res==MessageBoxResult.Yes)
                {
                    model.Anexo26_e entity = (model.Anexo26_e)listadg.SelectedItem;
                    manager.delete(entity.id);
                    InitList();
                }
            } else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla.","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }


        }

        private void Button_Click_3( object sender,RoutedEventArgs e )
        {

        }
    }
}
