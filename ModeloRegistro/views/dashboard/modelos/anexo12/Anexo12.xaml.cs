using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo12
{
    /// <summary>
    /// Interaction logic for Anexo12.xaml
    /// </summary>
    public partial class Anexo12:Page
    {
        private model.Anexo12_m manager = new model.Anexo12_m(Global.sqlite);
        public List<model.Anexo12_e> lista { get; set; }
        public Anexo12()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo12_e>();
            else
                lista.Clear();

            List<model.Anexo12_e> lm = manager.list();
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
                    model.Anexo12_e entity = (model.Anexo12_e)listadg.SelectedItem;
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
                        string fileName = "anexo_12._certificado_de_capacidad_legal_para_el_matrimonio.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo12_e entity = (model.Anexo12_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo12 anexo = new reports.entidades.Anexo12()
                        {
                            ciudad=entity.ciudad,
                            pais=entity.pais,
                            nombre_apellidos=entity.nombre_apellidos,
                            ciudadano=entity.ciudadano,
                            carnet_identidad=entity.carnet_identidad,
                            dia_fecha_nacimiento=entity.fecha_nacimiento.Split('-')[2],
                            mes_fecha_nacimiento=entity.fecha_nacimiento.Split('-')[1],
                            anno_fecha_nacimiento=entity.fecha_nacimiento.Split('-')[0],
                            provincia_lugar_nacimineto=entity.provincia_lugar_nacimineto,
                            municipio_lugar_nacimineto=entity.municipio_lugar_nacimineto,
                            provincia_registro_civil=entity.provincia_registro_civil,
                            municipio_registro_civil=entity.municipio_registro_civil,
                            vecino_de=entity.vecino_de,
                            nombre_apellido_apoderado=entity.nombre_apellido_apoderado,
                            si=entity.si,
                            no=entity.no,
                            numero=entity.numero,
                            fecha_poder_especial=entity.fecha_poder_especial,
                            nombre_apellido_notario=entity.nombre_apellido_notario,
                            competencia=entity.competencia,
                            sede=entity.sede,
                            legalizacion_minred=entity.legalizacion_minrex, // Nota: Ajuste de nombre de propiedad
                            legalizacion_embajada=entity.legalizacion_embajada
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
