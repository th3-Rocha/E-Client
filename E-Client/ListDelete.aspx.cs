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
            

            int rowIndex = Convert.ToInt32(e.CommandArgument);//pega o index pelo commandArgument do botão
            string ClientId = Convert.ToString(CLIList.DataKeys[rowIndex].Value); //usa o index para saber o DataKeyName da linha em questão
            if (e.CommandName.CompareTo("Delete_CLI") == 0)
            {
                DeleteClient(ClientId);
             
            }
            else if (e.CommandName.CompareTo("Edit_CLI") == 0)
            {

                string script = $"<script>alert('Cliente com ID {ClientId} Editado com sucesso!');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script);
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