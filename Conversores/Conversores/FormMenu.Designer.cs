namespace Conversores
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasa = new System.Windows.Forms.Button();
            this.btnMonedas = new System.Windows.Forms.Button();
            this.btnLongitud = new System.Windows.Forms.Button();
            this.btnVolumen = new System.Windows.Forms.Button();
            this.btnAlmacenamiento = new System.Windows.Forms.Button();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu de conversiones";
            // 
            // btnMasa
            // 
            this.btnMasa.Location = new System.Drawing.Point(384, 91);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.Size = new System.Drawing.Size(99, 55);
            this.btnMasa.TabIndex = 1;
            this.btnMasa.Text = "Masa";
            this.btnMasa.UseVisualStyleBackColor = true;
            this.btnMasa.Click += new System.EventHandler(this.btnMasa_Click);
            // 
            // btnMonedas
            // 
            this.btnMonedas.Location = new System.Drawing.Point(59, 91);
            this.btnMonedas.Name = "btnMonedas";
            this.btnMonedas.Size = new System.Drawing.Size(99, 55);
            this.btnMonedas.TabIndex = 2;
            this.btnMonedas.Text = "Monedas";
            this.btnMonedas.UseVisualStyleBackColor = true;
            this.btnMonedas.Click += new System.EventHandler(this.btnMonedas_Click);
            // 
            // btnLongitud
            // 
            this.btnLongitud.Location = new System.Drawing.Point(384, 176);
            this.btnLongitud.Name = "btnLongitud";
            this.btnLongitud.Size = new System.Drawing.Size(99, 55);
            this.btnLongitud.TabIndex = 2;
            this.btnLongitud.Text = "Longitud";
            this.btnLongitud.UseVisualStyleBackColor = true;
            this.btnLongitud.Click += new System.EventHandler(this.btnLongitud_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.Location = new System.Drawing.Point(59, 176);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(99, 55);
            this.btnVolumen.TabIndex = 2;
            this.btnVolumen.Text = "Volumen ";
            this.btnVolumen.UseVisualStyleBackColor = true;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // btnAlmacenamiento
            // 
            this.btnAlmacenamiento.Location = new System.Drawing.Point(59, 259);
            this.btnAlmacenamiento.Name = "btnAlmacenamiento";
            this.btnAlmacenamiento.Size = new System.Drawing.Size(99, 55);
            this.btnAlmacenamiento.TabIndex = 2;
            this.btnAlmacenamiento.Text = "Almacenamiento";
            this.btnAlmacenamiento.UseVisualStyleBackColor = true;
            this.btnAlmacenamiento.Click += new System.EventHandler(this.btnAlmacenamiento_Click);
            // 
            // btnTiempo
            // 
            this.btnTiempo.Location = new System.Drawing.Point(384, 259);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(99, 55);
            this.btnTiempo.TabIndex = 2;
            this.btnTiempo.Text = "Tiempo";
            this.btnTiempo.UseVisualStyleBackColor = true;
            this.btnTiempo.Click += new System.EventHandler(this.btnTiempo_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 349);
            this.Controls.Add(this.btnAlmacenamiento);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.btnTiempo);
            this.Controls.Add(this.btnLongitud);
            this.Controls.Add(this.btnMonedas);
            this.Controls.Add(this.btnMasa);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.Button btnMonedas;
        private System.Windows.Forms.Button btnLongitud;
        private System.Windows.Forms.Button btnVolumen;
        private System.Windows.Forms.Button btnAlmacenamiento;
        private System.Windows.Forms.Button btnTiempo;
    }
}