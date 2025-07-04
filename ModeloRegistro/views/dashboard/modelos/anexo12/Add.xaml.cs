﻿using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo12
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo12_m manager = new model.Anexo12_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo12());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo12_e()
            {
                ciudad=ValidarCampo(ciudad.Text),
                pais=ValidarCampo(pais.Text),
                nombre_apellidos=ValidarCampo(nombre_apellidos.Text),
                ciudadano=ValidarCampo(ciudadano.Text),
                carnet_identidad=ValidarCampo(carnet_identidad.Text),
                fecha_nacimiento=ValidarCampo(fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                municipio_lugar_nacimineto=ValidarCampo(municipio_lugar_nacimineto.Text),
                provincia_lugar_nacimineto=ValidarCampo(provincia_lugar_nacimineto.Text),
                municipio_registro_civil=ValidarCampo(municipio_registro_civil.Text),
                provincia_registro_civil=ValidarCampo(provincia_registro_civil.Text),
                vecino_de=ValidarCampo(vecino_de.Text),
                nombre_apellido_apoderado=ValidarCampo(nombre_apellido_apoderado.Text),
                si=ValidarCampo(si.IsChecked.ToString()),
                no=ValidarCampo(no.IsChecked.ToString()),
                numero=ValidarCampo(numero.Text),
                fecha_poder_especial=ValidarCampo(fecha_poder_especial.SelectedDate?.ToString("yyyy-MM-dd")),
                nombre_apellido_notario=ValidarCampo(nombre_apellido_notario.Text),
                competencia=ValidarCampo(competencia.Text),
                sede=ValidarCampo(sede.Text),
                legalizacion_minrex=ValidarCampo(legalizacion_minrex.Text),
                legalizacion_embajada=ValidarCampo(legalizacion_embajada.Text),
                fecha_de_solicitud=ValidarCampo(fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
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

    private bool ValidarAnexo( model.Anexo12_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            //return !string.IsNullOrWhiteSpace(anexo.ciudad)&&
            //       !string.IsNullOrWhiteSpace(anexo.pais)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadano)&&
            //       !string.IsNullOrWhiteSpace(anexo.carnet_identidad)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.municipio_lugar_nacimineto)&&
            //       !string.IsNullOrWhiteSpace(anexo.provincia_lugar_nacimineto)&&
            //       !string.IsNullOrWhiteSpace(anexo.municipio_registro_civil)&&
            //       !string.IsNullOrWhiteSpace(anexo.provincia_registro_civil)&&
            //       !string.IsNullOrWhiteSpace(anexo.vecino_de)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_apellido_apoderado)&&
            //       !string.IsNullOrWhiteSpace(anexo.si)&&
            //       !string.IsNullOrWhiteSpace(anexo.no)&&
            //       !string.IsNullOrWhiteSpace(anexo.numero)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_poder_especial)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_apellido_notario)&&
            //       !string.IsNullOrWhiteSpace(anexo.competencia)&&
            //       !string.IsNullOrWhiteSpace(anexo.sede)&&
            //       !string.IsNullOrWhiteSpace(anexo.legalizacion_minrex)&&
            //       !string.IsNullOrWhiteSpace(anexo.legalizacion_embajada)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_de_solicitud);
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
