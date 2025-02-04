using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo19
{
    /// <summary>
    /// Interaction logic for Anexo19.xaml
    /// </summary>
    public partial class Anexo19:Page
    {
        private model.Anexo19_m manager = new model.Anexo19_m(Global.sqlite);
        public List<model.Anexo19_e> lista { get; set; }
        public Anexo19()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo19_e>();
            else
                lista.Clear();

            List<model.Anexo19_e> lm = manager.list();
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
                    model.Anexo19_e entity = (model.Anexo19_e)listadg.SelectedItem;
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
                        string fileName = "anexo_19._modelo_no_3._solicitud_de_la_adquisicion_de_la_ciudadania_cubana_por_nacimiento._menores_de_edad._cuan.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo19_e entity = (model.Anexo19_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo19 anexo = new reports.entidades.Anexo19()
                        {
                            nombre_apellidos=entity.nombre_apellidos,
                            ciudadano=entity.ciudadano,
                            lugar_nacimiento=entity.lugar_nacimiento,
                            fecha_nacimiento=entity.fecha_nacimiento,
                            pasaporte=entity.pasaporte,
                            nombre_menor=entity.nombre_menor,
                            ciudadania_menor=entity.ciudadania_menor,
                            ciudadania_menor_no=entity.ciudadania_menor=="True" ? "✔" : "", // Asumiendo que "No" es falso
                            lugar_nacimineto_menor=entity.lugar_nacimineto_menor,
                            fecha_nacimiento_menor=entity.fecha_nacimiento_menor,
                            pasaporte_menor=entity.pasaporte_menor,
                            ultima_direccion_pedres=entity.ultima_direccion_pedres,
                            recidir_cuba=entity.recidir_cuba=="True" ? "✔" : "", // Asumiendo que "Sí" es verdadero
                            recidir_en_exterior=entity.recidir_en_exterior=="True" ? "✔" : "", // Asumiendo que "Sí" es verdadero
                            razones_personales=entity.razones_personales,
                            nombre_apellidos_1=entity.nombre_apellidos, // Asumiendo que es el mismo valor
                            nombre_funcionario=entity.nombre_funcionario,
                            telefono=entity.telefono,
                            email=entity.email
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
