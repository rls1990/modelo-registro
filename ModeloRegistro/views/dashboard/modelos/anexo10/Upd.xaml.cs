using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo10
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo10_m manager = new model.Anexo10_m(Global.sqlite);
        private model.Anexo10_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo10_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            ciudad.Text=entity.ciudad;
            pais.Text=entity.pais;
            solicito_certificado.Text=entity.solicito_certificado;
            de_mi.Text=entity.de_mi;
            nombre_apellidos.Text=entity.nombre_apellidos;
            fecha_nacimiento.Text=entity.fecha_nacimiento;
            lugar_nacimiento.Text=entity.lugar_nacimiento;
            nombre_padres.Text=entity.nombre_padres;
            lugar_vivio_cuba.Text=entity.lugar_vivio_cuba;
            fecha_fallecimiento.Text=entity.fecha_fallecimiento;
            otros_datos_interes.Text=entity.otros_datos_interes;
            nombre_apellidos_solicitante.Text=entity.nombre_apellidos_solicitante;
            doc_identidad.Text=entity.doc_identidad;
            pasaporte.Text=entity.pasaporte;
            direccion.Text=entity.direccion;
            telefono.Text=entity.telefono;
            email.Text=entity.email;
            legalizacion_minrex.Text=entity.legalizacion_minrex;
            legalizacion_embajada.Text=entity.legalizacion_embajada;
            fecha_de_solicitud.Text=entity.fecha_de_solicitud;
        }



        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo10());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo10_e()
            {
                id=entity.id,
                ciudad=ciudad.Text,
                pais=pais.Text,
                solicito_certificado=solicito_certificado.Text,
                de_mi=de_mi.Text,
                nombre_apellidos=nombre_apellidos.Text,
                fecha_nacimiento=fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                lugar_nacimiento=lugar_nacimiento.Text,
                nombre_padres=nombre_padres.Text,
                lugar_vivio_cuba=lugar_vivio_cuba.Text,
                fecha_fallecimiento=fecha_fallecimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                otros_datos_interes=otros_datos_interes.Text,
                nombre_apellidos_solicitante=nombre_apellidos_solicitante.Text,
                doc_identidad=doc_identidad.Text,
                pasaporte=pasaporte.Text,
                direccion=direccion.Text,
                telefono=telefono.Text,
                email=email.Text,
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

        private bool ValidarAnexo( model.Anexo10_e anexo )
        {
            // Verificar si cada campo de la entidad no es un string vacío
            return !string.IsNullOrWhiteSpace(anexo.ciudad)&&
                   !string.IsNullOrWhiteSpace(anexo.pais)&&
                   !string.IsNullOrWhiteSpace(anexo.solicito_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.de_mi)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_padres)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_vivio_cuba)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.otros_datos_interes)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellidos_solicitante)&&
                   !string.IsNullOrWhiteSpace(anexo.doc_identidad)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte)&&
                   !string.IsNullOrWhiteSpace(anexo.direccion)&&
                   !string.IsNullOrWhiteSpace(anexo.telefono)&&
                   !string.IsNullOrWhiteSpace(anexo.email)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_minrex)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_embajada)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_de_solicitud);
        }
    }
}
