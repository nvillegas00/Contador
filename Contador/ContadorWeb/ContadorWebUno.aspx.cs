using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContadorWeb
{
    public partial class ContadorWebUno : System.Web.UI.Page
    {
        private int nro;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtAumentar.Text = "0";
        }

        protected void btnAumentar_Click(object sender, EventArgs e)
        {
            nro++;
            txtAumentar.Text = nro.ToString(); 
        }
    }
}