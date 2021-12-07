
namespace Formularios
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAutor = new System.Windows.Forms.Label();
            this.panelPadre = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.panelMenu.Controls.Add(this.btnEstadistica);
            this.panelMenu.Controls.Add(this.btnMedicos);
            this.panelMenu.Controls.Add(this.btnPacientes);
            this.panelMenu.Controls.Add(this.btnConsultas);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.ForeColor = System.Drawing.Color.White;
            this.btnEstadistica.Image = global::Formularios.Properties.Resources.bar_chart_2;
            this.btnEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadistica.Location = new System.Drawing.Point(0, 313);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(220, 54);
            this.btnEstadistica.TabIndex = 4;
            this.btnEstadistica.Text = "Estadisticas";
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.ForeColor = System.Drawing.Color.White;
            this.btnMedicos.Image = global::Formularios.Properties.Resources.clipboard;
            this.btnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.Location = new System.Drawing.Point(0, 253);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(220, 54);
            this.btnMedicos.TabIndex = 3;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Image = global::Formularios.Properties.Resources.users;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 193);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(220, 54);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Image = global::Formularios.Properties.Resources.briefcase;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 133);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(220, 54);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            this.btnConsultas.Enter += new System.EventHandler(this.btnInicio_Enter);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Controls.Add(this.lblAutor);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 137);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Formularios.Properties.Resources.consultorio_shadow;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 87);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.btnLogo);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.ForeColor = System.Drawing.Color.White;
            this.lblAutor.Location = new System.Drawing.Point(52, 90);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(116, 21);
            this.lblAutor.TabIndex = 0;
            this.lblAutor.Text = "CONSULTORIO";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAutor.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelPadre
            // 
            this.panelPadre.AutoScroll = true;
            this.panelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadre.Location = new System.Drawing.Point(220, 0);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(1044, 681);
            this.panelPadre.TabIndex = 1;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelPadre);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Consultorio";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Panel panelPadre;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Panel panel1;
    }
}

