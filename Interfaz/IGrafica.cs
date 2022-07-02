using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Interfaz
{
    class IGrafica
    {
        static void Main(string[] args)
        {
            Validar valido = new Validar();
            string Respuesta1 = valido.ValCon();
            Console.WriteLine(Respuesta1);
            List<EntPersonas> Lista = valido.MostrarDatos();
            foreach (EntPersonas Valor in Lista)
            {
                Console.WriteLine($"{Valor.id} | {Valor.Nombre} | {Valor.Edad} | {Valor.Nacionalidad}");
            }
            string Respuesta2 = valido.ValDes();
            Console.WriteLine(Respuesta2);
            Console.ReadKey();
        }
    }
}
