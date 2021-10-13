using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public static String busqueda_valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    txtPersonID.Enabled = true;
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtHireDate.Enabled = false;
                    txtEnrollmentDate.Enabled = false;
                    
                    break;

                case 1:
                    txtPersonID.Enabled = false;
                    txtFirstName.Enabled = true;
                    txtLastName.Enabled = false;
                    txtHireDate.Enabled = false;
                    txtEnrollmentDate.Enabled = false;
                    
                    break;
                case 2:
                    txtPersonID.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = true;
                    txtHireDate.Enabled = false;
                    txtEnrollmentDate.Enabled = false;
                    
                    break;
                case 3:
                    txtPersonID.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtHireDate.Enabled = true;
                    txtEnrollmentDate.Enabled = false;
                   
                    break;
                case 4:
                    txtPersonID.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtHireDate.Enabled = false;
                    txtEnrollmentDate.Enabled = true;
                    
                    break;

                default:
                    MessageBox.Show("Seleccione una opción de Búsqueda");
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                clsNegPerson np = new clsNegPerson();
                dt = np.Busqueda(busqueda_valor);
                dgDatos.DataSource = dt;
                dgDatos.Refresh();
                // MessageBox.Show(busqueda_valor);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor válido para realizar la búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void txtPersonID_TextChanged(object sender, EventArgs e)
        {
            busqueda_valor = txtPersonID.Text;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            busqueda_valor = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            busqueda_valor = txtLastName.Text;
        }

        private void txtHireDate_ValueChanged(object sender, EventArgs e)
        {
            busqueda_valor = txtHireDate.Text;
        }

        private void txtEnrollmentDate_ValueChanged(object sender, EventArgs e)
        {
            busqueda_valor = txtEnrollmentDate.Text;
        }
    }
}
