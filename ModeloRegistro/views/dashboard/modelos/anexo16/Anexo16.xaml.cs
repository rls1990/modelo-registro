using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo16
{
    /// <summary>
    /// Interaction logic for Anexo16.xaml
    /// </summary>
    public partial class Anexo16:Page
    {
        private model.Anexo16_m manager = new model.Anexo16_m(Global.sqlite);
        public List<model.Anexo16_e> lista { get; set; }
        public Anexo16()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo16_e>();
            else
                lista.Clear();

            List<model.Anexo16_e> lm = manager.list();
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
                    model.Anexo16_e entity = (model.Anexo16_e)listadg.SelectedItem;
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
                        string fileName = "República de Cuba - anexo_16._modelo_de_solicitud_de_visas.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo16_e entity = (model.Anexo16_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo3_e
                        reports.entidades.Anexo16 anexo = new reports.entidades.Anexo16()
                        {
                            tirista=entity.tirista=="True" ? "✔" : "",
                            transeuntes=entity.transeuntes=="True" ? "✔" : "",
                            eventos=entity.eventos=="True" ? "✔" : "",
                            invitados=entity.invitados=="True" ? "✔" : "",
                            estudiantes_programas_becas=entity.estudiantes_programas_becas=="True" ? "✔" : "",
                            artistas=entity.artistas=="True" ? "✔" : "",
                            periodistas=entity.periodistas=="True" ? "✔" : "",
                            religiosos=entity.religiosos=="True" ? "✔" : "",
                            diplomaticas=entity.diplomaticas=="True" ? "✔" : "",
                            tecnicos=entity.tecnicos=="True" ? "✔" : "",
                            deportistas=entity.deportistas=="True" ? "✔" : "",
                            negocios=entity.negocios=="True" ? "✔" : "",
                            otras=entity.otras=="True" ? "✔" : "",
                            dia_fecha_solicitud=ValidarCampo(entity.fecha_solicitud)?entity.fecha_solicitud?.Split('-')[2]:"", // Asumiendo que fecha_solicitud es un string en formato "dd/MM/yyyy"
                            mes_fecha_solicitud=ValidarCampo(entity.fecha_solicitud) ? entity.fecha_solicitud?.Split('-')[1]:"",
                            anno_fecha_solicitud=ValidarCampo(entity.fecha_solicitud) ? entity.fecha_solicitud?.Split('-')[0]:"",
                            pasaporte=entity.pasaporte,
                            lugar_expedicion=entity.lugar_expedicion,
                            fecha_expedicion=entity.fecha_expedicion,
                            primer_apellido=entity.primer_apellido,
                            segundo_apellido=entity.segundo_apellido,
                            primer_nombre=entity.primer_nombre,
                            segundo_nombre=entity.segundo_nombre,
                            padre=entity.padre,
                            madre=entity.madre,
                            lugar_nacimiento_padres=entity.lugar_nacimiento_padres,
                            estatura=entity.estatura,
                            estado_civil=entity.estado_civil,
                            m=entity.m=="True" ? "✔" : "",
                            f=entity.f=="True" ? "✔" : "",
                            blue_green_claros=entity.blue_green_claros=="True" ? "✔" : "",
                            black_negros=entity.black_negros=="True" ? "✔" : "",
                            pardos=entity.pardos=="True" ? "✔" : "",
                            piel_blanca=entity.piel_blanca=="True" ? "✔" : "",
                            piel_negra=entity.piel_negra=="True" ? "✔" : "",
                            piel_albina=entity.piel_albina=="True" ? "✔" : "",
                            piel_amarilla=entity.piel_amarilla=="True" ? "✔" : "",
                            pelo_canoso=entity.pelo_canoso=="True" ? "✔" : "",
                            pelo_negro=entity.pelo_negro=="True" ? "✔" : "",
                            pelo_rubio=entity.pelo_rubio=="True" ? "✔" : "",
                            pelo_castano=entity.pelo_castaño=="True" ? "✔" : "",
                            pelo_rojo=entity.pelo_rojo=="True" ? "✔" : "",
                            pelo_otro=entity.pelo_otro=="True" ? "✔" : "",
                            pais=entity.pais,
                            provincia=entity.provincia,
                            ciudad_municipio=entity.ciudad_municipio,
                            dia_fecha_nacimiento=ValidarCampo(entity.fecha_nacimiento) ? entity.fecha_nacimiento?.Split('-')[2]:"", // Asumiendo que fecha_nacimiento es un string en formato "dd/MM/yyyy"
                            mes_fecha_nacimiento=ValidarCampo(entity.fecha_nacimiento) ? entity.fecha_nacimiento?.Split('-')[1]:"",
                            anno_fecha_nacimiento=ValidarCampo(entity.fecha_nacimiento) ? entity.fecha_nacimiento?.Split('-')[0]:"",
                            direccion=entity.direccion,
                            codigo_postal=entity.codigo_postal,
                            provincia_estado_region=entity.provincia_estado_region,
                            pais_residencia_actual=entity.pais_residencia_actual,
                            telefono=entity.telefono,
                            fax=entity.fax,
                            email=entity.email,
                            nombre_centro_trabajo_estudio=entity.nombre_centro_trabajo_estudio,
                            profecion=entity.profecion,
                            ocupacion=entity.ocupacion,
                            direccion_centro=entity.direccion_centro,
                            codigo_postal_centro=entity.codigo_postal_centro,
                            provincia_estado_region_centro=entity.provincia_estado_region_centro,
                            pais_centro=entity.pais_centro,
                            telefono_centro=entity.telefono_centro,
                            fax_centro=entity.fax_centro,
                            email_centro=entity.email_centro,
                            direccion_estancia_cuba=entity.direccion_estancia_cuba,
                            nombre_apellido_persona_a_vicitar_cuba=entity.nombre_apellido_persona_a_vicitar_cuba,
                            motivo_viaje_cuba=entity.motivo_viaje_cuba,
                            tiempo_estancia=entity.tiempo_estancia,
                            lugar_fecha_salida_cuba=entity.lugar_fecha_salida_cuba,
                            lugar_fecha_llegada_cuba=entity.lugar_fecha_llegada_cuba,
                            proposito_viaje_cuba=entity.proposito_viaje_cuba
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
