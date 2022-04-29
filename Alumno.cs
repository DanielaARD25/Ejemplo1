using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1
{
    internal class Alumno
    {
        // ALUMNA: DANIELA AILYN RODRIGUEZ DIAZ
        string matricula, nombreAlumno = String.Empty, apellidoPrimero, apellidoSegundo, domicilioAlumno, carrera;
        string curpAlumno, nombreInstitucion, contrasenaAlumno, grupoAlumno;
        DateTime fechaNacimiento, fechaIngresoInstitucion;

        // Miembro de tipo CONSTANTE
        const string FECHA_CREACION_INSTITUCION = "01-08-2008", NUMERO_PLANTEL = "100";

        //Miembro de tipo CONSTRUCTOR -- Permite construir o inicializar un objeto -- Este código siempre ha estado
        //Es un tipo especial de método
        //Tipo de acceso  NombreClase (entrada) {}
        //Los constructores siempre tienen como acceso Public
        //Valores de entrada
        public Alumno(string nombreAlumnoEntrada, string apellidoPrimeroEntrada, string apellidoSegundoEntrada,
            DateTime fechaIngresoEntrada, DateTime fechaNacimientoEntrada,
            string domicilioAlumnoEntrada, string carreraEntrada, string curpAlumnoEntrada,
            string grupoAlumnoEntrada)
        // Explicitas | Implicitas (C# lo hace por nosotros)
        {
            nombreAlumno = nombreAlumnoEntrada;
            apellidoPrimero = apellidoPrimeroEntrada;
            fechaIngresoInstitucion = fechaIngresoEntrada;
            fechaNacimiento = fechaNacimientoEntrada;
            apellidoSegundo = apellidoSegundoEntrada;
            domicilioAlumno = domicilioAlumnoEntrada;
            carrera = carreraEntrada;
            curpAlumno = curpAlumnoEntrada;
            grupoAlumno = grupoAlumnoEntrada;

            //Construir la matricula

            if (Folio.numeroFolio >=1 && Folio.numeroFolio <= 9)
            {
                matricula = (fechaIngresoInstitucion.Year + "" + NUMERO_PLANTEL).Substring(2, 5) + "000" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 10 && Folio.numeroFolio<=99)
            {
            matricula = (fechaIngresoInstitucion.Year + "" + NUMERO_PLANTEL).Substring(2, 5) + "00"+ Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 100 && Folio.numeroFolio <= 999)
            {
                matricula = (fechaIngresoInstitucion.Year + "" + NUMERO_PLANTEL).Substring(2, 5) + "00" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 1000 && Folio.numeroFolio <= 9999)
            {
                matricula = (fechaIngresoInstitucion.Year + "" + NUMERO_PLANTEL).Substring(2, 5) + "" + Folio.numeroFolio;
            }


            Folio.numeroFolio = Folio.numeroFolio + 1;

            //Construir la contraseña
            contrasenaAlumno = (apellidoPrimero+ matricula + apellidoSegundo);
        }
    
        
        //Miembros de tipo PROPIEDAD (protegen algun campo/variable)
        public string NombreAlumno
        {
            get //Sirve para leer el contenido de una variable
            {
                if (nombreAlumno != string.Empty)
                {
                    return nombreAlumno;
                }
                else
                {
                    return "No se asignó un nombre al objeto";
                }
            }

            set //Sirve para guardar contenido en una variable
            {
                nombreAlumno = value;
            }
        }

        //Propiedad para la variable fechaNacimiento
        public DateTime FechaNacimiento
        {
            set
            {
                fechaNacimiento = value;
            }
            get
            {
                return fechaNacimiento;
            }
        }


        //LOS MÉTODOS SIEMPRE VAN EN UN PROGRAMA
        //Miembro de tipo METODO
        //Tipo de acceso  Tipo de dato  Nombre metodo (entrada) {}
        //Tipos de acceso: Public | Private
        //Tipos de dato: int, float, string, char, double...
        public int CalcularEdadAlumno() //los métodos no tienen get ni set
        {
            //Calcular la edad
            int edadAlumno;
            if (fechaNacimiento.Year < 1000)
            {
                edadAlumno = 0;
            }
            else
            {
                edadAlumno = (DateTime.Now - fechaNacimiento).Days/365;
            }
            return edadAlumno; //todo método siempre lleva un return
        }


        //Miembro de tipo MÉTODO
        //Tipo de acceso  Tipo de dato  Nombre metodo (dominio | entrada) {}
        //Tipos de acceso: Public | Private | Protected | Internal ---- Normalmente son Public para poder sacarlos en el objeto
        //Tipos de dato: int, float, string, var, char, double, bool...
        public string CalcularEdadAlumno1()
        {
            int edadAlumno;
            string valorDeRetorno;
            if (fechaNacimiento.Year < 1960)
            {
                valorDeRetorno = string.Format("La edad no ha sido asignada, " +
                    "por favor asigna la edad al alumno: {0} {1}", nombreAlumno, apellidoPrimero);
            }

            else
            {
                edadAlumno = (DateTime.Now - fechaNacimiento).Days / 365;
                valorDeRetorno = string.Format(" Matrícula: {3} \n Alumno: {0} {2} {4}. \n" +
                    " Edad: {1} años. \n Curp: {5} \n Domicilio: {6} \n Grupo: {7} " +
                    "\n Contraseña institucional: {8} \n Carrera: {9} \n",
                    nombreAlumno, edadAlumno, apellidoPrimero, matricula, apellidoSegundo, curpAlumno, domicilioAlumno,
                    grupoAlumno, contrasenaAlumno, carrera);
            }
            return valorDeRetorno;
        }


        //Método con valores de entrada (DOMINIO)
        public string CalcularEdadAlumno2(DateTime fechaNacimientoEntrada)
        {
            int edadAlumno;
            string valorDeRetorno;
            fechaNacimiento = fechaNacimientoEntrada;
            //Validar que la fecha de nacimiento que se haya asignado por parte del
            if (fechaNacimientoEntrada.Year < 1960)
            {
                valorDeRetorno = string.Format("La edad no ha sido asignada, " +
                    "por favor asigna la edad al alumno: {0} {1}", nombreAlumno, apellidoPrimero);
            }

            else
            {
                edadAlumno = (DateTime.Now - fechaNacimientoEntrada).Days / 365;
                valorDeRetorno = string.Format("El alumno: {0} {2}. \n" +
                    "Tiene la edad de: {1} años.", nombreAlumno, edadAlumno, apellidoPrimero);
            }
            return valorDeRetorno;
        }
        //Asignar la matricula 
        //public string CalcularMatriculaAlumno()
        //{
        //    string valorDeRetorno;
        //    fechaIngresoInstitucion= FechaIngresoInstitucion;
        //    //Validar que la fecha de ingreso que se haya asignado por parte del
        //    if (fechaIngresoInstitucion.Year < 1960)
        //    {
        //        valorDeRetorno = string.Format("La fecha de ingreso no ha sido asignada" +
        //            "por favor asigna la fecha al alumno: {0} {1}", nombreAlumno, apellidoPrimero);
        //    }

        //    else
        //    {
        //        matricula = (fechaIngresoInstitucion.Year-2000);
        //        valorDeRetorno = string.Format("Matricula:{0}{1}{2}", matricula, numeroPlantel, NumeroRegistro);
        //    }
        //    return valorDeRetorno;
        //}

    }
}