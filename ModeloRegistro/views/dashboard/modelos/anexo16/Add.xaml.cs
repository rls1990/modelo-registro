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
            var anexo = new model.Anexo16_e()
            {
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
                manager.save(anexo);
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
            //    //!string.IsNullOrWhiteSpace(anexo.tirista)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.transeuntes)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.eventos)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.invitados)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.estudiantes_programas_becas)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.artistas)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.periodistas)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.religiosos)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.diplomaticas)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.tecnicos)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.deportistas)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.negocios)&&
            //    //   !string.IsNullOrWhiteSpace(anexo.otras)&&
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
            //        //! Validación de campos relacionados con la llegada a Cuba
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
