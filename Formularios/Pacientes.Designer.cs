
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoYnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMedicoSeleccionado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvEspecialidesDisponibles = new System.Windows.Forms.DataGridView();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicosDisponibles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelecciono = new System.Windows.Forms.Label();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.lblTituloFechaYHora = new System.Windows.Forms.Label();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblDniPaciente = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblTituloObraSocial = new System.Windows.Forms.Label();
            this.lblTituloMedico = new System.Windows.Forms.Label();
            this.lblTituloDniPaciente = new System.Windows.Forms.Label();
            this.lblTituloPaciente = new System.Windows.Forms.Label();
            this.btnAsignarMedico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosDisponibles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPacientes.RowTemplate.Height = 25;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(625, 494);
            this.dgvPacientes.TabIndex = 8;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
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
            // lblMedicoSeleccionado
            // 
            this.lblMedicoSeleccionado.AutoSize = true;
            this.lblMedicoSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedicoSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblMedicoSeleccionado.Location = new System.Drawing.Point(109, 719);
            this.lblMedicoSeleccionado.Name = "lblMedicoSeleccionado";
            this.lblMedicoSeleccionado.Size = new System.Drawing.Size(91, 15);
            this.lblMedicoSeleccionado.TabIndex = 30;
            this.lblMedicoSeleccionado.Text = "Todavía a nadie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label9.Location = new System.Drawing.Point(27, 719);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Seleccionó a:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label8.Location = new System.Drawing.Point(27, 688);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(576, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Seleccione un médico por apellido y nombre o por especialidad. Se actualizará aut" +
    "omaticamente en la ficha ";
            // 
            // dgvEspecialidesDisponibles
            // 
            this.dgvEspecialidesDisponibles.AllowUserToAddRows = false;
            this.dgvEspecialidesDisponibles.AllowUserToDeleteRows = false;
            this.dgvEspecialidesDisponibles.AllowUserToResizeColumns = false;
            this.dgvEspecialidesDisponibles.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvEspecialidesDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvEspecialidesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialidesDisponibles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEspecialidesDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEspecialidesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidesDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.especialidad});
            this.dgvEspecialidesDisponibles.Location = new System.Drawing.Point(521, 753);
            this.dgvEspecialidesDisponibles.MultiSelect = false;
            this.dgvEspecialidesDisponibles.Name = "dgvEspecialidesDisponibles";
            this.dgvEspecialidesDisponibles.ReadOnly = true;
            this.dgvEspecialidesDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEspecialidesDisponibles.RowHeadersVisible = false;
            this.dgvEspecialidesDisponibles.RowHeadersWidth = 20;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvEspecialidesDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvEspecialidesDisponibles.RowTemplate.Height = 25;
            this.dgvEspecialidesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidesDisponibles.Size = new System.Drawing.Size(468, 358);
            this.dgvEspecialidesDisponibles.TabIndex = 27;
            this.dgvEspecialidesDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidesDisponibles_CellClick);
            // 
            // especialidad
            // 
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // dgvMedicosDisponibles
            // 
            this.dgvMedicosDisponibles.AllowUserToAddRows = false;
            this.dgvMedicosDisponibles.AllowUserToDeleteRows = false;
            this.dgvMedicosDisponibles.AllowUserToResizeColumns = false;
            this.dgvMedicosDisponibles.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvMedicosDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMedicosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicosDisponibles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMedicosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvMedicosDisponibles.Location = new System.Drawing.Point(27, 753);
            this.dgvMedicosDisponibles.MultiSelect = false;
            this.dgvMedicosDisponibles.Name = "dgvMedicosDisponibles";
            this.dgvMedicosDisponibles.ReadOnly = true;
            this.dgvMedicosDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicosDisponibles.RowHeadersVisible = false;
            this.dgvMedicosDisponibles.RowHeadersWidth = 20;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.dgvMedicosDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMedicosDisponibles.RowTemplate.Height = 25;
            this.dgvMedicosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicosDisponibles.Size = new System.Drawing.Size(461, 358);
            this.dgvMedicosDisponibles.TabIndex = 26;
            this.dgvMedicosDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicosDisponibles_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "apellidoYnombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Apellido y Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 640);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(202, 37);
            this.label7.TabIndex = 25;
            this.label7.Text = "Asignar Médico";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblSelecciono);
            this.panel1.Controls.Add(this.lblFechaYHora);
            this.panel1.Controls.Add(this.lblTituloFechaYHora);
            this.panel1.Controls.Add(this.lblObraSocial);
            this.panel1.Controls.Add(this.lblDniPaciente);
            this.panel1.Controls.Add(this.lblMedico);
            this.panel1.Controls.Add(this.lblPaciente);
            this.panel1.Controls.Add(this.lblTituloObraSocial);
            this.panel1.Controls.Add(this.lblTituloMedico);
            this.panel1.Controls.Add(this.lblTituloDniPaciente);
            this.panel1.Controls.Add(this.lblTituloPaciente);
            this.panel1.Controls.Add(this.btnAsignarMedico);
            this.panel1.Location = new System.Drawing.Point(682, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 494);
            this.panel1.TabIndex = 31;
            // 
            // lblSelecciono
            // 
            this.lblSelecciono.AutoSize = true;
            this.lblSelecciono.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelecciono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblSelecciono.Location = new System.Drawing.Point(7, 219);
            this.lblSelecciono.Name = "lblSelecciono";
            this.lblSelecciono.Size = new System.Drawing.Size(287, 37);
            this.lblSelecciono.TabIndex = 17;
            this.lblSelecciono.Text = "Seleccione un paciente";
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaYHora.Location = new System.Drawing.Point(14, 324);
            this.lblFechaYHora.Margin = new System.Windows.Forms.Padding(0);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaYHora.Size = new System.Drawing.Size(194, 37);
            this.lblFechaYHora.TabIndex = 18;
            this.lblFechaYHora.Text = "Lorem Impsum";
            this.lblFechaYHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloFechaYHora
            // 
            this.lblTituloFechaYHora.AutoSize = true;
            this.lblTituloFechaYHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblTituloFechaYHora.Location = new System.Drawing.Point(14, 309);
            this.lblTituloFechaYHora.Name = "lblTituloFechaYHora";
            this.lblTituloFechaYHora.Size = new System.Drawing.Size(74, 15);
            this.lblTituloFechaYHora.TabIndex = 17;
            this.lblTituloFechaYHora.Text = "Hora llegada";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObraSocial.Location = new System.Drawing.Point(14, 250);
            this.lblObraSocial.Margin = new System.Windows.Forms.Padding(0);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblObraSocial.Size = new System.Drawing.Size(194, 37);
            this.lblObraSocial.TabIndex = 16;
            this.lblObraSocial.Text = "Lorem Impsum";
            this.lblObraSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDniPaciente
            // 
            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniPaciente.Location = new System.Drawing.Point(14, 111);
            this.lblDniPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.lblDniPaciente.Name = "lblDniPaciente";
            this.lblDniPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDniPaciente.Size = new System.Drawing.Size(194, 37);
            this.lblDniPaciente.TabIndex = 15;
            this.lblDniPaciente.Text = "Lorem Impsum";
            this.lblDniPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedico.Location = new System.Drawing.Point(14, 182);
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
            // lblTituloObraSocial
            // 
            this.lblTituloObraSocial.AutoSize = true;
            this.lblTituloObraSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblTituloObraSocial.Location = new System.Drawing.Point(14, 235);
            this.lblTituloObraSocial.Name = "lblTituloObraSocial";
            this.lblTituloObraSocial.Size = new System.Drawing.Size(67, 15);
            this.lblTituloObraSocial.TabIndex = 13;
            this.lblTituloObraSocial.Text = "Obra Social";
            // 
            // lblTituloMedico
            // 
            this.lblTituloMedico.AutoSize = true;
            this.lblTituloMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblTituloMedico.Location = new System.Drawing.Point(14, 167);
            this.lblTituloMedico.Name = "lblTituloMedico";
            this.lblTituloMedico.Size = new System.Drawing.Size(47, 15);
            this.lblTituloMedico.TabIndex = 12;
            this.lblTituloMedico.Text = "Médico";
            // 
            // lblTituloDniPaciente
            // 
            this.lblTituloDniPaciente.AutoSize = true;
            this.lblTituloDniPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblTituloDniPaciente.Location = new System.Drawing.Point(14, 91);
            this.lblTituloDniPaciente.Name = "lblTituloDniPaciente";
            this.lblTituloDniPaciente.Size = new System.Drawing.Size(75, 15);
            this.lblTituloDniPaciente.TabIndex = 11;
            this.lblTituloDniPaciente.Text = "DNI Paciente";
            // 
            // lblTituloPaciente
            // 
            this.lblTituloPaciente.AutoSize = true;
            this.lblTituloPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lblTituloPaciente.Location = new System.Drawing.Point(14, 22);
            this.lblTituloPaciente.Name = "lblTituloPaciente";
            this.lblTituloPaciente.Size = new System.Drawing.Size(52, 15);
            this.lblTituloPaciente.TabIndex = 10;
            this.lblTituloPaciente.Text = "Paciente";
            // 
            // btnAsignarMedico
            // 
            this.btnAsignarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.btnAsignarMedico.FlatAppearance.BorderSize = 0;
            this.btnAsignarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarMedico.ForeColor = System.Drawing.Color.White;
            this.btnAsignarMedico.Image = global::Formularios.Properties.Resources.users;
            this.btnAsignarMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarMedico.Location = new System.Drawing.Point(14, 421);
            this.btnAsignarMedico.Name = "btnAsignarMedico";
            this.btnAsignarMedico.Size = new System.Drawing.Size(280, 54);
            this.btnAsignarMedico.TabIndex = 8;
            this.btnAsignarMedico.Text = "Asignar medico";
            this.btnAsignarMedico.UseVisualStyleBackColor = false;
            this.btnAsignarMedico.Click += new System.EventHandler(this.btnAsignarMedico_Click);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1045, 1061);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMedicoSeleccionado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvEspecialidesDisponibles);
            this.Controls.Add(this.dgvMedicosDisponibles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosDisponibles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lblMedicoSeleccionado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvEspecialidesDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridView dgvMedicosDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelecciono;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblTituloObraSocial;
        private System.Windows.Forms.Label lblTituloMedico;
        private System.Windows.Forms.Label lblTituloDniPaciente;
        private System.Windows.Forms.Label lblTituloPaciente;
        private System.Windows.Forms.Button btnAsignarMedico;
        private System.Windows.Forms.Label lblFechaYHora;
        private System.Windows.Forms.Label lblTituloFechaYHora;
    }
}