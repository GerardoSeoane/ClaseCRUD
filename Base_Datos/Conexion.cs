using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Base_Datos
{
    public class Conexion
    {
        private NpgsqlConnection Con = new NpgsqlConnection("Host=127.0.0.1;Port=5432;Database=cursocsharp;User id = postgres; Password=12345");

        public bool Conectar()
        {
            try
            {
                Con.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public bool Desconectar()
        {
            try
            {
                Con.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public DataTable MostrarDatos()
        {
            DataTable Tablita = new DataTable();
            string Query = "select * from personas";
            NpgsqlDataAdapter GuardarDatos = new NpgsqlDataAdapter(Query, Con);
            GuardarDatos.Fill(Tablita);
            return Tablita;
        }
    }
}
