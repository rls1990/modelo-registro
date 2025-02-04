using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo10
{
    /// <summary>
    /// Interaction logic for Anexo10.xaml
    /// </summary>
    public partial class Anexo10:Page
    {
        private model.Anexo10_m manager = new model.Anexo10_m(Global.sqlite);
        public List<model.Anexo10_e> lista { get; set; }
        public Anexo10()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo10_e>();
            else
                lista.Clear();

            List<model.Anexo10_e> lm = manager.list();
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
                    model.Anexo10_e entity = (model.Anexo10_e)listadg.SelectedItem;
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
                        string fileName = "anexo_10._certificacion_de_ciudadania_o_su_negativo.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo10_e entity = (model.Anexo10_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo10 anexo = new reports.entidades.Anexo10()
                        {
                            ciudad=entity.ciudad,
                            pais=entity.pais,
                            solicito_certificado=entity.solicito_certificado,
                            de_mi=entity.de_mi,
                            nombre_apellidos=entity.nombre_apellidos,
                            fecha_nacimiento=entity.fecha_nacimiento,
                            lugar_nacimiento=entity.lugar_nacimiento,
                            nombre_padres=entity.nombre_padres,
                            lugar_vivio_cuba=entity.lugar_vivio_cuba,
                            fecha_fallecimiento=entity.fecha_fallecimiento,
                            otros_datos_interes=entity.otros_datos_interes,
                            nombre_apellidos_solicitante=entity.nombre_apellidos_solicitante,
                            doc_identidad=entity.doc_identidad,
                            pasaporte=entity.pasaporte,
                            direccion=entity.direccion,
                            telefono=entity.telefono,
                            email=entity.email,
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

        private void buscar_KeyUp( object sender,System.Windows.Input.KeyEventArgs e )
        {
            string searchText = buscar.Text;
            if(searchText.Length>0)
            {
                var listaF=lista.FindAll(( item ) => item.ContieneTexto(searchText));
                listadg.ItemsSource=listaF;
            } else listadg.ItemsSource=lista;
        }
    }
}
