namespace proclinica
{
    partial class Form_RegistrarPacientes
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
            this.Pnl_superior_registrarpacientes = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Pnl_Fondo_registropacientes = new Guna.UI2.WinForms.Guna2Panel();
            this.lblnumcontacto = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lbldocumento = new System.Windows.Forms.Label();
            this.lbltipodedocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTipoDoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEdad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDocumento = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_titulo_registrodepacientes = new System.Windows.Forms.Label();
            this.btnEnviar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_volver = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_superior_registrarpacientes.SuspendLayout();
            this.Pnl_Fondo_registropacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_superior_registrarpacientes
            // 
            this.Pnl_superior_registrarpacientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_superior_registrarpacientes.Controls.Add(this.Btn_volver);
            this.Pnl_superior_registrarpacientes.Location = new System.Drawing.Point(0, 0);
            this.Pnl_superior_registrarpacientes.Name = "Pnl_superior_registrarpacientes";
            this.Pnl_superior_registrarpacientes.Size = new System.Drawing.Size(801, 64);
            this.Pnl_superior_registrarpacientes.TabIndex = 1;
            // 
            // Pnl_Fondo_registropacientes
            // 
            this.Pnl_Fondo_registropacientes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_Fondo_registropacientes.Controls.Add(this.btnEnviar);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.lblnumcontacto);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.lblEdad);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.lblGenero);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.lbldocumento);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.lbltipodedocumento);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.lblNombre);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.cmbGenero);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.cmbTipoDoc);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.txtTelefono);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.txtEdad);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.txtDocumento);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.txtNombre);
            this.Pnl_Fondo_registropacientes.Controls.Add(this.lbl_titulo_registrodepacientes);
            this.Pnl_Fondo_registropacientes.Location = new System.Drawing.Point(181, 95);
            this.Pnl_Fondo_registropacientes.Name = "Pnl_Fondo_registropacientes";
            this.Pnl_Fondo_registropacientes.Size = new System.Drawing.Size(427, 461);
            this.Pnl_Fondo_registropacientes.TabIndex = 2;
            // 
            // lblnumcontacto
            // 
            this.lblnumcontacto.AutoSize = true;
            this.lblnumcontacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumcontacto.ForeColor = System.Drawing.Color.White;
            this.lblnumcontacto.Location = new System.Drawing.Point(21, 343);
            this.lblnumcontacto.Name = "lblnumcontacto";
            this.lblnumcontacto.Size = new System.Drawing.Size(157, 24);
            this.lblnumcontacto.TabIndex = 12;
            this.lblnumcontacto.Text = "Num de Contacto";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(21, 292);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 24);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(21, 229);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(74, 24);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Genero";
            // 
            // lbldocumento
            // 
            this.lbldocumento.AutoSize = true;
            this.lbldocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldocumento.ForeColor = System.Drawing.Color.White;
            this.lbldocumento.Location = new System.Drawing.Point(21, 176);
            this.lbldocumento.Name = "lbldocumento";
            this.lbldocumento.Size = new System.Drawing.Size(108, 24);
            this.lbldocumento.TabIndex = 9;
            this.lbldocumento.Text = "Documento";
            // 
            // lbltipodedocumento
            // 
            this.lbltipodedocumento.AutoSize = true;
            this.lbltipodedocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipodedocumento.ForeColor = System.Drawing.Color.White;
            this.lbltipodedocumento.Location = new System.Drawing.Point(21, 121);
            this.lbltipodedocumento.Name = "lbltipodedocumento";
            this.lbltipodedocumento.Size = new System.Drawing.Size(176, 24);
            this.lbltipodedocumento.TabIndex = 8;
            this.lbltipodedocumento.Text = "Tipo de documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(21, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.Transparent;
            this.cmbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGenero.ItemHeight = 30;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No binario",
            "Otro",
            "Prefiero no decirlo"});
            this.cmbGenero.Location = new System.Drawing.Point(252, 229);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(140, 36);
            this.cmbGenero.TabIndex = 6;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoDoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoDoc.ItemHeight = 30;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "Cédula de Ciudadanía",
            "Tarjeta de Identidad",
            "Cédula Extranjera",
            "Pasaporte",
            "Otro"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(252, 121);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(140, 36);
            this.cmbTipoDoc.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.Location = new System.Drawing.Point(252, 331);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(140, 36);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.DefaultText = "";
            this.txtEdad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEdad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEdad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEdad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdad.Location = new System.Drawing.Point(252, 280);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PlaceholderText = "";
            this.txtEdad.SelectedText = "";
            this.txtEdad.Size = new System.Drawing.Size(140, 36);
            this.txtEdad.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumento.DefaultText = "";
            this.txtDocumento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocumento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocumento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocumento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocumento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocumento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumento.Location = new System.Drawing.Point(252, 176);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PlaceholderText = "";
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.Size = new System.Drawing.Size(140, 36);
            this.txtDocumento.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(252, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(140, 36);
            this.txtNombre.TabIndex = 1;
            // 
            // lbl_titulo_registrodepacientes
            // 
            this.lbl_titulo_registrodepacientes.AutoSize = true;
            this.lbl_titulo_registrodepacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_registrodepacientes.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo_registrodepacientes.Location = new System.Drawing.Point(109, 11);
            this.lbl_titulo_registrodepacientes.Name = "lbl_titulo_registrodepacientes";
            this.lbl_titulo_registrodepacientes.Size = new System.Drawing.Size(225, 26);
            this.lbl_titulo_registrodepacientes.TabIndex = 0;
            this.lbl_titulo_registrodepacientes.Text = "Registro de Pacientes";
            // 
            // btnEnviar
            // 
            this.btnEnviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(131, 403);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(153, 36);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Btn_volver
            // 
            this.Btn_volver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_volver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_volver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_volver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_volver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_volver.ForeColor = System.Drawing.Color.White;
            this.Btn_volver.Location = new System.Drawing.Point(12, 12);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(96, 36);
            this.Btn_volver.TabIndex = 14;
            this.Btn_volver.Text = "volver";
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // Form_RegistrarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.Pnl_Fondo_registropacientes);
            this.Controls.Add(this.Pnl_superior_registrarpacientes);
            this.Name = "Form_RegistrarPacientes";
            this.Text = "Form_RegistrarPacientes";
            this.Pnl_superior_registrarpacientes.ResumeLayout(false);
            this.Pnl_Fondo_registropacientes.ResumeLayout(false);
            this.Pnl_Fondo_registropacientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel Pnl_superior_registrarpacientes;
        private Guna.UI2.WinForms.Guna2Panel Pnl_Fondo_registropacientes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGenero;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoDoc;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtEdad;
        private Guna.UI2.WinForms.Guna2TextBox txtDocumento;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label lbl_titulo_registrodepacientes;
        private System.Windows.Forms.Label lblnumcontacto;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lbldocumento;
        private System.Windows.Forms.Label lbltipodedocumento;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2Button btnEnviar;
        private Guna.UI2.WinForms.Guna2Button Btn_volver;
    }
}