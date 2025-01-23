using ModeloRegistro.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModeloRegistro.views.dashboard.modelos.anexo15
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo15_m manager = new model.Anexo15_m(Global.sqlite);
        private model.Anexo15_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo15_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            nombre_fallecido.Text=entity.nombre_fallecido;
            m.IsChecked=entity.m=="True";
            f.IsChecked=entity.f=="True";
            primer_apellido_fallecido.Text=entity.primer_apellido_fallecido;
            segundo_apellido_fallecido.Text=entity.segundo_apellido_fallecido;
            hora_fallecido.Text=entity.hora_fallecido;
            fecha_fallecimineto.Text=entity.fecha_fallecimineto;
            lugar_nacimineto_fallecido.Text=entity.lugar_nacimineto_fallecido;
            municipio_provincia_pais_fallecido.Text=entity.municipio_provincia_pais_fallecido;
            fecha_nacimiento.Text=entity.fecha_nacimiento;
            pasaporte_fallecido.Text=entity.pasaporte_fallecido;
            edad_fallecido.Text=entity.edad_fallecido;
            registro_civil_fallecido.Text=entity.registro_civil_fallecido;
            tomo_fallecido.Text=entity.tomo_fallecido;
            folio_fallecido.Text=entity.folio_fallecido;
            estado_civil_fallecido.Text=entity.estado_civil_fallecido;
            ocupacion_fallecido.Text=entity.ocupacion_fallecido;
            padre_fallecido.Text=entity.padre_fallecido;
            madre_fallecido.Text=entity.madre_fallecido;
            domicilio_fallecido.Text=entity.domicilio_fallecido;
            fecha_defuncion.Text=entity.fecha_defuncion;
            hora_defuncion.Text=entity.hora_defuncion;
            lugar_fallecimiento.Text=entity.lugar_fallecimiento;
            causa_muerte_fallecimiento.Text=entity.causa_muerte_fallecimiento;
            enfermedad_causa_fallecimiento.Text=entity.enfermedad_causa_fallecimiento;
            nombre_medico_certifica_fallecimiento.Text=entity.nombre_medico_certifica_fallecimiento;
            lugar_cepultura.Text=entity.lugar_cepultura;

            registro_civil.Text=entity.registro_civil;
            tomo.Text=entity.tomo;
            folio.Text=entity.folio;

            fecha_certificado.Text=entity.fecha_certificado;
            nombre_apellido_solicita.Text=entity.nombre_apellido_solicita;
            nro_pasaporte_carnet.Text=entity.nro_pasaporte_carnet;
            parentesco_fallecido.Text=entity.parentesco_fallecido;
            direccion_solicita.Text=entity.direccion_solicita;

            nombre_apellido_funcionario_consular.Text=entity.nombre_apellido_funcionario_consular;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo15());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo15_e()
            {
                id=entity.id,
                nombre_fallecido=nombre_fallecido.Text,
                m=m.IsChecked.ToString(),
                f=f.IsChecked.ToString(),
                primer_apellido_fallecido=primer_apellido_fallecido.Text,
                segundo_apellido_fallecido=segundo_apellido_fallecido.Text,
                hora_fallecido=hora_fallecido.Text,
                fecha_fallecimineto=fecha_fallecimineto.SelectedDate?.ToString("yyyy-MM-dd"),
                lugar_nacimineto_fallecido=lugar_nacimineto_fallecido.Text,
                municipio_provincia_pais_fallecido=municipio_provincia_pais_fallecido.Text,
                fecha_nacimiento=fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                pasaporte_fallecido=pasaporte_fallecido.Text,
                edad_fallecido=edad_fallecido.Text,
                registro_civil_fallecido=registro_civil_fallecido.Text,
                tomo_fallecido=tomo_fallecido.Text,
                folio_fallecido=folio_fallecido.Text,
                estado_civil_fallecido=estado_civil_fallecido.Text,
                ocupacion_fallecido=ocupacion_fallecido.Text,
                padre_fallecido=padre_fallecido.Text,
                madre_fallecido=madre_fallecido.Text,
                domicilio_fallecido=domicilio_fallecido.Text,

                fecha_defuncion=fecha_defuncion.SelectedDate?.ToString("yyyy-MM-dd"),
                hora_defuncion=hora_defuncion.Text,
                lugar_fallecimiento=lugar_fallecimiento.Text,
                causa_muerte_fallecimiento=causa_muerte_fallecimiento.Text,
                enfermedad_causa_fallecimiento=enfermedad_causa_fallecimiento.Text,

                nombre_medico_certifica_fallecimiento=nombre_medico_certifica_fallecimiento.Text,
                lugar_cepultura=lugar_cepultura.Text,

                registro_civil=registro_civil.Text,
                tomo=tomo.Text,
                folio=folio.Text,

                fecha_certificado=fecha_certificado.SelectedDate?.ToString("yyyy-MM-dd"),

                nombre_apellido_solicita=nombre_apellido_solicita.Text,
                nro_pasaporte_carnet=nro_pasaporte_carnet.Text,

                parentesco_fallecido=parentesco_fallecido.Text,
                direccion_solicita=direccion_solicita.Text,

                nombre_apellido_funcionario_consular=nombre_apellido_funcionario_consular.Text
            };

            if(ValidarAnexo(anexo))
            {
                manager.update(anexo);
                MessageBox.Show("Anexo guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        private bool ValidarAnexo( model.Anexo15_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.nombre_fallecido)&&
                   //!string.IsNullOrWhiteSpace(anexo.m)&&
                   //!string.IsNullOrWhiteSpace(anexo.f)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_apellido_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_apellido_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.hora_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_fallecimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimineto_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.municipio_provincia_pais_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.edad_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.registro_civil_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.tomo_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.folio_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.estado_civil_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.ocupacion_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.padre_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.madre_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.domicilio_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_defuncion)&&
                   !string.IsNullOrWhiteSpace(anexo.hora_defuncion)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.causa_muerte_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.enfermedad_causa_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_medico_certifica_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_cepultura)&&
                   !string.IsNullOrWhiteSpace(anexo.registro_civil)&&
                   !string.IsNullOrWhiteSpace(anexo.tomo)&&
                   !string.IsNullOrWhiteSpace(anexo.folio)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_solicita)&&
                   !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_carnet)&&
                   !string.IsNullOrWhiteSpace(anexo.parentesco_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.direccion_solicita)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_funcionario_consular);
        }
    }
}
