using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela
{   /*
     * cuando se crea una clase abstract no se puede crear instancias de la misma
     */
	abstract class Materia
	{
		#region Atributos
	 	private string clave;
		private string nombre;
        //private Profesor coordinador;
        /*se crea atributo Profesor con nombre porfesor utilizando la clase Profesor*/
        #endregion


        #region Propiedades
        public string Clave { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Metodos
        public abstract decimal  Evaluar();
        
        #endregion 

    }





}
