using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Client
{
    public partial class CreateUpdate : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
            }
        }
        protected void btnClient_Save(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            DateTime dataNascimento;
            bool ativo = chkAtivo.Checked;
            DateTime.TryParse(txtDataNascimento.Text, out dataNascimento);

            string connectionString = ConfigurationManager.ConnectionStrings["EClientDbConnection"].ConnectionString;

            string query = "INSERT INTO CLIENTE (CLI_NOME, CLI_DATANASCIMENTO, CLI_ATIVO) VALUES (@Nome, @DataNascimento, @Ativo)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    command.Parameters.AddWithValue("@Ativo", ativo);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        ModalSetup("Cliente criado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        ModalSetup("Cliente não criado Error: " + ex.Message);
                    }
                }
            }
        }

        protected void ModalSetup(string body)
        {
            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "Popup", $"ShowPopup('{body}');", true);
        }

    }
}