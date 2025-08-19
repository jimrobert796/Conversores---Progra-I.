
namespace Conversor_volumen
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblLitro = new System.Windows.Forms.Label();
            this.lblMetro_cubico = new System.Windows.Forms.Label();
            this.lblMililitro = new System.Windows.Forms.Label();
            this.lblCentimetro_cubico = new System.Windows.Forms.Label();
            this.lblGalon_EEUU = new System.Windows.Forms.Label();
            this.lblGalon_UK = new System.Windows.Forms.Label();
            this.lblOnza_liquida = new System.Windows.Forms.Label();
            this.lblPinta = new System.Windows.Forms.Label();
            this.lblCuarto = new System.Windows.Forms.Label();
            this.lblBarril = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblConvertidor_De_Volumen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(649, 219);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(167, 156);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click_1);
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
            this.cboOrigen.Location = new System.Drawing.Point(498, 87);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(216, 24);
            this.cboOrigen.TabIndex = 1;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(21, 85);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(173, 24);
            this.lblnum1.TabIndex = 2;
            this.lblnum1.Text = "Ingrese un valor: ";
            // 
            // lblLitro
            // 
            this.lblLitro.AutoSize = true;
            this.lblLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitro.Location = new System.Drawing.Point(54, 135);
            this.lblLitro.Name = "lblLitro";
            this.lblLitro.Size = new System.Drawing.Size(111, 20);
            this.lblLitro.TabIndex = 3;
            this.lblLitro.Text = "Litros (L): ?";
            // 
            // lblMetro_cubico
            // 
            this.lblMetro_cubico.AutoSize = true;
            this.lblMetro_cubico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetro_cubico.Location = new System.Drawing.Point(54, 212);
            this.lblMetro_cubico.Name = "lblMetro_cubico";
            this.lblMetro_cubico.Size = new System.Drawing.Size(182, 20);
            this.lblMetro_cubico.TabIndex = 4;
            this.lblMetro_cubico.Text = "Metro cúbico (m³): ?";
            // 
            // lblMililitro
            // 
            this.lblMililitro.AutoSize = true;
            this.lblMililitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMililitro.Location = new System.Drawing.Point(54, 171);
            this.lblMililitro.Name = "lblMililitro";
            this.lblMililitro.Size = new System.Drawing.Size(140, 20);
            this.lblMililitro.TabIndex = 5;
            this.lblMililitro.Text = "Mililitro (mL): ?";
            // 
            // lblCentimetro_cubico
            // 
            this.lblCentimetro_cubico.AutoSize = true;
            this.lblCentimetro_cubico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentimetro_cubico.Location = new System.Drawing.Point(54, 248);
            this.lblCentimetro_cubico.Name = "lblCentimetro_cubico";
            this.lblCentimetro_cubico.Size = new System.Drawing.Size(236, 20);
            this.lblCentimetro_cubico.TabIndex = 6;
            this.lblCentimetro_cubico.Text = "Centímetro cúbico (cm³): ?";
            // 
            // lblGalon_EEUU
            // 
            this.lblGalon_EEUU.AutoSize = true;
            this.lblGalon_EEUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalon_EEUU.Location = new System.Drawing.Point(54, 286);
            this.lblGalon_EEUU.Name = "lblGalon_EEUU";
            this.lblGalon_EEUU.Size = new System.Drawing.Size(293, 20);
            this.lblGalon_EEUU.TabIndex = 7;
            this.lblGalon_EEUU.Text = "Galón estadounidense (gal US): ?";
            // 
            // lblGalon_UK
            // 
            this.lblGalon_UK.AutoSize = true;
            this.lblGalon_UK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalon_UK.Location = new System.Drawing.Point(54, 322);
            this.lblGalon_UK.Name = "lblGalon_UK";
            this.lblGalon_UK.Size = new System.Drawing.Size(229, 20);
            this.lblGalon_UK.TabIndex = 8;
            this.lblGalon_UK.Text = "Galón imperial (gal UK): ?";
            // 
            // lblOnza_liquida
            // 
            this.lblOnza_liquida.AutoSize = true;
            this.lblOnza_liquida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnza_liquida.Location = new System.Drawing.Point(54, 355);
            this.lblOnza_liquida.Name = "lblOnza_liquida";
            this.lblOnza_liquida.Size = new System.Drawing.Size(193, 20);
            this.lblOnza_liquida.TabIndex = 9;
            this.lblOnza_liquida.Text = "Onza líquida (fl oz): ?";
            // 
            // lblPinta
            // 
            this.lblPinta.AutoSize = true;
            this.lblPinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinta.Location = new System.Drawing.Point(54, 387);
            this.lblPinta.Name = "lblPinta";
            this.lblPinta.Size = new System.Drawing.Size(110, 20);
            this.lblPinta.TabIndex = 10;
            this.lblPinta.Text = "Pinta (pt): ?";
            // 
            // lblCuarto
            // 
            this.lblCuarto.AutoSize = true;
            this.lblCuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuarto.Location = new System.Drawing.Point(54, 426);
            this.lblCuarto.Name = "lblCuarto";
            this.lblCuarto.Size = new System.Drawing.Size(123, 20);
            this.lblCuarto.TabIndex = 11;
            this.lblCuarto.Text = "Cuarto (qt): ?";
            // 
            // lblBarril
            // 
            this.lblBarril.AutoSize = true;
            this.lblBarril.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarril.Location = new System.Drawing.Point(54, 462);
            this.lblBarril.Name = "lblBarril";
            this.lblBarril.Size = new System.Drawing.Size(123, 20);
            this.lblBarril.TabIndex = 12;
            this.lblBarril.Text = "Barril (bbl): ?";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(212, 87);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(250, 22);
            this.txtNum1.TabIndex = 13;
            // 
            // lblConvertidor_De_Volumen
            // 
            this.lblConvertidor_De_Volumen.AutoSize = true;
            this.lblConvertidor_De_Volumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertidor_De_Volumen.Location = new System.Drawing.Point(252, 28);
            this.lblConvertidor_De_Volumen.Name = "lblConvertidor_De_Volumen";
            this.lblConvertidor_De_Volumen.Size = new System.Drawing.Size(338, 32);
            this.lblConvertidor_De_Volumen.TabIndex = 14;
            this.lblConvertidor_De_Volumen.Text = "Convertidor de volumen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 540);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblLitro;
        private System.Windows.Forms.Label lblMetro_cubico;
        private System.Windows.Forms.Label lblMililitro;
        private System.Windows.Forms.Label lblCentimetro_cubico;
        private System.Windows.Forms.Label lblGalon_EEUU;
        private System.Windows.Forms.Label lblGalon_UK;
        private System.Windows.Forms.Label lblOnza_liquida;
        private System.Windows.Forms.Label lblPinta;
        private System.Windows.Forms.Label lblCuarto;
        private System.Windows.Forms.Label lblBarril;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblConvertidor_De_Volumen;
    }
}

