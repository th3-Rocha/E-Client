using System;
using System.Collections;
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
        string connString = ConfigurationManager.ConnectionStrings["EClientDBConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClientList();
               
            }
        }
        private void ClientList()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM CLIENTE";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    da.Fill(dt);
                    CLIList.DataSource = dt;
                    CLIList.DataBind();
                }
                catch (Exception ex)
                {
                    ValidationSummary1.Visible = true;
                }
            }
        }
        protected void CLIList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {  
            CLIList.PageIndex = e.NewPageIndex;
            ClientList();
        }

        protected void CLIList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Use the client ID directly from CommandArgument
            string ClientId = e.CommandArgument.ToString();

            if (e.CommandName == "Delete_CLI")
            {
                DeleteClient(ClientId);
            }
            else if (e.CommandName == "Edit_CLI")
            {
                Response.Redirect($"CreateUpdate.aspx?clientID={ClientId}");
            }
        }

        private void DeleteClient(string cliId)
        {
            string query = "DELETE FROM CLIENTE WHERE CLI_ID = " + cliId;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ModalSetup("Cliente Deletado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        ModalSetup("Cliente não deletado error: " + ex.Message);
                    }
                }
            }
            ClientList();
        }



        protected void ModalSetup(string body)
        {
            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "Popup", $"ShowPopup('{body}');", true);
        }
    }
}