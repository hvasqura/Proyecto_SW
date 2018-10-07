using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{


    public class Asignatura

    {
        private int Codigo;
        private string Nombre_Asignatura;
        private string Centro;


        public int codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string nombre_Asignatura
        {
            get
            {
                return nombre_Asignatura;
            }

            set
            {
                nombre_Asignatura = value;
            }
        }

        public string centro
        {
            get
            {
                return centro;
            }

            set
            {
                centro = value;
            }
        }

        public Asignatura()
        {

        }
        public Asignatura(int Codigo)
        {
            this.Codigo = Codigo;
        }

        public Asignatura(int Codigo, string Nombre_Asignatura, string Centro)
        {
            this.Codigo = codigo;
            this.Nombre_Asignatura = nombre_Asignatura;
            this.Centro = centro;

        }

    }
}
