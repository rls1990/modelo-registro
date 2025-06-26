using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo9
{
    /// <summary>
    /// Interaction logic for Anexo9.xaml
    /// </summary>
    public partial class Anexo9:Page
    {
        private model.Anexo9_m manager = new model.Anexo9_m(Global.sqlite);
        public List<model.Anexo9_e> lista { get; set; }
        public Anexo9()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo9_e>();
            else
                lista.Clear();

            List<model.Anexo9_e> lm = manager.list();
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
                    model.Anexo9_e entity = (model.Anexo9_e)listadg.SelectedItem;
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
                        string fileName = "anexo_9._certificacion_de_solteria_0.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo9_e entity = (model.Anexo9_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo9 anexo = new reports.entidades.Anexo9()
                        {
                            ciudad=entity.ciudad,
                            pais=entity.pais,
                            encargado_registro_civil=entity.encargado_registro_civil,
                            municipio_encargado=entity.municipio_encargado,
                            provincia_encargado=entity.provincia_encargado,
                            nombre=entity.nombre,
                            dia_solicitud=ValidarCampo(entity.fecha_solicitud)?entity.fecha_solicitud.Split('-')[2]:"",
                            mes_solicitud=ValidarCampo(entity.fecha_solicitud) ? entity.fecha_solicitud.Split('-')[1]:"",
                            anno_solicitud=ValidarCampo(entity.fecha_solicitud) ? entity.fecha_solicitud.Split('-')[0]:"",
                            tomo_certificado=entity.tomo_certificado,
                            folio_certificado=entity.folio_certificado,
                            dia_nacimiento=ValidarCampo(entity.fecha_nacimiento) ? entity.fecha_nacimiento.Split('-')[2]:"",
                            mes_nacimiento=ValidarCampo(entity.fecha_nacimiento) ? entity.fecha_nacimiento.Split('-')[1]:"",
                            anno_nacimiento=ValidarCampo(entity.fecha_nacimiento) ? entity.fecha_nacimiento.Split('-')[0]:"",
                            municipio_persona=entity.municipio_persona,
                            provincia_persona=entity.provincia_persona,
                            padre=entity.padre,
                            madre=entity.madre,
                            legalizacion_minred=entity.legalizacion_minrex, // Nota: Ajuste de nombre de propiedad
                            legalizacion_embajada=entity.legalizacion_embajada,
                            fecha_solicitud=entity.fecha_de_solicitud // Nota: Ajuste de nombre de propiedad
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

        private bool ValidarCampo( string val )
        {
            if(!string.IsNullOrWhiteSpace(val))
                return true;
            return false;
        }
    }
}
