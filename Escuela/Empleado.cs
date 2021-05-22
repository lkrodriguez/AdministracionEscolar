using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela
{
	/*
	 * el  atributo FrecuenPago indica cada cuanto va ser su pago
	 * y este atributo se define como un enum
	 * y es accesible cualquier clase que pertenesca
	 */
	public enum FrecuenciaPago
	{ 
		Quincenal,
		Mensual,
		Bimestral

	}
	public class Empleado<Tipo>
	{
		#region Atributos
		private Tipo id;
		private string nombre;
		private bool activo;
		private int edad;
		private string nacionalidad;
		private decimal pago;

		#endregion

		#region Propiedades
		public Tipo Id {get; set; }
		
		public string Nombre
		{
			get 
			{
				return nombre;
			}
			/*
			 * el descriptor de acceso SET	permite la 
			 * midificacion el valor del atributo 
			 */
			set
			{
				this.nombre = value;
			}
		}
		/*
		 * esta es la forma abreviada
		 */
		public bool Activo { get; set; }

		public int Edad { get; set; }

		public string Nacionalidad { get; set; }

		public string Pago { get; }
		/*
		 * pago solo se podra consultar
		 */



		#endregion


		#region Metodos
		public void CalcularPago()
		{ 

		}
        #endregion


		#region Constructor

		public Empleado()
        {
			this.Activo = true;
		}
		/*
		 * sobre carga del Contructor Empleado
		 * su funcion es inicializar los atributos de un objeto
		 */
		public Empleado(string Nombre)
        {
			Nombre = nombre;
			this.Activo = true;
		}


		#endregion



    }
}
