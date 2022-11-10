
namespace testegit
{
    partial class TelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.btnconsulta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_cdcliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(65, 265);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(122, 78);
            this.btnconsulta.TabIndex = 3;
            this.btnconsulta.Text = "Consulta de clientes";
            this.btnconsulta.UseVisualStyleBackColor = true;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 78);
            this.button3.TabIndex = 4;
            this.button3.Text = "Reservas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_cdcliente
            // 
            this.btn_cdcliente.Location = new System.Drawing.Point(183, 349);
            this.btn_cdcliente.Name = "btn_cdcliente";
            this.btn_cdcliente.Size = new System.Drawing.Size(141, 70);
            this.btn_cdcliente.TabIndex = 5;
            this.btn_cdcliente.Text = "Cadastro Temporario do Cliente";
            this.btn_cdcliente.UseVisualStyleBackColor = true;
            this.btn_cdcliente.Click += new System.EventHandler(this.btn_cdcliente_Click);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(145)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.btn_cdcliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnconsulta);
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            this.Load += new System.EventHandler(this.TelaFuncionario_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_cdcliente;
    }
}