using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo4
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo4_m manager = new model.Anexo4_m(Global.sqlite);
        private model.Anexo4_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo4_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            ciudad.Text=entity.ciudad;
            pais.Text=entity.pais;
            f_name.Text=entity.f_name;
            s_name.Text=entity.s_name;
            f_apellido.Text=entity.f_apellido;
            s_apellido.Text=entity.s_apellido;

            lugar_nacimiento.Text=entity.lugar_nacimiento;
            ciudadania.Text=entity.ciudadania;
            nacionalidad.Text=entity.nacionalidad;

            estado_civil.Text=entity.estado_civil;
            fecha_nacimiento.Text=entity.fecha_nacimiento;

            sexo.Text=entity.sexo;
            color_piel.Text=entity.color_piel;

            profecion_oficio_ocupacion.Text=entity.profecion_oficio_ocupacion;

            nombre_padre.Text=entity.nombre_padre;
            nombre_madre.Text=entity.nombre_madre;

            carnet_identidad.Text=entity.carnet_identidad;
            pasaporte.Text=entity.pasaporte;

            calle.Text=entity.calle;
            numero.Text=entity.numero;

            entre.Text=entity.entre;
            y.Text=entity.y; 

            barrio.Text=entity.barrio;

            municipio.Text=entity.municipio;
            provincia.Text=entity.provincia;

            legalizacion_minred.Text=entity.legalizacion_minred;
            legalizacion_embajada.Text=entity.legalizacion_embajada;

            fecha_solicitud.Text=entity.fecha_solicitud;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo4());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo4 = new model.Anexo4_e()
            {
                id=entity.id,
                ciudad=ValidarCampo(ciudad.Text),
                pais=ValidarCampo(pais.Text),
                f_name=ValidarCampo(f_name.Text),
                s_name=ValidarCampo(s_name.Text),
                f_apellido=ValidarCampo(f_apellido.Text),
                s_apellido=ValidarCampo(s_apellido.Text),
                lugar_nacimiento=ValidarCampo(lugar_nacimiento.Text),
                ciudadania=ValidarCampo(ciudadania.Text),
                nacionalidad=ValidarCampo(nacionalidad.Text),
                estado_civil=ValidarCampo(estado_civil.Text),
                fecha_nacimiento=ValidarCampo(fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                sexo=ValidarCampo(sexo.Text),
                color_piel=ValidarCampo(color_piel.Text),
                profecion_oficio_ocupacion=ValidarCampo(profecion_oficio_ocupacion.Text),
                nombre_padre=ValidarCampo(nombre_padre.Text),
                nombre_madre=ValidarCampo(nombre_madre.Text),
                carnet_identidad=ValidarCampo(carnet_identidad.Text),
                pasaporte=ValidarCampo(pasaporte.Text),
                calle=ValidarCampo(calle.Text),
                numero=ValidarCampo(numero.Text),
                entre=ValidarCampo(entre.Text),
                y=ValidarCampo(y.Text),
                barrio=ValidarCampo(barrio.Text),
                municipio=ValidarCampo(municipio.Text),
                provincia=ValidarCampo(provincia.Text),
                legalizacion_minred=ValidarCampo(legalizacion_minred.Text),
                legalizacion_embajada=ValidarCampo(legalizacion_embajada.Text),
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
            };

            if(ValidarAnexo(anexo4))
            {
                manager.update(anexo4);
                MessageBox.Show("Anexo 4 guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo4_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.ciudad)||
            //    string.IsNullOrEmpty(model.pais)||
            //    string.IsNullOrEmpty(model.f_name)||
            //    string.IsNullOrEmpty(model.s_name)||
            //    string.IsNullOrEmpty(model.f_apellido)||
            //    string.IsNullOrEmpty(model.s_apellido)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento)||
            //    string.IsNullOrEmpty(model.ciudadania)||
            //    string.IsNullOrEmpty(model.nacionalidad)||
            //    string.IsNullOrEmpty(model.estado_civil)||
            //    string.IsNullOrEmpty(model.fecha_nacimiento)||
            //    string.IsNullOrEmpty(model.sexo)||
            //    string.IsNullOrEmpty(model.color_piel)||
            //    string.IsNullOrEmpty(model.profecion_oficio_ocupacion)||
            //    string.IsNullOrEmpty(model.nombre_padre)||
            //    string.IsNullOrEmpty(model.nombre_madre)||
            //    string.IsNullOrEmpty(model.carnet_identidad)||
            //    string.IsNullOrEmpty(model.pasaporte)||
            //    string.IsNullOrEmpty(model.calle)||
            //    string.IsNullOrEmpty(model.numero)||
            //    string.IsNullOrEmpty(model.entre)||
            //    string.IsNullOrEmpty(model.y)||
            //    string.IsNullOrEmpty(model.barrio)||
            //    string.IsNullOrEmpty(model.municipio)||
            //    string.IsNullOrEmpty(model.provincia)||
            //    string.IsNullOrEmpty(model.legalizacion_minred)||
            //    string.IsNullOrEmpty(model.legalizacion_embajada)||
            //    string.IsNullOrEmpty(model.fecha_solicitud))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo4_e es válida
        }
        private string ValidarCampo( string val )
        {
            string res = "";
            if(!string.IsNullOrWhiteSpace(val))
                res=val;
            return res;
        }
    }
}
