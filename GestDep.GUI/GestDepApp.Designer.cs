namespace GestDep.GUI
{
    partial class GestDepApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestDepApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.diaSelect = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreaUser = new System.Windows.Forms.Button();
            this.AfigUserAct = new System.Windows.Forms.Button();
            this.AfigActSala = new System.Windows.Forms.Button();
            this.CreaAct = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.diaSelect);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.CreaUser);
            this.panel1.Controls.Add(this.AfigUserAct);
            this.panel1.Controls.Add(this.AfigActSala);
            this.panel1.Controls.Add(this.CreaAct);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 523);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // diaSelect
            // 
            this.diaSelect.Location = new System.Drawing.Point(54, 43);
            this.diaSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diaSelect.Name = "diaSelect";
            this.diaSelect.Size = new System.Drawing.Size(151, 20);
            this.diaSelect.TabIndex = 5;
            this.diaSelect.ValueChanged += new System.EventHandler(this.diaSelect_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia1,
            this.Dia2,
            this.Dia3,
            this.Dia4,
            this.Dia5,
            this.Dia6});
            this.dataGridView1.Location = new System.Drawing.Point(54, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 366);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Dia1
            // 
            this.Dia1.HeaderText = "Dilluns";
            this.Dia1.MinimumWidth = 6;
            this.Dia1.Name = "Dia1";
            this.Dia1.ReadOnly = true;
            // 
            // Dia2
            // 
            this.Dia2.HeaderText = "Dimarts";
            this.Dia2.MinimumWidth = 6;
            this.Dia2.Name = "Dia2";
            this.Dia2.ReadOnly = true;
            // 
            // Dia3
            // 
            this.Dia3.HeaderText = "Dimecres";
            this.Dia3.MinimumWidth = 6;
            this.Dia3.Name = "Dia3";
            this.Dia3.ReadOnly = true;
            // 
            // Dia4
            // 
            this.Dia4.HeaderText = "Dijous";
            this.Dia4.MinimumWidth = 6;
            this.Dia4.Name = "Dia4";
            this.Dia4.ReadOnly = true;
            // 
            // Dia5
            // 
            this.Dia5.HeaderText = "Divendres";
            this.Dia5.MinimumWidth = 6;
            this.Dia5.Name = "Dia5";
            this.Dia5.ReadOnly = true;
            // 
            // Dia6
            // 
            this.Dia6.HeaderText = "Dissabte";
            this.Dia6.MinimumWidth = 6;
            this.Dia6.Name = "Dia6";
            this.Dia6.ReadOnly = true;
            // 
            // CreaUser
            // 
            this.CreaUser.Location = new System.Drawing.Point(230, 471);
            this.CreaUser.Name = "CreaUser";
            this.CreaUser.Size = new System.Drawing.Size(166, 49);
            this.CreaUser.TabIndex = 3;
            this.CreaUser.Text = "Crear nou usuari";
            this.CreaUser.UseVisualStyleBackColor = true;
            this.CreaUser.Click += new System.EventHandler(this.crearUsuari);
            // 
            // AfigUserAct
            // 
            this.AfigUserAct.Location = new System.Drawing.Point(625, 471);
            this.AfigUserAct.Name = "AfigUserAct";
            this.AfigUserAct.Size = new System.Drawing.Size(139, 49);
            this.AfigUserAct.TabIndex = 2;
            this.AfigUserAct.Text = "Afegir usuari existent a Activitat";
            this.AfigUserAct.UseVisualStyleBackColor = true;
            this.AfigUserAct.Click += new System.EventHandler(this.AfigUserAct_Click);
            // 
            // AfigActSala
            // 
            this.AfigActSala.Location = new System.Drawing.Point(438, 471);
            this.AfigActSala.Name = "AfigActSala";
            this.AfigActSala.Size = new System.Drawing.Size(148, 49);
            this.AfigActSala.TabIndex = 1;
            this.AfigActSala.Text = "Afegir monitor a activitat";
            this.AfigActSala.UseVisualStyleBackColor = true;
            this.AfigActSala.Click += new System.EventHandler(this.AfigActSala_Click);
            // 
            // CreaAct
            // 
            this.CreaAct.Location = new System.Drawing.Point(54, 471);
            this.CreaAct.Name = "CreaAct";
            this.CreaAct.Size = new System.Drawing.Size(127, 49);
            this.CreaAct.TabIndex = 0;
            this.CreaAct.Text = "Crear Activitat";
            this.CreaAct.UseVisualStyleBackColor = true;
            this.CreaAct.Click += new System.EventHandler(this.afegirActivitat);
            // 
            // GestDepApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(836, 556);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestDepApp";
            this.Text = "GestDepApp";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreaAct;
        private System.Windows.Forms.Button CreaUser;
        private System.Windows.Forms.Button AfigUserAct;
        private System.Windows.Forms.Button AfigActSala;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker diaSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia6;
    }
}