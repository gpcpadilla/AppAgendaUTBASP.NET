using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAgendaUTB.Modelo
{
    public class Personas
    {

        #region "Atributos"
        private string id;
        private string nombres;
        private string apellidos;
        private string emailp;
        private string emailw;
        private string telefonop;
        private string telefonow;
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public string Identificacion
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Establece o retorna los nombres y apellidos
        /// </summary>
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Emailp
        {
            get { return emailp; }
            set { emailp = value; }
        }

        public string EmailW
        {
            get { return emailw; }
            set { emailw = value; }
        }

        public string TelefonoP
        {
            get { return telefonop; }
            set { telefonop = value; }
        }

        public string TelefonoW
        {
            get { return telefonow; }
            set { telefonow = value; }
        }

        #endregion

        #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de Personas
        ///</summary>
        public Personas()
        {
            this.id = "1047424720";
            this.nombres = "geovanni enrique";
            this.apellidos = "padilla cervantes";
            this.emailp = "gpcpadilla@hotmail.com";
            this.emailw = "t00037024@gmail.com";
            this.telefonop = "3006048295";
            this.telefonow = "000000000";
           
        }

        ///<summary>
        ///Contructor de inicialización Personas
        ///</summary>
        ///<param name="id"> Identificacion de Personas</param>
        ///<param name="nombres"> Nombres De La Persona</param>
        ///<param name="apellidos"> Apaellidos De La Persona</param>
        ///<param name="emailp"> Email Personal</param>
        ///<param name="emailw"> Email Trabajo</param>
        ///<param name="telefonop"> Telefono Personal</param>
        ///<param name="telefonow"> Telefono Trabajo</param>
        ///
        public Personas(string id, string nombres, string apellidos, string emailp, string emailw, string telefonop, string telefonow)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.emailp = emailp;
            this.emailw = emailw;
            this.telefonop = telefonop;
            this.telefonow = telefonow;
            
        }
        #endregion

        #region "Métodos Sobre Escritos"
        /// <summary>
        /// Retorna el valor del objeto representado en una cadena
        /// </summary>
        public override string ToString()
        {
            return "\n=============================================\n" +
                     "Identificación:  " + this.id + "\n" +
                     "Nombres:  " + this.nombres + "\n" +
                     "Apellidos:  " + this.apellidos + "\n" +
                     "Email Personal:  " + this.emailp + "\n" +
                     "Email Trabajo:  " + this.emailw + "\n" +
                     "Telefono Personal:  " + this.telefonop + "\n" +
                     "Telefono Trabajo:  " + this.telefonow;
        }

        /// <summary>
        /// Método que compara dos objectos
        /// </summary>
        public override bool Equals(object obj)
        {
            Personas o = (Personas)obj;
            bool result = false;

            if ((this.id == o.id) &&
                (this.nombres == o.nombres) &&
                (this.apellidos == o.apellidos) &&
                (this.emailp == o.emailp) &&
                (this.emailw == o.emailw) &&
                (this.telefonop == o.telefonop) &&
                (this.telefonow == o.telefonow))
                result = true;

            return result;
        }

        /// <summary>
        /// Devuelve la identificación del objecto
        /// </summary>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion

    }
}