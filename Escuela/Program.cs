using System;

namespace Escuela
{
	class Program
	{
		public static void ImprimirMensajePantalla(string mensaje)
		{
			Console.Write("Respeusta  del Sistema:");
			Console.WriteLine(mensaje);
		}

		static void Main(string[] args)
		{
			Console.Title =  "Sistemas de Administracion Escolar";
			Profesor prof = new Profesor();
			string resp = prof.Checar();
			/*
			 * para invocar el metodo se coloca el nombre en este caso CHECAR
			 * y se recibe la respuesta del metodo Checar y se almacena en la variable resp 
			 */
			ImprimirMensajePantalla(resp);
			/*
			 * para imprimir el metodo en pantalla
			 * se pasa la variable resp como parametro en ImprimirMensajePantalla
			 */

			Console.WriteLine("Presiona 0 para mostrar mensaje de prueba");
			int x = Int32.Parse(Console.ReadLine());
			if (x == 0)
			{
				ImprimirMensajePantalla("Mensaje de Prueba");
			}
			Console.ReadKey();
			//Profesor nuevoProfesor = new Profesor();
			//nuevoProfesor.id = 0 ;
		}

		/*
		#region Propiedades
		public {get; set;}
		public {get; set;}
		#endregion*/
	}
}
