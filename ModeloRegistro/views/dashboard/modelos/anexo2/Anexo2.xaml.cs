using Microsoft.WindowsAPICodePack.Dialogs;
using ModeloRegistro.services;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo2
{
    /// <summary>
    /// Interaction logic for Anexo2.xaml
    /// </summary>
    public partial class Anexo2:Page
    {
        private model.Anexo2_m manager = new model.Anexo2_m(Global.sqlite);
        public List<model.Anexo2_e> lista { get; set; }
        public Anexo2()
        {
            InitializeComponent();
            InitList();
            DataContext=this;
        }

        public void InitList()
        {
            if(lista==null)
                lista=new List<model.Anexo2_e>();
            else
                lista.Clear();

            List<model.Anexo2_e> lm = manager.list();
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
                    model.Anexo2_e entity = (model.Anexo2_e)listadg.SelectedItem;
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
                        string fileName = "República de Cuba - anexo_2._planilla_para_tramites_consulares_0.html";
                        string outputFileName = dialog.FileName;

                        System.Console.WriteLine(outputFileName);

                        var html = Util.LoadHtmlReport(fileName);

                        // Supongamos que ya tienes una instancia de Anexo3_e seleccionada
                        model.Anexo2_e entity = (model.Anexo2_e)listadg.SelectedItem;

                        // Inicializa una nueva instancia de Anexo3 con los valores de Anexo
                        reports.entidades.Anexo2 anexo = new reports.entidades.Anexo2()
                        {
                            pasaporte_1ra_vez=entity.pasaporte_1ra_vez=="True" ? "✔" : "",
                            prorrogas=entity.prorrogas=="True" ? "✔" : "",
                            he_1=entity.he_1=="True" ? "✔" : "",
                            he_4=entity.he_4=="True" ? "✔" : "",
                            dvt=entity.dvt=="True" ? "✔" : "",
                            renovacion_pasaporte=entity.renovacion_pasaporte=="True" ? "✔" : "",
                            habilitacion_de_entrada=entity.habilitacion_de_entrada=="True" ? "✔" : "",
                            he_3=entity.he_3=="True" ? "✔" : "",
                            he_11=entity.he_11=="True" ? "✔" : "",
                            ccv=entity.ccv=="True" ? "✔" : "",
                            dia_fecha_de_solicitud=entity.fecha_de_solicitud?.Split('-')[2], // Asumiendo que fecha_de_solicitud es un string en formato "dd/MM/yyyy"
                            mes_fecha_de_solicitud=entity.fecha_de_solicitud?.Split('-')[1],
                            anno_fecha_de_solicitud=entity.fecha_de_solicitud?.Split('-')[0],
                            no_pasaporte=entity.no_pasaporte,
                            carnet=entity.carnet,
                            primer_apellido=entity.primer_apellido,
                            segundo_apellido=entity.segundo_apellido,
                            primer_nombre=entity.primer_nombre,
                            segundo_nombre=entity.segundo_nombre,
                            padre=entity.padre,
                            madre=entity.madre,
                            caracteristicas_especiales=entity.caracteristicas_especiales,
                            estatura=entity.estatura,
                            estado_civil=entity.estado_civil,
                            sexo_m=entity.sexo=="Masculino" ? "✔" : "",
                            sexo_f=entity.sexo=="Femenino" ? "✔" : "",
                            color_ojos_claros=entity.color_ojos=="Claros" ? "✔" : "",
                            color_ojos_negros=entity.color_ojos=="Negros" ? "✔" : "",
                            color_ojos_pardos=entity.color_ojos=="Pardos" ? "✔" : "",
                            color_piel_blanca=entity.color_piel=="Blanca" ? "✔" : "",
                            color_piel_negra=entity.color_piel=="Negra" ? "✔" : "",
                            color_piel_amarilla=entity.color_piel=="Amarilla" ? "✔" : "",
                            color_piel_mestiza=entity.color_piel=="Mestiza" ? "✔" : "",
                            color_piel_albina=entity.color_piel=="Albina" ? "✔" : "",
                            color_cabello_canoso=entity.color_cabello=="Canoso" ? "✔" : "",
                            color_cabello_negro=entity.color_cabello=="Negro" ? "✔" : "",
                            color_cabello_rubio=entity.color_cabello=="Rubio" ? "✔" : "",
                            color_cabello_castano=entity.color_cabello=="Castaño" ? "✔" : "",
                            color_cabello_rojo=entity.color_cabello=="Rojo" ? "✔" : "",
                            color_cabello_otros=entity.color_cabello=="Otros" ? "✔" : "",
                            permiso_emigracion=entity.permiso_emigracion=="True" ? "✔" : "",
                            residente_en_el_exterior=entity.residente_en_el_exterior=="True" ? "✔" : "",
                            asunto_oficial=entity.asunto_oficial=="True" ? "✔" : "",
                            pve=entity.pve=="True" ? "✔" : "",
                            psi=entity.psi=="True" ? "✔" : "",
                            residencia_exterior=entity.residencia_exterior=="True" ? "✔" : "",
                            pre=entity.pre=="True" ? "✔" : "",
                            pvt=entity.pvt=="True" ? "✔" : "",
                            pre_e=entity.pre_e=="True" ? "✔" : "",
                            salida_ilegal=entity.salida_ilegal=="True" ? "✔" : "",
                            dia_fecha_de_salida=entity.fecha_de_salida?.Split('-')[0], // Asumiendo que fecha_de_salida es un string en formato "dd/MM/yyyy"
                            mes_fecha_de_salida=entity.fecha_de_salida?.Split('-')[1],
                            anno_fecha_de_salida=entity.fecha_de_salida?.Split('-')[2],
                            pais=entity.pais,
                            provincia=entity.provincia,
                            municipio_ciudad=entity.municipio_ciudad,
                            dia_fecha_de_nacimiento=entity.fecha_de_nacimiento?.Split('-')[0], // Asumiendo que fecha_de_nacimiento es un string en formato "dd/MM/yyyy"
                            mes_fecha_de_nacimiento=entity.fecha_de_nacimiento?.Split('-')[1],
                            anno_fecha_de_nacimiento=entity.fecha_de_nacimiento?.Split('-')[2],
                            direccion=entity.direccion,
                            codigo_postal=entity.codigo_postal,
                            provincia_estado_region=entity.provincia_estado_region,
                            pais_residencia_actual=entity.pais_residencia_actual,
                            telefono_residencia=entity.telefono_residencia,
                            fax_residencia=entity.fax_residencia,
                            email_residencia=entity.email_residencia,
                            nombre_centro_trabajo_estudio=entity.nombre_centro_trabajo_estudio,
                            profesion=entity.profesion,
                            ocupacion=entity.ocupacion,
                            direccion_centro_estudio_trabajo=entity.direccion_centro_estudio_trabajo,
                            codigo_postal_centro_estudio_trabajo=entity.codigo_postal_centro_estudio_trabajo,
                            provincia_estado_region_centro_estudio_trabajo=entity.provincia_estado_region_centro_estudio_trabajo,
                            pais_centro_estudio_trabajo=entity.pais_centro_estudio_trabajo,
                            telefono_centro_estudio_trabajo=entity.telefono_centro_estudio_trabajo,
                            fax_centro_estudio_trabajo=entity.fax_centro_estudio_trabajo,
                            email_centro_estudio_trabajo=entity.email_centro_estudio_trabajo,
                            nivel_de_escolaridad=entity.nivel_de_escolaridad,
                            ocupacion_centro_estudio_trabajo=entity.ocupacion_centro_estudio_trabajo,
                            profecion_oficio_centro_estudio_trabajo=entity.profecion_oficio_centro_estudio_trabajo,
                            nombre_referencia_cuba=entity.nombre_referencia_cuba,
                            direccion_referencia_cuba=entity.direccion_referencia_cuba,
                            direccion1_referencia=entity.direccion1_referencia,
                            fecha_direccion1_referencia_desde=entity.fecha_direccion1_referencia_desde,
                            fecha_direccion1_referencia_fecha_hasta=entity.fecha_direccion1_referencia_fecha_hasta,
                            direccion2_referencia=entity.direccion2_referencia,
                            fecha_direccion2_referencia_desde=entity.fecha_direccion2_referencia_desde,
                            fecha_direccion2_referencia_fecha_hasta=entity.fecha_direccion2_referencia_fecha_hasta,
                            apellido_soltera_referencia=entity.apellido_soltera_referencia,
                            otros_nombres_referencia=entity.otros_nombres_referencia,
                            numero_residencia_referencia=entity.numero_residencia_referencia,
                            pasaporte_extranjero_referencia=entity.pasaporte_extranjero_referencia,
                            numero_pasaporte_vencido=entity.numero_pasaporte_vencido,
                            fecha_expedicion_pasaporte_vencido=entity.fecha_expedicion_pasaporte_vencido,
                            lugar_pasaporte_vencido=entity.lugar_pasaporte_vencido,
                            tomo_certificado_nacimiento=entity.tomo_certificado_nacimiento,
                            folio_certificado_nacimiento=entity.folio_certificado_nacimiento,
                            registro_civil_certificado_nacimiento=entity.registro_civil_certificado_nacimiento,
                            numero_inscripcion_consular=entity.numero_inscripcion_consular,
                            fecha_inscripcion_consular=entity.fecha_inscripcion_consular,
                            arancel_inscripcion_consular=entity.arancel_inscripcion_consular,
                            valoracion_consular=entity.valoracion_consular
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
