
namespace testegit
{
    partial class TelaAdm
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
            this.btnfun_consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfun_consulta
            // 
            this.btnfun_consulta.Location = new System.Drawing.Point(291, 358);
            this.btnfun_consulta.Name = "btnfun_consulta";
            this.btnfun_consulta.Size = new System.Drawing.Size(173, 56);
            this.btnfun_consulta.TabIndex = 0;
            this.btnfun_consulta.Text = "Consulta de Funcionarios";
            this.btnfun_consulta.UseVisualStyleBackColor = true;
            this.btnfun_consulta.Click += new System.EventHandler(this.btnfun_consulta_Click);
            // 
            // TelaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfun_consulta);
            this.Name = "TelaAdm";
            this.Text = "TelaAdm";
            this.Load += new System.EventHandler(this.TelaAdm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfun_consulta;
    }
}