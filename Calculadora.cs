using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1
{
    internal class Calculadora
    {
        // ALUMNA: DANIELA AILYN RODRIGUEZ DIAZ
        //tipoDato identificador (nombreVariable)
        //string | bool | int | double | float 1.f
        int sumaNumeroUno = 5;
        int sumaNumeroDos = 10;

        //Miembro de tipo Propiedad
        //public tipoDato NombrePropiedad {} (en PascalCase)
        public int SumaNumeroUno
        {
            get
            {
                return sumaNumeroUno;
            }
            set
            {
                sumaNumeroUno = value; //el value sirve para sustituir por value
                                       //todo lo que encuentre en la propiedad después de un igual
            }
        }
        public int LeerNumeroUno
        {
            //leer
            get
            {
                return sumaNumeroUno;
            }
        }
        
        public int EscribirNumeroUno
        {
            //escribir
            set
            {
                sumaNumeroUno = value;
            }
        }
            //get(obtener | lectura) set(poner | escritura) 
           //de tarea: hacer una propiedad para otra variable, las variables tendrán su propiedad de escritura y lectura separada.
        public int SumaNumeroDos
        {
            get
            {
                return sumaNumeroDos;
            }
            set
            {
                sumaNumeroDos = value;
            }
        }
        public int LeerNumeroDos
        {
            //leer
            get
            {
                return sumaNumeroDos;
            }
        }
        
        public int EscribirNumeroDos
        {
            //escribir
            set
            {
                SumaNumeroDos = value;
            }
        }
    }
}
