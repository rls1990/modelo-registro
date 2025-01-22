using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo16
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo16_m manager = new model.Anexo16_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo16());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        private bool ValidarAnexo( model.Anexo16_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return 
                //!string.IsNullOrWhiteSpace(anexo.tirista)&&
                //   !string.IsNullOrWhiteSpace(anexo.transeuntes)&&
                //   !string.IsNullOrWhiteSpace(anexo.eventos)&&
                //   !string.IsNullOrWhiteSpace(anexo.invitados)&&
                //   !string.IsNullOrWhiteSpace(anexo.estudiantes_programas_becas)&&
                //   !string.IsNullOrWhiteSpace(anexo.artistas)&&
                //   !string.IsNullOrWhiteSpace(anexo.periodistas)&&
                //   !string.IsNullOrWhiteSpace(anexo.religiosos)&&
                //   !string.IsNullOrWhiteSpace(anexo.diplomaticas)&&
                //   !string.IsNullOrWhiteSpace(anexo.tecnicos)&&
                //   !string.IsNullOrWhiteSpace(anexo.deportistas)&&
                //   !string.IsNullOrWhiteSpace(anexo.negocios)&&
                //   !string.IsNullOrWhiteSpace(anexo.otras)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_solicitud)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_expedicion)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_expedicion)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_apellido)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_apellido)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_nombre)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_nombre)&&
                   !string.IsNullOrWhiteSpace(anexo.padre)&&
                   !string.IsNullOrWhiteSpace(anexo.madre)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_padres)&&
                   !string.IsNullOrWhiteSpace(anexo.estatura)&&
                   !string.IsNullOrWhiteSpace(anexo.estado_civil)&&
                   //!string.IsNullOrWhiteSpace(anexo.m)&& // Sexo masculino
                   //!string.IsNullOrWhiteSpace(anexo.f)&& // Sexo femenino
                   //!string.IsNullOrWhiteSpace(anexo.blue_green_claros)&&
                   //!string.IsNullOrWhiteSpace(anexo.black_negros)&&
                   //!string.IsNullOrWhiteSpace(anexo.pardos)&&
                   //!string.IsNullOrWhiteSpace(anexo.piel_blanca)&&
                   //!string.IsNullOrWhiteSpace(anexo.piel_negra)&&
                   //!string.IsNullOrWhiteSpace(anexo.piel_albina)&&
                   //!string.IsNullOrWhiteSpace(anexo.piel_amarilla)&&
                   //!string.IsNullOrWhiteSpace(anexo.pelo_canoso)&&
                   //!string.IsNullOrWhiteSpace(anexo.pelo_negro)&&
                   //!string.IsNullOrWhiteSpace(anexo.pelo_rubio)&&
                   //!string.IsNullOrWhiteSpace(anexo.pelo_castaño)&&
                   //!string.IsNullOrWhiteSpace(anexo.pelo_rojo)&&
                   //!string.IsNullOrWhiteSpace(anexo.pelo_otro)&&
                   !string.IsNullOrWhiteSpace(anexo.pais)&&
                   !string.IsNullOrWhiteSpace(anexo.provincia)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudad_municipio)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.direccion)&&
                   !string.IsNullOrWhiteSpace(anexo.codigo_postal)&&
                   !string.IsNullOrWhiteSpace(anexo.provincia_estado_region)&&
                   !string.IsNullOrWhiteSpace(anexo.pais_residencia_actual)&&
                   !string.IsNullOrWhiteSpace(anexo.telefono)&&
                   !string.IsNullOrWhiteSpace(anexo.fax)&&

                   // Validación de campos relacionados con el trabajo o estudio
                   !string.IsNullOrWhiteSpace(anexo.nombre_centro_trabajo_estudio)&&
                   !string.IsNullOrWhiteSpace(anexo.profecion)&&
                   !string.IsNullOrWhiteSpace(anexo.ocupacion)&&
                   !string.IsNullOrWhiteSpace(anexo.direccion_centro)&&
                   !string.IsNullOrWhiteSpace(anexo.codigo_postal_centro)&&
                   !string.IsNullOrWhiteSpace(anexo.provincia_estado_region_centro)&&
                   !string.IsNullOrWhiteSpace(anexo.pais_centro)&&
                   !string.IsNullOrWhiteSpace(anexo.telefono_centro)&&
                   !string.IsNullOrWhiteSpace(anexo.fax_centro)&&
                   !string.IsNullOrWhiteSpace(anexo.email_centro)&&

                   // Validación de campos relacionados con la estancia en Cuba
                   !string.IsNullOrWhiteSpace(anexo.direccion_estancia_cuba)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_persona_a_vicitar_cuba)&&
                   !string.IsNullOrWhiteSpace(anexo.motivo_viaje_cuba)&&
                   !string.IsNullOrWhiteSpace(anexo.tiempo_estancia)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_fecha_salida_cuba)&&
                    //! Validación de campos relacionados con la llegada a Cuba
                   !string.IsNullOrWhiteSpace(anexo.lugar_fecha_llegada_cuba)&&
                   !string.IsNullOrWhiteSpace(anexo.proposito_viaje_cuba);
        }


    }
}
