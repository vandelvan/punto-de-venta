using System.ComponentModel;

namespace puntoDeVentaSBD
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.connect = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.connect.ForeColor = System.Drawing.Color.LightBlue;
            this.connect.Location = new System.Drawing.Point(172, 249);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(179, 58);
            this.connect.TabIndex = 0;
            this.connect.Text = "INGRESAR";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logo.Font = new System.Drawing.Font("Unispace", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.logo.ForeColor = System.Drawing.Color.LightBlue;
            this.logo.Location = new System.Drawing.Point(56, 46);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(394, 189);
            this.logo.TabIndex = 1;
            this.logo.Text = "ZAZ Abarrotes \r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(495, 414);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.connect);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label logo;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button connect;

        #endregion
    }
}