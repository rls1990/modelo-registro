using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo13
{
    /// <summary>
    /// Interaction logic for Anexo13.xaml
    /// </summary>
    public partial class Anexo13:Page
    {
        private model.Anexo13_m manager = new model.Anexo13_m(Global.sqlite);
        public List<model.Anexo13_e> lista { get; set; }
        public Anexo13()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo13_e>();
            else
                lista.Clear();

            List<model.Anexo13_e> lm = manager.list();
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
                    model.Anexo13_e entity = (model.Anexo13_e)listadg.SelectedItem;
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
                        string fileName = "anexo_13._modelo_9-30_modificado._solicitud_de_transcripcion_de_nacimiento.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo13_e entity = (model.Anexo13_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo13 anexo = new reports.entidades.Anexo13()
                        {
                            dia_fecha_solicitud=entity.fecha_solicitud.Split('-')[2],
                            mes_fecha_solicitud=entity.fecha_solicitud.Split('-')[1],
                            anno_fecha_solicitud=entity.fecha_solicitud.Split('-')[0],
                            nombre_comparece=entity.nombre_comparece,
                            no_pasaporte_comparece=entity.no_pasaporte_comparece,
                            nombre_inscripcion=entity.nombre_inscripcion,
                            m=entity.m=="True" ? "✔" : "",
                            f=entity.f=="True" ? "✔" : "",
                            primer_apellido_inscripcion=entity.primer_apellido_inscripcion,
                            segundo_apellido_inscripcion=entity.segundo_apellido_inscripcion,
                            hora_nacimiento=entity.hora_nacimiento,
                            dia_fecha_nacimineto=entity.fecha_nacimineto.Split('-')[2],
                            mes_fecha_nacimineto=entity.fecha_nacimineto.Split('-')[1],
                            anno_fecha_nacimineto=entity.fecha_nacimineto.Split('-')[0],
                            referencia_territorio_registro_civil=entity.referencia_territorio_registro_civil,
                            tomo_referencia_registral=entity.tomo_referencia_registral,
                            folio_referencia_registral=entity.folio_referencia_registral,
                            nro_asiento=entity.nro_asiento,
                            lugar_nacimineto=entity.lugar_nacimineto,
                            nombre_padre=entity.nombre_padre,
                            primer_apellido_padre=entity.primer_apellido_padre,
                            segundo_apellido_padre=entity.segundo_apellido_padre,
                            ciudadania_padre=entity.ciudadania_padre,
                            natural_de_padre=entity.natural_de_padre,
                            nro_pasaporte_padre=entity.nro_pasaporte_padre,
                            domicilio_padre=entity.domicilio_padre,
                            nombre_madre=entity.nombre_madre,
                            primer_apellido_madre=entity.primer_apellido_madre,
                            segundo_apellido_madre=entity.segundo_apellido_madre,
                            ciudadania_madre=entity.ciudadania_madre,
                            natural_de_madre=entity.natural_de_madre,
                            nro_pasaporte_madre=entity.nro_pasaporte_madre,
                            domicilio_madre=entity.domicilio_madre,
                            nombre_abuelo_paterno=entity.nombre_abuelo_paterno,
                            nombre_abuela_paterna=entity.nombre_abuela_paterna,
                            nombre_abuelo_materno=entity.nombre_abuelo_materno,
                            nombre_abuela_materna=entity.nombre_abuela_materna,
                            nombre_apellido_soltera_madre=entity.nombre_apellido_soltera_madre,
                            nombre_inscrito_pais_nacimineto=entity.nombre_inscrito_pais_nacimineto,
                            inscripcion_practicada_en_virtud_de=entity.inscripcion_practicada_en_virtud_de,
                            observaciones=entity.observaciones
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
