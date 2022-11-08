
namespace testegit
{
    partial class ConsultaFuncionario
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
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.Consulta_funcionario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(12, 72);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.RowTemplate.Height = 25;
            this.dgvFuncionario.Size = new System.Drawing.Size(761, 227);
            this.dgvFuncionario.TabIndex = 0;
            // 
            // Consulta_funcionario
            // 
            this.Consulta_funcionario.AutoSize = true;
            this.Consulta_funcionario.Location = new System.Drawing.Point(300, 20);
            this.Consulta_funcionario.Name = "Consulta_funcionario";
            this.Consulta_funcionario.Size = new System.Drawing.Size(38, 15);
            this.Consulta_funcionario.TabIndex = 1;
            this.Consulta_funcionario.Text = "label1";
            this.Consulta_funcionario.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consulta_funcionario);
            this.Controls.Add(this.dgvFuncionario);
            this.Name = "ConsultaFuncionario";
            this.Text = "ConsultaFuncionario";
            this.Load += new System.EventHandler(this.ConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Label Consulta_funcionario;
    }
}