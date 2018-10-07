using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Usuario

    {
        private string Nombre_Usuario;
        private string Login;
        private string Password;


        public string nombre_Usuario
        {
            get
            {
                return nombre_Usuario;
            }

            set
            {
                nombre_Usuario = value;
            }
        }

        public string login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public Usuario()
        {

        }
        public Usuario(int login)
        {
            this.login = Login;
        }

        public Usuario(string Nombre_Usuario, string Login, string Password)
        {
            this.Nombre_Usuario = nombre_Usuario;
            this.Login = login;
            this.Password = password;

        }

    }
}
