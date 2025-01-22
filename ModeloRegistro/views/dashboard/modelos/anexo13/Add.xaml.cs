using ModeloRegistro.model;
using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo13
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo13_m manager = new model.Anexo13_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo13());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo13_e()
            {
                fecha_solicitud=fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"),
                nombre_comparece=nombre_comparece.Text,
                no_pasaporte_comparece=no_pasaporte_comparece.Text,
                nombre_inscripcion=nombre_inscripcion.Text,
                m=m.IsChecked.ToString(),
                f=f.IsChecked.ToString(),
                primer_apellido_inscripcion=primer_apellido_inscripcion.Text,
                segundo_apellido_inscripcion=segundo_apellido_inscripcion.Text,
                hora_nacimiento=hora_nacimiento.Text,
                fecha_nacimineto=fecha_nacimineto.SelectedDate?.ToString("yyyy-MM-dd"),
                referencia_territorio_registro_civil=referencia_territorio_registro_civil.Text,
                tomo_referencia_registral=tomo_referencia_registral.Text,
                folio_referencia_registral=folio_referencia_registral.Text,
                nro_asiento=nro_asiento.Text,
                lugar_nacimineto=lugar_nacimineto.Text,
                nombre_padre=nombre_padre.Text,
                primer_apellido_padre=primer_apellido_padre.Text,
                segundo_apellido_padre=segundo_apellido_padre.Text,
                ciudadania_padre=ciudadania_padre.Text,
                natural_de_padre=natural_de_padre.Text,
                nro_pasaporte_padre=nro_pasaporte_padre.Text,
                domicilio_padre=domicilio_padre.Text,
                nombre_madre=nombre_madre.Text,
                primer_apellido_madre=primer_apellido_madre.Text,
                segundo_apellido_madre=segundo_apellido_madre.Text,
                ciudadania_madre=ciudadania_madre.Text,
                natural_de_madre=natural_de_madre.Text,
                nro_pasaporte_madre=nro_pasaporte_madre.Text,
                domicilio_madre=domicilio_madre.Text,
                nombre_abuelo_paterno=nombre_abuelo_paterno.Text,
                nombre_abuela_paterna=nombre_abuela_paterna.Text,
                nombre_abuelo_materno=nombre_abuelo_materno.Text,
                nombre_abuela_materna=nombre_abuela_materna.Text,
                nombre_apellido_soltera_madre=nombre_apellido_soltera_madre.Text,
                nombre_inscrito_pais_nacimineto=nombre_inscrito_pais_nacimineto.Text,
                inscripcion_practicada_en_virtud_de=inscripcion_practicada_en_virtud_de.Text,
                observaciones=observaciones.Text
            };

            if(ValidarAnexo(anexo))
            {
                manager.save(anexo);
                MessageBox.Show("Anexo guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        private bool ValidarAnexo( Anexo13_e anexo )
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
