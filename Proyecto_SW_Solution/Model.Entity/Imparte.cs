using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Imparte

    {
        private string Nombre_Profesor;
        private int Codigo_Asignatura;
        private string Horas;


        public string nombre_Profesor
        {
            get
            {
                return Nombre_Profesor;
            }

            set
            {
                Nombre_Profesor = value;
            }
        }

        public int codigo_Asignatura
        {
            get
            {
                return codigo_Asignatura;
            }

            set
            {
                codigo_Asignatura = value;
            }
        }

        public string horas
        {
            get
            {
                return Horas;
            }

            set
            {
                Horas = value;
            }
        }

        public Imparte()
        {

        }
        public Imparte(string Nombre_Profesor)
        {
            this.Nombre_Profesor = nombre_Profesor;
        }

        public Imparte(string nombre_Profesor, int codigo_Asignatura, string horas)
        {
            this.Nombre_Profesor = nombre_Profesor;
            this.Codigo_Asignatura = codigo_Asignatura;
            this.Horas = horas;

        }

    }
}
