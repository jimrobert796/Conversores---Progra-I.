
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
            this.lblMetro = new System.Windows.Forms.Label();
            this.lblCentimetro = new System.Windows.Forms.Label();
            this.lblKilometro = new System.Windows.Forms.Label();
            this.lblMilimetro = new System.Windows.Forms.Label();
            this.lblMilla = new System.Windows.Forms.Label();
            this.lblYarda = new System.Windows.Forms.Label();
            this.lblPie = new System.Windows.Forms.Label();
            this.lblPulgada = new System.Windows.Forms.Label();
            this.lblMilla_Nautica = new System.Windows.Forms.Label();
            this.lblAnu_luz = new System.Windows.Forms.Label();
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
            "Metro (m)",
            "Kilómetro (km)",
            "Centímetro (cm)",
            "Milímetro (mm)",
            "Milla (mi)",
            "Yarda (yd)",
            "Pie (ft)",
            "Pulgada (in)",
            "Milla náutica (nmi)",
            "Año luz (ly)"});
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
            // lblMetro
            // 
            this.lblMetro.AutoSize = true;
            this.lblMetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetro.Location = new System.Drawing.Point(54, 135);
            this.lblMetro.Name = "lblMetro";
            this.lblMetro.Size = new System.Drawing.Size(79, 20);
            this.lblMetro.TabIndex = 3;
            this.lblMetro.Text = "Metro: ?";
            // 
            // lblCentimetro
            // 
            this.lblCentimetro.AutoSize = true;
            this.lblCentimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentimetro.Location = new System.Drawing.Point(54, 212);
            this.lblCentimetro.Name = "lblCentimetro";
            this.lblCentimetro.Size = new System.Drawing.Size(130, 20);
            this.lblCentimetro.TabIndex = 4;
            this.lblCentimetro.Text = "Centrimetro: ?";
            // 
            // lblKilometro
            // 
            this.lblKilometro.AutoSize = true;
            this.lblKilometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometro.Location = new System.Drawing.Point(54, 171);
            this.lblKilometro.Name = "lblKilometro";
            this.lblKilometro.Size = new System.Drawing.Size(111, 20);
            this.lblKilometro.TabIndex = 5;
            this.lblKilometro.Text = "Kilometro: ?";
            // 
            // lblMilimetro
            // 
            this.lblMilimetro.AutoSize = true;
            this.lblMilimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilimetro.Location = new System.Drawing.Point(54, 248);
            this.lblMilimetro.Name = "lblMilimetro";
            this.lblMilimetro.Size = new System.Drawing.Size(109, 20);
            this.lblMilimetro.TabIndex = 6;
            this.lblMilimetro.Text = "Milimetro: ?";
            // 
            // lblMilla
            // 
            this.lblMilla.AutoSize = true;
            this.lblMilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilla.Location = new System.Drawing.Point(54, 286);
            this.lblMilla.Name = "lblMilla";
            this.lblMilla.Size = new System.Drawing.Size(71, 20);
            this.lblMilla.TabIndex = 7;
            this.lblMilla.Text = "Milla: ?";
            // 
            // lblYarda
            // 
            this.lblYarda.AutoSize = true;
            this.lblYarda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYarda.Location = new System.Drawing.Point(54, 322);
            this.lblYarda.Name = "lblYarda";
            this.lblYarda.Size = new System.Drawing.Size(79, 20);
            this.lblYarda.TabIndex = 8;
            this.lblYarda.Text = "Yarda: ?";
            // 
            // lblPie
            // 
            this.lblPie.AutoSize = true;
            this.lblPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPie.Location = new System.Drawing.Point(54, 355);
            this.lblPie.Name = "lblPie";
            this.lblPie.Size = new System.Drawing.Size(58, 20);
            this.lblPie.TabIndex = 9;
            this.lblPie.Text = "Pie: ?";
            // 
            // lblPulgada
            // 
            this.lblPulgada.AutoSize = true;
            this.lblPulgada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulgada.Location = new System.Drawing.Point(54, 387);
            this.lblPulgada.Name = "lblPulgada";
            this.lblPulgada.Size = new System.Drawing.Size(98, 20);
            this.lblPulgada.TabIndex = 10;
            this.lblPulgada.Text = "Pulgada: ?";
            // 
            // lblMilla_Nautica
            // 
            this.lblMilla_Nautica.AutoSize = true;
            this.lblMilla_Nautica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilla_Nautica.Location = new System.Drawing.Point(54, 426);
            this.lblMilla_Nautica.Name = "lblMilla_Nautica";
            this.lblMilla_Nautica.Size = new System.Drawing.Size(141, 20);
            this.lblMilla_Nautica.TabIndex = 11;
            this.lblMilla_Nautica.Text = "Milla Nautica: ?";
            // 
            // lblAnu_luz
            // 
            this.lblAnu_luz.AutoSize = true;
            this.lblAnu_luz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnu_luz.Location = new System.Drawing.Point(54, 462);
            this.lblAnu_luz.Name = "lblAnu_luz";
            this.lblAnu_luz.Size = new System.Drawing.Size(100, 20);
            this.lblAnu_luz.TabIndex = 12;
            this.lblAnu_luz.Text = "Año  luz: ?";
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
            this.lblConvertidor_De_Volumen.Size = new System.Drawing.Size(342, 32);
            this.lblConvertidor_De_Volumen.TabIndex = 14;
            this.lblConvertidor_De_Volumen.Text = "Convertidor de Longitud";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 540);
            this.Controls.Add(this.lblConvertidor_De_Volumen);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblAnu_luz);
            this.Controls.Add(this.lblMilla_Nautica);
            this.Controls.Add(this.lblPulgada);
            this.Controls.Add(this.lblPie);
            this.Controls.Add(this.lblYarda);
            this.Controls.Add(this.lblMilla);
            this.Controls.Add(this.lblMilimetro);
            this.Controls.Add(this.lblKilometro);
            this.Controls.Add(this.lblCentimetro);
            this.Controls.Add(this.lblMetro);
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
        private System.Windows.Forms.Label lblMetro;
        private System.Windows.Forms.Label lblCentimetro;
        private System.Windows.Forms.Label lblKilometro;
        private System.Windows.Forms.Label lblMilimetro;
        private System.Windows.Forms.Label lblMilla;
        private System.Windows.Forms.Label lblYarda;
        private System.Windows.Forms.Label lblPie;
        private System.Windows.Forms.Label lblPulgada;
        private System.Windows.Forms.Label lblMilla_Nautica;
        private System.Windows.Forms.Label lblAnu_luz;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblConvertidor_De_Volumen;
    }
}

