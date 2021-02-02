namespace GestDep.GUI
{
    partial class AddMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMonitor));
            this.listActs = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atras = new System.Windows.Forms.Button();
            this.monitorAfegit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listMonitor = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoAct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listActs
            // 
            this.listActs.FormattingEnabled = true;
            this.listActs.ItemHeight = 16;
            this.listActs.Location = new System.Drawing.Point(15, 29);
            this.listActs.Name = "listActs";
            this.listActs.Size = new System.Drawing.Size(389, 308);
            this.listActs.TabIndex = 0;
            this.listActs.SelectedIndexChanged += new System.EventHandler(this.listActs_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.atras);
            this.panel1.Controls.Add(this.monitorAfegit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listMonitor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.infoAct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listActs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 625);
            this.panel1.TabIndex = 0;
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(648, 558);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(117, 35);
            this.atras.TabIndex = 7;
            this.atras.Text = "Tornar Enrere";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // monitorAfegit
            // 
            this.monitorAfegit.AutoSize = true;
            this.monitorAfegit.ForeColor = System.Drawing.Color.Lime;
            this.monitorAfegit.Location = new System.Drawing.Point(603, 467);
            this.monitorAfegit.Name = "monitorAfegit";
            this.monitorAfegit.Size = new System.Drawing.Size(0, 17);
            this.monitorAfegit.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "Afegir Monitor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listMonitor
            // 
            this.listMonitor.FormattingEnabled = true;
            this.listMonitor.ItemHeight = 16;
            this.listMonitor.Location = new System.Drawing.Point(15, 385);
            this.listMonitor.Name = "listMonitor";
            this.listMonitor.Size = new System.Drawing.Size(389, 196);
            this.listMonitor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Afegir monitor";
            // 
            // infoAct
            // 
            this.infoAct.AutoSize = true;
            this.infoAct.Location = new System.Drawing.Point(489, 148);
            this.infoAct.Name = "infoAct";
            this.infoAct.Size = new System.Drawing.Size(0, 17);
            this.infoAct.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Actividad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMonitor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddMonitor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listActs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listMonitor;
        private System.Windows.Forms.Label monitorAfegit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button atras;
    }
}