namespace TIA02_MOD
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.interfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervaloDeArmazenamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundoDeEscalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portaDeComunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeDeComunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coeficientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirUnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(663, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interfaceToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // interfaceToolStripMenuItem
            // 
            this.interfaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervaloDeArmazenamentoToolStripMenuItem,
            this.fundoDeEscalaToolStripMenuItem,
            this.portaDeComunicaçãoToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.interfaceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfaceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            this.interfaceToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.interfaceToolStripMenuItem.Text = "Interface";
            // 
            // intervaloDeArmazenamentoToolStripMenuItem
            // 
            this.intervaloDeArmazenamentoToolStripMenuItem.Name = "intervaloDeArmazenamentoToolStripMenuItem";
            this.intervaloDeArmazenamentoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.intervaloDeArmazenamentoToolStripMenuItem.Text = "Intervalo de Armazenamento";
            // 
            // fundoDeEscalaToolStripMenuItem
            // 
            this.fundoDeEscalaToolStripMenuItem.Name = "fundoDeEscalaToolStripMenuItem";
            this.fundoDeEscalaToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.fundoDeEscalaToolStripMenuItem.Text = "Fundo de escala";
            // 
            // portaDeComunicaçãoToolStripMenuItem
            // 
            this.portaDeComunicaçãoToolStripMenuItem.Name = "portaDeComunicaçãoToolStripMenuItem";
            this.portaDeComunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.portaDeComunicaçãoToolStripMenuItem.Text = "Porta de Comunicação";
            this.portaDeComunicaçãoToolStripMenuItem.Click += new System.EventHandler(this.portaDeComunicaçãoToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeDeComunicaçãoToolStripMenuItem,
            this.calibraçãoToolStripMenuItem,
            this.coeficientesToolStripMenuItem,
            this.definirUnidadesToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // testeDeComunicaçãoToolStripMenuItem
            // 
            this.testeDeComunicaçãoToolStripMenuItem.Name = "testeDeComunicaçãoToolStripMenuItem";
            this.testeDeComunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.testeDeComunicaçãoToolStripMenuItem.Text = "Teste de Comunicação";
            // 
            // calibraçãoToolStripMenuItem
            // 
            this.calibraçãoToolStripMenuItem.Name = "calibraçãoToolStripMenuItem";
            this.calibraçãoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.calibraçãoToolStripMenuItem.Text = "Calibração";
            // 
            // coeficientesToolStripMenuItem
            // 
            this.coeficientesToolStripMenuItem.Name = "coeficientesToolStripMenuItem";
            this.coeficientesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.coeficientesToolStripMenuItem.Text = "Coeficientes";
            // 
            // definirUnidadesToolStripMenuItem
            // 
            this.definirUnidadesToolStripMenuItem.Name = "definirUnidadesToolStripMenuItem";
            this.definirUnidadesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.definirUnidadesToolStripMenuItem.Text = "Definir unidades";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(663, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(448, 99);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fundo de Escala";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(663, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(448, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(520, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "SISTEMA DE AQUISIÇÃO DE SINAIS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::TIA02_MOD.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1196, 673);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sisitema de Aquisição de Sinais - TIA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem interfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervaloDeArmazenamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundoDeEscalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portaDeComunicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeDeComunicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coeficientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirUnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

