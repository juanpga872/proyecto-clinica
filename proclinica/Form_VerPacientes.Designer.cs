namespace proclinica
{
    partial class Form_VerPacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPacientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.Btn_volver = new Guna.UI2.WinForms.Guna2Button();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPacientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPacientes.ColumnHeadersHeight = 20;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPacientes.Location = new System.Drawing.Point(75, 108);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.RowHeadersVisible = false;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(644, 307);
            this.dataGridViewPacientes.TabIndex = 0;
            this.dataGridViewPacientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPacientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewPacientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewPacientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewPacientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewPacientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPacientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPacientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewPacientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPacientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPacientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPacientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewPacientes.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridViewPacientes.ThemeStyle.ReadOnly = false;
            this.dataGridViewPacientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPacientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPacientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPacientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewPacientes.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewPacientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPacientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacientes_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(261, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(268, 36);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(196, 42);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(59, 20);
            this.lblbuscar.TabIndex = 2;
            this.lblbuscar.Text = "Buscar";
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
            this.Btn_volver.TabIndex = 15;
            this.Btn_volver.Text = "volver";
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "eliminar";
            this.eliminar.MinimumWidth = 20;
            this.eliminar.Name = "eliminar";
            // 
            // Form_VerPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Name = "Form_VerPacientes";
            this.Text = "Form_VerPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewPacientes;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label lblbuscar;
        private Guna.UI2.WinForms.Guna2Button Btn_volver;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}