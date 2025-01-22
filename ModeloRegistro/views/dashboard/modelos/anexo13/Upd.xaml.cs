using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo13
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo13_m manager = new model.Anexo13_m(Global.sqlite);
        private model.Anexo13_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo13());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        private bool ValidarAnexo( model.Anexo13_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.fecha_solicitud)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_comparece)&&
                   !string.IsNullOrWhiteSpace(anexo.no_pasaporte_comparece)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_inscripcion)&&
                   //!string.IsNullOrWhiteSpace(anexo.m)&&
                   //!string.IsNullOrWhiteSpace(anexo.f)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_apellido_inscripcion)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_apellido_inscripcion)&&
                   !string.IsNullOrWhiteSpace(anexo.hora_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.referencia_territorio_registro_civil)&&
                   !string.IsNullOrWhiteSpace(anexo.tomo_referencia_registral)&&
                   !string.IsNullOrWhiteSpace(anexo.folio_referencia_registral)&&
                   !string.IsNullOrWhiteSpace(anexo.nro_asiento)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_apellido_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_apellido_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.natural_de_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.domicilio_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_apellido_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_apellido_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.natural_de_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.domicilio_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_abuelo_paterno)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_abuela_paterna)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_abuelo_materno)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_abuela_materna)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_soltera_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_inscrito_pais_nacimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.inscripcion_practicada_en_virtud_de)&&
                   !string.IsNullOrWhiteSpace(anexo.observaciones);
        }
    }
}
