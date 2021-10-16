using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab09
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            Response.Write("<script> alert('Hola " + txtNombre.Text + "');</script>");
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == " " 
                || txtApellido.Text == " " 
                || txtUsuario.Text == " " 
                || ddlDepartamento.Text == " " 
                || txtDireccion.Text == " " 
                || CheckBox1.Checked == false)
            {
                Response.Write("<script> alert('Ingrese todos los datos del formulario, por favor');</script>");
            }
            else
            {
                Response.Write("<script> alert('El usuario: @" + txtUsuario.Text + " ha sido registrado exitosamente!');</script>");
            }
            

        }
    }
}