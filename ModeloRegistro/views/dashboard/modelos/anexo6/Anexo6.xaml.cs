using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo6
{
    /// <summary>
    /// Interaction logic for Anexo6.xaml
    /// </summary>
    public partial class Anexo6:Page
    {
        private model.Anexo6_m manager = new model.Anexo6_m(Global.sqlite);
        public List<model.Anexo6_e> lista { get; set; }
        public Anexo6()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo6_e>();
            else
                lista.Clear();

            List<model.Anexo6_e> lm = manager.list();
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
                    model.Anexo6_e entity = (model.Anexo6_e)listadg.SelectedItem;
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
            if(listadg.SelectedIndex!=-1)
            {
                var res = MessageBox.Show("Está seguro que desea exportar esta fila?","Confirmación",MessageBoxButton.YesNo,MessageBoxImage.Question);

                if(res==MessageBoxResult.Yes)
                {
                    CommonOpenFileDialog dialog = new CommonOpenFileDialog
                    {
                        // Configura el diálogo para seleccionar carpetas
                        IsFolderPicker=false
                    };

                    // Muestra el diálogo y verifica si el usuario seleccionó una carpeta
                    if(dialog.ShowDialog()==CommonFileDialogResult.Ok)
                    {
                        string fileName = "anexo_6.certificacion_de_sentencia_de_divorcio_0.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo6_e entity = (model.Anexo6_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo6 anexo = new reports.entidades.Anexo6()
                        {
                            ciudad=entity.ciudad,
                            pais=entity.pais,
                            nombre_apellido_hombre=entity.nombre_apellido_hombre,
                            nombre_apellido_mujer=entity.nombre_apellido_mujer,
                            tribunal_dicto_sentencia=entity.tribunal_dicto_sentencia,
                            nombre_secretario_actuante=entity.nombre_secretario_actuante,
                            dia_fecha_dicto_sentencia=entity.fecha_dicto_sentencia.Split('-')[2],
                            mes_fecha_dicto_sentencia=entity.fecha_dicto_sentencia.Split('-')[1],
                            anno_fecha_dicto_sentencia=entity.fecha_dicto_sentencia.Split('-')[0],
                            dia_fecha_firmeza_sentencia=entity.fecha_firmeza_sentencia.Split('-')[2],
                            mes_fecha_firmeza_sentencia=entity.fecha_firmeza_sentencia.Split('-')[1],
                            anno_fecha_firmeza_sentencia=entity.fecha_firmeza_sentencia.Split('-')[0],
                            no_sentencia=entity.no_sentencia,
                            no_radicacion=entity.no_radicacion,
                            legalizacion_minred=entity.legalizacion_minred,
                            legalizacion_embajada=entity.legalizacion_embajada,
                            fecha_solicitud=entity.fecha_solicitud
                        };

                        Util.LlenarSpans(html,anexo);

                        Util.SaveHtmlReport(html,outputFileName);

                    } else
                    {
                        MessageBox.Show("No se seleccionó ninguna carpeta.");
                    }
                }
            } else
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla.","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void buscar_TextChanged( object sender,TextChangedEventArgs e )
        {
            string searchText = buscar.Text;
            if(searchText.Length>0)
            {
                var listaF = lista.FindAll(( item ) => item.ContieneTexto(searchText));
                listadg.ItemsSource=listaF;
            } else
                listadg.ItemsSource=lista;
        }
    }
}
