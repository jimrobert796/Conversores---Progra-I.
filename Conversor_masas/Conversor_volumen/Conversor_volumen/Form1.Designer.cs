
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
            this.lblKilogramo = new System.Windows.Forms.Label();
            this.lblMiligramo = new System.Windows.Forms.Label();
            this.lblGramo = new System.Windows.Forms.Label();
            this.lblTonelada_metrica = new System.Windows.Forms.Label();
            this.lblLibra = new System.Windows.Forms.Label();
            this.lblOnza = new System.Windows.Forms.Label();
            this.lblStone = new System.Windows.Forms.Label();
            this.lblQuintal = new System.Windows.Forms.Label();
            this.lblTonelada_Corta = new System.Windows.Forms.Label();
            this.lblTonelada_larga = new System.Windows.Forms.Label();
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
            "Kilogramo (kg)",
            "Gramo (g)",
            "Miligramo (mg)",
            "Tonelada métrica (t)",
            "Libra (lb)",
            "Onza (oz)",
            "Stone (st)",
            "Quintal (q)",
            "Tonelada corta (US ton)",
            "Tonelada larga (UK ton)"});
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
            // lblKilogramo
            // 
            this.lblKilogramo.AutoSize = true;
            this.lblKilogramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilogramo.Location = new System.Drawing.Point(54, 135);
            this.lblKilogramo.Name = "lblKilogramo";
            this.lblKilogramo.Size = new System.Drawing.Size(115, 20);
            this.lblKilogramo.TabIndex = 3;
            this.lblKilogramo.Text = "Kilogramo: ?";
            // 
            // lblMiligramo
            // 
            this.lblMiligramo.AutoSize = true;
            this.lblMiligramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiligramo.Location = new System.Drawing.Point(54, 212);
            this.lblMiligramo.Name = "lblMiligramo";
            this.lblMiligramo.Size = new System.Drawing.Size(113, 20);
            this.lblMiligramo.TabIndex = 4;
            this.lblMiligramo.Text = "Miligramo: ?";
            // 
            // lblGramo
            // 
            this.lblGramo.AutoSize = true;
            this.lblGramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramo.Location = new System.Drawing.Point(54, 171);
            this.lblGramo.Name = "lblGramo";
            this.lblGramo.Size = new System.Drawing.Size(87, 20);
            this.lblGramo.TabIndex = 5;
            this.lblGramo.Text = "Gramo: ?";
            // 
            // lblTonelada_metrica
            // 
            this.lblTonelada_metrica.AutoSize = true;
            this.lblTonelada_metrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonelada_metrica.Location = new System.Drawing.Point(54, 248);
            this.lblTonelada_metrica.Name = "lblTonelada_metrica";
            this.lblTonelada_metrica.Size = new System.Drawing.Size(176, 20);
            this.lblTonelada_metrica.TabIndex = 6;
            this.lblTonelada_metrica.Text = "Tonelada metrica: ?";
            // 
            // lblLibra
            // 
            this.lblLibra.AutoSize = true;
            this.lblLibra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibra.Location = new System.Drawing.Point(54, 286);
            this.lblLibra.Name = "lblLibra";
            this.lblLibra.Size = new System.Drawing.Size(74, 20);
            this.lblLibra.TabIndex = 7;
            this.lblLibra.Text = "Libra: ?";
            // 
            // lblOnza
            // 
            this.lblOnza.AutoSize = true;
            this.lblOnza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnza.Location = new System.Drawing.Point(54, 322);
            this.lblOnza.Name = "lblOnza";
            this.lblOnza.Size = new System.Drawing.Size(75, 20);
            this.lblOnza.TabIndex = 8;
            this.lblOnza.Text = "Onza: ?";
            // 
            // lblStone
            // 
            this.lblStone.AutoSize = true;
            this.lblStone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStone.Location = new System.Drawing.Point(54, 355);
            this.lblStone.Name = "lblStone";
            this.lblStone.Size = new System.Drawing.Size(79, 20);
            this.lblStone.TabIndex = 9;
            this.lblStone.Text = "Stone: ?";
            // 
            // lblQuintal
            // 
            this.lblQuintal.AutoSize = true;
            this.lblQuintal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuintal.Location = new System.Drawing.Point(54, 387);
            this.lblQuintal.Name = "lblQuintal";
            this.lblQuintal.Size = new System.Drawing.Size(91, 20);
            this.lblQuintal.TabIndex = 10;
            this.lblQuintal.Text = "Quintal: ?";
            // 
            // lblTonelada_Corta
            // 
            this.lblTonelada_Corta.AutoSize = true;
            this.lblTonelada_Corta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonelada_Corta.Location = new System.Drawing.Point(54, 426);
            this.lblTonelada_Corta.Name = "lblTonelada_Corta";
            this.lblTonelada_Corta.Size = new System.Drawing.Size(159, 20);
            this.lblTonelada_Corta.TabIndex = 11;
            this.lblTonelada_Corta.Text = "Tonelada Corta: ?";
            // 
            // lblTonelada_larga
            // 
            this.lblTonelada_larga.AutoSize = true;
            this.lblTonelada_larga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonelada_larga.Location = new System.Drawing.Point(54, 462);
            this.lblTonelada_larga.Name = "lblTonelada_larga";
            this.lblTonelada_larga.Size = new System.Drawing.Size(161, 20);
            this.lblTonelada_larga.TabIndex = 12;
            this.lblTonelada_larga.Text = "Tonelada Larga: ?";
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
            this.lblConvertidor_De_Volumen.Size = new System.Drawing.Size(311, 32);
            this.lblConvertidor_De_Volumen.TabIndex = 14;
            this.lblConvertidor_De_Volumen.Text = "Convertidor de masas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 540);
            this.Controls.Add(this.lblConvertidor_De_Volumen);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblTonelada_larga);
            this.Controls.Add(this.lblTonelada_Corta);
            this.Controls.Add(this.lblQuintal);
            this.Controls.Add(this.lblStone);
            this.Controls.Add(this.lblOnza);
            this.Controls.Add(this.lblLibra);
            this.Controls.Add(this.lblTonelada_metrica);
            this.Controls.Add(this.lblGramo);
            this.Controls.Add(this.lblMiligramo);
            this.Controls.Add(this.lblKilogramo);
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
        private System.Windows.Forms.Label lblKilogramo;
        private System.Windows.Forms.Label lblMiligramo;
        private System.Windows.Forms.Label lblGramo;
        private System.Windows.Forms.Label lblTonelada_metrica;
        private System.Windows.Forms.Label lblLibra;
        private System.Windows.Forms.Label lblOnza;
        private System.Windows.Forms.Label lblStone;
        private System.Windows.Forms.Label lblQuintal;
        private System.Windows.Forms.Label lblTonelada_Corta;
        private System.Windows.Forms.Label lblTonelada_larga;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblConvertidor_De_Volumen;
    }
}

