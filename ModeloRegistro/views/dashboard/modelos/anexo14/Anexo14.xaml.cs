using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo14
{
    /// <summary>
    /// Interaction logic for Anexo14.xaml
    /// </summary>
    public partial class Anexo14:Page
    {
        private model.Anexo14_m manager = new model.Anexo14_m(Global.sqlite);
        public List<model.Anexo14_e> lista { get; set; }
        public Anexo14()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo14_e>();
            else
                lista.Clear();

            List<model.Anexo14_e> lm = manager.list();
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
                    model.Anexo14_e entity = (model.Anexo14_e)listadg.SelectedItem;
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
                        string fileName = "anexo_14._modelo_11-30_modificado._solicitud_transcripcion_de_matrimonio_0.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo14_e entity = (model.Anexo14_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo14 anexo = new reports.entidades.Anexo14()
                        {
                            quien_suscribe=entity.quien_suscribe,
                            nombre_contrayente=entity.nombre_contrayente,
                            ciudadania_contrayente=entity.ciudadania_contrayente,
                            primer_apellido_contrayente=entity.primer_apellido_contrayente,
                            segundo_apellido_contrayente=entity.segundo_apellido_contrayente,
                            registro_civil_contrayente=entity.registro_civil_contrayente,
                            tomo_contrayente=entity.tomo_contrayente,
                            folio_contrayente=entity.folio_contrayente,
                            lugar_nacimiento_contrayente=entity.lugar_nacimiento_contrayente,
                            fecha_nacimiento_contrayente=entity.fecha_nacimiento_contrayente,
                            nro_pasaporte_identidad_contrayente=entity.nro_pasaporte_identidad_contrayente,
                            estado_civil_antes_matrimonio_contrayente=entity.estado_civil_antes_matrimonio_contrayente,
                            ocupacion_contrayente=entity.ocupacion_contrayente,
                            padre_contrayente=entity.padre_contrayente,
                            madre_contrayente=entity.madre_contrayente,
                            domicilio_contrayente=entity.domicilio_contrayente,
                            nombre_la_contrayente=entity.nombre_la_contrayente,
                            ciudadania_la_contrayente=entity.ciudadania_la_contrayente,
                            primer_apellido_la_contrayente=entity.primer_apellido_la_contrayente,
                            segundo_apellido_la_contrayente=entity.segundo_apellido_la_contrayente,
                            registro_civil_la_contrayente=entity.registro_civil_la_contrayente,
                            tomo_la_contrayente=entity.tomo_la_contrayente,
                            folio_la_contrayente=entity.folio_la_contrayente,
                            lugar_nacimiento_la_contrayente=entity.lugar_nacimiento_la_contrayente,
                            dia_fecha_nacimiento_la_contrayente=entity.fecha_nacimiento_la_contrayente.Split('-')[2],
                            mes_fecha_nacimiento_la_contrayente=entity.fecha_nacimiento_la_contrayente.Split('-')[1],
                            anno_fecha_nacimiento_la_contrayente=entity.fecha_nacimiento_la_contrayente.Split('-')[0],
                            nro_pasaporte_identidad_la_contrayente=entity.nro_pasaporte_identidad_la_contrayente,
                            estado_civil_antes_matrimonio_la_contrayente=entity.estado_civil_antes_matrimonio_la_contrayente,
                            ocupacion_la_contrayente=entity.ocupacion_la_contrayente,
                            padre_la_contrayente=entity.padre_la_contrayente,
                            madre_la_contrayente=entity.madre_la_contrayente,
                            domicilio_la_contrayente=entity.domicilio_la_contrayente,
                            observaciones_la_contrayente=entity.observaciones_la_contrayente,
                            lugar_certificado=entity.lugar_certificado,
                            tomo_certificado=entity.tomo_certificado,
                            folio_certificado=entity.folio_certificado,
                            dia_fecha_formalizacion=entity.fecha_formalizacion.Split('-')[2],
                            mes_fecha_formalizacion=entity.fecha_formalizacion.Split('-')[1],
                            anno_fecha_formalizacion=entity.fecha_formalizacion.Split('-')[0],
                            nombre_funcionario_expidió_certificado=entity.nombre_funcionario_expidió_certificado,
                            cargo_funcionario_expidió_certificado=entity.cargo_funcionario_expidió_certificado,
                            dia_fecha_solicitud=entity.fecha_solicitud.Split('-')[2],
                            mes_fecha_solicitud=entity.fecha_solicitud.Split('-')[1],
                            anno_fecha_solicitud=entity.fecha_solicitud.Split('-')[0]
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
