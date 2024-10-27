using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Client
{
    public partial class ListDelete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientList();
        }
        private void ClientList()
        {
            string connString = ConfigurationManager.ConnectionStrings["EClientDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM CLIENTE";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    da.Fill(dt);
                    gvClientes.DataSource = dt;
                    gvClientes.DataBind();
                }
                catch (Exception ex)
                {
                    ValidationSummary1.Visible = true;
               
                }
            }
        }
    }
}