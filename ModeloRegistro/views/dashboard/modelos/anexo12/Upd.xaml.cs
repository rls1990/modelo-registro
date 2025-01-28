using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo12
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo12_m manager = new model.Anexo12_m(Global.sqlite);
        private model.Anexo12_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo12_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            ciudad.Text=entity.ciudad;
            pais.Text=entity.pais;
            nombre_apellidos.Text=entity.nombre_apellidos;
            ciudadano.Text=entity.ciudadano;
            carnet_identidad.Text=entity.carnet_identidad;
            fecha_nacimiento.Text=entity.fecha_nacimiento;
            municipio_lugar_nacimineto.Text=entity.municipio_lugar_nacimineto;
            provincia_lugar_nacimineto.Text=entity.provincia_lugar_nacimineto;
            municipio_registro_civil.Text=entity.municipio_registro_civil;
            provincia_registro_civil.Text=entity.provincia_registro_civil;
            vecino_de.Text=entity.vecino_de;
            nombre_apellido_apoderado.Text=entity.nombre_apellido_apoderado;
            si.IsChecked=entity.si=="True"; 
            no.IsChecked=entity.no=="False";
            numero.Text=entity.numero;
            fecha_poder_especial.Text=entity.fecha_poder_especial;
            nombre_apellido_notario.Text=entity.nombre_apellido_notario;
            competencia.Text=entity.competencia;
            sede.Text=entity.sede;
            legalizacion_minrex.Text=entity.legalizacion_minrex;
            legalizacion_embajada.Text=entity.legalizacion_embajada;
            fecha_de_solicitud.Text=entity.fecha_de_solicitud;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo12());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo12_e()
            {
                id=entity.id,
                ciudad=ciudad.Text,
                pais=pais.Text,
                nombre_apellidos=nombre_apellidos.Text,
                ciudadano=ciudadano.Text,
                carnet_identidad=carnet_identidad.Text,
                fecha_nacimiento=fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                municipio_lugar_nacimineto=municipio_lugar_nacimineto.Text,
                provincia_lugar_nacimineto=provincia_lugar_nacimineto.Text,
                municipio_registro_civil=municipio_registro_civil.Text,
                provincia_registro_civil=provincia_registro_civil.Text,
                vecino_de=vecino_de.Text,
                nombre_apellido_apoderado=nombre_apellido_apoderado.Text,
                si=si.IsChecked.ToString(),
                no=no.IsChecked.ToString(),
                numero=numero.Text,
                fecha_poder_especial=fecha_poder_especial.SelectedDate?.ToString("yyyy-MM-dd"),
                nombre_apellido_notario=nombre_apellido_notario.Text,
                competencia=competencia.Text,
                sede=sede.Text,
                legalizacion_minrex=legalizacion_minrex.Text,
                legalizacion_embajada=legalizacion_embajada.Text,
                fecha_de_solicitud=fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd")
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

        private bool ValidarAnexo( model.Anexo12_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.ciudad)&&
                   !string.IsNullOrWhiteSpace(anexo.pais)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadano)&&
                   !string.IsNullOrWhiteSpace(anexo.carnet_identidad)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.municipio_lugar_nacimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.provincia_lugar_nacimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.municipio_registro_civil)&&
                   !string.IsNullOrWhiteSpace(anexo.provincia_registro_civil)&&
                   !string.IsNullOrWhiteSpace(anexo.vecino_de)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_apoderado)&&
                   !string.IsNullOrWhiteSpace(anexo.si)&&
                   !string.IsNullOrWhiteSpace(anexo.no)&&
                   !string.IsNullOrWhiteSpace(anexo.numero)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_poder_especial)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_notario)&&
                   !string.IsNullOrWhiteSpace(anexo.competencia)&&
                   !string.IsNullOrWhiteSpace(anexo.sede)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_minrex)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_embajada)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_de_solicitud);
        }

    }
}
