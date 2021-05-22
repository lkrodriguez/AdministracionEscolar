using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela
{
	/*
	 * la clase Profesor hereda de la clase Empleado
	 */
	class Profesor<Tipo> : Empleado<Tipo>
	{
		#region Atributos

		private string matricula;
		//private Materia materia;
		/* se crea un atributo Materia con el nombre materia, utilizando la clase Materia */
		private FrecuenciaPago frecPago;

		#endregion


		#region Propiedades

		public string Matricula 
		{
			get
			{
				return matricula + "_2021 ";
			}
			set
            {
				this.matricula = value;

			}
		}
		/*
		 * materia es una propiedad auto implementada 
		 * y asi se evita declarar su atributo
		 */
		public Materia Materia {get; set;}
		#endregion




		#region Metodos
		public string Checar()
		{
			DateTime horaActual = DateTime.Now;
			//guardar la hora en la BD
			string respuesta = "Hora de Regritro" + horaActual;
			return respuesta; 
		}

		public void AsignarMateria(Materia materia)
		{
			Materia = materia;
			/*
			 *Materia es igual a materia que se ha recibido por parametro
			 *AsignarMateria
			 */
		}

		#endregion


		#region Constructor

		public Profesor()
        {
			this.matricula = "_2021 ";
			this.Activo = true;
		}

		#endregion

	}
}
