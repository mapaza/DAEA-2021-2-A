
namespace Lab03
{
    partial class Cursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgListadoC = new System.Windows.Forms.DataGridView();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.btnListarC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(5, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 69);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla Cursos";
            // 
            // dvgListadoC
            // 
            this.dvgListadoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListadoC.Location = new System.Drawing.Point(45, 216);
            this.dvgListadoC.Name = "dvgListadoC";
            this.dvgListadoC.RowHeadersWidth = 51;
            this.dvgListadoC.RowTemplate.Height = 24;
            this.dvgListadoC.Size = new System.Drawing.Size(725, 531);
            this.dvgListadoC.TabIndex = 14;
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarC.Location = new System.Drawing.Point(655, 114);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(115, 74);
            this.btnBuscarC.TabIndex = 13;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = false;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // txtNombreC
            // 
            this.txtNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreC.Location = new System.Drawing.Point(334, 136);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(281, 30);
            this.txtNombreC.TabIndex = 12;
            // 
            // btnListarC
            // 
            this.btnListarC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarC.Location = new System.Drawing.Point(45, 114);
            this.btnListarC.Name = "btnListarC";
            this.btnListarC.Size = new System.Drawing.Size(115, 75);
            this.btnListarC.TabIndex = 11;
            this.btnListarC.Text = "Listar";
            this.btnListarC.UseVisualStyleBackColor = false;
            this.btnListarC.Click += new System.EventHandler(this.btnListarC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(206, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titulo Curso";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 764);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvgListadoC);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.btnListarC);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgListadoC;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Button btnListarC;
        private System.Windows.Forms.Label label2;
    }
}