
namespace testegit
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(363, 340);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtnEntrar.TabIndex = 11;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click_1);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(338, 258);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(134, 23);
            this.txtsenha.TabIndex = 10;
            // 
            // textusuario
            // 
            this.textusuario.BackColor = System.Drawing.Color.White;
            this.textusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textusuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textusuario.Location = new System.Drawing.Point(338, 145);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(134, 23);
            this.textusuario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuário";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_login.Location = new System.Drawing.Point(363, 33);
            this.lb_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(73, 28);
            this.lb_login.TabIndex = 6;
            this.lb_login.Text = "Login";
            this.lb_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_login);
            this.Name = "TelaInicial";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_login;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

