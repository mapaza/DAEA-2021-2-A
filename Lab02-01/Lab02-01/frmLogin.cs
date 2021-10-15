using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Evento cuando se presiona el boton de iniciar sesion se muestra el formulario MDI Principal
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Validación si existe un usuario

            //Creación de Array con valores para username y password
            String[] arr_username =
            {
                "demo", "mapaza","cmayta"
            };

             String[] arr_password =
            {
                "demo123", "mapaza123","cmayta123"
            };

            String username = txtUsuario.Text;
            String password = txtPassword.Text;

            for(int i = 0; i <arr_username.Length; i++)
            {
                if(username == arr_username[i] && password == arr_password[i])
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("Las credenciales no son válidas. Inténtelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
