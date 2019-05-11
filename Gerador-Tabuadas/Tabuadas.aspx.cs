using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gerador_Tabuadas
{
    public partial class Tabuadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string GenerateTables(int qtd)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<div class='row'> ");
            for (int i = 1; i <= qtd; i++)
            {
                if (i % 2 == 0)
                {
                    builder.Append("<div style='width: 200px; margin: 15px; padding:10px; background-color:cyan; border: solid 1px '> ");
                    for (int a = 1; a <= 10; a++)
                    {
                        builder.Append("<p>" + i + " * " + a + " = " + (i * a) + "</p>");
                    }
                    builder.Append("</div>");
                }
                else
                {
                    builder.Append("<div style='width: 200px; margin: 15px; padding:10px; border: solid 1px' > ");
                    for (int a = 1; a <= 10; a++)
                    {
                        builder.Append("<p >" + i + " * " + a + " = " + (i * a) + "</p>");
                    }
                    builder.Append("</div>");
                }

            }
            builder.Append("</div>");
            return builder.ToString();
        }

        protected void btnTables_Click(object sender, EventArgs e)
        {
            ltlHtml.Text = GenerateTables(Convert.ToInt32(txtQtd.Text));
        }
    }
}