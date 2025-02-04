using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo15
{
    /// <summary>
    /// Interaction logic for Anexo15.xaml
    /// </summary>
    public partial class Anexo15:Page
    {
        private model.Anexo15_m manager = new model.Anexo15_m(Global.sqlite);
        public List<model.Anexo15_e> lista { get; set; }
        public Anexo15()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo15_e>();
            else
                lista.Clear();

            List<model.Anexo15_e> lm = manager.list();
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
                    model.Anexo15_e entity = (model.Anexo15_e)listadg.SelectedItem;
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
                        string fileName = "anexo_15._modelo_13-30_modificado._solicitud_de_transcripcion_de_defuncion.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo15_e entity = (model.Anexo15_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo15 anexo = new reports.entidades.Anexo15()
                        {
                            nombre_fallecido=entity.nombre_fallecido,
                            m=entity.m,
                            f=entity.f,
                            primer_apellido_fallecido=entity.primer_apellido_fallecido,
                            segundo_apellido_fallecido=entity.segundo_apellido_fallecido,
                            hora_fallecido=entity.hora_fallecido,
                            dia_fecha_fallecimineto=entity.fecha_fallecimineto.Split('-')[2],
                            mes_fecha_fallecimineto=entity.fecha_fallecimineto.Split('-')[1],
                            anno_fecha_fallecimineto=entity.fecha_fallecimineto.Split('-')[0],
                            lugar_nacimineto_fallecido=entity.lugar_nacimineto_fallecido,
                            municipio_provincia_pais_fallecido=entity.municipio_provincia_pais_fallecido,
                            dia_fecha_nacimiento=entity.fecha_nacimiento.Split('-')[2],
                            mes_fecha_nacimiento=entity.fecha_nacimiento.Split('-')[1],
                            anno_fecha_nacimiento=entity.fecha_nacimiento.Split('-')[0],
                            pasaporte_fallecido=entity.pasaporte_fallecido,
                            edad_fallecido=entity.edad_fallecido,
                            registro_civil_fallecido=entity.registro_civil_fallecido,
                            tomo_fallecido=entity.tomo_fallecido,
                            folio_fallecido=entity.folio_fallecido,
                            estado_civil_fallecido=entity.estado_civil_fallecido,
                            ocupacion_fallecido=entity.ocupacion_fallecido,
                            padre_fallecido=entity.padre_fallecido,
                            madre_fallecido=entity.madre_fallecido,
                            domicilio_fallecido=entity.domicilio_fallecido,
                            dia_fecha_defuncion=entity.fecha_defuncion.Split('-')[2],
                            mes_fecha_defuncion=entity.fecha_defuncion.Split('-')[1],
                            anno_fecha_defuncion=entity.fecha_defuncion.Split('-')[0],
                            hora_defuncion=entity.hora_defuncion,
                            lugar_fallecimiento=entity.lugar_fallecimiento,
                            causa_muerte_fallecimiento=entity.causa_muerte_fallecimiento,
                            enfermedad_causa_fallecimiento=entity.enfermedad_causa_fallecimiento,
                            nombre_medico_certifica_fallecimiento=entity.nombre_medico_certifica_fallecimiento,
                            lugar_cepultura=entity.lugar_cepultura,
                            registro_civil=entity.registro_civil,
                            tomo=entity.tomo,
                            folio=entity.folio,
                            dia_fecha_certificado=entity.fecha_certificado.Split('-')[2],
                            mes_fecha_certificado=entity.fecha_certificado.Split('-')[1],
                            anno_fecha_certificado=entity.fecha_certificado.Split('-')[0],
                            nombre_apellido_solicita=entity.nombre_apellido_solicita,
                            nro_pasaporte_carnet=entity.nro_pasaporte_carnet,
                            parentesco_fallecido=entity.parentesco_fallecido,
                            direccion_solicita=entity.direccion_solicita,
                            nombre_apellido_funcionario_consular=entity.nombre_apellido_funcionario_consular
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
