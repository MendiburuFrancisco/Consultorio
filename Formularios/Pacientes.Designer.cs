
namespace Formularios
{
    partial class Pacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoYnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.apellidoYnombre,
            this.edad,
            this.obraSocial});
            this.dgvPacientes.Location = new System.Drawing.Point(27, 119);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowHeadersWidth = 20;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.RowTemplate.Height = 25;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(973, 494);
            this.dgvPacientes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(27, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Listado de pacientes en espera";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(27, 28);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(127, 37);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Pacientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // apellidoYnombre
            // 
            this.apellidoYnombre.DataPropertyName = "apellidoYnombre";
            this.apellidoYnombre.HeaderText = "Apellido y Nombre";
            this.apellidoYnombre.Name = "apellidoYnombre";
            this.apellidoYnombre.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // obraSocial
            // 
            this.obraSocial.DataPropertyName = "obraSocial";
            this.obraSocial.HeaderText = "Obra Social";
            this.obraSocial.Name = "obraSocial";
            this.obraSocial.ReadOnly = true;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1028, 642);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoYnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn obraSocial;
    }
}