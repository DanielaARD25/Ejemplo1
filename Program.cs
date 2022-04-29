using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //COLAPSAR CÓDIGO
            #region OldCode
            //// ALUMNA: DANIELA AILYN RODRIGUEZ DIAZ
            ////Instanciar un objeto
            ////tipoDeClase nombreObjeto = new  tipoDeclase();
            ////Calculadora operacion = new Calculadora();
            ////operacion.SumaNumeroUno = 25;
            ////int resultadoDevuelto = operacion.SumaNumeroUno;
            ////Console.WriteLine(resultadoDevuelto);

            //////acceder a otro miembro
            ////operacion.EscribirNumeroUno = 18;
            ////Console.WriteLine("Primer propiedad: {0}", operacion.LeerNumeroUno);

            ////int resultadoDevueltoDos = operacion.SumaNumeroDos;
            ////Console.WriteLine(resultadoDevueltoDos);

            //////acceder a un segundo miembro
            ////operacion.EscribirNumeroDos = 45;
            ////Console.WriteLine("Segunda propiedad: {0} \n\n", operacion.LeerNumeroDos);


            ////Crear un objeto de clase Alumno
            ////tipoDeClase nombreObjeto = new  tipoDeclase();
            //Alumno objetoUno = new Alumno("Daniela Ailyn", "Rodriguez", Convert.ToDateTime("04-04-2021")); //Justo en este momento se crea el constructor
            ////objetoUno.NombreAlumno = "Daniela Ailyn Rodriguez Diaz";
            //Console.WriteLine("Alumno: {0}", objetoUno.NombreAlumno);
            //objetoUno.FechaNacimiento = Convert.ToDateTime("25-06-2003 13:30:21");
            //Console.WriteLine(objetoUno.CalcularEdadAlumno1());
            //Console.WriteLine("\n");

            //Alumno objetoDos = new Alumno("Ricardo Lenin", "Vazquez",DateTime.Now);
            //objetoDos.NombreAlumno = "Ricardo Lenin Vazquez Arriaga";
            //Console.WriteLine("Alumno: {0}", objetoDos.NombreAlumno);
            //Console.WriteLine(objetoDos.CalcularEdadAlumno1());

            ////if (objetoDos.CalcularEdadAlumno() == 0) 
            ////{
            ////    Console.WriteLine("Edad no asignada");
            ////}
            ////else
            ////{
            ////Console.WriteLine("Edad: {0}",objetoDos.CalcularEdadAlumno());
            ////}
            //Console.WriteLine("\n");


            //Alumno objetoTres = new Alumno("Evelin Michel", "Chavez", Convert.ToDateTime("18-07-2020"));
            ////objetoTres.NombreAlumno = "Evelin Michel Chavez Fragoza";
            //Console.WriteLine("Alumno: {0}", objetoTres.NombreAlumno);
            //Console.WriteLine(objetoTres.CalcularEdadAlumno2(Convert.ToDateTime("13-02-2002")));
            //Console.WriteLine(objetoTres.FechaNacimiento);
            //Console.ReadKey()
            #endregion  


            //1. Crear objeto (instanciar)
            Alumno alumno1 = new Alumno("Daniela Ailyn", "Rodriguez", "Diaz", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2003"), "Av. Lerdo #174 Col.Centro",
                "Sistemas Computacionales", "RODD030625MCLDZNA4", "D");
            Alumno alumno2 = new Alumno("Amador", "Rivera", "Martinez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("04-01-2004"), "Av. Los Angeles #10 Col.Centro",
                "Sistemas Computacionales", "RIAM040625HCLDZNA4", "D");
            Alumno alumno3 = new Alumno("Ezequiel", "Sandoval", "Martinez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2003"), "Av. Jimenez #123 Col.Centro",
                "Logística", "SAME040625HCLDZNA4", "F");
            Alumno alumno4 = new Alumno("Yolanda Elizabeth", "Zapata", "Gonzalez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2001"), "Av. Degollado #258 Col.Centro",
                "Sistemas Computacionales", "ZAGY040625MCLDZNA4", "C");
            Alumno alumno5 = new Alumno("Daniela Ailyn", "Rodriguez", "Diaz", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2004"), "Av. Abasolo #30 Col.Centro",
                "Industrial", "RODD030625MCLDZNA4", "E");
            Alumno alumno6 = new Alumno("Sonia Abigail", "Huerta", "Carrillo", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"), "Av. Higalgo #189 Col.Centro",
                "Gestión Empresarial", "HUCS040625MCLDZNA4", "G");
            Alumno alumno7 = new Alumno("Sonia Abigail", "Huerta", "Carrillo", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"), "Av. Higalgo #189 Col.Centro",
                "Gestión Empresarial", "HUCS040625MCLDZNA4", "G");
            Alumno alumno8 = new Alumno("Sonia Abigail", "Huerta", "Carrillo", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"), "Av. Higalgo #189 Col.Centro",
                "Gestión Empresarial", "HUCS040625MCLDZNA4", "G");
            Alumno alumno9 = new Alumno("Sonia Abigail", "Huerta", "Carrillo", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"), "Av. Higalgo #189 Col.Centro",
                "Gestión Empresarial", "HUCS040625MCLDZNA4", "G");
            Alumno alumno10 = new Alumno("Sonia Abigail", "Huerta", "Carrillo", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"), "Av. Higalgo #189 Col.Centro",
                "Gestión Empresarial", "HUCS040625MCLDZNA4", "G");

            //2. Mandar llamar algun miembro
            Console.WriteLine(alumno1.CalcularEdadAlumno1());
            Console.WriteLine(alumno2.CalcularEdadAlumno1());
            Console.WriteLine(alumno3.CalcularEdadAlumno1());
            Console.WriteLine(alumno4.CalcularEdadAlumno1());
            Console.WriteLine(alumno5.CalcularEdadAlumno1());
            Console.WriteLine(alumno6.CalcularEdadAlumno1());
            Console.WriteLine(alumno7.CalcularEdadAlumno1());
            Console.WriteLine(alumno8.CalcularEdadAlumno1());
            Console.WriteLine(alumno9.CalcularEdadAlumno1());
            Console.WriteLine(alumno10.CalcularEdadAlumno1());
            Console.ReadKey();
        }
    }
}
