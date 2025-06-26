using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo21
{
    /// <summary>
    /// Interaction logic for Anexo21.xaml
    /// </summary>
    public partial class Anexo21:Page
    {
        private model.Anexo21_m manager = new model.Anexo21_m(Global.sqlite);
        public List<model.Anexo21_e> lista { get; set; }
        public Anexo21()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo21_e>();
            else
                lista.Clear();

            List<model.Anexo21_e> lm = manager.list();
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
                    model.Anexo21_e entity = (model.Anexo21_e)listadg.SelectedItem;
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
                        string fileName = "anexo_21._modelo_de_solicitud_autorizo_de_pasaporte_y_salida_del_menor.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo21_e entity = (model.Anexo21_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo21 anexo = new reports.entidades.Anexo21()
                        {
                            dia_fecha_solicitud=ValidarCampo(entity.fecha_solicitud)?entity.fecha_solicitud.Split('-')[2]:"",
                            mes_fecha_solicitud=ValidarCampo(entity.fecha_solicitud) ? entity.fecha_solicitud.Split('-')[1]:"",
                            anno_fecha_solicitud=ValidarCampo(entity.fecha_solicitud) ? entity.fecha_solicitud.Split('-')[0]:"",
                            nombre_padre=entity.nombre_padre,
                            ciudadania_padre=entity.ciudadania_padre,
                            estado_civil_padre=entity.estado_civil_padre,
                            minicipio_nacimineto_padre=entity.minicipio_nacimineto_padre,
                            provincia_nacimineto_padre=entity.provincia_nacimineto_padre,
                            dia_fecha_nacimiento_padre=ValidarCampo(entity.fecha_nacimiento_padre) ? entity.fecha_nacimiento_padre.Split('-')[2]:"",
                            mes_fecha_nacimiento_padre=ValidarCampo(entity.fecha_nacimiento_padre) ? entity.fecha_nacimiento_padre.Split('-')[1]:"",
                            anno_fecha_nacimiento_padre=ValidarCampo(entity.fecha_nacimiento_padre) ? entity.fecha_nacimiento_padre.Split('-')[0]:"",
                            profecion_padre=entity.profecion_padre,
                            carnet_pasaporte_padre=entity.carnet_pasaporte_padre,
                            categoria_migratoria_padre=entity.categoria_migratoria_padre,
                            direccion_eu_padre=entity.direccion_eu_padre,
                            correo=entity.correo,
                            celular=entity.celular,
                            nombre_menor=entity.nombre_menor,
                            municipio_nacimiento_menor=entity.municipio_nacimiento_menor,
                            provincia_nacimiento_menor=entity.provincia_nacimiento_menor,
                            dia_fecha_nacimiento_menor=ValidarCampo(entity.fecha_nacimiento_menor) ? entity.fecha_nacimiento_menor.Split('-')[2]:"",
                            mes_fecha_nacimiento_menor=ValidarCampo(entity.fecha_nacimiento_menor) ? entity.fecha_nacimiento_menor.Split('-')[1]:"",
                            anno_fecha_nacimiento_menor=ValidarCampo(entity.fecha_nacimiento_menor) ? entity.fecha_nacimiento_menor.Split('-')[0]:"",
                            registro_estado_nacimiento_menor=entity.registro_estado_nacimiento_menor,
                            tomo=entity.tomo,
                            folio=entity.folio,
                            tarjeta_menor=entity.tarjeta_menor,
                            direccion_menor_cuba=entity.direccion_menor_cuba
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
