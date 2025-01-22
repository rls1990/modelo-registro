using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo4_m
    {
        private SQLiteConnection connection;

        public Anexo4_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo4_e anexo4_e)
        {
            string[] columns = new string[] { "ciudad", "pais", "f_name", "s_name", "f_apellido", "s_apellido", "lugar_nacimiento", "ciudadania", "nacionalidad", "estado_civil", "fecha_nacimiento", "sexo", "color_piel", "profecion_oficio_ocupacion", "nombre_padre", "nombre_madre", "carnet_identidad", "pasaporte", "calle", "numero", "entre", "y", "barrio", "municipio", "provincia", "legalizacion_minred", "legalizacion_embajada", "fecha_solicitud" };
            object[] values = new object[] { anexo4_e.ciudad, anexo4_e.pais, anexo4_e.f_name, anexo4_e.s_name, anexo4_e.f_apellido, anexo4_e.s_apellido, anexo4_e.lugar_nacimiento, anexo4_e.ciudadania, anexo4_e.nacionalidad, anexo4_e.estado_civil, anexo4_e.fecha_nacimiento, anexo4_e.sexo, anexo4_e.color_piel, anexo4_e.profecion_oficio_ocupacion, anexo4_e.nombre_padre, anexo4_e.nombre_madre, anexo4_e.carnet_identidad, anexo4_e.pasaporte, anexo4_e.calle, anexo4_e.numero, anexo4_e.entre, anexo4_e.y, anexo4_e.barrio, anexo4_e.municipio, anexo4_e.provincia, anexo4_e.legalizacion_minred, anexo4_e.legalizacion_embajada, anexo4_e.fecha_solicitud };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo4 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo4_e anexo4_e)
        {
            string[] columns = new string[] { "ciudad", "pais", "f_name", "s_name", "f_apellido", "s_apellido", "lugar_nacimiento", "ciudadania", "nacionalidad", "estado_civil", "fecha_nacimiento", "sexo", "color_piel", "profecion_oficio_ocupacion", "nombre_padre", "nombre_madre", "carnet_identidad", "pasaporte", "calle", "numero", "entre", "y", "barrio", "municipio", "provincia", "legalizacion_minred", "legalizacion_embajada", "fecha_solicitud" };
            object[] values = new object[] { anexo4_e.ciudad, anexo4_e.pais, anexo4_e.f_name, anexo4_e.s_name, anexo4_e.f_apellido, anexo4_e.s_apellido, anexo4_e.lugar_nacimiento, anexo4_e.ciudadania, anexo4_e.nacionalidad, anexo4_e.estado_civil, anexo4_e.fecha_nacimiento, anexo4_e.sexo, anexo4_e.color_piel, anexo4_e.profecion_oficio_ocupacion, anexo4_e.nombre_padre, anexo4_e.nombre_madre, anexo4_e.carnet_identidad, anexo4_e.pasaporte, anexo4_e.calle, anexo4_e.numero, anexo4_e.entre, anexo4_e.y, anexo4_e.barrio, anexo4_e.municipio, anexo4_e.provincia, anexo4_e.legalizacion_minred, anexo4_e.legalizacion_embajada, anexo4_e.fecha_solicitud };

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

            sqlite_cmd.CommandText = $"UPDATE anexo4 SET {data} WHERE id = {anexo4_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo4 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo4_e> list()
        {
            List<Anexo4_e> list = new List<Anexo4_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo4";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo4_e anexo4_e = new Anexo4_e();
                anexo4_e.id = sqlite_datareader.GetInt32(0);
                anexo4_e.ciudad = sqlite_datareader.GetString(1);
                anexo4_e.pais = sqlite_datareader.GetString(2);
                anexo4_e.f_name = sqlite_datareader.GetString(3);
                anexo4_e.s_name = sqlite_datareader.GetString(4);
                anexo4_e.f_apellido = sqlite_datareader.GetString(5);
                anexo4_e.s_apellido = sqlite_datareader.GetString(6);
                anexo4_e.lugar_nacimiento = sqlite_datareader.GetString(7);
                anexo4_e.ciudadania = sqlite_datareader.GetString(8);
                anexo4_e.nacionalidad = sqlite_datareader.GetString(9);
                anexo4_e.estado_civil = sqlite_datareader.GetString(10);
                anexo4_e.fecha_nacimiento = sqlite_datareader.GetString(11);
                anexo4_e.sexo = sqlite_datareader.GetString(12);
                anexo4_e.color_piel = sqlite_datareader.GetString(13);
                anexo4_e.profecion_oficio_ocupacion = sqlite_datareader.GetString(14);
                anexo4_e.nombre_padre = sqlite_datareader.GetString(15);
                anexo4_e.nombre_madre = sqlite_datareader.GetString(16);
                anexo4_e.carnet_identidad = sqlite_datareader.GetString(17);
                anexo4_e.pasaporte = sqlite_datareader.GetString(18);
                anexo4_e.calle = sqlite_datareader.GetString(19);
                anexo4_e.numero = sqlite_datareader.GetString(20);
                anexo4_e.entre = sqlite_datareader.GetString(21);
                anexo4_e.y = sqlite_datareader.GetString(22);
                anexo4_e.barrio = sqlite_datareader.GetString(23);
                anexo4_e.municipio = sqlite_datareader.GetString(24);
                anexo4_e.provincia = sqlite_datareader.GetString(25);
                anexo4_e.legalizacion_minred = sqlite_datareader.GetString(26);
                anexo4_e.legalizacion_embajada = sqlite_datareader.GetString(27);
                anexo4_e.fecha_solicitud = sqlite_datareader.GetString(28);
                list.Add(anexo4_e);
            }
            
            return list;
        }
    }
}