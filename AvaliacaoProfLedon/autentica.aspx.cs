using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoProfLedon
{
    public partial class autentica : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string nome, senha;
            nome = Convert.ToString(Request.Params["nomeusuario"]);
            senha = Convert.ToString(Request.Params["senhausuario"]);

            bool encontrado = false;

            if (nome != null && senha != null)
            {
                try
                {
                    MySqlConnection sqlCon = new MySqlConnection("server=localhost; port=3306; user id=root; password=; database=lojaonline;SSL Mode = None; ");

                    sqlCon.Open();

                    String sqlSelect = "SELECT * FROM usuarios WHERE nomeusuario='" + nome + "' AND senhausuario='" + senha + "';";

                    MySqlCommand statement = new MySqlCommand(sqlSelect, sqlCon);

                    MySqlDataReader leitor = statement.ExecuteReader();

                    while (leitor.Read())
                    {
                        encontrado = true;
                        Console.Write(encontrado);
                        Session["id"] = leitor.GetString(0);
                        Session["nomeusuario"] = leitor.GetString(2);
                        Response.Redirect("menu.aspx");
                    }
                    if (!encontrado)
                    {
                        Response.Redirect("index.aspx?invalid=true");
                    }


                }
                catch { }
            }
        }

    }
}