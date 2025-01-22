using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo14_m
    {
        private SQLiteConnection connection;

        public Anexo14_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo14_e anexo14_e)
        {
            string[] columns = new string[] { "quien_suscribe", "nombre_contrayente", "ciudadania_contrayente", "primer_apellido_contrayente", "segundo_apellido_contrayente", "registro_civil_contrayente", "tomo_contrayente", "folio_contrayente", "lugar_nacimiento_contrayente", "fecha_nacimiento_contrayente", "nro_pasaporte_identidad_contrayente", "estado_civil_antes_matrimonio_contrayente", "ocupacion_contrayente", "padre_contrayente", "madre_contrayente", "domicilio_contrayente", "nombre_la_contrayente", "ciudadania_la_contrayente", "primer_apellido_la_contrayente", "segundo_apellido_la_contrayente", "registro_civil_la_contrayente", "tomo_la_contrayente", "folio_la_contrayente", "lugar_nacimiento_la_contrayente", "fecha_nacimiento_la_contrayente", "nro_pasaporte_identidad_la_contrayente", "estado_civil_antes_matrimonio_la_contrayente", "ocupacion_la_contrayente", "padre_la_contrayente", "madre_la_contrayente", "domicilio_la_contrayente", "observaciones_la_contrayente", "lugar_certificado", "tomo_certificado", "folio_certificado", "fecha_formalizacion", "nombre_funcionario_expidió_certificado", "cargo_funcionario_expidió_certificado", "fecha_solicitud" };
            object[] values = new object[] { anexo14_e.quien_suscribe, anexo14_e.nombre_contrayente, anexo14_e.ciudadania_contrayente, anexo14_e.primer_apellido_contrayente, anexo14_e.segundo_apellido_contrayente, anexo14_e.registro_civil_contrayente, anexo14_e.tomo_contrayente, anexo14_e.folio_contrayente, anexo14_e.lugar_nacimiento_contrayente, anexo14_e.fecha_nacimiento_contrayente, anexo14_e.nro_pasaporte_identidad_contrayente, anexo14_e.estado_civil_antes_matrimonio_contrayente, anexo14_e.ocupacion_contrayente, anexo14_e.padre_contrayente, anexo14_e.madre_contrayente, anexo14_e.domicilio_contrayente, anexo14_e.nombre_la_contrayente, anexo14_e.ciudadania_la_contrayente, anexo14_e.primer_apellido_la_contrayente, anexo14_e.segundo_apellido_la_contrayente, anexo14_e.registro_civil_la_contrayente, anexo14_e.tomo_la_contrayente, anexo14_e.folio_la_contrayente, anexo14_e.lugar_nacimiento_la_contrayente, anexo14_e.fecha_nacimiento_la_contrayente, anexo14_e.nro_pasaporte_identidad_la_contrayente, anexo14_e.estado_civil_antes_matrimonio_la_contrayente, anexo14_e.ocupacion_la_contrayente, anexo14_e.padre_la_contrayente, anexo14_e.madre_la_contrayente, anexo14_e.domicilio_la_contrayente, anexo14_e.observaciones_la_contrayente, anexo14_e.lugar_certificado, anexo14_e.tomo_certificado, anexo14_e.folio_certificado, anexo14_e.fecha_formalizacion, anexo14_e.nombre_funcionario_expidió_certificado, anexo14_e.cargo_funcionario_expidió_certificado, anexo14_e.fecha_solicitud };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo14 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo14_e anexo14_e)
        {
            string[] columns = new string[] { "quien_suscribe", "nombre_contrayente", "ciudadania_contrayente", "primer_apellido_contrayente", "segundo_apellido_contrayente", "registro_civil_contrayente", "tomo_contrayente", "folio_contrayente", "lugar_nacimiento_contrayente", "fecha_nacimiento_contrayente", "nro_pasaporte_identidad_contrayente", "estado_civil_antes_matrimonio_contrayente", "ocupacion_contrayente", "padre_contrayente", "madre_contrayente", "domicilio_contrayente", "nombre_la_contrayente", "ciudadania_la_contrayente", "primer_apellido_la_contrayente", "segundo_apellido_la_contrayente", "registro_civil_la_contrayente", "tomo_la_contrayente", "folio_la_contrayente", "lugar_nacimiento_la_contrayente", "fecha_nacimiento_la_contrayente", "nro_pasaporte_identidad_la_contrayente", "estado_civil_antes_matrimonio_la_contrayente", "ocupacion_la_contrayente", "padre_la_contrayente", "madre_la_contrayente", "domicilio_la_contrayente", "observaciones_la_contrayente", "lugar_certificado", "tomo_certificado", "folio_certificado", "fecha_formalizacion", "nombre_funcionario_expidió_certificado", "cargo_funcionario_expidió_certificado", "fecha_solicitud" };
            object[] values = new object[] { anexo14_e.quien_suscribe, anexo14_e.nombre_contrayente, anexo14_e.ciudadania_contrayente, anexo14_e.primer_apellido_contrayente, anexo14_e.segundo_apellido_contrayente, anexo14_e.registro_civil_contrayente, anexo14_e.tomo_contrayente, anexo14_e.folio_contrayente, anexo14_e.lugar_nacimiento_contrayente, anexo14_e.fecha_nacimiento_contrayente, anexo14_e.nro_pasaporte_identidad_contrayente, anexo14_e.estado_civil_antes_matrimonio_contrayente, anexo14_e.ocupacion_contrayente, anexo14_e.padre_contrayente, anexo14_e.madre_contrayente, anexo14_e.domicilio_contrayente, anexo14_e.nombre_la_contrayente, anexo14_e.ciudadania_la_contrayente, anexo14_e.primer_apellido_la_contrayente, anexo14_e.segundo_apellido_la_contrayente, anexo14_e.registro_civil_la_contrayente, anexo14_e.tomo_la_contrayente, anexo14_e.folio_la_contrayente, anexo14_e.lugar_nacimiento_la_contrayente, anexo14_e.fecha_nacimiento_la_contrayente, anexo14_e.nro_pasaporte_identidad_la_contrayente, anexo14_e.estado_civil_antes_matrimonio_la_contrayente, anexo14_e.ocupacion_la_contrayente, anexo14_e.padre_la_contrayente, anexo14_e.madre_la_contrayente, anexo14_e.domicilio_la_contrayente, anexo14_e.observaciones_la_contrayente, anexo14_e.lugar_certificado, anexo14_e.tomo_certificado, anexo14_e.folio_certificado, anexo14_e.fecha_formalizacion, anexo14_e.nombre_funcionario_expidió_certificado, anexo14_e.cargo_funcionario_expidió_certificado, anexo14_e.fecha_solicitud };

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

            sqlite_cmd.CommandText = $"UPDATE anexo14 SET {data} WHERE id = {anexo14_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo14 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo14_e> list()
        {
            List<Anexo14_e> list = new List<Anexo14_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo14";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo14_e anexo14_e = new Anexo14_e();
                anexo14_e.id = sqlite_datareader.GetInt32(0);
                anexo14_e.quien_suscribe = sqlite_datareader.GetString(1);
                anexo14_e.nombre_contrayente = sqlite_datareader.GetString(2);
                anexo14_e.ciudadania_contrayente = sqlite_datareader.GetString(3);
                anexo14_e.primer_apellido_contrayente = sqlite_datareader.GetString(4);
                anexo14_e.segundo_apellido_contrayente = sqlite_datareader.GetString(5);
                anexo14_e.registro_civil_contrayente = sqlite_datareader.GetString(6);
                anexo14_e.tomo_contrayente = sqlite_datareader.GetString(7);
                anexo14_e.folio_contrayente = sqlite_datareader.GetString(8);
                anexo14_e.lugar_nacimiento_contrayente = sqlite_datareader.GetString(9);
                anexo14_e.fecha_nacimiento_contrayente = sqlite_datareader.GetString(10);
                anexo14_e.nro_pasaporte_identidad_contrayente = sqlite_datareader.GetString(11);
                anexo14_e.estado_civil_antes_matrimonio_contrayente = sqlite_datareader.GetString(12);
                anexo14_e.ocupacion_contrayente = sqlite_datareader.GetString(13);
                anexo14_e.padre_contrayente = sqlite_datareader.GetString(14);
                anexo14_e.madre_contrayente = sqlite_datareader.GetString(15);
                anexo14_e.domicilio_contrayente = sqlite_datareader.GetString(16);
                anexo14_e.nombre_la_contrayente = sqlite_datareader.GetString(17);
                anexo14_e.ciudadania_la_contrayente = sqlite_datareader.GetString(18);
                anexo14_e.primer_apellido_la_contrayente = sqlite_datareader.GetString(19);
                anexo14_e.segundo_apellido_la_contrayente = sqlite_datareader.GetString(20);
                anexo14_e.registro_civil_la_contrayente = sqlite_datareader.GetString(21);
                anexo14_e.tomo_la_contrayente = sqlite_datareader.GetString(22);
                anexo14_e.folio_la_contrayente = sqlite_datareader.GetString(23);
                anexo14_e.lugar_nacimiento_la_contrayente = sqlite_datareader.GetString(24);
                anexo14_e.fecha_nacimiento_la_contrayente = sqlite_datareader.GetString(25);
                anexo14_e.nro_pasaporte_identidad_la_contrayente = sqlite_datareader.GetString(26);
                anexo14_e.estado_civil_antes_matrimonio_la_contrayente = sqlite_datareader.GetString(27);
                anexo14_e.ocupacion_la_contrayente = sqlite_datareader.GetString(28);
                anexo14_e.padre_la_contrayente = sqlite_datareader.GetString(29);
                anexo14_e.madre_la_contrayente = sqlite_datareader.GetString(30);
                anexo14_e.domicilio_la_contrayente = sqlite_datareader.GetString(31);
                anexo14_e.observaciones_la_contrayente = sqlite_datareader.GetString(32);
                anexo14_e.lugar_certificado = sqlite_datareader.GetString(33);
                anexo14_e.tomo_certificado = sqlite_datareader.GetString(34);
                anexo14_e.folio_certificado = sqlite_datareader.GetString(35);
                anexo14_e.fecha_formalizacion = sqlite_datareader.GetString(36);
                anexo14_e.nombre_funcionario_expidió_certificado = sqlite_datareader.GetString(37);
                anexo14_e.cargo_funcionario_expidió_certificado = sqlite_datareader.GetString(38);
                anexo14_e.fecha_solicitud = sqlite_datareader.GetString(39);
                list.Add(anexo14_e);
            }
            
            return list;
        }
    }
}