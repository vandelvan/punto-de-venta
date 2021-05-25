using System.ComponentModel;

namespace puntoDeVentaSBD
{
    partial class Error
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.texto = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.texto.ForeColor = System.Drawing.Color.White;
            this.texto.Location = new System.Drawing.Point(12, 9);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(278, 99);
            this.texto.TabIndex = 0;
            this.texto.Text = "¡No se pudo conectar!\r\nVerifique la base de datos y vuelva a intentarlo.\r\n";
            this.texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.BackColor = System.Drawing.Color.White;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.connect.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.connect.Location = new System.Drawing.Point(96, 100);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(118, 44);
            this.connect.TabIndex = 1;
            this.connect.Text = "OK";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(301, 173);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.texto);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button connect;

        private System.Windows.Forms.Label texto;

        #endregion
    }
}