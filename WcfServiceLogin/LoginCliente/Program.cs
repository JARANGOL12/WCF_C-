using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = string.Empty, password = string.Empty;
            ServiceReferenceLogin.IloginServiceClient objClient = new ServiceReferenceLogin.IloginServiceClient();
            Console.WriteLine("Ingresar Usuario");
            user = Console.ReadLine();
            Console.WriteLine("Ingresar Password");
            password = Console.ReadLine();

            if (objClient.validateLogin(user, password))
{
                Console.WriteLine("Conexion Exitosa");

            }
          else
            {
                Console.WriteLine("La conexion es Fallida");
            }
            Console.ReadKey();

        }
    }
}
