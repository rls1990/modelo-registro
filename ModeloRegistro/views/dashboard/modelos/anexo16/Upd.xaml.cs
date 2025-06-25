using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo16
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo16_m manager = new model.Anexo16_m(Global.sqlite);
        private model.Anexo16_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo16_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            tirista.IsChecked=entity.tirista=="True";
            transeuntes.IsChecked=entity.transeuntes=="True";
            eventos.IsChecked=entity.eventos=="True";
            invitados.IsChecked=entity.invitados=="True";
            estudiantes_programas_becas.IsChecked=entity.estudiantes_programas_becas=="True";
            artistas.IsChecked=entity.artistas=="True";
            periodistas.IsChecked=entity.periodistas=="True";
            religiosos.IsChecked=entity.religiosos=="True";
            diplomaticas.IsChecked=entity.diplomaticas=="True";
            tecnicos.IsChecked=entity.tecnicos=="True";
            deportistas.IsChecked=entity.deportistas=="True";
            negocios.IsChecked=entity.negocios=="True";
            otras.IsChecked=entity.otras=="True";

            fecha_solicitud.Text=entity.fecha_solicitud;
            pasaporte.Text=entity.pasaporte;
            lugar_expedicion.Text=entity.lugar_expedicion;
            fecha_expedicion.Text=entity.fecha_expedicion;

            primer_apellido.Text=entity.primer_apellido;
            segundo_apellido.Text=entity.segundo_apellido;
            primer_nombre.Text=entity.primer_nombre;
            segundo_nombre.Text=entity.segundo_nombre;

            padre.Text=entity.padre;
            madre.Text=entity.madre;
            lugar_nacimiento_padres.Text=entity.lugar_nacimiento_padres;

            estatura.Text=entity.estatura;
            estado_civil.Text=entity.estado_civil;

            m.IsChecked=entity.m=="True"; // Asegúrate de que esto sea un campo adecuado
            f.IsChecked=entity.f=="True"; // Igual que el anterior

            blue_green_claros.IsChecked=entity.blue_green_claros=="True";
            black_negros.IsChecked=entity.black_negros=="True";
            pardos.IsChecked=entity.pardos=="True";
            piel_blanca.IsChecked=entity.piel_blanca=="True";
            piel_negra.IsChecked=entity.piel_negra=="True";
            piel_albina.IsChecked=entity.piel_albina=="True";
            piel_amarilla.IsChecked=entity.piel_amarilla=="True";

            pelo_canoso.IsChecked=entity.pelo_canoso=="True";
            pelo_negro.IsChecked=entity.pelo_negro=="True";
            pelo_rubio.IsChecked=entity.pelo_rubio=="True";
            pelo_castaño.IsChecked=entity.pelo_castaño=="True";
            pelo_rojo.IsChecked=entity.pelo_rojo=="True";
            pelo_otro.IsChecked=entity.pelo_otro=="True";

            pais.Text=entity.pais;
            provincia.Text=entity.provincia;
            ciudad_municipio.Text=entity.ciudad_municipio;

            fecha_nacimiento.Text=entity.fecha_nacimiento;

            direccion.Text=entity.direccion;

            codigo_postal.Text=entity.codigo_postal;

            provincia_estado_region.Text=entity.provincia_estado_region;

            pais_residencia_actual.Text=entity.pais_residencia_actual;

            telefono.Text=entity.telefono;

            fax.Text=entity.fax;

            email.Text=entity.email;

            nombre_centro_trabajo_estudio.Text=entity.nombre_centro_trabajo_estudio;

            profecion.Text=entity.profecion; // Asegúrate de que este campo sea correcto
            ocupacion.Text=entity.ocupacion;

            direccion_centro.Text=entity.direccion_centro;

            codigo_postal_centro.Text=entity.codigo_postal_centro;

            provincia_estado_region_centro.Text=entity.provincia_estado_region_centro;

            pais_centro.Text=entity.pais_centro;

            telefono_centro.Text=entity.telefono_centro;

            fax_centro.Text=entity.fax_centro;

            email_centro.Text=entity.email_centro;

            direccion_estancia_cuba.Text=entity.direccion_estancia_cuba;

            nombre_apellido_persona_a_vicitar_cuba.Text=entity.nombre_apellido_persona_a_vicitar_cuba;

            motivo_viaje_cuba.Text=entity.motivo_viaje_cuba;

            tiempo_estancia.Text=entity.tiempo_estancia;

            lugar_fecha_salida_cuba.Text=entity.lugar_fecha_salida_cuba;

            lugar_fecha_llegada_cuba.Text=entity.lugar_fecha_llegada_cuba;

            proposito_viaje_cuba.Text=entity.proposito_viaje_cuba;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo16());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo16_e()
            {
                id=entity.id,
                tirista=ValidarCampo(tirista.IsChecked.ToString()),
                transeuntes=ValidarCampo(transeuntes.IsChecked.ToString()),
                eventos=ValidarCampo(eventos.IsChecked.ToString()),
                invitados=ValidarCampo(invitados.IsChecked.ToString()),
                estudiantes_programas_becas=ValidarCampo(estudiantes_programas_becas.IsChecked.ToString()),
                artistas=ValidarCampo(artistas.IsChecked.ToString()),
                periodistas=ValidarCampo(periodistas.IsChecked.ToString()),
                religiosos=ValidarCampo(religiosos.IsChecked.ToString()),
                diplomaticas=ValidarCampo(diplomaticas.IsChecked.ToString()),
                tecnicos=ValidarCampo(tecnicos.IsChecked.ToString()),
                deportistas=ValidarCampo(deportistas.IsChecked.ToString()),
                negocios=ValidarCampo(negocios.IsChecked.ToString()),
                otras=ValidarCampo(otras.IsChecked.ToString()),

                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd")),
                pasaporte=ValidarCampo(pasaporte.Text),
                lugar_expedicion=ValidarCampo(lugar_expedicion.Text),
                fecha_expedicion=ValidarCampo(fecha_expedicion.SelectedDate?.ToString("yyyy-MM-dd")),

                primer_apellido=ValidarCampo(primer_apellido.Text),
                segundo_apellido=ValidarCampo(segundo_apellido.Text),
                primer_nombre=ValidarCampo(primer_nombre.Text),
                segundo_nombre=ValidarCampo(segundo_nombre.Text),

                padre=ValidarCampo(padre.Text),
                madre=ValidarCampo(madre.Text),

                lugar_nacimiento_padres=ValidarCampo(lugar_nacimiento_padres.Text),

                estatura=ValidarCampo(estatura.Text),
                estado_civil=ValidarCampo(estado_civil.Text),

                m=ValidarCampo(m.IsChecked.ToString()),
                f=ValidarCampo(f.IsChecked.ToString()),

                blue_green_claros=ValidarCampo(blue_green_claros.IsChecked.ToString()),
                black_negros=ValidarCampo(black_negros.IsChecked.ToString()),
                pardos=ValidarCampo(pardos.IsChecked.ToString()),
                piel_blanca=ValidarCampo(piel_blanca.IsChecked.ToString()),
                piel_negra=ValidarCampo(piel_negra.IsChecked.ToString()),
                piel_albina=ValidarCampo(piel_albina.IsChecked.ToString()),
                piel_amarilla=ValidarCampo(piel_amarilla.IsChecked.ToString()),

                pelo_canoso=ValidarCampo(pelo_canoso.IsChecked.ToString()),
                pelo_negro=ValidarCampo(pelo_negro.IsChecked.ToString()),
                pelo_rubio=ValidarCampo(pelo_rubio.IsChecked.ToString()),
                pelo_castaño=ValidarCampo(pelo_castaño.IsChecked.ToString()),
                pelo_rojo=ValidarCampo(pelo_rojo.IsChecked.ToString()),
                pelo_otro=ValidarCampo(pelo_otro.IsChecked.ToString()),

                pais=ValidarCampo(pais.Text),
                provincia=ValidarCampo(provincia.Text),

                ciudad_municipio=ValidarCampo(ciudad_municipio.Text),

                fecha_nacimiento=ValidarCampo(fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),

                direccion=ValidarCampo(direccion.Text),

                codigo_postal=ValidarCampo(codigo_postal.Text),

                provincia_estado_region=ValidarCampo(provincia_estado_region.Text),

                pais_residencia_actual=ValidarCampo(pais_residencia_actual.Text),

                telefono=ValidarCampo(telefono.Text),

                fax=ValidarCampo(fax.Text),

                email=ValidarCampo(email.Text),

                nombre_centro_trabajo_estudio=ValidarCampo(nombre_centro_trabajo_estudio.Text),

                profecion=ValidarCampo(profecion.Text),

                ocupacion=ValidarCampo(ocupacion.Text),

                direccion_centro=ValidarCampo(direccion_centro.Text),

                codigo_postal_centro=ValidarCampo(codigo_postal_centro.Text),

                provincia_estado_region_centro=ValidarCampo(provincia_estado_region_centro.Text),

                pais_centro=ValidarCampo(pais_centro.Text),

                telefono_centro=ValidarCampo(telefono_centro.Text),

                fax_centro=ValidarCampo(fax_centro.Text),

                email_centro=ValidarCampo(email_centro.Text),


                direccion_estancia_cuba=ValidarCampo(direccion_estancia_cuba.Text),

                nombre_apellido_persona_a_vicitar_cuba=ValidarCampo(nombre_apellido_persona_a_vicitar_cuba.Text),

                motivo_viaje_cuba=ValidarCampo(motivo_viaje_cuba.Text),

                tiempo_estancia=ValidarCampo(tiempo_estancia.Text),

                lugar_fecha_salida_cuba=ValidarCampo(lugar_fecha_salida_cuba.Text),

                lugar_fecha_llegada_cuba=ValidarCampo(lugar_fecha_llegada_cuba.Text),

                proposito_viaje_cuba=ValidarCampo(proposito_viaje_cuba.Text)
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

        private bool ValidarAnexo( model.Anexo16_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            //return
            //       //!string.IsNullOrWhiteSpace(anexo.tirista)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.transeuntes)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.eventos)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.invitados)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.estudiantes_programas_becas)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.artistas)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.periodistas)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.religiosos)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.diplomaticas)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.tecnicos)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.deportistas)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.negocios)&&
            //       //   !string.IsNullOrWhiteSpace(anexo.otras)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_solicitud)&&
            //       !string.IsNullOrWhiteSpace(anexo.pasaporte)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_expedicion)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_expedicion)&&
            //       !string.IsNullOrWhiteSpace(anexo.primer_apellido)&&
            //       !string.IsNullOrWhiteSpace(anexo.segundo_apellido)&&
            //       !string.IsNullOrWhiteSpace(anexo.primer_nombre)&&
            //       !string.IsNullOrWhiteSpace(anexo.segundo_nombre)&&
            //       !string.IsNullOrWhiteSpace(anexo.padre)&&
            //       !string.IsNullOrWhiteSpace(anexo.madre)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_padres)&&
            //       !string.IsNullOrWhiteSpace(anexo.estatura)&&
            //       !string.IsNullOrWhiteSpace(anexo.estado_civil)&&
            //       //!string.IsNullOrWhiteSpace(anexo.m)&& // Sexo masculino
            //       //!string.IsNullOrWhiteSpace(anexo.f)&& // Sexo femenino
            //       //!string.IsNullOrWhiteSpace(anexo.blue_green_claros)&&
            //       //!string.IsNullOrWhiteSpace(anexo.black_negros)&&
            //       //!string.IsNullOrWhiteSpace(anexo.pardos)&&
            //       //!string.IsNullOrWhiteSpace(anexo.piel_blanca)&&
            //       //!string.IsNullOrWhiteSpace(anexo.piel_negra)&&
            //       //!string.IsNullOrWhiteSpace(anexo.piel_albina)&&
            //       //!string.IsNullOrWhiteSpace(anexo.piel_amarilla)&&
            //       //!string.IsNullOrWhiteSpace(anexo.pelo_canoso)&&
            //       //!string.IsNullOrWhiteSpace(anexo.pelo_negro)&&
            //       //!string.IsNullOrWhiteSpace(anexo.pelo_rubio)&&
            //       //!string.IsNullOrWhiteSpace(anexo.pelo_castaño)&&
            //       //!string.IsNullOrWhiteSpace(anexo.pelo_rojo)&&
            //       //!string.IsNullOrWhiteSpace(anexo.pelo_otro)&&
            //       !string.IsNullOrWhiteSpace(anexo.pais)&&
            //       !string.IsNullOrWhiteSpace(anexo.provincia)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudad_municipio)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.direccion)&&
            //       !string.IsNullOrWhiteSpace(anexo.codigo_postal)&&
            //       !string.IsNullOrWhiteSpace(anexo.provincia_estado_region)&&
            //       !string.IsNullOrWhiteSpace(anexo.pais_residencia_actual)&&
            //       !string.IsNullOrWhiteSpace(anexo.telefono)&&
            //       !string.IsNullOrWhiteSpace(anexo.fax)&&

            //       // Validación de campos relacionados con el trabajo o estudio
            //       !string.IsNullOrWhiteSpace(anexo.nombre_centro_trabajo_estudio)&&
            //       !string.IsNullOrWhiteSpace(anexo.profecion)&&
            //       !string.IsNullOrWhiteSpace(anexo.ocupacion)&&
            //       !string.IsNullOrWhiteSpace(anexo.direccion_centro)&&
            //       !string.IsNullOrWhiteSpace(anexo.codigo_postal_centro)&&
            //       !string.IsNullOrWhiteSpace(anexo.provincia_estado_region_centro)&&
            //       !string.IsNullOrWhiteSpace(anexo.pais_centro)&&
            //       !string.IsNullOrWhiteSpace(anexo.telefono_centro)&&
            //       !string.IsNullOrWhiteSpace(anexo.fax_centro)&&
            //       !string.IsNullOrWhiteSpace(anexo.email_centro)&&

            //       // Validación de campos relacionados con la estancia en Cuba
            //       !string.IsNullOrWhiteSpace(anexo.direccion_estancia_cuba)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_apellido_persona_a_vicitar_cuba)&&
            //       !string.IsNullOrWhiteSpace(anexo.motivo_viaje_cuba)&&
            //       !string.IsNullOrWhiteSpace(anexo.tiempo_estancia)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_fecha_salida_cuba)&&
            //       //! Validación de campos relacionados con la llegada a Cuba
            //       !string.IsNullOrWhiteSpace(anexo.lugar_fecha_llegada_cuba)&&
            //       !string.IsNullOrWhiteSpace(anexo.proposito_viaje_cuba);

            return true;
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
