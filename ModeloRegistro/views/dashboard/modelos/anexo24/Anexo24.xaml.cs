using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo24
{
    /// <summary>
    /// Interaction logic for Anexo24.xaml
    /// </summary>
    public partial class Anexo24:Page
    {
        private model.Anexo24_m manager = new model.Anexo24_m(Global.sqlite);
        public List<model.Anexo24_e> lista { get; set; }
        public Anexo24()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo24_e>();
            else
                lista.Clear();

            List<model.Anexo24_e> lm = manager.list();
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
                    model.Anexo24_e entity = (model.Anexo24_e)listadg.SelectedItem;
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
                        string fileName = "anexo_24._modelo_de_solicitud_poder_especial_para_compra_venta_de_autos.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo24_e entity = (model.Anexo24_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo24 anexo = new reports.entidades.Anexo24()
                        {
                            dia_fecha_solicitud=entity.fecha_solicitud.Split('-')[2],
                            mes_fecha_solicitud=entity.fecha_solicitud.Split('-')[1],
                            anno_fecha_solicitud=entity.fecha_solicitud.Split('-')[0],
                            nombre=entity.nombre,
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
                            nombre_padres_apoderado=entity.nombre_padres_apoderado,
                            condicion_migratoria_apoderado=entity.condicion_migratoria_apoderado,
                            marca=entity.marca,
                            modelo=entity.modelo,
                            anno=entity.anno,
                            color=entity.color,
                            nro_motor=entity.nro_motor,
                            nro_chasis=entity.nro_chasis,
                            matricula=entity.matricula
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
