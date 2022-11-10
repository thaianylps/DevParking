
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAdm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctr_reservas = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conultaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeReservaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctr_reservas,
            this.reservasToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.valoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctr_reservas
            // 
            this.ctr_reservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaReservasToolStripMenuItem});
            this.ctr_reservas.Name = "ctr_reservas";
            this.ctr_reservas.Size = new System.Drawing.Size(64, 20);
            this.ctr_reservas.Text = "Reservas";
            // 
            // consultaReservasToolStripMenuItem
            // 
            this.consultaReservasToolStripMenuItem.Name = "consultaReservasToolStripMenuItem";
            this.consultaReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaReservasToolStripMenuItem.Text = "Consulta reservas";
            this.consultaReservasToolStripMenuItem.Click += new System.EventHandler(this.consultaReservasToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conultaReservaToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.reservasToolStripMenuItem.Text = "Clientes";
            // 
            // conultaReservaToolStripMenuItem
            // 
            this.conultaReservaToolStripMenuItem.Name = "conultaReservaToolStripMenuItem";
            this.conultaReservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conultaReservaToolStripMenuItem.Text = "Consultar Cliente";
            this.conultaReservaToolStripMenuItem.Click += new System.EventHandler(this.conultaReservaToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFuncionárioToolStripMenuItem,
            this.consultaFuncionárioToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // cadastroDeFuncionárioToolStripMenuItem
            // 
            this.cadastroDeFuncionárioToolStripMenuItem.Name = "cadastroDeFuncionárioToolStripMenuItem";
            this.cadastroDeFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastroDeFuncionárioToolStripMenuItem.Text = "Cadastro de Funcionário";
            this.cadastroDeFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionárioToolStripMenuItem_Click);
            // 
            // consultaFuncionárioToolStripMenuItem
            // 
            this.consultaFuncionárioToolStripMenuItem.Name = "consultaFuncionárioToolStripMenuItem";
            this.consultaFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consultaFuncionárioToolStripMenuItem.Text = "Consulta Funcionário";
            this.consultaFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.consultaFuncionárioToolStripMenuItem_Click);
            // 
            // valoresToolStripMenuItem
            // 
            this.valoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planoDeReservaToolStripMenuItem1});
            this.valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            this.valoresToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.valoresToolStripMenuItem.Text = "Valores";
            // 
            // planoDeReservaToolStripMenuItem1
            // 
            this.planoDeReservaToolStripMenuItem1.Name = "planoDeReservaToolStripMenuItem1";
            this.planoDeReservaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.planoDeReservaToolStripMenuItem1.Text = "Plano de Reserva";
            this.planoDeReservaToolStripMenuItem1.Click += new System.EventHandler(this.planoDeReservaToolStripMenuItem1_Click);
            // 
            // TelaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(145)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(287, 287);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaAdm";
            this.Text = "TelaAdm";
            this.Load += new System.EventHandler(this.TelaAdm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctr_reservas;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conultaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeReservaToolStripMenuItem1;
    }
}