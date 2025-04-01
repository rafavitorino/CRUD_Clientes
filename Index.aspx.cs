using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;
using System.Configuration;


namespace CRUD_Simples_new
{
    public partial class Index : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
        static bool novo;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se essa é a primeira requisição da página, se é uma nova requisição, se não for ele vai direto para o método que queremos
            if (!IsPostBack)
            {
                frmCadastroCliente_Load();
            }

        }

        // Método da página inicial
        protected void frmCadastroCliente_Load() //FUNCIONANDO
        {
            tsbNovo.Visible = true;
            tsbSalvar.Visible = false;
            tsbCancelar.Visible = false;
            tsbExcluir.Visible = false;
            txtId.Visible = true;
            tsbBuscar.Visible = true;
            txtNome.Disabled = true;
            txtEndereco.Disabled = true;
            mskCep.Disabled = true;
            txtBairro.Disabled = true;
            txtCidade.Disabled = true;
            txtUf.Disabled = true;
            mskTelefone.Disabled = true;

        }

        //Método que ativa os campos e os botões 
        public void tsbNovo_Click(object sender, EventArgs e) 
        {       
            tsbNovo.Visible = false;
            tsbSalvar.Visible = true;
            tsbCancelar.Visible = true;
            tsbExcluir.Visible = false;
            txtId.Visible = false;
            tsbBuscar.Visible = false;
            txtNome.Disabled = false;
            txtEndereco.Disabled = false;
            mskCep.Disabled = false;
            txtBairro.Disabled = false;
            txtCidade.Disabled = false;
            txtUf.Disabled = false;
            mskTelefone.Disabled = false;
            txtNome.Focus();
            novo = true;
        }

        // Método para salvar ou alterar o registro
        public void tsbSalvar_Click(object sender, EventArgs e) 
        {
            if (novo)
            {
                string sql = "INSERT INTO CLIENTE (NOME, ENDERECO, CEP, BAIRRO, CIDADE, UF, TELEFONE) VALUES ('" + txtNome.Value + "','" + txtEndereco.Value + "','" + mskCep.Value + "','" + txtBairro.Value + "','" + txtCidade.Value + "','" + txtUf.Value + "','" + mskTelefone.Value + "' );";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        Response.Write("<script>alert('Cadastrado com sucesso!');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE CLIENTE SET NOME='" + txtNome.Value + "',ENDERECO = '" + txtEndereco.Value + "', " + "CEP='" + mskCep.Value + "', BAIRRO='" + txtBairro.Value + "',CIDADE = '" + txtCidade.Value + "', " + "UF='" + txtUf.Value + "', TELEFONE='" + mskTelefone.Value + "' WHERE ID='" + txt_bucarId.Value + "';";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        Response.Write("<script>alert('Cadastrado alterado com sucesso!');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

            tsbNovo.Visible = true;
            tsbSalvar.Visible = false;
            tsbCancelar.Visible = false;
            tsbExcluir.Visible = false;
            txtId.Visible = true;
            tsbBuscar.Visible = true;
            txtNome.Disabled = true;
            txtEndereco.Disabled = true;
            mskCep.Disabled = true;
            txtBairro.Disabled = true;
            txtCidade.Disabled = true;
            txtUf.Disabled = true;
            mskTelefone.Disabled = true;
            txtId.Value = "";
            txtNome.Value = "";
            txtEndereco.Value = "";
            mskCep.Value = "";
            txtBairro.Value = "";
            txtCidade.Value = "";
            txtUf.Value = "";
            mskTelefone.Value = "";

        }
        public void tsbCancelar_Click(object sender, EventArgs e) //FUNCIONANDO
        {
            tsbNovo.Visible = true;
            tsbSalvar.Visible = false;
            tsbCancelar.Visible = false;
            tsbExcluir.Visible = false;
            txtId.Visible = true;
            tsbBuscar.Visible = true;
            txtNome.Disabled = true;
            txtEndereco.Disabled = true;
            mskCep.Disabled = true;
            txtBairro.Disabled = true;
            txtCidade.Disabled = true;
            txtUf.Disabled = true;
            mskTelefone.Disabled = true;
            txtId.Value = "";
            txtNome.Value = "";
            txtEndereco.Value = "";
            mskCep.Value = "";
            txtBairro.Value = "";
            txtCidade.Value = "";
            txtUf.Value = "";
            mskTelefone.Value = "";

        }
        public void tsbExcluir_Click(object sender, EventArgs e)
        {

            string sql = "DELETE FROM CLIENTE WHERE ID=" + txt_bucarId.Value;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Response.Write("<script>alert('Registro excluido com sucesso!');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            tsbNovo.Visible = true;
            tsbSalvar.Visible = false;
            tsbCancelar.Visible = false;
            tsbExcluir.Visible = false;
            txtId.Visible = true;
            tsbBuscar.Visible = true;
            txtNome.Disabled = true;
            txtEndereco.Disabled = true;
            mskCep.Disabled = true;
            txtBairro.Disabled = true;
            txtCidade.Disabled = true;
            txtUf.Disabled = true;
            mskTelefone.Disabled = true;
            txtId.Value = "";
            txtNome.Value = "";
            txtEndereco.Value = "";
            mskCep.Value = "";
            txtBairro.Value = "";
            txtCidade.Value = "";
            txtUf.Value = "";
            mskTelefone.Value = "";
        }

        public void tsbBuscar_Click(object sender, EventArgs e) //FUNCIONANDO
        {
            string sql = "SELECT * FROM CLIENTE WHERE ID=" + txt_bucarId.Value;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNovo.Visible = false;
                    tsbSalvar.Visible = true;
                    tsbCancelar.Visible = true;
                    tsbExcluir.Visible = true;
                    txtId.Visible = true;
                    tsbBuscar.Visible = true;
                    txtNome.Visible = true;
                    txtEndereco.Visible = true;
                    mskCep.Visible = true;
                    txtBairro.Visible = true;
                    txtCidade.Visible = true;
                    txtUf.Visible = true;
                    mskTelefone.Visible = true;
                    txtNome.Focus();
                    txtId.Value = reader[0].ToString();
                    txtNome.Value = reader[1].ToString();
                    txtEndereco.Value = reader[2].ToString();
                    mskCep.Value = reader[3].ToString();
                    txtBairro.Value = reader[4].ToString();
                    txtCidade.Value = reader[5].ToString();
                    txtUf.Value = reader[6].ToString();
                    mskTelefone.Value = reader[7].ToString();
                    novo = false;
                }
                else
                    Response.Write("<script>alert('Nenhum registro encontrado com o ID especificado');</script>");

            }
            catch (Exception ex)
            {
                Response.Write("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            txtId.Value = "";

        }

    }

}
                     




