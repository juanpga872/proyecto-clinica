namespace proclinica
{
    partial class Form_prueba
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
            this.btnVerRecepcionistas = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarRecepcionista = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnVerRecepcionistas
            // 
            this.btnVerRecepcionistas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerRecepcionistas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerRecepcionistas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerRecepcionistas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerRecepcionistas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVerRecepcionistas.ForeColor = System.Drawing.Color.White;
            this.btnVerRecepcionistas.Location = new System.Drawing.Point(43, 221);
            this.btnVerRecepcionistas.Name = "btnVerRecepcionistas";
            this.btnVerRecepcionistas.Size = new System.Drawing.Size(180, 45);
            this.btnVerRecepcionistas.TabIndex = 0;
            this.btnVerRecepcionistas.Text = "Ver Recepcionistas";
            this.btnVerRecepcionistas.Click += new System.EventHandler(this.btnVerRecepcionistas_Click);
            // 
            // btnRegistrarRecepcionista
            // 
            this.btnRegistrarRecepcionista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarRecepcionista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarRecepcionista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrarRecepcionista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarRecepcionista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrarRecepcionista.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarRecepcionista.Location = new System.Drawing.Point(43, 121);
            this.btnRegistrarRecepcionista.Name = "btnRegistrarRecepcionista";
            this.btnRegistrarRecepcionista.Size = new System.Drawing.Size(180, 45);
            this.btnRegistrarRecepcionista.TabIndex = 1;
            this.btnRegistrarRecepcionista.Text = "Registrar recepcionista";
            this.btnRegistrarRecepcionista.Click += new System.EventHandler(this.btnRegistrarRecepcionista_Click);
            // 
            // Form_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrarRecepcionista);
            this.Controls.Add(this.btnVerRecepcionistas);
            this.Name = "Form_prueba";
            this.Text = "Form_prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnVerRecepcionistas;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarRecepcionista;
    }
}