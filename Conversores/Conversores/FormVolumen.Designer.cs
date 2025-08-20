namespace Conversores
{
    partial class FormVolumen
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
            this.lblConvertidor_De_Volumen = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblBarril = new System.Windows.Forms.Label();
            this.lblCuarto = new System.Windows.Forms.Label();
            this.lblPinta = new System.Windows.Forms.Label();
            this.lblOnza_liquida = new System.Windows.Forms.Label();
            this.lblGalon_UK = new System.Windows.Forms.Label();
            this.lblGalon_EEUU = new System.Windows.Forms.Label();
            this.lblCentimetro_cubico = new System.Windows.Forms.Label();
            this.lblMililitro = new System.Windows.Forms.Label();
            this.lblMetro_cubico = new System.Windows.Forms.Label();
            this.lblLitro = new System.Windows.Forms.Label();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConvertidor_De_Volumen
            // 
            this.lblConvertidor_De_Volumen.AutoSize = true;
            this.lblConvertidor_De_Volumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertidor_De_Volumen.Location = new System.Drawing.Point(193, 21);
            this.lblConvertidor_De_Volumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConvertidor_De_Volumen.Name = "lblConvertidor_De_Volumen";
            this.lblConvertidor_De_Volumen.Size = new System.Drawing.Size(265, 26);
            this.lblConvertidor_De_Volumen.TabIndex = 29;
            this.lblConvertidor_De_Volumen.Text = "Convertidor de volumen";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(174, 75);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(188, 20);
            this.txtNum1.TabIndex = 28;
            // 
            // lblBarril
            // 
            this.lblBarril.AutoSize = true;
            this.lblBarril.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarril.Location = new System.Drawing.Point(55, 379);
            this.lblBarril.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarril.Name = "lblBarril";
            this.lblBarril.Size = new System.Drawing.Size(96, 16);
            this.lblBarril.TabIndex = 27;
            this.lblBarril.Text = "Barril (bbl): ?";
            // 
            // lblCuarto
            // 
            this.lblCuarto.AutoSize = true;
            this.lblCuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuarto.Location = new System.Drawing.Point(55, 350);
            this.lblCuarto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuarto.Name = "lblCuarto";
            this.lblCuarto.Size = new System.Drawing.Size(95, 16);
            this.lblCuarto.TabIndex = 26;
            this.lblCuarto.Text = "Cuarto (qt): ?";
            // 
            // lblPinta
            // 
            this.lblPinta.AutoSize = true;
            this.lblPinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinta.Location = new System.Drawing.Point(55, 318);
            this.lblPinta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPinta.Name = "lblPinta";
            this.lblPinta.Size = new System.Drawing.Size(85, 16);
            this.lblPinta.TabIndex = 25;
            this.lblPinta.Text = "Pinta (pt): ?";
            // 
            // lblOnza_liquida
            // 
            this.lblOnza_liquida.AutoSize = true;
            this.lblOnza_liquida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnza_liquida.Location = new System.Drawing.Point(55, 292);
            this.lblOnza_liquida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnza_liquida.Name = "lblOnza_liquida";
            this.lblOnza_liquida.Size = new System.Drawing.Size(151, 16);
            this.lblOnza_liquida.TabIndex = 24;
            this.lblOnza_liquida.Text = "Onza líquida (fl oz): ?";
            // 
            // lblGalon_UK
            // 
            this.lblGalon_UK.AutoSize = true;
            this.lblGalon_UK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalon_UK.Location = new System.Drawing.Point(55, 266);
            this.lblGalon_UK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGalon_UK.Name = "lblGalon_UK";
            this.lblGalon_UK.Size = new System.Drawing.Size(184, 16);
            this.lblGalon_UK.TabIndex = 23;
            this.lblGalon_UK.Text = "Galón imperial (gal UK): ?";
            // 
            // lblGalon_EEUU
            // 
            this.lblGalon_EEUU.AutoSize = true;
            this.lblGalon_EEUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalon_EEUU.Location = new System.Drawing.Point(55, 236);
            this.lblGalon_EEUU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGalon_EEUU.Name = "lblGalon_EEUU";
            this.lblGalon_EEUU.Size = new System.Drawing.Size(240, 16);
            this.lblGalon_EEUU.TabIndex = 22;
            this.lblGalon_EEUU.Text = "Galón estadounidense (gal US): ?";
            // 
            // lblCentimetro_cubico
            // 
            this.lblCentimetro_cubico.AutoSize = true;
            this.lblCentimetro_cubico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentimetro_cubico.Location = new System.Drawing.Point(55, 206);
            this.lblCentimetro_cubico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCentimetro_cubico.Name = "lblCentimetro_cubico";
            this.lblCentimetro_cubico.Size = new System.Drawing.Size(186, 16);
            this.lblCentimetro_cubico.TabIndex = 21;
            this.lblCentimetro_cubico.Text = "Centímetro cúbico (cm³): ?";
            // 
            // lblMililitro
            // 
            this.lblMililitro.AutoSize = true;
            this.lblMililitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMililitro.Location = new System.Drawing.Point(55, 143);
            this.lblMililitro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMililitro.Name = "lblMililitro";
            this.lblMililitro.Size = new System.Drawing.Size(107, 16);
            this.lblMililitro.TabIndex = 20;
            this.lblMililitro.Text = "Mililitro (mL): ?";
            // 
            // lblMetro_cubico
            // 
            this.lblMetro_cubico.AutoSize = true;
            this.lblMetro_cubico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetro_cubico.Location = new System.Drawing.Point(55, 176);
            this.lblMetro_cubico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMetro_cubico.Name = "lblMetro_cubico";
            this.lblMetro_cubico.Size = new System.Drawing.Size(143, 16);
            this.lblMetro_cubico.TabIndex = 19;
            this.lblMetro_cubico.Text = "Metro cúbico (m³): ?";
            // 
            // lblLitro
            // 
            this.lblLitro.AutoSize = true;
            this.lblLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitro.Location = new System.Drawing.Point(55, 114);
            this.lblLitro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLitro.Name = "lblLitro";
            this.lblLitro.Size = new System.Drawing.Size(83, 16);
            this.lblLitro.TabIndex = 18;
            this.lblLitro.Text = "Litros (L): ?";
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(31, 73);
            this.lblnum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(138, 18);
            this.lblnum1.TabIndex = 17;
            this.lblnum1.Text = "Ingrese un valor: ";
            // 
            // cboOrigen
            // 
            this.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "Litro (L) - Unidad base",
            "Mililitro (mL)",
            "Metro cúbico (m³)",
            "Centímetro cúbico (cm³)",
            "Galón estadounidense (gal US)",
            "Galón imperial (gal UK)",
            "Onza líquida (fl oz)",
            "Pinta (pt)",
            "Cuarto (qt)",
            "Barril (bbl)"});
            this.cboOrigen.Location = new System.Drawing.Point(389, 75);
            this.cboOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(163, 21);
            this.cboOrigen.TabIndex = 16;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(501, 155);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(125, 127);
            this.btnConvertir.TabIndex = 15;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(386, 57);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(131, 16);
            this.lblOrigen.TabIndex = 30;
            this.lblOrigen.Text = "Unidad de origen:";
            this.lblOrigen.Click += new System.EventHandler(this.lblOrigen_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(501, 320);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(125, 76);
            this.btnCerrar.TabIndex = 64;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormVolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 423);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblConvertidor_De_Volumen);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblBarril);
            this.Controls.Add(this.lblCuarto);
            this.Controls.Add(this.lblPinta);
            this.Controls.Add(this.lblOnza_liquida);
            this.Controls.Add(this.lblGalon_UK);
            this.Controls.Add(this.lblGalon_EEUU);
            this.Controls.Add(this.lblCentimetro_cubico);
            this.Controls.Add(this.lblMililitro);
            this.Controls.Add(this.lblMetro_cubico);
            this.Controls.Add(this.lblLitro);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.btnConvertir);
            this.Name = "FormVolumen";
            this.RightToLeftLayout = true;
            this.Text = "Convertidor Volumen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvertidor_De_Volumen;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblBarril;
        private System.Windows.Forms.Label lblCuarto;
        private System.Windows.Forms.Label lblPinta;
        private System.Windows.Forms.Label lblOnza_liquida;
        private System.Windows.Forms.Label lblGalon_UK;
        private System.Windows.Forms.Label lblGalon_EEUU;
        private System.Windows.Forms.Label lblCentimetro_cubico;
        private System.Windows.Forms.Label lblMililitro;
        private System.Windows.Forms.Label lblMetro_cubico;
        private System.Windows.Forms.Label lblLitro;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnCerrar;
    }
}