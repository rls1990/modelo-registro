using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo21_m
    {
        private SQLiteConnection connection;

        public Anexo21_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo21_e anexo21_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_padre", "ciudadania_padre", "estado_civil_padre", "minicipio_nacimineto_padre", "provincia_nacimineto_padre", "fecha_nacimiento_padre", "profecion_padre", "carnet_pasaporte_padre", "categoria_migratoria_padre", "direccion_eu_padre", "correo", "celular", "nombre_menor", "municipio_nacimiento_menor", "provincia_nacimiento_menor", "fecha_nacimiento_menor", "registro_estado_nacimiento_menor", "tomo", "folio", "tarjeta_menor", "direccion_menor_cuba" };
            object[] values = new object[] { anexo21_e.fecha_solicitud, anexo21_e.nombre_padre, anexo21_e.ciudadania_padre, anexo21_e.estado_civil_padre, anexo21_e.minicipio_nacimineto_padre, anexo21_e.provincia_nacimineto_padre, anexo21_e.fecha_nacimiento_padre, anexo21_e.profecion_padre, anexo21_e.carnet_pasaporte_padre, anexo21_e.categoria_migratoria_padre, anexo21_e.direccion_eu_padre, anexo21_e.correo, anexo21_e.celular, anexo21_e.nombre_menor, anexo21_e.municipio_nacimiento_menor, anexo21_e.provincia_nacimiento_menor, anexo21_e.fecha_nacimiento_menor, anexo21_e.registro_estado_nacimiento_menor, anexo21_e.tomo, anexo21_e.folio, anexo21_e.tarjeta_menor, anexo21_e.direccion_menor_cuba };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo21 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo21_e anexo21_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_padre", "ciudadania_padre", "estado_civil_padre", "minicipio_nacimineto_padre", "provincia_nacimineto_padre", "fecha_nacimiento_padre", "profecion_padre", "carnet_pasaporte_padre", "categoria_migratoria_padre", "direccion_eu_padre", "correo", "celular", "nombre_menor", "municipio_nacimiento_menor", "provincia_nacimiento_menor", "fecha_nacimiento_menor", "registro_estado_nacimiento_menor", "tomo", "folio", "tarjeta_menor", "direccion_menor_cuba" };
            object[] values = new object[] { anexo21_e.fecha_solicitud, anexo21_e.nombre_padre, anexo21_e.ciudadania_padre, anexo21_e.estado_civil_padre, anexo21_e.minicipio_nacimineto_padre, anexo21_e.provincia_nacimineto_padre, anexo21_e.fecha_nacimiento_padre, anexo21_e.profecion_padre, anexo21_e.carnet_pasaporte_padre, anexo21_e.categoria_migratoria_padre, anexo21_e.direccion_eu_padre, anexo21_e.correo, anexo21_e.celular, anexo21_e.nombre_menor, anexo21_e.municipio_nacimiento_menor, anexo21_e.provincia_nacimiento_menor, anexo21_e.fecha_nacimiento_menor, anexo21_e.registro_estado_nacimiento_menor, anexo21_e.tomo, anexo21_e.folio, anexo21_e.tarjeta_menor, anexo21_e.direccion_menor_cuba };

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

            sqlite_cmd.CommandText = $"UPDATE anexo21 SET {data} WHERE id = {anexo21_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo21 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo21_e> list()
        {
            List<Anexo21_e> list = new List<Anexo21_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo21";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo21_e anexo21_e = new Anexo21_e();
                anexo21_e.id = sqlite_datareader.GetInt32(0);
                anexo21_e.fecha_solicitud = sqlite_datareader.GetString(1);
                anexo21_e.nombre_padre = sqlite_datareader.GetString(2);
                anexo21_e.ciudadania_padre = sqlite_datareader.GetString(3);
                anexo21_e.estado_civil_padre = sqlite_datareader.GetString(4);
                anexo21_e.minicipio_nacimineto_padre = sqlite_datareader.GetString(5);
                anexo21_e.provincia_nacimineto_padre = sqlite_datareader.GetString(6);
                anexo21_e.fecha_nacimiento_padre = sqlite_datareader.GetString(7);
                anexo21_e.profecion_padre = sqlite_datareader.GetString(8);
                anexo21_e.carnet_pasaporte_padre = sqlite_datareader.GetString(9);
                anexo21_e.categoria_migratoria_padre = sqlite_datareader.GetString(10);
                anexo21_e.direccion_eu_padre = sqlite_datareader.GetString(11);
                anexo21_e.correo = sqlite_datareader.GetString(12);
                anexo21_e.celular = sqlite_datareader.GetString(13);
                anexo21_e.nombre_menor = sqlite_datareader.GetString(14);
                anexo21_e.municipio_nacimiento_menor = sqlite_datareader.GetString(15);
                anexo21_e.provincia_nacimiento_menor = sqlite_datareader.GetString(16);
                anexo21_e.fecha_nacimiento_menor = sqlite_datareader.GetString(17);
                anexo21_e.registro_estado_nacimiento_menor = sqlite_datareader.GetString(18);
                anexo21_e.tomo = sqlite_datareader.GetString(19);
                anexo21_e.folio = sqlite_datareader.GetString(20);
                anexo21_e.tarjeta_menor = sqlite_datareader.GetString(21);
                anexo21_e.direccion_menor_cuba = sqlite_datareader.GetString(22);
                list.Add(anexo21_e);
            }
            
            return list;
        }
    }
}