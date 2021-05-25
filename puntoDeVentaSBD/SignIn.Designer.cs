using System.ComponentModel;

namespace puntoDeVentaSBD
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.bnv = new System.Windows.Forms.Label();
            this.inicieSesion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnv
            // 
            this.bnv.BackColor = System.Drawing.Color.Transparent;
            this.bnv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnv.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bnv.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.bnv.Location = new System.Drawing.Point(32, 25);
            this.bnv.Name = "bnv";
            this.bnv.Size = new System.Drawing.Size(308, 118);
            this.bnv.TabIndex = 2;
            this.bnv.Text = "!Bienvenido¡";
            this.bnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inicieSesion
            // 
            this.inicieSesion.BackColor = System.Drawing.Color.Transparent;
            this.inicieSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inicieSesion.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inicieSesion.ForeColor = System.Drawing.Color.White;
            this.inicieSesion.Location = new System.Drawing.Point(13, 143);
            this.inicieSesion.Name = "inicieSesion";
            this.inicieSesion.Size = new System.Drawing.Size(337, 68);
            this.inicieSesion.TabIndex = 3;
            this.inicieSesion.Text = "Inicie Sesión\r\n";
            this.inicieSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.inicieSesion);
            this.Controls.Add(this.bnv);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label inicieSesion;

        private System.Windows.Forms.Label bnv;

        #endregion
    }
}