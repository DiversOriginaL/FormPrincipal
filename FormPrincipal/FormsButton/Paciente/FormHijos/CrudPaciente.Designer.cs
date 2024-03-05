﻿namespace FormPrincipal.FormsButton.Paciente.FormHijos
{
    partial class CrudPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudPaciente));
            this.txtPnombre = new System.Windows.Forms.TextBox();
            this.txtSapellido = new System.Windows.Forms.TextBox();
            this.txtSnombre = new System.Windows.Forms.TextBox();
            this.txtPapellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtNumCasa = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEstadoSalud = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPnombre
            // 
            this.txtPnombre.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPnombre.ForeColor = System.Drawing.Color.Silver;
            this.txtPnombre.Location = new System.Drawing.Point(109, 76);
            this.txtPnombre.Multiline = true;
            this.txtPnombre.Name = "txtPnombre";
            this.txtPnombre.Size = new System.Drawing.Size(485, 46);
            this.txtPnombre.TabIndex = 1;
            this.txtPnombre.Text = "PRIMER NOMBRE:";
            this.txtPnombre.Enter += new System.EventHandler(this.txtPnombre_Enter);
            this.txtPnombre.Leave += new System.EventHandler(this.txtPnombre_Leave);
            // 
            // txtSapellido
            // 
            this.txtSapellido.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSapellido.ForeColor = System.Drawing.Color.Silver;
            this.txtSapellido.Location = new System.Drawing.Point(109, 267);
            this.txtSapellido.Multiline = true;
            this.txtSapellido.Name = "txtSapellido";
            this.txtSapellido.Size = new System.Drawing.Size(485, 46);
            this.txtSapellido.TabIndex = 4;
            this.txtSapellido.Text = "SEGUNDO APELLIDO:";
            this.txtSapellido.Enter += new System.EventHandler(this.txtSapellido_Enter);
            this.txtSapellido.Leave += new System.EventHandler(this.txtSapellido_Leave);
            // 
            // txtSnombre
            // 
            this.txtSnombre.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSnombre.ForeColor = System.Drawing.Color.Silver;
            this.txtSnombre.Location = new System.Drawing.Point(109, 139);
            this.txtSnombre.Multiline = true;
            this.txtSnombre.Name = "txtSnombre";
            this.txtSnombre.Size = new System.Drawing.Size(485, 46);
            this.txtSnombre.TabIndex = 2;
            this.txtSnombre.Text = "SEGUNDO NOMBRE:";
            this.txtSnombre.Enter += new System.EventHandler(this.txtSnombre_Enter);
            this.txtSnombre.Leave += new System.EventHandler(this.txtSnombre_Leave);
            // 
            // txtPapellido
            // 
            this.txtPapellido.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPapellido.ForeColor = System.Drawing.Color.Silver;
            this.txtPapellido.Location = new System.Drawing.Point(109, 203);
            this.txtPapellido.Multiline = true;
            this.txtPapellido.Name = "txtPapellido";
            this.txtPapellido.Size = new System.Drawing.Size(485, 46);
            this.txtPapellido.TabIndex = 3;
            this.txtPapellido.Text = "PRIMER APELLIDO:";
            this.txtPapellido.Enter += new System.EventHandler(this.txtPapellido_Enter);
            this.txtPapellido.Leave += new System.EventHandler(this.txtPapellido_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEdad.ForeColor = System.Drawing.Color.Silver;
            this.txtEdad.Location = new System.Drawing.Point(668, 76);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(485, 46);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.Text = "EDAD:";
            this.txtEdad.Enter += new System.EventHandler(this.txtEdad_Enter);
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersona.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPersona.Location = new System.Drawing.Point(12, 9);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(217, 53);
            this.lblPersona.TabIndex = 0;
            this.lblPersona.Text = "Persona:";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContacto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContacto.Location = new System.Drawing.Point(12, 350);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(235, 53);
            this.lblContacto.TabIndex = 7;
            this.lblContacto.Text = "Contacto:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefono.Location = new System.Drawing.Point(668, 418);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(485, 46);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Text = "TELEFONO:";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCelular.ForeColor = System.Drawing.Color.Silver;
            this.txtCelular.Location = new System.Drawing.Point(109, 418);
            this.txtCelular.Multiline = true;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(485, 46);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.Text = "CELULAR:";
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUbicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUbicacion.Location = new System.Drawing.Point(12, 515);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(253, 53);
            this.lblUbicacion.TabIndex = 10;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // txtSector
            // 
            this.txtSector.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSector.ForeColor = System.Drawing.Color.Silver;
            this.txtSector.Location = new System.Drawing.Point(109, 647);
            this.txtSector.Multiline = true;
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(485, 46);
            this.txtSector.TabIndex = 12;
            this.txtSector.Text = "SECTOR:";
            this.txtSector.Enter += new System.EventHandler(this.txtSector_Enter);
            this.txtSector.Leave += new System.EventHandler(this.txtSector_Leave);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCiudad.ForeColor = System.Drawing.Color.Silver;
            this.txtCiudad.Location = new System.Drawing.Point(109, 588);
            this.txtCiudad.Multiline = true;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(485, 46);
            this.txtCiudad.TabIndex = 11;
            this.txtCiudad.Text = "CIUDAD:";
            this.txtCiudad.Enter += new System.EventHandler(this.txtCiudad_Enter);
            this.txtCiudad.Leave += new System.EventHandler(this.txtCiudad_Leave);
            // 
            // txtNumCasa
            // 
            this.txtNumCasa.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumCasa.ForeColor = System.Drawing.Color.Silver;
            this.txtNumCasa.Location = new System.Drawing.Point(109, 706);
            this.txtNumCasa.Multiline = true;
            this.txtNumCasa.Name = "txtNumCasa";
            this.txtNumCasa.Size = new System.Drawing.Size(485, 46);
            this.txtNumCasa.TabIndex = 13;
            this.txtNumCasa.Text = "NUMERO DE CASA:";
            this.txtNumCasa.Enter += new System.EventHandler(this.txtNumCasa_Enter);
            this.txtNumCasa.Leave += new System.EventHandler(this.txtNumCasa_Leave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(68)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(758, 803);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(256, 67);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = " GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(68)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(1054, 803);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(236, 67);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEstadoSalud
            // 
            this.btnEstadoSalud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadoSalud.FlatAppearance.BorderSize = 5;
            this.btnEstadoSalud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(68)))));
            this.btnEstadoSalud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(68)))));
            this.btnEstadoSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoSalud.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadoSalud.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEstadoSalud.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadoSalud.Image")));
            this.btnEstadoSalud.Location = new System.Drawing.Point(668, 588);
            this.btnEstadoSalud.Name = "btnEstadoSalud";
            this.btnEstadoSalud.Size = new System.Drawing.Size(499, 164);
            this.btnEstadoSalud.TabIndex = 14;
            this.btnEstadoSalud.Text = "ESTADO DE SALUD";
            this.btnEstadoSalud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadoSalud.UseVisualStyleBackColor = true;
            this.btnEstadoSalud.Click += new System.EventHandler(this.btnEstadoSalud_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSexo.ForeColor = System.Drawing.Color.Silver;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(668, 139);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(485, 42);
            this.cbSexo.TabIndex = 17;
            this.cbSexo.Text = "SEXO:";
            this.cbSexo.Leave += new System.EventHandler(this.cbSexo_Leave);
            // 
            // CrudPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1302, 882);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnEstadoSalud);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNumCasa);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtPapellido);
            this.Controls.Add(this.txtSnombre);
            this.Controls.Add(this.txtSapellido);
            this.Controls.Add(this.txtPnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudPaciente";
            this.Text = "CrudPaciente";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CrudPaciente_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPnombre;
        private TextBox txtSapellido;
        private TextBox txtSnombre;
        private TextBox txtPapellido;
        private TextBox txtEdad;
        private Label lblPersona;
        private Label lblContacto;
        private TextBox txtTelefono;
        private TextBox txtCelular;
        private Label lblUbicacion;
        private TextBox txtSector;
        private TextBox txtCiudad;
        private TextBox txtNumCasa;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnEstadoSalud;
        private ComboBox cbSexo;
    }
}