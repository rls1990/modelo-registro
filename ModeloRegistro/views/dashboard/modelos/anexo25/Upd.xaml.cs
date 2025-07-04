﻿using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo25
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo25_m manager = new model.Anexo25_m(Global.sqlite);
        private model.Anexo25_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo25_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            fecha_solicitud.Text=entity.fecha_solicitud;
            nombre_poderante.Text=entity.nombre_poderante;
            sexo_poderante.Text=entity.sexo_poderante;

            lugar_nacimiento_municipio_poderante.Text=entity.lugar_nacimiento_municipio_poderante;
            lugar_nacimiento_provincia_poderante.Text=entity.lugar_nacimiento_provincia_poderante;

            fecha_nacimineto_poderante.Text=entity.fecha_nacimineto_poderante;
            estado_civil_poderante.Text=entity.estado_civil_poderante;

            ciudadania_poderante.Text=entity.ciudadania_poderante;
            ocupacion_poderante.Text=entity.ocupacion_poderante;

            direccion_particular_poderante.Text=entity.direccion_particular_poderante;
            carne_pasaporte_poderante.Text=entity.carne_pasaporte_poderante;

            condicion_migratoria_poderante.Text=entity.condicion_migratoria_poderante;

            correo_poderante.Text=entity.correo_poderante;
            celular_poderante.Text=entity.celular_poderante;

            nombre_apoderado.Text=entity.nombre_apoderado;
            sexo_apoderado.Text=entity.sexo_apoderado;

            lugar_nacimiento_municipio_apoderado.Text=entity.lugar_nacimiento_municipio_apoderado;
            lugar_nacimiento_provincia_apoderado.Text=entity.lugar_nacimiento_provincia_apoderado;

            fecha_nacimineto_apoderado.Text=entity.fecha_nacimineto_apoderado;
            estado_civil_apoderado.Text=entity.estado_civil_apoderado;

            ciudadania_apoderado.Text=entity.ciudadania_apoderado;
            ocupacion_apoderado.Text=entity.ocupacion_apoderado;

            direccion_particular_apoderado.Text=entity.direccion_particular_apoderado;
            carne_pasaporte_apoderado.Text=entity.carne_pasaporte_apoderado;

            condicion_migratoria_apoderado.Text=entity.condicion_migratoria_apoderado;

            nombre_contrallente.Text=entity.nombre_contrallente;
            sexo_contrallente.Text=entity.sexo_contrallente;

            lugar_nacimiento_municipio_contrallente.Text=entity.lugar_nacimiento_municipio_contrallente;
            lugar_nacimiento_provincia_contrallente.Text=entity.lugar_nacimiento_provincia_contrallente;

            fecha_nacimineto_contrallente.Text=entity.fecha_nacimineto_contrallente;
            estado_civil_contrallente.Text=entity.estado_civil_contrallente;

            ciudadania_contrallente.Text=entity.ciudadania_contrallente;
            ocupacion_contrallente.Text=entity.ocupacion_contrallente;

            direccion_particular_contrallente.Text=entity.direccion_particular_contrallente;
            carne_pasaporte_contrallente.Text=entity.carne_pasaporte_contrallente;

            padres_contrallente.Text=entity.padres_contrallente;

            nivel_escolaridad_contrallente.Text=entity.nivel_escolaridad_contrallente;

            condicion_migratoria_contrallente.Text=entity.condicion_migratoria_contrallente;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo25());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo25_e()
            {
                id=entity.id,
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd")),
                nombre_poderante=ValidarCampo(nombre_poderante.Text),
                sexo_poderante=ValidarCampo(sexo_poderante.Text),
                lugar_nacimiento_municipio_poderante=ValidarCampo(lugar_nacimiento_municipio_poderante.Text),
                lugar_nacimiento_provincia_poderante=ValidarCampo(lugar_nacimiento_provincia_poderante.Text),
                fecha_nacimineto_poderante=ValidarCampo(fecha_nacimineto_poderante.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil_poderante=ValidarCampo(estado_civil_poderante.Text),
                ciudadania_poderante=ValidarCampo(ciudadania_poderante.Text),
                ocupacion_poderante=ValidarCampo(ocupacion_poderante.Text),
                direccion_particular_poderante=ValidarCampo(direccion_particular_poderante.Text),
                carne_pasaporte_poderante=ValidarCampo(carne_pasaporte_poderante.Text),
                condicion_migratoria_poderante=ValidarCampo(condicion_migratoria_poderante.Text),
                correo_poderante=ValidarCampo(correo_poderante.Text),
                celular_poderante=ValidarCampo(celular_poderante.Text),

                nombre_apoderado=ValidarCampo(nombre_apoderado.Text),
                sexo_apoderado=ValidarCampo(sexo_apoderado.Text),
                lugar_nacimiento_municipio_apoderado=ValidarCampo(lugar_nacimiento_municipio_apoderado.Text),
                lugar_nacimiento_provincia_apoderado=ValidarCampo(lugar_nacimiento_provincia_apoderado.Text),
                fecha_nacimineto_apoderado=ValidarCampo(fecha_nacimineto_apoderado.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil_apoderado=ValidarCampo(estado_civil_apoderado.Text),
                ciudadania_apoderado=ValidarCampo(ciudadania_apoderado.Text),
                ocupacion_apoderado=ValidarCampo(ocupacion_apoderado.Text),
                direccion_particular_apoderado=ValidarCampo(direccion_particular_apoderado.Text),
                carne_pasaporte_apoderado=ValidarCampo(carne_pasaporte_apoderado.Text),
                condicion_migratoria_apoderado=ValidarCampo(condicion_migratoria_apoderado.Text),

                nombre_contrallente=ValidarCampo(nombre_contrallente.Text),
                sexo_contrallente=ValidarCampo(sexo_contrallente.Text),
                lugar_nacimiento_municipio_contrallente=ValidarCampo(lugar_nacimiento_municipio_contrallente.Text),
                lugar_nacimiento_provincia_contrallente=ValidarCampo(lugar_nacimiento_provincia_contrallente.Text),
                fecha_nacimineto_contrallente=ValidarCampo(fecha_nacimineto_contrallente.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil_contrallente=ValidarCampo(estado_civil_contrallente.Text),
                ciudadania_contrallente=ValidarCampo(ciudadania_contrallente.Text),
                ocupacion_contrallente=ValidarCampo(ocupacion_contrallente.Text),
                direccion_particular_contrallente=ValidarCampo(direccion_particular_contrallente.Text),
                carne_pasaporte_contrallente=ValidarCampo(carne_pasaporte_contrallente.Text),

                padres_contrallente=ValidarCampo(padres_contrallente.Text),
                nivel_escolaridad_contrallente=ValidarCampo(nivel_escolaridad_contrallente.Text),
                condicion_migratoria_contrallente=ValidarCampo(condicion_migratoria_contrallente.Text)
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

        public bool ValidarAnexo( model.Anexo25_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.fecha_solicitud)||
            //    string.IsNullOrEmpty(model.nombre_poderante)||
            //    string.IsNullOrEmpty(model.sexo_poderante)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_municipio_poderante)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_provincia_poderante)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto_poderante)||
            //    string.IsNullOrEmpty(model.estado_civil_poderante)||
            //    string.IsNullOrEmpty(model.ciudadania_poderante)||
            //    string.IsNullOrEmpty(model.ocupacion_poderante)||
            //    string.IsNullOrEmpty(model.direccion_particular_poderante)||
            //    string.IsNullOrEmpty(model.carne_pasaporte_poderante)||
            //    string.IsNullOrEmpty(model.condicion_migratoria_poderante)||
            //    string.IsNullOrEmpty(model.correo_poderante)||
            //    string.IsNullOrEmpty(model.celular_poderante)||
            //    string.IsNullOrEmpty(model.nombre_apoderado)||
            //    string.IsNullOrEmpty(model.sexo_apoderado)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_municipio_apoderado)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_provincia_apoderado)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto_apoderado)||
            //    string.IsNullOrEmpty(model.estado_civil_apoderado)||
            //    string.IsNullOrEmpty(model.ciudadania_apoderado)||
            //    string.IsNullOrEmpty(model.ocupacion_apoderado)||
            //    string.IsNullOrEmpty(model.direccion_particular_apoderado)||
            //    string.IsNullOrEmpty(model.carne_pasaporte_apoderado)||
            //    string.IsNullOrEmpty(model.condicion_migratoria_apoderado)||
            //    string.IsNullOrEmpty(model.nombre_contrallente)||
            //    string.IsNullOrEmpty(model.sexo_contrallente)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_municipio_contrallente)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_provincia_contrallente)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto_contrallente)||
            //    string.IsNullOrEmpty(model.estado_civil_contrallente)||
            //    string.IsNullOrEmpty(model.ciudadania_contrallente)||
            //    string.IsNullOrEmpty(model.ocupacion_contrallente)||
            //    string.IsNullOrEmpty(model.direccion_particular_contrallente)||
            //    string.IsNullOrEmpty(model.carne_pasaporte_contrallente)||
            //    string.IsNullOrEmpty(model.padres_contrallente)||
            //    string.IsNullOrEmpty(model.nivel_escolaridad_contrallente)||
            //    string.IsNullOrEmpty(model.condicion_migratoria_contrallente))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo25_e es válida
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
