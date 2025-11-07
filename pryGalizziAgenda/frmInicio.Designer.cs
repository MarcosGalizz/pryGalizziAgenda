namespace pryGalizziAgenda
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.gunaBtnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLblTituloAgenda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaDgvAgenda = new Guna.UI2.WinForms.Guna2DataGridView();
            this.asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaBtnActualizar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaBtnAgregar
            // 
            this.gunaBtnAgregar.Animated = true;
            this.gunaBtnAgregar.AutoRoundedCorners = true;
            this.gunaBtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBtnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gunaBtnAgregar.ForeColor = System.Drawing.Color.White;
            this.gunaBtnAgregar.Location = new System.Drawing.Point(49, 368);
            this.gunaBtnAgregar.Name = "gunaBtnAgregar";
            this.gunaBtnAgregar.Size = new System.Drawing.Size(180, 45);
            this.gunaBtnAgregar.TabIndex = 0;
            this.gunaBtnAgregar.Text = "Agregar actividad";
            this.gunaBtnAgregar.Click += new System.EventHandler(this.gunaBtnAgregar_Click);
            // 
            // gunaBtnEliminar
            // 
            this.gunaBtnEliminar.Animated = true;
            this.gunaBtnEliminar.AutoRoundedCorners = true;
            this.gunaBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBtnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gunaBtnEliminar.ForeColor = System.Drawing.Color.White;
            this.gunaBtnEliminar.Location = new System.Drawing.Point(283, 368);
            this.gunaBtnEliminar.Name = "gunaBtnEliminar";
            this.gunaBtnEliminar.Size = new System.Drawing.Size(180, 45);
            this.gunaBtnEliminar.TabIndex = 1;
            this.gunaBtnEliminar.Text = "Eliminar actividad";
            this.gunaBtnEliminar.Click += new System.EventHandler(this.gunaBtnEliminar_Click);
            // 
            // gunaBtnSalir
            // 
            this.gunaBtnSalir.Animated = true;
            this.gunaBtnSalir.AutoRoundedCorners = true;
            this.gunaBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBtnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gunaBtnSalir.ForeColor = System.Drawing.Color.White;
            this.gunaBtnSalir.Location = new System.Drawing.Point(514, 368);
            this.gunaBtnSalir.Name = "gunaBtnSalir";
            this.gunaBtnSalir.Size = new System.Drawing.Size(180, 45);
            this.gunaBtnSalir.TabIndex = 2;
            this.gunaBtnSalir.Text = "Salir";
            this.gunaBtnSalir.Click += new System.EventHandler(this.gunaBtnSalir_Click);
            // 
            // gunaLblTituloAgenda
            // 
            this.gunaLblTituloAgenda.AutoSize = false;
            this.gunaLblTituloAgenda.BackColor = System.Drawing.Color.Transparent;
            this.gunaLblTituloAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLblTituloAgenda.Location = new System.Drawing.Point(252, 22);
            this.gunaLblTituloAgenda.Name = "gunaLblTituloAgenda";
            this.gunaLblTituloAgenda.Size = new System.Drawing.Size(225, 31);
            this.gunaLblTituloAgenda.TabIndex = 3;
            this.gunaLblTituloAgenda.Text = "Agenda de actividades";
            // 
            // gunaDgvAgenda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDgvAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDgvAgenda.ColumnHeadersHeight = 15;
            this.gunaDgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asunto,
            this.fecha,
            this.observacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDgvAgenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDgvAgenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvAgenda.Location = new System.Drawing.Point(49, 59);
            this.gunaDgvAgenda.Name = "gunaDgvAgenda";
            this.gunaDgvAgenda.RowHeadersVisible = false;
            this.gunaDgvAgenda.RowHeadersWidth = 51;
            this.gunaDgvAgenda.Size = new System.Drawing.Size(645, 265);
            this.gunaDgvAgenda.TabIndex = 4;
            this.gunaDgvAgenda.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvAgenda.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDgvAgenda.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDgvAgenda.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDgvAgenda.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDgvAgenda.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvAgenda.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvAgenda.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDgvAgenda.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDgvAgenda.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvAgenda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDgvAgenda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDgvAgenda.ThemeStyle.HeaderStyle.Height = 15;
            this.gunaDgvAgenda.ThemeStyle.ReadOnly = false;
            this.gunaDgvAgenda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvAgenda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDgvAgenda.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvAgenda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDgvAgenda.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDgvAgenda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDgvAgenda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // asunto
            // 
            this.asunto.HeaderText = "Asunto";
            this.asunto.MinimumWidth = 6;
            this.asunto.Name = "asunto";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            // 
            // observacion
            // 
            this.observacion.HeaderText = "Observacion";
            this.observacion.MinimumWidth = 6;
            this.observacion.Name = "observacion";
            // 
            // gunaBtnActualizar
            // 
            this.gunaBtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBtnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnActualizar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnActualizar.ForeColor = System.Drawing.Color.White;
            this.gunaBtnActualizar.Location = new System.Drawing.Point(646, 22);
            this.gunaBtnActualizar.Name = "gunaBtnActualizar";
            this.gunaBtnActualizar.Size = new System.Drawing.Size(48, 31);
            this.gunaBtnActualizar.TabIndex = 5;
            this.gunaBtnActualizar.Text = "🔄";
            this.gunaBtnActualizar.Click += new System.EventHandler(this.gunaBtnActualizar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.gunaBtnActualizar);
            this.Controls.Add(this.gunaDgvAgenda);
            this.Controls.Add(this.gunaLblTituloAgenda);
            this.Controls.Add(this.gunaBtnSalir);
            this.Controls.Add(this.gunaBtnEliminar);
            this.Controls.Add(this.gunaBtnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button gunaBtnAgregar;
        private Guna.UI2.WinForms.Guna2Button gunaBtnEliminar;
        private Guna.UI2.WinForms.Guna2Button gunaBtnSalir;
        private Guna.UI2.WinForms.Guna2HtmlLabel gunaLblTituloAgenda;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDgvAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private Guna.UI2.WinForms.Guna2Button gunaBtnActualizar;
    }
}