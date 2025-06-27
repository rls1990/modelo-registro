using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo31
{
    /// <summary>
    /// Interaction logic for Anexo31.xaml
    /// </summary>
    public partial class Anexo31:Page
    {
        private model.Anexo31_m manager = new model.Anexo31_m(Global.sqlite);
        public List<model.Anexo31_e> lista { get; set; }
        public Anexo31()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo31_e>();
            else
                lista.Clear();

            List<model.Anexo31_e> lm = manager.list();
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
                    model.Anexo31_e entity = (model.Anexo31_e)listadg.SelectedItem;
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
                        string fileName = "anexo_31._modelo_de_solicitud_poder_especial.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo31_e entity = (model.Anexo31_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo31 anexo = new reports.entidades.Anexo31()
                        {
                            dia_fecha_solicitud=ValidarCampo(entity.fecha_solicitud)?entity.fecha_solicitud.Split('-')[2]:"",
                            mes_fecha_solicitud=ValidarCampo(entity.fecha_solicitud) ? entity.fecha_solicitud.Split('-')[1]:"",
                            anno_fecha_solicitud=ValidarCampo(entity.fecha_solicitud) ? entity.fecha_solicitud.Split('-')[0]:"",
                            nombre_poderante=entity.nombre_poderante,
                            lugar_nacimiento_municipio_poderante=entity.lugar_nacimiento_municipio_poderante,
                            lugar_nacimiento_provincia_poderante=entity.lugar_nacimiento_provincia_poderante,
                            dia_fecha_nacimineto_poderante=ValidarCampo(entity.fecha_nacimineto_poderante) ? entity.fecha_nacimineto_poderante.Split('-')[2]:"",
                            mes_fecha_nacimineto_poderante=ValidarCampo(entity.fecha_nacimineto_poderante) ? entity.fecha_nacimineto_poderante.Split('-')[1]:"",
                            anno_fecha_nacimineto_poderante=ValidarCampo(entity.fecha_nacimineto_poderante) ? entity.fecha_nacimineto_poderante.Split('-')[0]:"",
                            registro_estado_civil_poderante=entity.registro_estado_civil_poderante,
                            tomo_poderante=entity.tomo_poderante,
                            folio_poderante=entity.folio_poderante,
                            estado_civil_poderante=entity.estado_civil_poderante,
                            ciudadania_poderante=entity.ciudadania_poderante,
                            ocupacion_poderante=entity.ocupacion_poderante,
                            direccion_particular_poderante=entity.direccion_particular_poderante,
                            carne_pasaporte_poderante=entity.carne_pasaporte_poderante,
                            nombre_apellido_padres_poderante=entity.nombre_apellido_padres_poderante,
                            condicion_migratoria_poderante=entity.condicion_migratoria_poderante,
                            correo_poderante=entity.correo_poderante,
                            celular_poderante=entity.celular_poderante,
                            nombre_apoderado=entity.nombre_apoderado,
                            lugar_nacimineto_municipio_apoderado=entity.lugar_nacimiento_municipio_apoderado,
                            lugar_nacimineto_provincia_apoderado=entity.lugar_nacimiento_provincia_apoderado,
                            dia_fecha_nacimineto_apoderado=ValidarCampo(entity.fecha_nacimineto_apoderado) ? entity.fecha_nacimineto_apoderado.Split('-')[2]:"",
                            mes_fecha_nacimineto_apoderado=ValidarCampo(entity.fecha_nacimineto_apoderado) ? entity.fecha_nacimineto_apoderado.Split('-')[1]:"",
                            anno_fecha_nacimineto_apoderado=ValidarCampo(entity.fecha_nacimineto_apoderado) ? entity.fecha_nacimineto_apoderado.Split('-')[0]:"",
                            registro_estado_civil_apoderado=entity.registro_estado_civil_apoderado,
                            tomo_apoderado=entity.tomo_apoderado,
                            folio_apoderado=entity.folio_apoderado,
                            estado_civil_apoderado=entity.estado_civil_apoderado,
                            ciudadania_apoderado=entity.ciudadania_apoderado,
                            ocupacion_apoderado=entity.ocupacion_apoderado,
                            direccion_particular_apoderado=entity.direccion_particular_apoderado,
                            carne_pasaporte_apoderado=entity.carne_pasaporte_apoderado,
                            nombre_apellido_padres_apoderado=entity.nombre_apellido_padres_apoderado,
                            condicion_migratoria_apoderado=entity.condicion_migratoria_apoderado,
                            clausula=entity.clausula
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
