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
            this.label_usuario = new System.Windows.Forms.Label();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.label_contra = new System.Windows.Forms.Label();
            this.text_contra = new System.Windows.Forms.TextBox();
            this.btn_sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnv
            // 
            this.bnv.BackColor = System.Drawing.Color.Transparent;
            this.bnv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnv.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bnv.ForeColor = System.Drawing.Color.LightBlue;
            this.bnv.Location = new System.Drawing.Point(32, 9);
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
            this.inicieSesion.Location = new System.Drawing.Point(12, 112);
            this.inicieSesion.Name = "inicieSesion";
            this.inicieSesion.Size = new System.Drawing.Size(337, 68);
            this.inicieSesion.TabIndex = 3;
            this.inicieSesion.Text = "Inicie Sesión\r\n";
            this.inicieSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_usuario
            // 
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_usuario.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_usuario.ForeColor = System.Drawing.Color.White;
            this.label_usuario.Location = new System.Drawing.Point(46, 180);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(90, 44);
            this.label_usuario.TabIndex = 4;
            this.label_usuario.Text = "Usuario";
            this.label_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_usuario
            // 
            this.text_usuario.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.text_usuario.Location = new System.Drawing.Point(59, 216);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(244, 21);
            this.text_usuario.TabIndex = 5;
            this.text_usuario.Tag = "";
            this.text_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_usuario_KeyDown);
            // 
            // label_contra
            // 
            this.label_contra.BackColor = System.Drawing.Color.Transparent;
            this.label_contra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_contra.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_contra.ForeColor = System.Drawing.Color.White;
            this.label_contra.Location = new System.Drawing.Point(46, 250);
            this.label_contra.Name = "label_contra";
            this.label_contra.Size = new System.Drawing.Size(111, 44);
            this.label_contra.TabIndex = 6;
            this.label_contra.Text = "Contraseña";
            this.label_contra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_contra
            // 
            this.text_contra.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.text_contra.Location = new System.Drawing.Point(59, 288);
            this.text_contra.Name = "text_contra";
            this.text_contra.Size = new System.Drawing.Size(244, 21);
            this.text_contra.TabIndex = 7;
            this.text_contra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_contra_KeyDown);
            // 
            // btn_sign
            // 
            this.btn_sign.AutoSize = true;
            this.btn_sign.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_sign.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_sign.Location = new System.Drawing.Point(118, 335);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(118, 44);
            this.btn_sign.TabIndex = 8;
            this.btn_sign.Text = "ENTRAR";
            this.btn_sign.UseVisualStyleBackColor = false;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.text_contra);
            this.Controls.Add(this.label_contra);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.inicieSesion);
            this.Controls.Add(this.bnv);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_sign;

        private System.Windows.Forms.TextBox text_contra;

        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.Label label_contra;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label_usuario;

        private System.Windows.Forms.Label inicieSesion;

        private System.Windows.Forms.Label bnv;

        #endregion
    }
}