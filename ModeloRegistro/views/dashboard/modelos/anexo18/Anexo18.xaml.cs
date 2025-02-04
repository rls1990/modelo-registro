using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo18
{
    /// <summary>
    /// Interaction logic for Anexo18.xaml
    /// </summary>
    public partial class Anexo18:Page
    {
        private model.Anexo18_m manager = new model.Anexo18_m(Global.sqlite);
        public List<model.Anexo18_e> lista { get; set; }
        public Anexo18()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo18_e>();
            else
                lista.Clear();

            List<model.Anexo18_e> lm = manager.list();
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
                    model.Anexo18_e entity = (model.Anexo18_e)listadg.SelectedItem;
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
                        string fileName = "anexo_18._modelo_no_2._solicitud_de_la_adquisicion_de_la_ciudadania_cubana_por_nacimiento._menores_de_edad_o_inc.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo18_e entity = (model.Anexo18_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo18 anexo = new reports.entidades.Anexo18()
                        {
                            nombre_hombre=entity.nombre_hombre,
                            nombre_mujer=entity.nombre_mujer,
                            ciudadania_hombre=entity.ciudadania_hombre,
                            ciudadania_mujer=entity.ciudadania_mujer,
                            lugar_nacimiento_hombre=entity.lugar_nacimiento_hombre,
                            lugar_nacimiento_mujer=entity.lugar_nacimiento_mujer,
                            fecha_nacimiento_hombre=entity.fecha_nacimiento_hombre,
                            fecha_nacimiento_mujer=entity.fecha_nacimiento_mujer,
                            pasaporte_hombre=entity.pasaporte_hombre,
                            pasaporte_mujer=entity.pasaporte_mujer,
                            nombre_hijo_menor=entity.nombre_hijo_menor,
                            ciudadania_hijo_menor=entity.ciudadania_hijo_menor,
                            ciudadania_hijo_menor_no=entity.ciudadania_hijo_menor, // Asumiendo que es el mismo valor
                            lugar_nacimineto_hijo_menor=entity.lugar_nacimineto_hijo_menor,
                            fecha_nacimiento_hijo_menor=entity.fecha_nacimiento_hijo_menor,
                            pasaporte_hijo_menor=entity.pasaporte_hijo_menor,
                            padre=entity.padre,
                            ciudadania_padre=entity.ciudadania_padre,
                            madre=entity.madre,
                            ciudadania_madre=entity.ciudadania_madre,
                            ultima_direccion_cuba=entity.ultima_direccion_cuba,
                            nombre_hijo_menor_1=entity.nombre_hijo_menor, // Asumiendo que es el mismo valor
                            recidir_cuba=entity.recidir_cuba,
                            recidir_en_exterior=entity.recidir_en_exterior,
                            razones_personales=entity.razones_personales,
                            nombre_hombre_1=entity.nombre_hombre, // Asumiendo que es el mismo valor
                            nombre_mujer_1=entity.nombre_mujer, // Asumiendo que es el mismo valor
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
