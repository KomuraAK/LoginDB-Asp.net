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
    public partial class listar : System.Web.UI.Page
    {
        readonly MySqlConnection conexao = new MySqlConnection("server=localhost; port=3306; uid=root; password=; database=lojaonline; SSL Mode = None;");
        protected void Page_Load(object sender, EventArgs e)
        {
            preencherDataGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
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
                Response.Redirect("menu.aspx");
            }
        }
        public void preencherDataGrid()
        {
            AbrirConexao();
            try
            { 
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM produtos ORDER BY idprod", conexao);
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                Label1.Text = "Lista de produtos ordernados por ID";
            }
            catch (Exception exec)
            {
                Label1.Text = "Erro preenchendo o GridView: " + exec.Message;
            }
            conexao.Close();
        }
    }
}