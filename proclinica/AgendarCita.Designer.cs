namespace proclinica
{
    partial class AgendarCita
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
            this.dateTimeHora = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.txcDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txcConsultorio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnVolverAtras = new Guna.UI2.WinForms.Guna2Button();
            this.txcPaciente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateTimeFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContainerControl1.SuspendLayout();
            this.guna2ContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeHora
            // 
            this.dateTimeHora.Checked = true;
            this.dateTimeHora.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dateTimeHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHora.Location = new System.Drawing.Point(93, 113);
            this.dateTimeHora.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimeHora.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeHora.Name = "dateTimeHora";
            this.dateTimeHora.ShowUpDown = true;
            this.dateTimeHora.Size = new System.Drawing.Size(200, 36);
            this.dateTimeHora.TabIndex = 0;
            this.dateTimeHora.Value = new System.DateTime(2025, 5, 7, 9, 56, 43, 918);
            this.dateTimeHora.ValueChanged += new System.EventHandler(this.dateTimeHora_ValueChanged);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.txtMotivo);
            this.guna2ContainerControl1.Controls.Add(this.btnAgregar);
            this.guna2ContainerControl1.Controls.Add(this.DateTimeFecha);
            this.guna2ContainerControl1.Controls.Add(this.txcPaciente);
            this.guna2ContainerControl1.Controls.Add(this.txcDoctor);
            this.guna2ContainerControl1.Controls.Add(this.txcConsultorio);
            this.guna2ContainerControl1.Controls.Add(this.dateTimeHora);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(101, 153);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(729, 416);
            this.guna2ContainerControl1.TabIndex = 1;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // txcDoctor
            // 
            this.txcDoctor.BackColor = System.Drawing.Color.Transparent;
            this.txcDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txcDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txcDoctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txcDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txcDoctor.ItemHeight = 30;
            this.txcDoctor.Location = new System.Drawing.Point(372, 43);
            this.txcDoctor.Name = "txcDoctor";
            this.txcDoctor.Size = new System.Drawing.Size(200, 36);
            this.txcDoctor.TabIndex = 5;
            this.txcDoctor.SelectedIndexChanged += new System.EventHandler(this.txcDoctor_SelectedIndexChanged);
            // 
            // txcConsultorio
            // 
            this.txcConsultorio.BackColor = System.Drawing.Color.Transparent;
            this.txcConsultorio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txcConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txcConsultorio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcConsultorio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcConsultorio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txcConsultorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txcConsultorio.ItemHeight = 30;
            this.txcConsultorio.Location = new System.Drawing.Point(372, 113);
            this.txcConsultorio.Name = "txcConsultorio";
            this.txcConsultorio.Size = new System.Drawing.Size(200, 36);
            this.txcConsultorio.TabIndex = 3;
            this.txcConsultorio.SelectedIndexChanged += new System.EventHandler(this.txcConsultorio_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(399, 100);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(145, 31);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Agendar cita\r\n";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.Controls.Add(this.btnVolverAtras);
            this.guna2ContainerControl2.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2ContainerControl2.Location = new System.Drawing.Point(-7, -1);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(974, 83);
            this.guna2ContainerControl2.TabIndex = 3;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolverAtras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolverAtras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolverAtras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolverAtras.FillColor = System.Drawing.Color.Red;
            this.btnVolverAtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.btnVolverAtras.Location = new System.Drawing.Point(31, 22);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(100, 39);
            this.btnVolverAtras.TabIndex = 3;
            this.btnVolverAtras.Text = "volver";
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // txcPaciente
            // 
            this.txcPaciente.BackColor = System.Drawing.Color.Transparent;
            this.txcPaciente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txcPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txcPaciente.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcPaciente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txcPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txcPaciente.ItemHeight = 30;
            this.txcPaciente.Location = new System.Drawing.Point(93, 43);
            this.txcPaciente.Name = "txcPaciente";
            this.txcPaciente.Size = new System.Drawing.Size(200, 36);
            this.txcPaciente.TabIndex = 7;
            this.txcPaciente.SelectedIndexChanged += new System.EventHandler(this.txcPaciente_SelectedIndexChanged);
            // 
            // DateTimeFecha
            // 
            this.DateTimeFecha.Checked = true;
            this.DateTimeFecha.FillColor = System.Drawing.Color.LightSkyBlue;
            this.DateTimeFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeFecha.Location = new System.Drawing.Point(93, 203);
            this.DateTimeFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeFecha.Name = "DateTimeFecha";
            this.DateTimeFecha.Size = new System.Drawing.Size(200, 36);
            this.DateTimeFecha.TabIndex = 8;
            this.DateTimeFecha.Value = new System.DateTime(2025, 5, 7, 9, 56, 43, 918);
            this.DateTimeFecha.ValueChanged += new System.EventHandler(this.DateTimeFecha_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(93, 324);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 52);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.DefaultText = "";
            this.txtMotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.Location = new System.Drawing.Point(372, 203);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.Size = new System.Drawing.Size(281, 173);
            this.txtMotivo.TabIndex = 10;
            this.txtMotivo.TextChanged += new System.EventHandler(this.txtMotivo_TextChanged);
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 629);
            this.Controls.Add(this.guna2ContainerControl2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "AgendarCita";
            this.Text = "AgendarCita";
            this.Load += new System.EventHandler(this.AgendarCita_Load);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimeHora;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Guna.UI2.WinForms.Guna2ComboBox txcConsultorio;
        private Guna.UI2.WinForms.Guna2ComboBox txcDoctor;
        private Guna.UI2.WinForms.Guna2Button btnVolverAtras;
        private Guna.UI2.WinForms.Guna2ComboBox txcPaciente;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeFecha;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
    }
}