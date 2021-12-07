
namespace Formularios
{
    partial class Consultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelecciono = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMedicosDisponibles = new System.Windows.Forms.DataGridView();
            this.apellidoYnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEspecialidesDisponibles = new System.Windows.Forms.DataGridView();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMedicoSeleccionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de consultas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(27, 28);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(132, 37);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Consultas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AllowUserToResizeColumns = false;
            this.dgvConsultas.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paciente,
            this.medico,
            this.estado,
            this.fecha_hora});
            this.dgvConsultas.Location = new System.Drawing.Point(27, 118);
            this.dgvConsultas.MultiSelect = false;
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.RowHeadersWidth = 20;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvConsultas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvConsultas.RowTemplate.Height = 25;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(625, 494);
            this.dgvConsultas.TabIndex = 5;
            this.dgvConsultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellClick);
            this.dgvConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellContentClick);
            // 
            // paciente
            // 
            this.paciente.DataPropertyName = "paciente";
            this.paciente.HeaderText = "Paciente";
            this.paciente.Name = "paciente";
            this.paciente.ReadOnly = true;
            this.paciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // medico
            // 
            this.medico.DataPropertyName = "medico";
            this.medico.HeaderText = "Medico";
            this.medico.Name = "medico";
            this.medico.ReadOnly = true;
            this.medico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha_hora
            // 
            this.fecha_hora.DataPropertyName = "fecha_hora";
            this.fecha_hora.HeaderText = "Fecha y Hora";
            this.fecha_hora.Name = "fecha_hora";
            this.fecha_hora.ReadOnly = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Image = global::Formularios.Properties.Resources.briefcase;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(14, 421);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(280, 54);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Marcar como finalizada";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblSelecciono);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.lblFechaYHora);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblMedico);
            this.panel1.Controls.Add(this.lblPaciente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Location = new System.Drawing.Point(695, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 494);
            this.panel1.TabIndex = 9;
            // 
            // lblSelecciono
            // 
            this.lblSelecciono.AutoSize = true;
            this.lblSelecciono.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelecciono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblSelecciono.Location = new System.Drawing.Point(4, 211);
            this.lblSelecciono.Name = "lblSelecciono";
            this.lblSelecciono.Size = new System.Drawing.Size(299, 37);
            this.lblSelecciono.TabIndex = 17;
            this.lblSelecciono.Text = "Seleccione una consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(14, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Asignar resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(14, 312);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(280, 91);
            this.txtResultado.TabIndex = 18;
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaYHora.Location = new System.Drawing.Point(14, 226);
            this.lblFechaYHora.Margin = new System.Windows.Forms.Padding(0);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaYHora.Size = new System.Drawing.Size(194, 37);
            this.lblFechaYHora.TabIndex = 16;
            this.lblFechaYHora.Text = "Lorem Impsum";
            this.lblFechaYHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(14, 163);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstado.Size = new System.Drawing.Size(194, 37);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Lorem Impsum";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedico.Location = new System.Drawing.Point(14, 98);
            this.lblMedico.Margin = new System.Windows.Forms.Padding(0);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMedico.Size = new System.Drawing.Size(194, 37);
            this.lblMedico.TabIndex = 14;
            this.lblMedico.Text = "Lorem Impsum";
            this.lblMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaciente.Location = new System.Drawing.Point(14, 37);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPaciente.Size = new System.Drawing.Size(194, 37);
            this.lblPaciente.TabIndex = 10;
            this.lblPaciente.Text = "Lorem Impsum";
            this.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(14, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha y Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(14, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paciente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 639);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(202, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "Asignar Médico";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMedicosDisponibles
            // 
            this.dgvMedicosDisponibles.AllowUserToAddRows = false;
            this.dgvMedicosDisponibles.AllowUserToDeleteRows = false;
            this.dgvMedicosDisponibles.AllowUserToResizeColumns = false;
            this.dgvMedicosDisponibles.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvMedicosDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMedicosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicosDisponibles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMedicosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apellidoYnombre});
            this.dgvMedicosDisponibles.Location = new System.Drawing.Point(27, 752);
            this.dgvMedicosDisponibles.MultiSelect = false;
            this.dgvMedicosDisponibles.Name = "dgvMedicosDisponibles";
            this.dgvMedicosDisponibles.ReadOnly = true;
            this.dgvMedicosDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicosDisponibles.RowHeadersVisible = false;
            this.dgvMedicosDisponibles.RowHeadersWidth = 20;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvMedicosDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMedicosDisponibles.RowTemplate.Height = 25;
            this.dgvMedicosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicosDisponibles.Size = new System.Drawing.Size(461, 358);
            this.dgvMedicosDisponibles.TabIndex = 20;
            this.dgvMedicosDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicosDisponibles_CellClick);
            // 
            // apellidoYnombre
            // 
            this.apellidoYnombre.DataPropertyName = "apellidoYnombre";
            this.apellidoYnombre.HeaderText = "Apellido y Nombre";
            this.apellidoYnombre.Name = "apellidoYnombre";
            this.apellidoYnombre.ReadOnly = true;
            // 
            // dgvEspecialidesDisponibles
            // 
            this.dgvEspecialidesDisponibles.AllowUserToAddRows = false;
            this.dgvEspecialidesDisponibles.AllowUserToDeleteRows = false;
            this.dgvEspecialidesDisponibles.AllowUserToResizeColumns = false;
            this.dgvEspecialidesDisponibles.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvEspecialidesDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEspecialidesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialidesDisponibles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEspecialidesDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEspecialidesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidesDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.especialidad});
            this.dgvEspecialidesDisponibles.Location = new System.Drawing.Point(521, 752);
            this.dgvEspecialidesDisponibles.MultiSelect = false;
            this.dgvEspecialidesDisponibles.Name = "dgvEspecialidesDisponibles";
            this.dgvEspecialidesDisponibles.ReadOnly = true;
            this.dgvEspecialidesDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEspecialidesDisponibles.RowHeadersVisible = false;
            this.dgvEspecialidesDisponibles.RowHeadersWidth = 20;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvEspecialidesDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEspecialidesDisponibles.RowTemplate.Height = 25;
            this.dgvEspecialidesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidesDisponibles.Size = new System.Drawing.Size(468, 358);
            this.dgvEspecialidesDisponibles.TabIndex = 21;
            this.dgvEspecialidesDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidesDisponibles_CellClick);
            // 
            // especialidad
            // 
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label8.Location = new System.Drawing.Point(27, 687);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(576, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Seleccione un médico por apellido y nombre o por especialidad. Se actualizará aut" +
    "omaticamente en la ficha ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label9.Location = new System.Drawing.Point(27, 718);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Seleccionó a:";
            // 
            // lblMedicoSeleccionado
            // 
            this.lblMedicoSeleccionado.AutoSize = true;
            this.lblMedicoSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedicoSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblMedicoSeleccionado.Location = new System.Drawing.Point(109, 718);
            this.lblMedicoSeleccionado.Name = "lblMedicoSeleccionado";
            this.lblMedicoSeleccionado.Size = new System.Drawing.Size(91, 15);
            this.lblMedicoSeleccionado.TabIndex = 24;
            this.lblMedicoSeleccionado.Text = "Todavía a nadie";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1045, 1061);
            this.Controls.Add(this.lblMedicoSeleccionado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvEspecialidesDisponibles);
            this.Controls.Add(this.dgvMedicosDisponibles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaYHora;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hora;
        private System.Windows.Forms.Label lblSelecciono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMedicosDisponibles;
        private System.Windows.Forms.DataGridView dgvEspecialidesDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoYnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMedicoSeleccionado;
    }
}