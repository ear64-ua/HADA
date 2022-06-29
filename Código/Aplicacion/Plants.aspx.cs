using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Libreria;

namespace Aplicacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GridView1.DataBind();
        }

        protected void Conectado_Click(object sender, EventArgs e)
        {
            ENPlanta en = new ENPlanta();

            List<ENPlanta> lista = en.LeerConectado();

            var listaPlantas = lista;

            GridView1.DataSource = listaPlantas;
            GridView1.DataBind();
        }

        protected void Desconectado_Click(object sender, EventArgs e)
        {
            ENPlanta en = new ENPlanta();

            GridView1.DataSource = en.LeerDesconectado();
            GridView1.DataBind();
        }

        protected void InsertarConectado_Click(object sender, EventArgs e)
        {
            ENPlanta en = new ENPlanta
            {
                nombre = Nombre.Text.ToString(),
                regado = Convert.ToBoolean(Regado.Text.ToString())
            };

            en.InsertarConectado();
            GridView1.DataBind();
            Nombre.Text = "";
            Regado.Text = "";
        }

        protected void InsertarDesconectado_Click(object sender, EventArgs e)
        {
            ENPlanta en = new ENPlanta
            {
                nombre = Nombre.Text.ToString(),
                regado = Convert.ToBoolean(Regado.Text.ToString())
            };

            GridView1.DataSource = en.InsertarDesconectado();
            GridView1.DataBind();
            Nombre.Text = "";
            Regado.Text = "";
        }

        protected void BorrarConectado_Click(object sender, EventArgs e)
        {
            ENPlanta en = new ENPlanta
            {
                nombre = Nombre.Text.ToString(),
            };

            en.BorrarConectado();
            GridView1.DataBind();
            Nombre.Text = "";
            Regado.Text = "";
        }

        protected void BorrarDesconectado_Click(object sender, EventArgs e)
        {
            ENPlanta en = new ENPlanta
            {
                nombre = Nombre.Text.ToString(),
            };

            GridView1.DataSource = en.BorrarDesconectado();
            GridView1.DataBind();
            Nombre.Text = "";
            Regado.Text = "";
        }

        protected void ActualizarConectado_Click(object sender, EventArgs e)
        {
            ENPlanta en = new ENPlanta
            {
                nombre = Nombre.Text.ToString(),
                regado = Convert.ToBoolean(Regado.Text.ToString())
            };

            en.ActualizarConectado();
            GridView1.DataBind();
            Nombre.Text = "";
            Regado.Text = "";
        }

        protected void ActualizarDesconectado_Click(object sender, EventArgs e)
        {
            ENPlanta en = new ENPlanta
            {
                nombre = Nombre.Text.ToString(),
                regado = Convert.ToBoolean(Regado.Text.ToString())
            };

            GridView1.DataSource = en.ActualizarDesconectado();
            GridView1.DataBind();
            Nombre.Text = "";
            Regado.Text = "";
        }
    }
}