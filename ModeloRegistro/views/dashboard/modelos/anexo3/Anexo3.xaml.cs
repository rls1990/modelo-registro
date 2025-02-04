using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo3
{
    /// <summary>
    /// Interaction logic for Anexo3.xaml
    /// </summary>
    public partial class Anexo3:Page
    {
        private model.Anexo3_m manager = new model.Anexo3_m(Global.sqlite);
        public List<model.Anexo3_e> lista { get; set; }
        public Anexo3()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo3_e>();
            else
                lista.Clear();

            List<model.Anexo3_e> lm = manager.list();
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
                    model.Anexo3_e entity = (model.Anexo3_e)listadg.SelectedItem;
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
                        string fileName = "anexo_3.certificacion_de_nacimiento_1.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo3_e entity = (model.Anexo3_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo3 anexo = new reports.entidades.Anexo3()
                        {
                            ciudad=entity.ciudad,
                            pais=entity.pais,
                            nombre_apellido=entity.nombre_apellido,
                            dia=entity.fecha_nacimiento.Split('-')[2],
                            mes=entity.fecha_nacimiento.Split('-')[1],
                            anno=entity.fecha_nacimiento.Split('-')[0],
                            municipio=entity.municipio,
                            provincia=entity.provincia,
                            registro=entity.registro,
                            municipio_registro=entity.municipio_registro,
                            provincia_registro=entity.provincia_registro,
                            tomo=entity.tomo,
                            folio=entity.folio,
                            dia_asiento=entity.fecha_asiento.Split('-')[2],
                            mes_asiento=entity.fecha_asiento.Split('-')[1],
                            anno_asiento=entity.fecha_asiento.Split('-')[0],
                            nombre_padre=entity.nombre_padre,
                            nombre_madre=entity.nombre_madre,
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
