namespace pryGalizziAgenda
{
    partial class frmActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActividades));
            this.gunaLblActividad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaLblFecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaLblObservacion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaBtnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.gunaTxtActividad = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaDtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaTxtObservacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // gunaLblActividad
            // 
            this.gunaLblActividad.BackColor = System.Drawing.Color.Transparent;
            this.gunaLblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLblActividad.Location = new System.Drawing.Point(29, 40);
            this.gunaLblActividad.Name = "gunaLblActividad";
            this.gunaLblActividad.Size = new System.Drawing.Size(59, 18);
            this.gunaLblActividad.TabIndex = 4;
            this.gunaLblActividad.Text = "Actividad";
            // 
            // gunaLblFecha
            // 
            this.gunaLblFecha.BackColor = System.Drawing.Color.Transparent;
            this.gunaLblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLblFecha.Location = new System.Drawing.Point(29, 99);
            this.gunaLblFecha.Name = "gunaLblFecha";
            this.gunaLblFecha.Size = new System.Drawing.Size(41, 18);
            this.gunaLblFecha.TabIndex = 5;
            this.gunaLblFecha.Text = "Fecha";
            // 
            // gunaLblObservacion
            // 
            this.gunaLblObservacion.BackColor = System.Drawing.Color.Transparent;
            this.gunaLblObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLblObservacion.Location = new System.Drawing.Point(29, 167);
            this.gunaLblObservacion.Name = "gunaLblObservacion";
            this.gunaLblObservacion.Size = new System.Drawing.Size(80, 18);
            this.gunaLblObservacion.TabIndex = 6;
            this.gunaLblObservacion.Text = "Observación";
            // 
            // gunaBtnAceptar
            // 
            this.gunaBtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBtnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnAceptar.ForeColor = System.Drawing.Color.White;
            this.gunaBtnAceptar.Location = new System.Drawing.Point(125, 306);
            this.gunaBtnAceptar.Name = "gunaBtnAceptar";
            this.gunaBtnAceptar.Size = new System.Drawing.Size(180, 45);
            this.gunaBtnAceptar.TabIndex = 7;
            this.gunaBtnAceptar.Text = "Aceptar";
            this.gunaBtnAceptar.Click += new System.EventHandler(this.gunaBtnAceptar_Click);
            // 
            // gunaBtnCancelar
            // 
            this.gunaBtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBtnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnCancelar.ForeColor = System.Drawing.Color.White;
            this.gunaBtnCancelar.Location = new System.Drawing.Point(413, 306);
            this.gunaBtnCancelar.Name = "gunaBtnCancelar";
            this.gunaBtnCancelar.Size = new System.Drawing.Size(180, 45);
            this.gunaBtnCancelar.TabIndex = 8;
            this.gunaBtnCancelar.Text = "Cancelar";
            this.gunaBtnCancelar.Click += new System.EventHandler(this.gunaBtnCancelar_Click);
            // 
            // gunaTxtActividad
            // 
            this.gunaTxtActividad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtActividad.DefaultText = "";
            this.gunaTxtActividad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtActividad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtActividad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtActividad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtActividad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtActividad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTxtActividad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtActividad.Location = new System.Drawing.Point(125, 30);
            this.gunaTxtActividad.Name = "gunaTxtActividad";
            this.gunaTxtActividad.PlaceholderText = "";
            this.gunaTxtActividad.SelectedText = "";
            this.gunaTxtActividad.Size = new System.Drawing.Size(468, 39);
            this.gunaTxtActividad.TabIndex = 9;
            // 
            // gunaDtpFecha
            // 
            this.gunaDtpFecha.Checked = true;
            this.gunaDtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gunaDtpFecha.Location = new System.Drawing.Point(125, 90);
            this.gunaDtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDtpFecha.Name = "gunaDtpFecha";
            this.gunaDtpFecha.Size = new System.Drawing.Size(261, 36);
            this.gunaDtpFecha.TabIndex = 10;
            this.gunaDtpFecha.Value = new System.DateTime(2025, 9, 19, 18, 47, 41, 117);
            // 
            // gunaTxtObservacion
            // 
            this.gunaTxtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtObservacion.DefaultText = "";
            this.gunaTxtObservacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtObservacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtObservacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtObservacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtObservacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtObservacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTxtObservacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtObservacion.Location = new System.Drawing.Point(125, 157);
            this.gunaTxtObservacion.Multiline = true;
            this.gunaTxtObservacion.Name = "gunaTxtObservacion";
            this.gunaTxtObservacion.PlaceholderText = "";
            this.gunaTxtObservacion.SelectedText = "";
            this.gunaTxtObservacion.Size = new System.Drawing.Size(468, 123);
            this.gunaTxtObservacion.TabIndex = 11;
            // 
            // frmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 387);
            this.Controls.Add(this.gunaTxtObservacion);
            this.Controls.Add(this.gunaDtpFecha);
            this.Controls.Add(this.gunaTxtActividad);
            this.Controls.Add(this.gunaBtnCancelar);
            this.Controls.Add(this.gunaBtnAceptar);
            this.Controls.Add(this.gunaLblObservacion);
            this.Controls.Add(this.gunaLblFecha);
            this.Controls.Add(this.gunaLblActividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.frmActividades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel gunaLblActividad;
        private Guna.UI2.WinForms.Guna2HtmlLabel gunaLblFecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel gunaLblObservacion;
        private Guna.UI2.WinForms.Guna2Button gunaBtnAceptar;
        private Guna.UI2.WinForms.Guna2Button gunaBtnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtActividad;
        private Guna.UI2.WinForms.Guna2DateTimePicker gunaDtpFecha;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtObservacion;
    }
}