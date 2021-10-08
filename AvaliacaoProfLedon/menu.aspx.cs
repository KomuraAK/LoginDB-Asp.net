using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoProfLedon
{
    public partial class menu : System.Web.UI.Page
    {
        readonly MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=lojaonline; SSL Mode = None;");
        protected void Page_Load(object sender, EventArgs e)
        {
            preencherDataGrid();
            string idUser, Username;
            try
            {
                if (String.IsNullOrEmpty((String)Session["id"]) || String.IsNullOrEmpty((String)Session["nomeusuario"]))
                {
                    Response.Redirect("index.aspx");
                }
                idUser = HttpContext.Current.Session["id"].ToString();
                Username = HttpContext.Current.Session["nomeusuario"].ToString();


                Label1.Text = "Bem vindo:" + Username + "  (" + idUser + ")";
            }
            catch (Exception)
            {
                Label1.Text = "Por favor, digite valores corretos!.";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("index.aspx");
        }
        public void AbrirConexao()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception exec)
            {
                Label1.Text = "Erro na conexão: " + exec.Message;
                Response.Redirect("index.aspx");
            }
        }
        public void preencherDataGrid()
        {
            AbrirConexao();
            try
            {
                string idUser;
                idUser = HttpContext.Current.Session["id"].ToString();
                MySqlCommand cmd = new MySqlCommand("SELECT idusuario, idproduto, qtdecomprada FROM comprasefetuadas WHERE idusuario='" + idUser + "';", conexao);
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable); 
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                Label1.Text = "Mostramos os dados da tabela 'alunos' do BD formato MySQL 'escola' ";
            }
            catch (Exception exec)
            {
                Label1.Text = "Erro preenchendo o GridView: " + exec.Message;
            }
            conexao.Close();
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("listar.aspx");
        }
    }
}