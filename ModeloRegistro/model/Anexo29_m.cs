using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo29_m
    {
        private SQLiteConnection connection;

        public Anexo29_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo29_e anexo29_e)
        {
            string[] columns = new string[] { "nombre", "sexo", "lugar_nacimineto_municipio", "lugar_nacimineto_provincia", "fecha_nacimineto", "estado_civil", "ciudadania", "ocupacion", "direccion", "carnet_pasaporte", "condicion_migratoria", "correo", "celular", "nombre_apoderado", "sexo_apoderado", "lugar_nacimineto_municipio_apoderado", "lugar_nacimineto_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_apoderado", "carnet_pasaporte_apoderado", "condicion_migratoria_apoderado", "nombre_menor", "natural_de", "fecha_nacimineto_menor", "edad", "tomo", "folio", "registro_estado_civil", "tipo_tramites", "id" };
            object[] values = new object[] { anexo29_e.nombre, anexo29_e.sexo, anexo29_e.lugar_nacimineto_municipio, anexo29_e.lugar_nacimineto_provincia, anexo29_e.fecha_nacimineto, anexo29_e.estado_civil, anexo29_e.ciudadania, anexo29_e.ocupacion, anexo29_e.direccion, anexo29_e.carnet_pasaporte, anexo29_e.condicion_migratoria, anexo29_e.correo, anexo29_e.celular, anexo29_e.nombre_apoderado, anexo29_e.sexo_apoderado, anexo29_e.lugar_nacimineto_municipio_apoderado, anexo29_e.lugar_nacimineto_provincia_apoderado, anexo29_e.fecha_nacimineto_apoderado, anexo29_e.estado_civil_apoderado, anexo29_e.ciudadania_apoderado, anexo29_e.ocupacion_apoderado, anexo29_e.direccion_apoderado, anexo29_e.carnet_pasaporte_apoderado, anexo29_e.condicion_migratoria_apoderado, anexo29_e.nombre_menor, anexo29_e.natural_de, anexo29_e.fecha_nacimineto_menor, anexo29_e.edad, anexo29_e.tomo, anexo29_e.folio, anexo29_e.registro_estado_civil, anexo29_e.tipo_tramites, anexo29_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo29 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo29_e anexo29_e)
        {
            string[] columns = new string[] { "nombre", "sexo", "lugar_nacimineto_municipio", "lugar_nacimineto_provincia", "fecha_nacimineto", "estado_civil", "ciudadania", "ocupacion", "direccion", "carnet_pasaporte", "condicion_migratoria", "correo", "celular", "nombre_apoderado", "sexo_apoderado", "lugar_nacimineto_municipio_apoderado", "lugar_nacimineto_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_apoderado", "carnet_pasaporte_apoderado", "condicion_migratoria_apoderado", "nombre_menor", "natural_de", "fecha_nacimineto_menor", "edad", "tomo", "folio", "registro_estado_civil", "tipo_tramites", "id" };
            object[] values = new object[] { anexo29_e.nombre, anexo29_e.sexo, anexo29_e.lugar_nacimineto_municipio, anexo29_e.lugar_nacimineto_provincia, anexo29_e.fecha_nacimineto, anexo29_e.estado_civil, anexo29_e.ciudadania, anexo29_e.ocupacion, anexo29_e.direccion, anexo29_e.carnet_pasaporte, anexo29_e.condicion_migratoria, anexo29_e.correo, anexo29_e.celular, anexo29_e.nombre_apoderado, anexo29_e.sexo_apoderado, anexo29_e.lugar_nacimineto_municipio_apoderado, anexo29_e.lugar_nacimineto_provincia_apoderado, anexo29_e.fecha_nacimineto_apoderado, anexo29_e.estado_civil_apoderado, anexo29_e.ciudadania_apoderado, anexo29_e.ocupacion_apoderado, anexo29_e.direccion_apoderado, anexo29_e.carnet_pasaporte_apoderado, anexo29_e.condicion_migratoria_apoderado, anexo29_e.nombre_menor, anexo29_e.natural_de, anexo29_e.fecha_nacimineto_menor, anexo29_e.edad, anexo29_e.tomo, anexo29_e.folio, anexo29_e.registro_estado_civil, anexo29_e.tipo_tramites, anexo29_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo29 SET {data} WHERE id = {anexo29_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo29 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo29_e> list()
        {
            List<Anexo29_e> list = new List<Anexo29_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo29";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo29_e anexo29_e = new Anexo29_e();
                anexo29_e.fecha_solicitud = sqlite_datareader.GetString(0);
                anexo29_e.nombre = sqlite_datareader.GetString(1);
                anexo29_e.sexo = sqlite_datareader.GetString(2);
                anexo29_e.lugar_nacimineto_municipio = sqlite_datareader.GetString(3);
                anexo29_e.lugar_nacimineto_provincia = sqlite_datareader.GetString(4);
                anexo29_e.fecha_nacimineto = sqlite_datareader.GetString(5);
                anexo29_e.estado_civil = sqlite_datareader.GetString(6);
                anexo29_e.ciudadania = sqlite_datareader.GetString(7);
                anexo29_e.ocupacion = sqlite_datareader.GetString(8);
                anexo29_e.direccion = sqlite_datareader.GetString(9);
                anexo29_e.carnet_pasaporte = sqlite_datareader.GetString(10);
                anexo29_e.condicion_migratoria = sqlite_datareader.GetString(11);
                anexo29_e.correo = sqlite_datareader.GetString(12);
                anexo29_e.celular = sqlite_datareader.GetString(13);
                anexo29_e.nombre_apoderado = sqlite_datareader.GetString(14);
                anexo29_e.sexo_apoderado = sqlite_datareader.GetString(15);
                anexo29_e.lugar_nacimineto_municipio_apoderado = sqlite_datareader.GetString(16);
                anexo29_e.lugar_nacimineto_provincia_apoderado = sqlite_datareader.GetString(17);
                anexo29_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(18);
                anexo29_e.estado_civil_apoderado = sqlite_datareader.GetString(19);
                anexo29_e.ciudadania_apoderado = sqlite_datareader.GetString(20);
                anexo29_e.ocupacion_apoderado = sqlite_datareader.GetString(21);
                anexo29_e.direccion_apoderado = sqlite_datareader.GetString(22);
                anexo29_e.carnet_pasaporte_apoderado = sqlite_datareader.GetString(23);
                anexo29_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(24);
                anexo29_e.nombre_menor = sqlite_datareader.GetString(25);
                anexo29_e.natural_de = sqlite_datareader.GetString(26);
                anexo29_e.fecha_nacimineto_menor = sqlite_datareader.GetString(27);
                anexo29_e.edad = sqlite_datareader.GetString(28);
                anexo29_e.tomo = sqlite_datareader.GetString(29);
                anexo29_e.folio = sqlite_datareader.GetString(30);
                anexo29_e.registro_estado_civil = sqlite_datareader.GetString(31);
                anexo29_e.tipo_tramites = sqlite_datareader.GetString(32);
                anexo29_e.id = sqlite_datareader.GetInt32(33);
                list.Add(anexo29_e);
            }
            
            return list;
        }
    }
}