﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class Persona : Form
    {
        SqlConnection conn;
        public Persona(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "select * from Person";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgListado.DataSource = dt;
                dvgListado.Refresh();
            }
            else
            {
                MessageBox.Show("La conexión está cerrada");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.Red;
            btnBuscarDR.BackColor = Color.Black;
            if (conn.State == ConnectionState.Open)
            {
                String FirstName = txtNombre.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarPersonaNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@FirstName";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = FirstName;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgListado.DataSource = dt;
                dvgListado.Refresh();
            }
            else
            {
                MessageBox.Show("La conexión está cerrada");
            }
        }

        private void btnBuscarDR_Click(object sender, EventArgs e)
        {
            btnBuscarDR.BackColor = Color.Red;
            btnBuscar.BackColor = Color.Black;
            if (conn.State == ConnectionState.Open)
            {
                String FirstName = txtNombre.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarPersonaNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@FirstName";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = FirstName;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dvgListado.DataSource = dt;
                dvgListado.Refresh();
            }
            else
            {
                MessageBox.Show("La conexión está cerrada");
            }
        }

        private void Persona_Load(object sender, EventArgs e)
        {

        }
    }
}
