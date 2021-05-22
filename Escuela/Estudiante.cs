using System;
using System.Collections.Generic;
using System.Text;


namespace Escuela
{
	class Estudiante
		
	{
		#region Atributos

		private int id;
		private string matricula;
		string nombre;
		string gradoGrupo;
		bool estatus;

		#endregion

		#region Propiedades

		public int Id { get; }
        public string Matricula { get; }
        public string Nombre { get; set; }
        public string GradoGrupo { get; set; }
        public bool Estatus { get; set; }

		#endregion


		#region Metodos

		public string Registrar()
		{
			//regristro en la BD
			string resp = "Alumno Registrado";
			return resp;
		}
		

		public string DarDeBaja(string motivo = "")
        {
			this.Estatus = false;
			//editar en la base de datos, agregar motivo
			string respuesta = "";
			//condicion 
			if(motivo != "")
            {
				respuesta = "Alumno dado de baja. Motivo: " + motivo;
			}
			else
            { 
				respuesta = "Alumno dado de baja";
			}
			 

			return respuesta;
		}

		/*
		 * cvUsuario = clave de usuario
		 * pwd = contraseña
		 */
		/*
		 * sobre carga del metodo DarDeBaja
		 */
		public void DarDeBaja(string cvUsuario, string pwd, string motivo)
        {
			/*
			 * consultar que el usuario cuente con los permisos requeridos 
			 * con un metodo verificar usuario donde se ´pasan ls parametros 
			 * cvUsuario y pwd
			*/
			/*si el usuario es correcto  : 
			 * eliminar  el registro del estudiante
			 * guardar moviemientop en un log
			 */

			
		}
		#endregion



		#region Constructor

		public Estudiante(string nombre, string gradoGrupo)
        {
			this.nombre = nombre; 
			GradoGrupo = gradoGrupo;
		}
		/*
		 * sobre carga de un contructor Estudiante	  
		 */
		public Estudiante(bool estatus)
        {
            Estatus = estatus;
            Nombre = "";
        }


		#endregion


	}

}
