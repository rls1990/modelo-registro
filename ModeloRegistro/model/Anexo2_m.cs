using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo2_m
    {
        private SQLiteConnection connection;

        public Anexo2_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo2_e anexo2_e)
        {
            string[] columns = new string[] { "pasaporte_1ra_vez", "prorrogas", "he_1", "he_4", "dvt", "renovacion_pasaporte", "habilitacion_de_entrada", "he_3", "he_11", "ccv", "fecha_de_solicitud", "no_pasaporte", "carnet", "primer_apellido", "segundo_apellido", "primer_nombre", "segundo_nombre", "padre", "madre", "caracteristicas_especiales", "estatura", "estado_civil", "sexo", "color_ojos", "color_piel", "color_cabello", "permiso_emigracion", "residente_en_el_exterior", "asunto_oficial", "pve", "psi", "residencia_exterior", "pre", "pvt", "pre_e", "salida_ilegal", "fecha_de_salida", "pais", "provincia", "municipio_ciudad", "fecha_de_nacimiento", "direccion", "codigo_postal", "provincia_estado_region", "pais_residencia_actual", "telefono_residencia", "fax_residencia", "email_residencia", "nombre_centro_trabajo_estudio", "profesion", "ocupacion", "direccion_centro_estudio_trabajo", "codigo_postal_centro_estudio_trabajo", "provincia_estado_region_centro_estudio_trabajo", "pais_centro_estudio_trabajo", "telefono_centro_estudio_trabajo", "fax_centro_estudio_trabajo", "email_centro_estudio_trabajo", "nivel_de_escolaridad", "ocupacion_centro_estudio_trabajo", "profecion_oficio_centro_estudio_trabajo", "nombre_referencia_cuba", "direccion_referencia_cuba", "direccion1_referencia", "fecha_direccion1_referencia_desde", "fecha_direccion1_referencia_fecha_hasta", "direccion2_referencia", "fecha_direccion2_referencia_desde", "fecha_direccion2_referencia_fecha_hasta", "apellido_soltera_referencia", "otros_nombres_referencia", "numero_residencia_referencia", "pasaporte_extranjero_referencia", "numero_pasaporte_vencido", "fecha_expedicion_pasaporte_vencido", "lugar_pasaporte_vencido", "tomo_certificado_nacimiento", "folio_certificado_nacimiento", "registro_civil_certificado_nacimiento", "numero_inscripcion_consular", "fecha_inscripcion_consular", "arancel_inscripcion_consular", "valoracion_consular" };
            object[] values = new object[] { anexo2_e.pasaporte_1ra_vez, anexo2_e.prorrogas, anexo2_e.he_1, anexo2_e.he_4, anexo2_e.dvt, anexo2_e.renovacion_pasaporte, anexo2_e.habilitacion_de_entrada, anexo2_e.he_3, anexo2_e.he_11, anexo2_e.ccv, anexo2_e.fecha_de_solicitud, anexo2_e.no_pasaporte, anexo2_e.carnet, anexo2_e.primer_apellido, anexo2_e.segundo_apellido, anexo2_e.primer_nombre, anexo2_e.segundo_nombre, anexo2_e.padre, anexo2_e.madre, anexo2_e.caracteristicas_especiales, anexo2_e.estatura, anexo2_e.estado_civil, anexo2_e.sexo, anexo2_e.color_ojos, anexo2_e.color_piel, anexo2_e.color_cabello, anexo2_e.permiso_emigracion, anexo2_e.residente_en_el_exterior, anexo2_e.asunto_oficial, anexo2_e.pve, anexo2_e.psi, anexo2_e.residencia_exterior, anexo2_e.pre, anexo2_e.pvt, anexo2_e.pre_e, anexo2_e.salida_ilegal, anexo2_e.fecha_de_salida, anexo2_e.pais, anexo2_e.provincia, anexo2_e.municipio_ciudad, anexo2_e.fecha_de_nacimiento, anexo2_e.direccion, anexo2_e.codigo_postal, anexo2_e.provincia_estado_region, anexo2_e.pais_residencia_actual, anexo2_e.telefono_residencia, anexo2_e.fax_residencia, anexo2_e.email_residencia, anexo2_e.nombre_centro_trabajo_estudio, anexo2_e.profesion, anexo2_e.ocupacion, anexo2_e.direccion_centro_estudio_trabajo, anexo2_e.codigo_postal_centro_estudio_trabajo, anexo2_e.provincia_estado_region_centro_estudio_trabajo, anexo2_e.pais_centro_estudio_trabajo, anexo2_e.telefono_centro_estudio_trabajo, anexo2_e.fax_centro_estudio_trabajo, anexo2_e.email_centro_estudio_trabajo, anexo2_e.nivel_de_escolaridad, anexo2_e.ocupacion_centro_estudio_trabajo, anexo2_e.profecion_oficio_centro_estudio_trabajo, anexo2_e.nombre_referencia_cuba, anexo2_e.direccion_referencia_cuba, anexo2_e.direccion1_referencia, anexo2_e.fecha_direccion1_referencia_desde, anexo2_e.fecha_direccion1_referencia_fecha_hasta, anexo2_e.direccion2_referencia, anexo2_e.fecha_direccion2_referencia_desde, anexo2_e.fecha_direccion2_referencia_fecha_hasta, anexo2_e.apellido_soltera_referencia, anexo2_e.otros_nombres_referencia, anexo2_e.numero_residencia_referencia, anexo2_e.pasaporte_extranjero_referencia, anexo2_e.numero_pasaporte_vencido, anexo2_e.fecha_expedicion_pasaporte_vencido, anexo2_e.lugar_pasaporte_vencido, anexo2_e.tomo_certificado_nacimiento, anexo2_e.folio_certificado_nacimiento, anexo2_e.registro_civil_certificado_nacimiento, anexo2_e.numero_inscripcion_consular, anexo2_e.fecha_inscripcion_consular, anexo2_e.arancel_inscripcion_consular, anexo2_e.valoracion_consular };

            SQLiteCommand sqlite_cmd = connection.CreateCommand();

            string exp_columns = "(";
            string exp_values = "(";
            for (int i = 0; i < columns.Length; i++)
            {
                if (i + 1 < columns.Length)
                {
                    exp_columns += columns[i] + ",";
                    Type ty = values[i].GetType();
                    string cad = ty.Name;

                    if (cad == "String")
                    {
                        exp_values += $"'{values[i]}', ";
                    }
                    else
                    {
                        exp_values += $"{ values[i]}, ";
                    }
                }
                else
                {
                    exp_columns += columns[i] + ")";
                    Type ty = values[i].GetType();
                    string cad = ty.Name;

                    if (cad == "String")
                    {
                        exp_values += $"'{values[i]}')";
                    }
                    else
                    {
                        exp_values += $"{values[i]})";
                    }
                }
            }

            sqlite_cmd.CommandText = $"INSERT INTO anexo2 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo2_e anexo2_e)
        {
            string[] columns = new string[] { "pasaporte_1ra_vez", "prorrogas", "he_1", "he_4", "dvt", "renovacion_pasaporte", "habilitacion_de_entrada", "he_3", "he_11", "ccv", "fecha_de_solicitud", "no_pasaporte", "carnet", "primer_apellido", "segundo_apellido", "primer_nombre", "segundo_nombre", "padre", "madre", "caracteristicas_especiales", "estatura", "estado_civil", "sexo", "color_ojos", "color_piel", "color_cabello", "permiso_emigracion", "residente_en_el_exterior", "asunto_oficial", "pve", "psi", "residencia_exterior", "pre", "pvt", "pre_e", "salida_ilegal", "fecha_de_salida", "pais", "provincia", "municipio_ciudad", "fecha_de_nacimiento", "direccion", "codigo_postal", "provincia_estado_region", "pais_residencia_actual", "telefono_residencia", "fax_residencia", "email_residencia", "nombre_centro_trabajo_estudio", "profesion", "ocupacion", "direccion_centro_estudio_trabajo", "codigo_postal_centro_estudio_trabajo", "provincia_estado_region_centro_estudio_trabajo", "pais_centro_estudio_trabajo", "telefono_centro_estudio_trabajo", "fax_centro_estudio_trabajo", "email_centro_estudio_trabajo", "nivel_de_escolaridad", "ocupacion_centro_estudio_trabajo", "profecion_oficio_centro_estudio_trabajo", "nombre_referencia_cuba", "direccion_referencia_cuba", "direccion1_referencia", "fecha_direccion1_referencia_desde", "fecha_direccion1_referencia_fecha_hasta", "direccion2_referencia", "fecha_direccion2_referencia_desde", "fecha_direccion2_referencia_fecha_hasta", "apellido_soltera_referencia", "otros_nombres_referencia", "numero_residencia_referencia", "pasaporte_extranjero_referencia", "numero_pasaporte_vencido", "fecha_expedicion_pasaporte_vencido", "lugar_pasaporte_vencido", "tomo_certificado_nacimiento", "folio_certificado_nacimiento", "registro_civil_certificado_nacimiento", "numero_inscripcion_consular", "fecha_inscripcion_consular", "arancel_inscripcion_consular", "valoracion_consular" };
            object[] values = new object[] { anexo2_e.pasaporte_1ra_vez, anexo2_e.prorrogas, anexo2_e.he_1, anexo2_e.he_4, anexo2_e.dvt, anexo2_e.renovacion_pasaporte, anexo2_e.habilitacion_de_entrada, anexo2_e.he_3, anexo2_e.he_11, anexo2_e.ccv, anexo2_e.fecha_de_solicitud, anexo2_e.no_pasaporte, anexo2_e.carnet, anexo2_e.primer_apellido, anexo2_e.segundo_apellido, anexo2_e.primer_nombre, anexo2_e.segundo_nombre, anexo2_e.padre, anexo2_e.madre, anexo2_e.caracteristicas_especiales, anexo2_e.estatura, anexo2_e.estado_civil, anexo2_e.sexo, anexo2_e.color_ojos, anexo2_e.color_piel, anexo2_e.color_cabello, anexo2_e.permiso_emigracion, anexo2_e.residente_en_el_exterior, anexo2_e.asunto_oficial, anexo2_e.pve, anexo2_e.psi, anexo2_e.residencia_exterior, anexo2_e.pre, anexo2_e.pvt, anexo2_e.pre_e, anexo2_e.salida_ilegal, anexo2_e.fecha_de_salida, anexo2_e.pais, anexo2_e.provincia, anexo2_e.municipio_ciudad, anexo2_e.fecha_de_nacimiento, anexo2_e.direccion, anexo2_e.codigo_postal, anexo2_e.provincia_estado_region, anexo2_e.pais_residencia_actual, anexo2_e.telefono_residencia, anexo2_e.fax_residencia, anexo2_e.email_residencia, anexo2_e.nombre_centro_trabajo_estudio, anexo2_e.profesion, anexo2_e.ocupacion, anexo2_e.direccion_centro_estudio_trabajo, anexo2_e.codigo_postal_centro_estudio_trabajo, anexo2_e.provincia_estado_region_centro_estudio_trabajo, anexo2_e.pais_centro_estudio_trabajo, anexo2_e.telefono_centro_estudio_trabajo, anexo2_e.fax_centro_estudio_trabajo, anexo2_e.email_centro_estudio_trabajo, anexo2_e.nivel_de_escolaridad, anexo2_e.ocupacion_centro_estudio_trabajo, anexo2_e.profecion_oficio_centro_estudio_trabajo, anexo2_e.nombre_referencia_cuba, anexo2_e.direccion_referencia_cuba, anexo2_e.direccion1_referencia, anexo2_e.fecha_direccion1_referencia_desde, anexo2_e.fecha_direccion1_referencia_fecha_hasta, anexo2_e.direccion2_referencia, anexo2_e.fecha_direccion2_referencia_desde, anexo2_e.fecha_direccion2_referencia_fecha_hasta, anexo2_e.apellido_soltera_referencia, anexo2_e.otros_nombres_referencia, anexo2_e.numero_residencia_referencia, anexo2_e.pasaporte_extranjero_referencia, anexo2_e.numero_pasaporte_vencido, anexo2_e.fecha_expedicion_pasaporte_vencido, anexo2_e.lugar_pasaporte_vencido, anexo2_e.tomo_certificado_nacimiento, anexo2_e.folio_certificado_nacimiento, anexo2_e.registro_civil_certificado_nacimiento, anexo2_e.numero_inscripcion_consular, anexo2_e.fecha_inscripcion_consular, anexo2_e.arancel_inscripcion_consular, anexo2_e.valoracion_consular };

            SQLiteCommand sqlite_cmd = connection.CreateCommand();

            string data = "";

            for (int i = 0; i < columns.Length; i++)
            {
                if (i + 1 < columns.Length)
                {
                    Type ty = values[i].GetType();
                    string cad = ty.Name;

                    if (cad == "String")
                    {
                        data += $"{columns[i]} = '{values[i]}', ";
                    }
                    else
                    {
                        data += $"{columns[i]} = {values[i]}, ";
                    }
                    }
                else
                {
                    Type ty = values[i].GetType();
                    string cad = ty.Name;

                    if (cad == "String")
                    {
                        data += $"{ columns[i]} = '{values[i]}'";
                    }
                    else
                    {
                        data += $"{columns[i]} = {values[i]}";
                    }
                }
            }

            sqlite_cmd.CommandText = $"UPDATE anexo2 SET {data} WHERE id = {anexo2_e.id}";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void delete(int id)
        {
            SQLiteCommand sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = $"DELETE FROM anexo2 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo2_e> list()
        {
            List<Anexo2_e> list = new List<Anexo2_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo2";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo2_e anexo2_e = new Anexo2_e();
                anexo2_e.id = sqlite_datareader.GetInt32(0);
                anexo2_e.pasaporte_1ra_vez = sqlite_datareader.GetString(1);
                anexo2_e.prorrogas = sqlite_datareader.GetString(2);
                anexo2_e.he_1 = sqlite_datareader.GetString(3);
                anexo2_e.he_4 = sqlite_datareader.GetString(4);
                anexo2_e.dvt = sqlite_datareader.GetString(5);
                anexo2_e.renovacion_pasaporte = sqlite_datareader.GetString(6);
                anexo2_e.habilitacion_de_entrada = sqlite_datareader.GetString(7);
                anexo2_e.he_3 = sqlite_datareader.GetString(8);
                anexo2_e.he_11 = sqlite_datareader.GetString(9);
                anexo2_e.ccv = sqlite_datareader.GetString(10);
                anexo2_e.fecha_de_solicitud = sqlite_datareader.GetString(11);
                anexo2_e.no_pasaporte = sqlite_datareader.GetString(12);
                anexo2_e.carnet = sqlite_datareader.GetString(13);
                anexo2_e.primer_apellido = sqlite_datareader.GetString(14);
                anexo2_e.segundo_apellido = sqlite_datareader.GetString(15);
                anexo2_e.primer_nombre = sqlite_datareader.GetString(16);
                anexo2_e.segundo_nombre = sqlite_datareader.GetString(17);
                anexo2_e.padre = sqlite_datareader.GetString(18);
                anexo2_e.madre = sqlite_datareader.GetString(19);
                anexo2_e.caracteristicas_especiales = sqlite_datareader.GetString(20);
                anexo2_e.estatura = sqlite_datareader.GetString(21);
                anexo2_e.estado_civil = sqlite_datareader.GetString(22);
                anexo2_e.sexo = sqlite_datareader.GetString(23);
                anexo2_e.color_ojos = sqlite_datareader.GetString(24);
                anexo2_e.color_piel = sqlite_datareader.GetString(25);
                anexo2_e.color_cabello = sqlite_datareader.GetString(26);
                anexo2_e.permiso_emigracion = sqlite_datareader.GetString(27);
                anexo2_e.residente_en_el_exterior = sqlite_datareader.GetString(28);
                anexo2_e.asunto_oficial = sqlite_datareader.GetString(29);
                anexo2_e.pve = sqlite_datareader.GetString(30);
                anexo2_e.psi = sqlite_datareader.GetString(31);
                anexo2_e.residencia_exterior = sqlite_datareader.GetString(32);
                anexo2_e.pre = sqlite_datareader.GetString(33);
                anexo2_e.pvt = sqlite_datareader.GetString(34);
                anexo2_e.pre_e = sqlite_datareader.GetString(35);
                anexo2_e.salida_ilegal = sqlite_datareader.GetString(36);
                anexo2_e.fecha_de_salida = sqlite_datareader.GetString(37);
                anexo2_e.pais = sqlite_datareader.GetString(38);
                anexo2_e.provincia = sqlite_datareader.GetString(39);
                anexo2_e.municipio_ciudad = sqlite_datareader.GetString(40);
                anexo2_e.fecha_de_nacimiento = sqlite_datareader.GetString(41);
                anexo2_e.direccion = sqlite_datareader.GetString(42);
                anexo2_e.codigo_postal = sqlite_datareader.GetString(43);
                anexo2_e.provincia_estado_region = sqlite_datareader.GetString(44);
                anexo2_e.pais_residencia_actual = sqlite_datareader.GetString(45);
                anexo2_e.telefono_residencia = sqlite_datareader.GetString(46);
                anexo2_e.fax_residencia = sqlite_datareader.GetString(47);
                anexo2_e.email_residencia = sqlite_datareader.GetString(48);
                anexo2_e.nombre_centro_trabajo_estudio = sqlite_datareader.GetString(49);
                anexo2_e.profesion = sqlite_datareader.GetString(50);
                anexo2_e.ocupacion = sqlite_datareader.GetString(51);
                anexo2_e.direccion_centro_estudio_trabajo = sqlite_datareader.GetString(52);
                anexo2_e.codigo_postal_centro_estudio_trabajo = sqlite_datareader.GetString(53);
                anexo2_e.provincia_estado_region_centro_estudio_trabajo = sqlite_datareader.GetString(54);
                anexo2_e.pais_centro_estudio_trabajo = sqlite_datareader.GetString(55);
                anexo2_e.telefono_centro_estudio_trabajo = sqlite_datareader.GetString(56);
                anexo2_e.fax_centro_estudio_trabajo = sqlite_datareader.GetString(57);
                anexo2_e.email_centro_estudio_trabajo = sqlite_datareader.GetString(58);
                anexo2_e.nivel_de_escolaridad = sqlite_datareader.GetString(59);
                anexo2_e.ocupacion_centro_estudio_trabajo = sqlite_datareader.GetString(60);
                anexo2_e.profecion_oficio_centro_estudio_trabajo = sqlite_datareader.GetString(61);
                anexo2_e.nombre_referencia_cuba = sqlite_datareader.GetString(62);
                anexo2_e.direccion_referencia_cuba = sqlite_datareader.GetString(63);
                anexo2_e.direccion1_referencia = sqlite_datareader.GetString(64);
                anexo2_e.fecha_direccion1_referencia_desde = sqlite_datareader.GetString(65);
                anexo2_e.fecha_direccion1_referencia_fecha_hasta = sqlite_datareader.GetString(66);
                anexo2_e.direccion2_referencia = sqlite_datareader.GetString(67);
                anexo2_e.fecha_direccion2_referencia_desde = sqlite_datareader.GetString(68);
                anexo2_e.fecha_direccion2_referencia_fecha_hasta = sqlite_datareader.GetString(69);
                anexo2_e.apellido_soltera_referencia = sqlite_datareader.GetString(70);
                anexo2_e.otros_nombres_referencia = sqlite_datareader.GetString(71);
                anexo2_e.numero_residencia_referencia = sqlite_datareader.GetString(72);
                anexo2_e.pasaporte_extranjero_referencia = sqlite_datareader.GetString(73);
                anexo2_e.numero_pasaporte_vencido = sqlite_datareader.GetString(74);
                anexo2_e.fecha_expedicion_pasaporte_vencido = sqlite_datareader.GetString(75);
                anexo2_e.lugar_pasaporte_vencido = sqlite_datareader.GetString(76);
                anexo2_e.tomo_certificado_nacimiento = sqlite_datareader.GetString(77);
                anexo2_e.folio_certificado_nacimiento = sqlite_datareader.GetString(78);
                anexo2_e.registro_civil_certificado_nacimiento = sqlite_datareader.GetString(79);
                anexo2_e.numero_inscripcion_consular = sqlite_datareader.GetString(80);
                anexo2_e.fecha_inscripcion_consular = sqlite_datareader.GetString(81);
                anexo2_e.arancel_inscripcion_consular = sqlite_datareader.GetString(82);
                anexo2_e.valoracion_consular = sqlite_datareader.GetString(83);
                list.Add(anexo2_e);
            }
            
            return list;
        }
    }
}