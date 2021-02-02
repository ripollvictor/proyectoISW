namespace GestDep.GUI
{
    partial class AddActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddActivity));
            this.panel1 = new System.Windows.Forms.Panel();
            this.horainici = new System.Windows.Forms.MaskedTextBox();
            this.duracio = new System.Windows.Forms.MaskedTextBox();
            this.checkDays = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkRooms = new System.Windows.Forms.CheckedListBox();
            this.but_can = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.datainici = new System.Windows.Forms.DateTimePicker();
            this.preu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datafi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimaforo = new System.Windows.Forms.TextBox();
            this.aforomaxim = new System.Windows.Forms.TextBox();
            this.descripcio = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.horainici);
            this.panel1.Controls.Add(this.duracio);
            this.panel1.Controls.Add(this.checkDays);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkRooms);
            this.panel1.Controls.Add(this.but_can);
            this.panel1.Controls.Add(this.but_add);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.datainici);
            this.panel1.Controls.Add(this.preu);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.datafi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimaforo);
            this.panel1.Controls.Add(this.aforomaxim);
            this.panel1.Controls.Add(this.descripcio);
            this.panel1.Location = new System.Drawing.Point(2, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1610, 1178);
            this.panel1.TabIndex = 0;
            // 
            // horainici
            // 
            this.horainici.Location = new System.Drawing.Point(630, 554);
            this.horainici.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.horainici.Mask = "00:00:00";
            this.horainici.Name = "horainici";
            this.horainici.Size = new System.Drawing.Size(196, 38);
            this.horainici.TabIndex = 5;
            this.horainici.ValidatingType = typeof(System.DateTime);
            // 
            // duracio
            // 
            this.duracio.Location = new System.Drawing.Point(630, 366);
            this.duracio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.duracio.Mask = "00:00:00";
            this.duracio.Name = "duracio";
            this.duracio.Size = new System.Drawing.Size(196, 38);
            this.duracio.TabIndex = 3;
            this.duracio.ValidatingType = typeof(System.DateTime);
            this.duracio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // checkDays
            // 
            this.checkDays.CheckOnClick = true;
            this.checkDays.FormattingEnabled = true;
            this.checkDays.Items.AddRange(new object[] {
            "Dilluns ",
            "Dimarts",
            "Dimecres",
            "Dijous",
            "Divendres",
            "Dissabte"});
            this.checkDays.Location = new System.Drawing.Point(630, 58);
            this.checkDays.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.checkDays.Name = "checkDays";
            this.checkDays.Size = new System.Drawing.Size(428, 144);
            this.checkDays.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(986, 727);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rooms";
            // 
            // checkRooms
            // 
            this.checkRooms.CheckOnClick = true;
            this.checkRooms.FormattingEnabled = true;
            this.checkRooms.Location = new System.Drawing.Point(1130, 727);
            this.checkRooms.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.checkRooms.Name = "checkRooms";
            this.checkRooms.Size = new System.Drawing.Size(236, 109);
            this.checkRooms.TabIndex = 10;
            // 
            // but_can
            // 
            this.but_can.ForeColor = System.Drawing.Color.Black;
            this.but_can.Location = new System.Drawing.Point(346, 1046);
            this.but_can.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_can.Name = "but_can";
            this.but_can.Size = new System.Drawing.Size(138, 58);
            this.but_can.TabIndex = 12;
            this.but_can.Text = "Cancelar";
            this.but_can.UseVisualStyleBackColor = true;
            this.but_can.Click += new System.EventHandler(this.cancelarActivitat);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(630, 1046);
            this.but_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(138, 58);
            this.but_add.TabIndex = 11;
            this.but_add.Text = "Afegir";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.afegirActivitat);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 560);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 32);
            this.label10.TabIndex = 17;
            this.label10.Text = "Hora d\'inici";
            // 
            // datainici
            // 
            this.datainici.Location = new System.Drawing.Point(630, 457);
            this.datainici.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.datainici.Name = "datainici";
            this.datainici.Size = new System.Drawing.Size(526, 38);
            this.datainici.TabIndex = 4;
            // 
            // preu
            // 
            this.preu.Location = new System.Drawing.Point(630, 882);
            this.preu.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.preu.Name = "preu";
            this.preu.Size = new System.Drawing.Size(260, 38);
            this.preu.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 887);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Preu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 457);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data d\'inici";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 802);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Minim aforament";
            // 
            // datafi
            // 
            this.datafi.Location = new System.Drawing.Point(630, 624);
            this.datafi.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.datafi.Name = "datafi";
            this.datafi.Size = new System.Drawing.Size(526, 38);
            this.datafi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 723);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Màxim aforament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 639);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de finalització";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 376);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duració";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Breu descripció";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Día de l\'activitat";
            // 
            // minimaforo
            // 
            this.minimaforo.Location = new System.Drawing.Point(630, 794);
            this.minimaforo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.minimaforo.Name = "minimaforo";
            this.minimaforo.Size = new System.Drawing.Size(260, 38);
            this.minimaforo.TabIndex = 8;
            // 
            // aforomaxim
            // 
            this.aforomaxim.Location = new System.Drawing.Point(630, 717);
            this.aforomaxim.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.aforomaxim.Name = "aforomaxim";
            this.aforomaxim.Size = new System.Drawing.Size(260, 38);
            this.aforomaxim.TabIndex = 7;
            // 
            // descripcio
            // 
            this.descripcio.Location = new System.Drawing.Point(630, 287);
            this.descripcio.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.descripcio.Name = "descripcio";
            this.descripcio.Size = new System.Drawing.Size(428, 38);
            this.descripcio.TabIndex = 2;
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1207);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "AddActivity";
            this.Text = "AddActivity";
            this.Load += new System.EventHandler(this.AddActivity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox minimaforo;
        private System.Windows.Forms.TextBox aforomaxim;
        private System.Windows.Forms.TextBox descripcio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datafi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox preu;
        private System.Windows.Forms.DateTimePicker datainici;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button but_can;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.CheckedListBox checkRooms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkDays;
        private System.Windows.Forms.MaskedTextBox duracio;
        private System.Windows.Forms.MaskedTextBox horainici;
    }
}