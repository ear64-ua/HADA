using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{

    public class ENPlanta
    {
        private string nombre_;
        private bool regado_;

        public string nombre
        {
            get { return nombre_;  }
            set { nombre_ = value; }
        }

        public bool regado { 
            get { return regado_; }
            set { regado_ = value; }
        }


        public List<ENPlanta> LeerConectado()
        {
            CADPlanta cad = new CADPlanta();
            return cad.LeerConectado();
        }

        public DataSet LeerDesconectado()
        {
            CADPlanta cad = new CADPlanta();
            return cad.LeerDesconectado();
        }

        public bool InsertarConectado()
        {
            CADPlanta cad = new CADPlanta();
            return cad.InsertarConectado(this);
        }

        public DataSet InsertarDesconectado()
        {
            CADPlanta cad = new CADPlanta();
            return cad.InsertarDesconectado(this);
        }

        public bool BorrarConectado()
        {
            CADPlanta cad = new CADPlanta();
            return cad.BorrarConectado(this);
        }

        public DataSet BorrarDesconectado()
        {
            CADPlanta cad = new CADPlanta();
            return cad.BorrarDesconectado(this);
        }

        public bool ActualizarConectado()
        {
            CADPlanta cad = new CADPlanta();
            return cad.ActualizarConectado(this);
        }

        public DataSet ActualizarDesconectado()
        {
            CADPlanta cad = new CADPlanta();
            return cad.ActualizarDesconectado(this);
        }

    }
}
