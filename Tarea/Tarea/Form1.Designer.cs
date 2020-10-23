namespace Tarea
{
    partial class Form1
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
            this.btnServivo = new System.Windows.Forms.Button();
            this.btnMamíferos = new System.Windows.Forms.Button();
            this.btnGatitos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServivo
            // 
            this.btnServivo.Location = new System.Drawing.Point(327, 87);
            this.btnServivo.Name = "btnServivo";
            this.btnServivo.Size = new System.Drawing.Size(85, 23);
            this.btnServivo.TabIndex = 0;
            this.btnServivo.Text = "Ser vivo";
            this.btnServivo.UseVisualStyleBackColor = true;
            this.btnServivo.Click += new System.EventHandler(this.btnServivo_Click);
            // 
            // btnMamíferos
            // 
            this.btnMamíferos.Location = new System.Drawing.Point(327, 153);
            this.btnMamíferos.Name = "btnMamíferos";
            this.btnMamíferos.Size = new System.Drawing.Size(85, 23);
            this.btnMamíferos.TabIndex = 1;
            this.btnMamíferos.Text = "Mamíferos";
            this.btnMamíferos.UseVisualStyleBackColor = true;
            this.btnMamíferos.Click += new System.EventHandler(this.btnMamíferos_Click);
            // 
            // btnGatitos
            // 
            this.btnGatitos.Location = new System.Drawing.Point(327, 227);
            this.btnGatitos.Name = "btnGatitos";
            this.btnGatitos.Size = new System.Drawing.Size(85, 23);
            this.btnGatitos.TabIndex = 2;
            this.btnGatitos.Text = "Gatitos";
            this.btnGatitos.UseVisualStyleBackColor = true;
            this.btnGatitos.Click += new System.EventHandler(this.btnGatitos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGatitos);
            this.Controls.Add(this.btnMamíferos);
            this.Controls.Add(this.btnServivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServivo;
        private System.Windows.Forms.Button btnMamíferos;
        private System.Windows.Forms.Button btnGatitos;
    }
}

