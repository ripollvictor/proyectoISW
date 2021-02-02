namespace GestDep.GUI
{
    partial class AddNewUser
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.af_usuari = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.adresa_text = new System.Windows.Forms.TextBox();
            this.iban_text = new System.Windows.Forms.TextBox();
            this.zipCode_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iban = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.retired_check = new System.Windows.Forms.CheckBox();
            this.but_add = new System.Windows.Forms.Button();
            this.but_can = new System.Windows.Forms.Button();
            this.DNIlabel = new System.Windows.Forms.Label();
            this.DNI_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // af_usuari
            // 
            this.af_usuari.AutoSize = true;
            this.af_usuari.Location = new System.Drawing.Point(322, 85);
            this.af_usuari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.af_usuari.Name = "af_usuari";
            this.af_usuari.Size = new System.Drawing.Size(231, 32);
            this.af_usuari.TabIndex = 0;
            this.af_usuari.Text = "AFEGIR USUARI";
            this.af_usuari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(480, 209);
            this.name_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(374, 38);
            this.name_text.TabIndex = 1;
            // 
            // adresa_text
            // 
            this.adresa_text.Location = new System.Drawing.Point(480, 298);
            this.adresa_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adresa_text.Name = "adresa_text";
            this.adresa_text.Size = new System.Drawing.Size(374, 38);
            this.adresa_text.TabIndex = 2;
            // 
            // iban_text
            // 
            this.iban_text.Location = new System.Drawing.Point(480, 482);
            this.iban_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iban_text.Name = "iban_text";
            this.iban_text.Size = new System.Drawing.Size(374, 38);
            this.iban_text.TabIndex = 4;
            // 
            // zipCode_text
            // 
            this.zipCode_text.Location = new System.Drawing.Point(480, 581);
            this.zipCode_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zipCode_text.Name = "zipCode_text";
            this.zipCode_text.Size = new System.Drawing.Size(156, 38);
            this.zipCode_text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom i cognoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adreça";
            // 
            // iban
            // 
            this.iban.AutoSize = true;
            this.iban.Location = new System.Drawing.Point(98, 482);
            this.iban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.iban.Name = "iban";
            this.iban.Size = new System.Drawing.Size(80, 32);
            this.iban.TabIndex = 7;
            this.iban.Text = "IBAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 581);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codi Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 668);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de naixement";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(480, 668);
            this.birthDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(374, 38);
            this.birthDate.TabIndex = 6;
            // 
            // retired_check
            // 
            this.retired_check.AutoSize = true;
            this.retired_check.Location = new System.Drawing.Point(288, 771);
            this.retired_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.retired_check.Name = "retired_check";
            this.retired_check.Size = new System.Drawing.Size(297, 36);
            this.retired_check.TabIndex = 7;
            this.retired_check.Text = "L\'usuari està jubilat";
            this.retired_check.UseVisualStyleBackColor = true;
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(520, 944);
            this.but_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(138, 58);
            this.but_add.TabIndex = 8;
            this.but_add.Text = "Afegir";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.clickAdd);
            // 
            // but_can
            // 
            this.but_can.ForeColor = System.Drawing.Color.Black;
            this.but_can.Location = new System.Drawing.Point(226, 944);
            this.but_can.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_can.Name = "but_can";
            this.but_can.Size = new System.Drawing.Size(138, 58);
            this.but_can.TabIndex = 9;
            this.but_can.Text = "Cancelar";
            this.but_can.UseVisualStyleBackColor = true;
            this.but_can.Click += new System.EventHandler(this.clickCancel);
            // 
            // DNIlabel
            // 
            this.DNIlabel.AutoSize = true;
            this.DNIlabel.Location = new System.Drawing.Point(102, 391);
            this.DNIlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DNIlabel.Name = "DNIlabel";
            this.DNIlabel.Size = new System.Drawing.Size(62, 32);
            this.DNIlabel.TabIndex = 16;
            this.DNIlabel.Text = "DNI";
            // 
            // DNI_text
            // 
            this.DNI_text.Location = new System.Drawing.Point(480, 391);
            this.DNI_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DNI_text.Name = "DNI_text";
            this.DNI_text.Size = new System.Drawing.Size(374, 38);
            this.DNI_text.TabIndex = 3;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 1221);
            this.Controls.Add(this.DNIlabel);
            this.Controls.Add(this.DNI_text);
            this.Controls.Add(this.but_can);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.retired_check);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zipCode_text);
            this.Controls.Add(this.iban_text);
            this.Controls.Add(this.adresa_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.af_usuari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewUser";
            this.Text = "GestDepAPP";
            this.Load += new System.EventHandler(this.GestDepApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label af_usuari;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox adresa_text;
        private System.Windows.Forms.TextBox iban_text;
        private System.Windows.Forms.TextBox zipCode_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label iban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.CheckBox retired_check;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_can;
        private System.Windows.Forms.Label DNIlabel;
        private System.Windows.Forms.TextBox DNI_text;
    }
}

