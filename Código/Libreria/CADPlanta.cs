using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes; // clases para trabajar ocn tipos de datos nativos de SQL Server
using System.Configuration;

namespace Libreria
{
    class CADPlanta
    {
        readonly string s = ConfigurationManager.ConnectionStrings["miConexion"].ToString();
        public List<ENPlanta> LeerConectado()
        {
            List<ENPlanta> lista = new List<ENPlanta>();
            SqlConnection c = new SqlConnection(s);
            try
            {
        
                c.Open();

                SqlCommand com = new SqlCommand("SELECT * FROM Plantas", c);

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ENPlanta nueva = new ENPlanta
                    {
                        nombre = dr[0].ToString(),
                        regado = dr.GetBoolean(1)
                    };
                    lista.Add(nueva);
                }
            }
            catch(Exception e) { Console.WriteLine(e);  }
            finally{ c.Close(); }

            return lista;
        }

        public DataSet LeerDesconectado()
        {
            DataSet ds = new DataSet();

            SqlConnection c = new SqlConnection(s);

            SqlDataAdapter da = new SqlDataAdapter("select * from Plantas", c);
            da.Fill(ds, "planta");
            return ds;
        }

        public bool InsertarConectado(ENPlanta en)
        {

            SqlConnection c = new SqlConnection(s);
            c.Open();

            try
            {
                SqlCommand com = new SqlCommand("INSERT INTO Plantas(Nombre,Regada) VALUES ('" + en.nombre + "','" + en.regado + "')", c);
                if (com.ExecuteNonQuery() == 0)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                c.Close();
                return false;
            }
            c.Close();
            return true;
        }

        public DataSet InsertarDesconectado(ENPlanta en)
        {
            DataSet ds = new DataSet();
            SqlConnection c = new SqlConnection(s);

            SqlDataAdapter da = new SqlDataAdapter("Select * from plantas",c);
            da.Fill(ds,"planta");

            var newRow = ds.Tables["planta"].NewRow();
            newRow["nombre"] = en.nombre;
            newRow["regada"] = en.regado;
            ds.Tables["planta"].Rows.Add(newRow);

            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(ds,"planta");
            return ds;
        }

        public bool BorrarConectado(ENPlanta en)
        {

            SqlConnection c = new SqlConnection(s);
            c.Open();

            try
            {
                SqlCommand com = new SqlCommand("DELETE FROM Plantas WHERE Nombre = '" + en.nombre + "'", c);
                if (com.ExecuteNonQuery() == 0)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                c.Close();
                return false;
            }
            c.Close();
            return true;
        }

        public DataSet BorrarDesconectado(ENPlanta en)
        {
            DataSet ds = new DataSet();
            SqlConnection c = new SqlConnection(s);

            SqlDataAdapter da = new SqlDataAdapter("Select * from plantas", c);
            da.Fill(ds, "planta");

            DataTable t = new DataTable();
            t = ds.Tables["planta"];

            int i = 0;
            foreach (DataRow row in t.Rows){
                if (row["nombre"].ToString() == en.nombre)
                {
                    t.Rows[i].Delete();
                }
                i++;
            }
           
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(ds, "planta");
            return ds;
        }

        public bool ActualizarConectado(ENPlanta en)
        {

            SqlConnection c = new SqlConnection(s);
            c.Open();

            try
            {
                SqlCommand com = new SqlCommand("UPDATE Plantas SET Regada = '"+ en.regado +"' WHERE Nombre = '" + en.nombre + "'", c);
                if (com.ExecuteNonQuery() == 0)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                c.Close();
                return false;
            }
            c.Close();
            return true;
        }

        public DataSet ActualizarDesconectado(ENPlanta en)
        {
            DataSet ds = new DataSet();
            SqlConnection c = new SqlConnection(s);

            SqlDataAdapter da = new SqlDataAdapter("Select * from plantas", c);
            da.Fill(ds, "planta");
            DataTable t = ds.Tables["planta"];

            foreach (DataRow row in t.Rows)
            {
                if (row["nombre"].ToString() == en.nombre)
                {
                    row["regada"] = en.regado;
                }
            }

            new SqlCommandBuilder(da);
            da.Update(ds, "planta");
            return ds;
        }
    }
}