namespace proclinica
{
    partial class Form_CrearPerfil
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
            this.Pnl_superior_registrarrecepcionista = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Btn_volver_recepcionista = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.lbl_titulo_registroderecepcionistas = new System.Windows.Forms.Label();
            this.Pnl_superior_registrarrecepcionista.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_superior_registrarrecepcionista
            // 
            this.Pnl_superior_registrarrecepcionista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_superior_registrarrecepcionista.Controls.Add(this.Btn_volver_recepcionista);
            this.Pnl_superior_registrarrecepcionista.Location = new System.Drawing.Point(1, 1);
            this.Pnl_superior_registrarrecepcionista.Name = "Pnl_superior_registrarrecepcionista";
            this.Pnl_superior_registrarrecepcionista.Size = new System.Drawing.Size(801, 65);
            this.Pnl_superior_registrarrecepcionista.TabIndex = 3;
            // 
            // Btn_volver_recepcionista
            // 
            this.Btn_volver_recepcionista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_volver_recepcionista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_volver_recepcionista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_volver_recepcionista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_volver_recepcionista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_volver_recepcionista.ForeColor = System.Drawing.Color.White;
            this.Btn_volver_recepcionista.Location = new System.Drawing.Point(12, 12);
            this.Btn_volver_recepcionista.Name = "Btn_volver_recepcionista";
            this.Btn_volver_recepcionista.Size = new System.Drawing.Size(96, 36);
            this.Btn_volver_recepcionista.TabIndex = 14;
            this.Btn_volver_recepcionista.Text = "volver";
            this.Btn_volver_recepcionista.Click += new System.EventHandler(this.Btn_volver_recepcionista_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboRoles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCrearPerfil);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.comboUsuarios);
            this.panel1.Controls.Add(this.lbl_titulo_registroderecepcionistas);
            this.panel1.Location = new System.Drawing.Point(136, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 319);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Rol para el Perfil:\r\n";
            // 
            // comboRoles
            // 
            this.comboRoles.FormattingEnabled = true;
            this.comboRoles.Location = new System.Drawing.Point(277, 230);
            this.comboRoles.Name = "comboRoles";
            this.comboRoles.Size = new System.Drawing.Size(197, 21);
            this.comboRoles.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Usuarios Registrados:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Contraseña para el Perfil:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Usuario para el Perfil:\r\n";
            // 
            // btnCrearPerfil
            // 
            this.btnCrearPerfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearPerfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearPerfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearPerfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearPerfil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCrearPerfil.ForeColor = System.Drawing.Color.White;
            this.btnCrearPerfil.Location = new System.Drawing.Point(222, 269);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.Size = new System.Drawing.Size(96, 36);
            this.btnCrearPerfil.TabIndex = 15;
            this.btnCrearPerfil.Text = "Crear Perfil";
            this.btnCrearPerfil.Click += new System.EventHandler(this.btnCrearPerfil_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(277, 140);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 20);
            this.txtUsuario.TabIndex = 29;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(277, 187);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(197, 20);
            this.txtContraseña.TabIndex = 28;
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(277, 91);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(197, 21);
            this.comboUsuarios.TabIndex = 27;
            // 
            // lbl_titulo_registroderecepcionistas
            // 
            this.lbl_titulo_registroderecepcionistas.AutoSize = true;
            this.lbl_titulo_registroderecepcionistas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo_registroderecepcionistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_registroderecepcionistas.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo_registroderecepcionistas.Location = new System.Drawing.Point(155, 16);
            this.lbl_titulo_registroderecepcionistas.Name = "lbl_titulo_registroderecepcionistas";
            this.lbl_titulo_registroderecepcionistas.Size = new System.Drawing.Size(202, 26);
            this.lbl_titulo_registroderecepcionistas.TabIndex = 26;
            this.lbl_titulo_registroderecepcionistas.Text = "Registro de Perfiles\r\n";
            // 
            // Form_CrearPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_superior_registrarrecepcionista);
            this.Name = "Form_CrearPerfil";
            this.Text = "Form_CrearPerfil";
            this.Pnl_superior_registrarrecepcionista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel Pnl_superior_registrarrecepcionista;
        private Guna.UI2.WinForms.Guna2Button Btn_volver_recepcionista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCrearPerfil;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.Label lbl_titulo_registroderecepcionistas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRoles;
    }
}