using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo29
{
    /// <summary>
    /// Interaction logic for Anexo29.xaml
    /// </summary>
    public partial class Anexo29:Page
    {
        private model.Anexo29_m manager = new model.Anexo29_m(Global.sqlite);
        public List<model.Anexo29_e> lista { get; set; }
        public Anexo29()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo29_e>();
            else
                lista.Clear();

            List<model.Anexo29_e> lm = manager.list();
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
                    model.Anexo29_e entity = (model.Anexo29_e)listadg.SelectedItem;
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
                        string fileName = "anexo_29._modelo_de_solicitud_poder_especial_para_escritura_de_autorizacion.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo29_e entity = (model.Anexo29_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo29 anexo = new reports.entidades.Anexo29()
                        {
                            dia_fecha_solicitud=entity.fecha_solicitud.Split('-')[2],
                            mes_fecha_solicitud=entity.fecha_solicitud.Split('-')[1],
                            anno_fecha_solicitud=entity.fecha_solicitud.Split('-')[0],
                            nombre=entity.nombre,
                            sexo=entity.sexo,
                            lugar_nacimineto_municipio=entity.lugar_nacimineto_municipio,
                            lugar_nacimineto_provincia=entity.lugar_nacimineto_provincia,
                            dia_fecha_nacimineto=entity.fecha_nacimineto.Split('-')[2],
                            mes_fecha_nacimineto=entity.fecha_nacimineto.Split('-')[1],
                            anno_fecha_nacimineto=entity.fecha_nacimineto.Split('-')[0],
                            estado_civil=entity.estado_civil,
                            ciudadania=entity.ciudadania,
                            ocupacion=entity.ocupacion,
                            direccion=entity.direccion,
                            carnet_pasaporte=entity.carnet_pasaporte,
                            condicion_migratoria=entity.condicion_migratoria,
                            correo=entity.correo,
                            celular=entity.celular,
                            nombre_apoderado=entity.nombre_apoderado,
                            sexo_apoderado=entity.sexo_apoderado,
                            lugar_nacimineto_municipio_apoderado=entity.lugar_nacimineto_municipio_apoderado,
                            lugar_nacimineto_provincia_apoderado=entity.lugar_nacimineto_provincia_apoderado,
                            dia_fecha_nacimineto_apoderado=entity.fecha_nacimineto_apoderado.Split('-')[2],
                            mes_fecha_nacimineto_apoderado=entity.fecha_nacimineto_apoderado.Split('-')[1],
                            anno_fecha_nacimineto_apoderado=entity.fecha_nacimineto_apoderado.Split('-')[0],
                            estado_civil_apoderado=entity.estado_civil_apoderado,
                            ciudadania_apoderado=entity.ciudadania_apoderado,
                            ocupacion_apoderado=entity.ocupacion_apoderado,
                            direccion_apoderado=entity.direccion_apoderado,
                            carnet_pasaporte_apoderado=entity.carnet_pasaporte_apoderado,
                            condicion_migratoria_apoderado=entity.condicion_migratoria_apoderado,
                            nombre_menor=entity.nombre_menor,
                            natural_de=entity.natural_de,
                            fecha_nacimineto_menor=entity.fecha_nacimineto_menor,
                            edad=entity.edad,
                            tomo=entity.tomo,
                            folio=entity.folio,
                            registro_estado_civil=entity.registro_estado_civil,
                            tipo_tramites=entity.tipo_tramites
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
