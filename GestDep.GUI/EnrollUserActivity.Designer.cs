namespace GestDep.GUI
{
    partial class EnrollUserActivity
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IniciData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCerca = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Descripcio,
            this.IniciData,
            this.FiData,
            this.Duracio});
            this.dataGridView1.Location = new System.Drawing.Point(45, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 397);
            this.dataGridView1.TabIndex = 5;
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            // 
            // Descripcio
            // 
            this.Descripcio.HeaderText = "Descripció";
            this.Descripcio.Name = "Descripcio";
            this.Descripcio.ReadOnly = true;
            // 
            // IniciData
            // 
            this.IniciData.HeaderText = "iniciData";
            this.IniciData.Name = "IniciData";
            this.IniciData.ReadOnly = true;
            // 
            // FiData
            // 
            this.FiData.HeaderText = "fiData";
            this.FiData.Name = "FiData";
            this.FiData.ReadOnly = true;
            // 
            // Duracio
            // 
            this.Duracio.HeaderText = "Duracio";
            this.Duracio.Name = "Duracio";
            this.Duracio.ReadOnly = true;
            // 
            // dniCerca
            // 
            this.dniCerca.Location = new System.Drawing.Point(638, 12);
            this.dniCerca.Name = "dniCerca";
            this.dniCerca.Size = new System.Drawing.Size(100, 20);
            this.dniCerca.TabIndex = 6;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(566, 15);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 7;
            this.DNI.Text = "DNI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(527, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 217);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "DNI";
            // 
            // EnrollUserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.dniCerca);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EnrollUserActivity";
            this.Text = "EnrollUserActivity";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IniciData;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracio;
        private System.Windows.Forms.TextBox dniCerca;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}