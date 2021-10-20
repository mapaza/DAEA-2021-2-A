using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocio;

namespace Presentación_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgDatos.DataSource = dt;
            dgDatos.DataBind();
        }
    }
}