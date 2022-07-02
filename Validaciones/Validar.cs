using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Datos;

namespace Validaciones
{
    public class Validar
    {
        Conexion con = new Conexion();

        public string ValCon()
        {
            bool Respuesta = con.Conectar();

            if (Respuesta==true)
            {
                return "Conexion exitosa";
            }
            else
            {
                return "Conexion fallida";
            }
        }

        public string ValDes()
        {
            bool respuesta2 = con.Desconectar();
            if (respuesta2==true)
            {
                return "Desconexion exitosa";
            }
            else
            {
                return "Desconexion fallida";
            }
        }

        public List<EntPersonas> MostrarDatos()
        {
            try
            {
                List<EntPersonas> Lista = new List<EntPersonas>();
                DataTable Tablita = con.MostrarDatos();

                foreach (DataRow Valor in Tablita.Rows)
                {
                    EntPersonas P = new EntPersonas();
                    P.id = Convert.ToInt32(Valor["id"]);
                    P.Nombre = Valor["nombre"].ToString();
                    P.Edad = Convert.ToInt32(Valor["edad"]);
                    P.Nacionalidad = Valor["nacionalidad"].ToString();
                    Lista.Add(P);
                }
                return Lista;
            }
            catch (Exception)
            {

                return new List<EntPersonas>();
            }
        }
    }
}
