namespace GestDep.GUI
{
    partial class EnrollUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollUser));
            this.label1 = new System.Windows.Forms.Label();
            this.listActs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DNIres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.infoUser = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.infoAct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar Actividad:";
            // 
            // listActs
            // 
            this.listActs.FormattingEnabled = true;
            this.listActs.ItemHeight = 16;
            this.listActs.Location = new System.Drawing.Point(18, 37);
            this.listActs.Name = "listActs";
            this.listActs.Size = new System.Drawing.Size(389, 324);
            this.listActs.TabIndex = 2;
            this.listActs.SelectedIndexChanged += new System.EventHandler(this.listActs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introduir DNI";
            // 
            // DNIres
            // 
            this.DNIres.Location = new System.Drawing.Point(544, 39);
            this.DNIres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DNIres.Name = "DNIres";
            this.DNIres.Size = new System.Drawing.Size(114, 22);
            this.DNIres.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cercar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cercar);
            // 
            // infoUser
            // 
            this.infoUser.AutoSize = true;
            this.infoUser.Location = new System.Drawing.Point(449, 181);
            this.infoUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoUser.Name = "infoUser";
            this.infoUser.Size = new System.Drawing.Size(61, 17);
            this.infoUser.TabIndex = 7;
            this.infoUser.Text = "infoUser";
            this.infoUser.Visible = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(477, 491);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(108, 28);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(604, 491);
            this.accept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(108, 28);
            this.accept.TabIndex = 10;
            this.accept.Text = "Aceptar";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // infoAct
            // 
            this.infoAct.AutoSize = true;
            this.infoAct.Location = new System.Drawing.Point(20, 380);
            this.infoAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoAct.Name = "infoAct";
            this.infoAct.Size = new System.Drawing.Size(53, 17);
            this.infoAct.TabIndex = 11;
            this.infoAct.Text = "infoACt";
            this.infoAct.Visible = false;
            // 
            // EnrollUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 563);
            this.Controls.Add(this.infoAct);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.infoUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DNIres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listActs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EnrollUser";
            this.Text = "Afegir Usuari a Activitat";
            this.Load += new System.EventHandler(this.EnrollUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listActs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DNIres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label infoUser;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label infoAct;
    }
}