using System;

namespace Escuela
{
	class MiClasePrueba
    {
		protected int pruebaA;
	}
	class Program
	{
		public static void ImprimirMensajePantalla(string mensaje, bool guardar =false )
		{
			Console.Write("Respeusta  del Sistema:");
			Console.WriteLine(mensaje);
			if(guardar )
            { 
				//Guardar en bd  el mensaje 
				// bool guardar este parametro indica que debe recibirlo 
			}
		}

		static void Main(string[] args)
		{
			Console.Title =  "Sistemas de Administracion Escolar";

			#region Profesor
			Profesor<int> profInterno = new Profesor<int>();
			string resp = profInterno.Checar();
			/*
			 * para invocar el metodo se coloca el nombre en este caso CHECAR
			 * y se recibe la respuesta del metodo Checar y se almacena en la variable resp 
			 */

			Profesor<string> profExterno = new Profesor<string>();

			#endregion


			#region Estudiante
			string nombreEstudiante = "karen" ;
			string gradoGrupo = "4a" ;
			Estudiante estudiante = new Estudiante(nombreEstudiante, gradoGrupo);
			//estudiante = null;
			bool estatusEstudiante =true;
			Estudiante estudianteB = new Estudiante(estatusEstudiante);
			#endregion

			//Program  miProgram = new Program;

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
