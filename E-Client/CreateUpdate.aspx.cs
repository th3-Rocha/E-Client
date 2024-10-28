using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace E_Client
{
    public partial class CreateUpdate : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string clientId = Request.QueryString["clientID"];
                if (!string.IsNullOrEmpty(clientId))
                {
                    LoadClientData(clientId);
                    btnSave.Text = "Atualizar Cliente";
                    headerTitle.Text = "Editar Cliente";
                }
            }
        }

        protected void LoadClientData(string clientId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EClientDbConnection"].ConnectionString;
            string query = "SELECT CLI_NOME, CLI_DATANASCIMENTO, CLI_ATIVO FROM CLIENTE WHERE CLI_ID = @ClientId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", clientId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNome.Text = reader["CLI_NOME"].ToString();
                            txtDataNascimento.Text = Convert.ToDateTime(reader["CLI_DATANASCIMENTO"]).ToString("yyyy-MM-dd");
                            chkAtivo.Checked = Convert.ToBoolean(reader["CLI_ATIVO"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        ModalSetup("Erro ao carregar o cliente: " + ex.Message);
                    }
                }
            }
        }

        protected void btnClient_Save(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            DateTime dataNascimento;
            bool ativo = chkAtivo.Checked;
            DateTime.TryParse(txtDataNascimento.Text, out dataNascimento);

            string connectionString = ConfigurationManager.ConnectionStrings["EClientDbConnection"].ConnectionString;
            string clientId = Request.QueryString["clientID"];

            string query;
            if (string.IsNullOrEmpty(clientId))
            {
          
                query = "INSERT INTO CLIENTE (CLI_NOME, CLI_DATANASCIMENTO, CLI_ATIVO) VALUES (@Nome, @DataNascimento, @Ativo)";
            }
            else
            {
                
                query = "UPDATE CLIENTE SET CLI_NOME = @Nome, CLI_DATANASCIMENTO = @DataNascimento, CLI_ATIVO = @Ativo WHERE CLI_ID = @ClientId";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    command.Parameters.AddWithValue("@Ativo", ativo);

                    if (!string.IsNullOrEmpty(clientId))
                    {
                        command.Parameters.AddWithValue("@ClientId", clientId);
                    }

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        string message = string.IsNullOrEmpty(clientId) ? "Cliente criado com sucesso!" : "Cliente atualizado com sucesso!";
                        ModalSetup(message);
                     
                    }
                    catch (Exception ex)
                    {
                        ModalSetup("Erro ao salvar o cliente: " + ex.Message);
                    }
                }
            }
        }
        protected void btnRouter_Back(object sender, EventArgs e)
        {
            string clientId = Request.QueryString["clientID"];
            if (!string.IsNullOrEmpty(clientId))
            {
                Response.Redirect($"ListDelete.aspx");
            }
            else
            {
                Response.Redirect($"/");

            }
        }
        protected void ModalSetup(string body)
        {
            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "Popup", $"ShowPopup('{body}');", true);
        }
    }
}
