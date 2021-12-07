
namespace Formularios
{
    partial class Estadisticas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvMedicosPorPaciente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTxtMedicoMenosAtenciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantMedicoMenosAtenciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltxtMedicoConMasAtenciones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMedicoCantAtenciones = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTxtEspecialidadMasAtendida = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCantEspecialidadMasAtendida = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantAtenciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosPorPaciente)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(27, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estadisticas";
            // 
            // dgvMedicosPorPaciente
            // 
            this.dgvMedicosPorPaciente.AllowUserToAddRows = false;
            this.dgvMedicosPorPaciente.AllowUserToDeleteRows = false;
            this.dgvMedicosPorPaciente.AllowUserToResizeColumns = false;
            this.dgvMedicosPorPaciente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvMedicosPorPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicosPorPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicosPorPaciente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMedicosPorPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicosPorPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosPorPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apellido,
            this.nombre,
            this.especialidad,
            this.cantAtenciones});
            this.dgvMedicosPorPaciente.Location = new System.Drawing.Point(27, 114);
            this.dgvMedicosPorPaciente.MultiSelect = false;
            this.dgvMedicosPorPaciente.Name = "dgvMedicosPorPaciente";
            this.dgvMedicosPorPaciente.ReadOnly = true;
            this.dgvMedicosPorPaciente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicosPorPaciente.RowHeadersVisible = false;
            this.dgvMedicosPorPaciente.RowHeadersWidth = 20;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvMedicosPorPaciente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicosPorPaciente.RowTemplate.Height = 25;
            this.dgvMedicosPorPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicosPorPaciente.Size = new System.Drawing.Size(625, 494);
            this.dgvMedicosPorPaciente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medicos ordenados por cantidad de pacientes atendidos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTxtMedicoMenosAtenciones);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblCantMedicoMenosAtenciones);
            this.panel3.Location = new System.Drawing.Point(707, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 140);
            this.panel3.TabIndex = 11;
            // 
            // lblTxtMedicoMenosAtenciones
            // 
            this.lblTxtMedicoMenosAtenciones.AutoSize = true;
            this.lblTxtMedicoMenosAtenciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTxtMedicoMenosAtenciones.Location = new System.Drawing.Point(104, 116);
            this.lblTxtMedicoMenosAtenciones.Name = "lblTxtMedicoMenosAtenciones";
            this.lblTxtMedicoMenosAtenciones.Size = new System.Drawing.Size(80, 15);
            this.lblTxtMedicoMenosAtenciones.TabIndex = 7;
            this.lblTxtMedicoMenosAtenciones.Text = "Lorem Ipsum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Medico que menos pacientes atendió";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantMedicoMenosAtenciones
            // 
            this.lblCantMedicoMenosAtenciones.AutoSize = true;
            this.lblCantMedicoMenosAtenciones.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantMedicoMenosAtenciones.Location = new System.Drawing.Point(67, 20);
            this.lblCantMedicoMenosAtenciones.Name = "lblCantMedicoMenosAtenciones";
            this.lblCantMedicoMenosAtenciones.Size = new System.Drawing.Size(74, 89);
            this.lblCantMedicoMenosAtenciones.TabIndex = 6;
            this.lblCantMedicoMenosAtenciones.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbltxtMedicoConMasAtenciones);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMedicoCantAtenciones);
            this.panel1.Location = new System.Drawing.Point(707, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 140);
            this.panel1.TabIndex = 12;
            // 
            // lbltxtMedicoConMasAtenciones
            // 
            this.lbltxtMedicoConMasAtenciones.AutoSize = true;
            this.lbltxtMedicoConMasAtenciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltxtMedicoConMasAtenciones.Location = new System.Drawing.Point(87, 116);
            this.lbltxtMedicoConMasAtenciones.Name = "lbltxtMedicoConMasAtenciones";
            this.lbltxtMedicoConMasAtenciones.Size = new System.Drawing.Size(91, 15);
            this.lbltxtMedicoConMasAtenciones.TabIndex = 7;
            this.lbltxtMedicoConMasAtenciones.Text = "Lorem Impsum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medico que más pacientes atendió";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedicoCantAtenciones
            // 
            this.lblMedicoCantAtenciones.AutoSize = true;
            this.lblMedicoCantAtenciones.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedicoCantAtenciones.Location = new System.Drawing.Point(67, 22);
            this.lblMedicoCantAtenciones.Name = "lblMedicoCantAtenciones";
            this.lblMedicoCantAtenciones.Size = new System.Drawing.Size(74, 89);
            this.lblMedicoCantAtenciones.TabIndex = 6;
            this.lblMedicoCantAtenciones.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTxtEspecialidadMasAtendida);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblCantEspecialidadMasAtendida);
            this.panel2.Location = new System.Drawing.Point(707, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 140);
            this.panel2.TabIndex = 12;
            // 
            // lblTxtEspecialidadMasAtendida
            // 
            this.lblTxtEspecialidadMasAtendida.AutoSize = true;
            this.lblTxtEspecialidadMasAtendida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTxtEspecialidadMasAtendida.Location = new System.Drawing.Point(87, 116);
            this.lblTxtEspecialidadMasAtendida.Name = "lblTxtEspecialidadMasAtendida";
            this.lblTxtEspecialidadMasAtendida.Size = new System.Drawing.Size(91, 15);
            this.lblTxtEspecialidadMasAtendida.TabIndex = 7;
            this.lblTxtEspecialidadMasAtendida.Text = "Lorem Impsum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Especialidad más atendida";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantEspecialidadMasAtendida
            // 
            this.lblCantEspecialidadMasAtendida.AutoSize = true;
            this.lblCantEspecialidadMasAtendida.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantEspecialidadMasAtendida.Location = new System.Drawing.Point(67, 24);
            this.lblCantEspecialidadMasAtendida.Name = "lblCantEspecialidadMasAtendida";
            this.lblCantEspecialidadMasAtendida.Size = new System.Drawing.Size(74, 89);
            this.lblCantEspecialidadMasAtendida.TabIndex = 6;
            this.lblCantEspecialidadMasAtendida.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(609, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 89);
            this.label12.TabIndex = 6;
            this.label12.Text = "285";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // especialidad
            // 
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            this.especialidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cantAtenciones
            // 
            this.cantAtenciones.DataPropertyName = "cantAtenciones";
            this.cantAtenciones.HeaderText = "Cantidad de Atenciones";
            this.cantAtenciones.Name = "cantAtenciones";
            this.cantAtenciones.ReadOnly = true;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1028, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicosPorPaciente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Estadisticas";
            this.Text = "w";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosPorPaciente)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvMedicosPorPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTxtMedicoMenosAtenciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltxtMedicoConMasAtenciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMedicoCantAtenciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTxtEspecialidadMasAtendida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCantEspecialidadMasAtendida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCantMedicoMenosAtenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantAtenciones;
    }
}