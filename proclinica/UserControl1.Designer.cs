namespace proclinica
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.contraseña_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_btn = new Guna.UI2.WinForms.Guna2Button();
            this.correo_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_Btn
            // 
            this.login_Btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.login_Btn.BorderRadius = 20;
            this.login_Btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.login_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_Btn.ForeColor = System.Drawing.Color.White;
            this.login_Btn.Location = new System.Drawing.Point(159, 299);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(180, 45);
            this.login_Btn.TabIndex = 3;
            this.login_Btn.Text = "iniciar";
            this.login_Btn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // contraseña_txt
            // 
            this.contraseña_txt.BorderRadius = 20;
            this.contraseña_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contraseña_txt.DefaultText = "Contraseña";
            this.contraseña_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contraseña_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contraseña_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contraseña_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contraseña_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contraseña_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contraseña_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contraseña_txt.Location = new System.Drawing.Point(231, 227);
            this.contraseña_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contraseña_txt.Name = "contraseña_txt";
            this.contraseña_txt.PlaceholderText = "";
            this.contraseña_txt.SelectedText = "";
            this.contraseña_txt.Size = new System.Drawing.Size(256, 48);
            this.contraseña_txt.TabIndex = 1;
            this.contraseña_txt.TextChanged += new System.EventHandler(this.guna2TextBox1_OnTextChanged);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.register_btn.BorderRadius = 20;
            this.register_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.register_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.register_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.register_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.register_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(391, 299);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(180, 45);
            this.register_btn.TabIndex = 4;
            this.register_btn.Text = "Registrate";
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // correo_txt
            // 
            this.correo_txt.BorderRadius = 20;
            this.correo_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.correo_txt.DefaultText = "Correo";
            this.correo_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.correo_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.correo_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.correo_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.correo_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.correo_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.correo_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.correo_txt.Location = new System.Drawing.Point(231, 159);
            this.correo_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correo_txt.Name = "correo_txt";
            this.correo_txt.PlaceholderText = "";
            this.correo_txt.SelectedText = "";
            this.correo_txt.Size = new System.Drawing.Size(256, 48);
            this.correo_txt.TabIndex = 5;
            this.correo_txt.TextChanged += new System.EventHandler(this.correo_txt_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel1.BorderRadius = 195;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.correo_txt);
            this.guna2Panel1.Controls.Add(this.register_btn);
            this.guna2Panel1.Controls.Add(this.contraseña_txt);
            this.guna2Panel1.Controls.Add(this.login_Btn);
            this.guna2Panel1.Location = new System.Drawing.Point(51, 30);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(710, 392);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(246, 79);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(229, 41);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Iniciar Seccion";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_Btn;
        private Guna.UI2.WinForms.Guna2TextBox contraseña_txt;
        private Guna.UI2.WinForms.Guna2Button register_btn;
        private Guna.UI2.WinForms.Guna2TextBox correo_txt;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
