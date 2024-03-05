namespace FormPrincipal.FormsButton.Paciente.FormHijos.FormEstadoSalud
{
    partial class EstadoSalud
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
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.rbSiEnfermedad = new System.Windows.Forms.RadioButton();
            this.rbNoEnfermedad = new System.Windows.Forms.RadioButton();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.rdNoMedicamento = new System.Windows.Forms.RadioButton();
            this.rdSiMedicamento = new System.Windows.Forms.RadioButton();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblAlergia = new System.Windows.Forms.Label();
            this.rbNoAlergia = new System.Windows.Forms.RadioButton();
            this.rbSiAlergia = new System.Windows.Forms.RadioButton();
            this.txtAlergia = new System.Windows.Forms.TextBox();
            this.lblEmbarazo = new System.Windows.Forms.Label();
            this.txtEmbarazo = new System.Windows.Forms.TextBox();
            this.rbNoEmbarazada = new System.Windows.Forms.RadioButton();
            this.rbSiEmbarazada = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnfermedad.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnfermedad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnfermedad.Location = new System.Drawing.Point(63, 9);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(497, 34);
            this.lblEnfermedad.TabIndex = 7;
            this.lblEnfermedad.Text = "¿Tiene algun tipo de enfermedad?";
            // 
            // rbSiEnfermedad
            // 
            this.rbSiEnfermedad.AutoSize = true;
            this.rbSiEnfermedad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiEnfermedad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSiEnfermedad.Location = new System.Drawing.Point(221, 57);
            this.rbSiEnfermedad.Name = "rbSiEnfermedad";
            this.rbSiEnfermedad.Size = new System.Drawing.Size(53, 28);
            this.rbSiEnfermedad.TabIndex = 8;
            this.rbSiEnfermedad.Text = "SI";
            this.rbSiEnfermedad.UseVisualStyleBackColor = true;
            this.rbSiEnfermedad.CheckedChanged += new System.EventHandler(this.rbSiEnfermedad_CheckedChanged);
            // 
            // rbNoEnfermedad
            // 
            this.rbNoEnfermedad.AutoSize = true;
            this.rbNoEnfermedad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoEnfermedad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNoEnfermedad.Location = new System.Drawing.Point(297, 57);
            this.rbNoEnfermedad.Name = "rbNoEnfermedad";
            this.rbNoEnfermedad.Size = new System.Drawing.Size(62, 28);
            this.rbNoEnfermedad.TabIndex = 9;
            this.rbNoEnfermedad.Text = "NO";
            this.rbNoEnfermedad.UseVisualStyleBackColor = true;
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Enabled = false;
            this.txtEnfermedad.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnfermedad.ForeColor = System.Drawing.Color.Silver;
            this.txtEnfermedad.Location = new System.Drawing.Point(12, 102);
            this.txtEnfermedad.Multiline = true;
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(599, 377);
            this.txtEnfermedad.TabIndex = 10;
            this.txtEnfermedad.Text = "DESCRIPCION:";
            this.txtEnfermedad.Visible = false;
            this.txtEnfermedad.Enter += new System.EventHandler(this.txtEnfermedad_Enter);
            this.txtEnfermedad.Leave += new System.EventHandler(this.txtEnfermedad_Leave);
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMedicamento.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedicamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMedicamento.Location = new System.Drawing.Point(17, 502);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(543, 34);
            this.lblMedicamento.TabIndex = 11;
            this.lblMedicamento.Text = "¿Estas tomando algun medicamento?";
            // 
            // rdNoMedicamento
            // 
            this.rdNoMedicamento.AutoSize = true;
            this.rdNoMedicamento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdNoMedicamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdNoMedicamento.Location = new System.Drawing.Point(297, 552);
            this.rdNoMedicamento.Name = "rdNoMedicamento";
            this.rdNoMedicamento.Size = new System.Drawing.Size(62, 28);
            this.rdNoMedicamento.TabIndex = 13;
            this.rdNoMedicamento.Text = "NO";
            this.rdNoMedicamento.UseVisualStyleBackColor = true;
            // 
            // rdSiMedicamento
            // 
            this.rdSiMedicamento.AutoSize = true;
            this.rdSiMedicamento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdSiMedicamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdSiMedicamento.Location = new System.Drawing.Point(221, 552);
            this.rdSiMedicamento.Name = "rdSiMedicamento";
            this.rdSiMedicamento.Size = new System.Drawing.Size(53, 28);
            this.rdSiMedicamento.TabIndex = 12;
            this.rdSiMedicamento.Text = "SI";
            this.rdSiMedicamento.UseVisualStyleBackColor = true;
            this.rdSiMedicamento.CheckedChanged += new System.EventHandler(this.rdSiMedicamento_CheckedChanged);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Enabled = false;
            this.txtMedicamento.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMedicamento.ForeColor = System.Drawing.Color.Silver;
            this.txtMedicamento.Location = new System.Drawing.Point(12, 597);
            this.txtMedicamento.Multiline = true;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(599, 377);
            this.txtMedicamento.TabIndex = 14;
            this.txtMedicamento.Text = "DESCRIPCION:";
            this.txtMedicamento.Visible = false;
            this.txtMedicamento.Enter += new System.EventHandler(this.txtMedicamento_Enter);
            this.txtMedicamento.Leave += new System.EventHandler(this.txtMedicamento_Leave);
            // 
            // lblAlergia
            // 
            this.lblAlergia.AutoSize = true;
            this.lblAlergia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlergia.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlergia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlergia.Location = new System.Drawing.Point(687, 9);
            this.lblAlergia.Name = "lblAlergia";
            this.lblAlergia.Size = new System.Drawing.Size(580, 34);
            this.lblAlergia.TabIndex = 15;
            this.lblAlergia.Text = "¿Le genera alergia algun medicamento?";
            // 
            // rbNoAlergia
            // 
            this.rbNoAlergia.AutoSize = true;
            this.rbNoAlergia.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoAlergia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNoAlergia.Location = new System.Drawing.Point(1015, 57);
            this.rbNoAlergia.Name = "rbNoAlergia";
            this.rbNoAlergia.Size = new System.Drawing.Size(62, 28);
            this.rbNoAlergia.TabIndex = 17;
            this.rbNoAlergia.Text = "NO";
            this.rbNoAlergia.UseVisualStyleBackColor = true;
            // 
            // rbSiAlergia
            // 
            this.rbSiAlergia.AutoSize = true;
            this.rbSiAlergia.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiAlergia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSiAlergia.Location = new System.Drawing.Point(941, 57);
            this.rbSiAlergia.Name = "rbSiAlergia";
            this.rbSiAlergia.Size = new System.Drawing.Size(53, 28);
            this.rbSiAlergia.TabIndex = 16;
            this.rbSiAlergia.Text = "SI";
            this.rbSiAlergia.UseVisualStyleBackColor = true;
            this.rbSiAlergia.CheckedChanged += new System.EventHandler(this.rbSiAlergia_CheckedChanged);
            // 
            // txtAlergia
            // 
            this.txtAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlergia.Enabled = false;
            this.txtAlergia.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAlergia.ForeColor = System.Drawing.Color.Silver;
            this.txtAlergia.Location = new System.Drawing.Point(687, 102);
            this.txtAlergia.Multiline = true;
            this.txtAlergia.Name = "txtAlergia";
            this.txtAlergia.Size = new System.Drawing.Size(594, 377);
            this.txtAlergia.TabIndex = 18;
            this.txtAlergia.Text = "DESCRIPCION:";
            this.txtAlergia.Visible = false;
            this.txtAlergia.Enter += new System.EventHandler(this.txtAlergia_Enter);
            this.txtAlergia.Leave += new System.EventHandler(this.txtAlergia_Leave);
            // 
            // lblEmbarazo
            // 
            this.lblEmbarazo.AutoSize = true;
            this.lblEmbarazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmbarazo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmbarazo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmbarazo.Location = new System.Drawing.Point(854, 502);
            this.lblEmbarazo.Name = "lblEmbarazo";
            this.lblEmbarazo.Size = new System.Drawing.Size(304, 34);
            this.lblEmbarazo.TabIndex = 19;
            this.lblEmbarazo.Text = "¿Estas embarazada?";
            // 
            // txtEmbarazo
            // 
            this.txtEmbarazo.Enabled = false;
            this.txtEmbarazo.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmbarazo.ForeColor = System.Drawing.Color.Silver;
            this.txtEmbarazo.Location = new System.Drawing.Point(687, 597);
            this.txtEmbarazo.Multiline = true;
            this.txtEmbarazo.Name = "txtEmbarazo";
            this.txtEmbarazo.Size = new System.Drawing.Size(594, 371);
            this.txtEmbarazo.TabIndex = 20;
            this.txtEmbarazo.Text = "DESCRIPCION:";
            this.txtEmbarazo.Visible = false;
            this.txtEmbarazo.Enter += new System.EventHandler(this.txtEmbarazo_Enter);
            this.txtEmbarazo.Leave += new System.EventHandler(this.txtEmbarazo_Leave);
            // 
            // rbNoEmbarazada
            // 
            this.rbNoEmbarazada.AutoSize = true;
            this.rbNoEmbarazada.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoEmbarazada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNoEmbarazada.Location = new System.Drawing.Point(1015, 546);
            this.rbNoEmbarazada.Name = "rbNoEmbarazada";
            this.rbNoEmbarazada.Size = new System.Drawing.Size(62, 28);
            this.rbNoEmbarazada.TabIndex = 22;
            this.rbNoEmbarazada.Text = "NO";
            this.rbNoEmbarazada.UseVisualStyleBackColor = true;
            // 
            // rbSiEmbarazada
            // 
            this.rbSiEmbarazada.AutoSize = true;
            this.rbSiEmbarazada.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiEmbarazada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSiEmbarazada.Location = new System.Drawing.Point(941, 546);
            this.rbSiEmbarazada.Name = "rbSiEmbarazada";
            this.rbSiEmbarazada.Size = new System.Drawing.Size(53, 28);
            this.rbSiEmbarazada.TabIndex = 21;
            this.rbSiEmbarazada.Text = "SI";
            this.rbSiEmbarazada.UseVisualStyleBackColor = true;
            this.rbSiEmbarazada.CheckedChanged += new System.EventHandler(this.rbSiEmbarazada_CheckedChanged);
            // 
            // EstadoSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1293, 1000);
            this.Controls.Add(this.rbNoEmbarazada);
            this.Controls.Add(this.rbSiEmbarazada);
            this.Controls.Add(this.txtEmbarazo);
            this.Controls.Add(this.lblEmbarazo);
            this.Controls.Add(this.txtAlergia);
            this.Controls.Add(this.rbNoAlergia);
            this.Controls.Add(this.rbSiAlergia);
            this.Controls.Add(this.lblAlergia);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.rdNoMedicamento);
            this.Controls.Add(this.rdSiMedicamento);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.rbNoEnfermedad);
            this.Controls.Add(this.rbSiEnfermedad);
            this.Controls.Add(this.lblEnfermedad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoSalud";
            this.Text = "EstadoSalud";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EstadoSalud_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnfermedad;
        private RadioButton rbSiEnfermedad;
        private RadioButton rbNoEnfermedad;
        private TextBox txtEnfermedad;
        private Label lblMedicamento;
        private RadioButton rdNoMedicamento;
        private RadioButton rdSiMedicamento;
        private TextBox txtMedicamento;
        private Label lblAlergia;
        private RadioButton rbNoAlergia;
        private RadioButton rbSiAlergia;
        private TextBox txtAlergia;
        private Label lblEmbarazo;
        private TextBox txtEmbarazo;
        private RadioButton rbNoEmbarazada;
        private RadioButton rbSiEmbarazada;
    }
}