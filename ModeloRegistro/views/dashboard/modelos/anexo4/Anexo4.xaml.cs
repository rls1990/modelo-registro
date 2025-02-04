using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo4
{
    /// <summary>
    /// Interaction logic for Anexo4.xaml
    /// </summary>
    public partial class Anexo4:Page
    {
        private model.Anexo4_m manager = new model.Anexo4_m(Global.sqlite);
        public List<model.Anexo4_e> lista { get; set; }
        public Anexo4()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo4_e>();
            else
                lista.Clear();

            List<model.Anexo4_e> lm = manager.list();
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
                    model.Anexo4_e entity = (model.Anexo4_e)listadg.SelectedItem;
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
                        string fileName = "anexo_4._certificacion_de_antecedentes_penales_0.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo4_e entity = (model.Anexo4_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo4 anexo = new reports.entidades.Anexo4()
                        {
                            ciudad=entity.ciudad,
                            pais=entity.pais,
                            f_name=entity.f_name,
                            s_name=entity.s_name,
                            f_apellido=entity.f_apellido,
                            s_apellido=entity.s_apellido,
                            lugar_nacimiento=entity.lugar_nacimiento,
                            ciudadania=entity.ciudadania,
                            fecha_nacimiento=entity.fecha_nacimiento,
                            nacionalidad=entity.nacionalidad,
                            sexo=entity.sexo,
                            estado_civil=entity.estado_civil,
                            color_piel=entity.color_piel,
                            profecion_oficio_ocupacion=entity.profecion_oficio_ocupacion,
                            nombre_padre=entity.nombre_padre,
                            nombre_madre=entity.nombre_madre,
                            carnet_identidad=entity.carnet_identidad,
                            pasaporte=entity.pasaporte,
                            calle=entity.calle,
                            numero=entity.numero,
                            entre=entity.entre,
                            y=entity.y,
                            barrio=entity.barrio,
                            municipio=entity.municipio,
                            provincia=entity.provincia,
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
