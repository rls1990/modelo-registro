﻿using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo3
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo3_m manager = new model.Anexo3_m(Global.sqlite);
        private model.Anexo3_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo3_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            ciudad.Text=entity.ciudad;
            pais.Text=entity.pais;
            nombre_apellido.Text=entity.nombre_apellido;
            fecha_nacimiento.Text=entity.fecha_nacimiento;
            municipio.Text=entity.municipio;
            provincia.Text=entity.provincia;
            registro.Text=entity.registro;
            municipio_registro.Text=entity.municipio_registro;
            provincia_registro.Text=entity.provincia_registro;
            tomo.Text=entity.tomo;
            folio.Text=entity.folio;
            fecha_asiento.Text=entity.fecha_asiento;
            nombre_padre.Text=entity.nombre_padre;
            nombre_madre.Text=entity.nombre_madre;
            legalizacion_minred.Text=entity.legalizacion_minred;
            legalizacion_embajada.Text=entity.legalizacion_embajada;
            fecha_solicitud.Text=entity.fecha_solicitud;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo3());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo3 = new model.Anexo3_e()
            {
                id=entity.id,
                ciudad=ValidarCampo(ciudad.Text),
                pais=ValidarCampo(pais.Text),
                nombre_apellido=ValidarCampo(nombre_apellido.Text),
                fecha_nacimiento=ValidarCampo(fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                municipio=ValidarCampo(municipio.Text),
                provincia=ValidarCampo(provincia.Text),
                registro=ValidarCampo(registro.Text),
                municipio_registro=ValidarCampo(municipio_registro.Text),
                provincia_registro=ValidarCampo(provincia_registro.Text),
                tomo=ValidarCampo(tomo.Text),
                folio=ValidarCampo(folio.Text),
                fecha_asiento=ValidarCampo(fecha_asiento.SelectedDate?.ToString("yyyy-MM-dd")),
                nombre_padre=ValidarCampo(nombre_padre.Text),
                nombre_madre=ValidarCampo(nombre_madre.Text),
                legalizacion_minred=ValidarCampo(legalizacion_minred.Text),
                legalizacion_embajada=ValidarCampo(legalizacion_embajada.Text),
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
            };

            if(ValidarAnexo(anexo3))
            {
                manager.update(anexo3);
                MessageBox.Show("Anexo 3 guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo3_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.ciudad)||
            //    string.IsNullOrEmpty(model.pais)||
            //    string.IsNullOrEmpty(model.nombre_apellido)||
            //    string.IsNullOrEmpty(model.fecha_nacimiento)||
            //    string.IsNullOrEmpty(model.municipio)||
            //    string.IsNullOrEmpty(model.provincia)||
            //    string.IsNullOrEmpty(model.registro)||
            //    string.IsNullOrEmpty(model.municipio_registro)||
            //    string.IsNullOrEmpty(model.provincia_registro)||
            //    string.IsNullOrEmpty(model.tomo)||
            //    string.IsNullOrEmpty(model.folio)||
            //    string.IsNullOrEmpty(model.fecha_asiento)||
            //    string.IsNullOrEmpty(model.nombre_padre)||
            //    string.IsNullOrEmpty(model.nombre_madre)||
            //    string.IsNullOrEmpty(model.legalizacion_minred)||
            //    string.IsNullOrEmpty(model.legalizacion_embajada)||
            //    string.IsNullOrEmpty(model.fecha_solicitud))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo3_e es válida
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
