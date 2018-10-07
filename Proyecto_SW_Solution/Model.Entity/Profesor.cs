using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class Profesor

    {
        private string nombre;
        private string dedicacion;
        private string categoria;


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Dedicacion
        {
            get
            {
                return dedicacion;
            }

            set
            {
                dedicacion = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public Profesor()
        {

        }
        public Profesor(string Nombre)
        {
            this.nombre = Nombre;
        }

        public Profesor(string nombre, string dedicacion, string categoria)
        {
            this.Nombre = nombre;
            this.Dedicacion = dedicacion;
            this.Categoria = categoria;

        }

    }
}
