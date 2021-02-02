using GestDep.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestDep.GUI
{
    public partial class AddNewUser : Form
    {
       private IGestDepService service;
        

        public AddNewUser(IGestDepService service) {
            InitializeComponent();
            this.service = service;

        }


        private void GestDepApp_Load(object sender, EventArgs e)
        {
            this.Text = "Afegir nou usuari";
        }

        private void clickAdd(object sender, EventArgs e)
        {


            try
            {
                string nombre = name_text.Text;
                string adress = adresa_text.Text;
                string IBAN = iban_text.Text;
                int ZipCode = Int32.Parse(zipCode_text.Text);
                string DNI = DNI_text.Text;
                bool Jubilado = retired_check.Checked;
                DateTime nacimiento = birthDate.Value;

                service.AddNewUser(adress, IBAN, DNI, nombre, ZipCode, nacimiento, Jubilado);
            }
            catch (ServiceException sE) {
                var result = MessageBox.Show(sE.Message, "Error al afegir usuari", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.FormatException Fe)
            {
                var result = MessageBox.Show(Fe.Message, "Error de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            GestDepApp menu = new GestDepApp(service);
            menu.Show();

        }

        private void clickCancel(object sender, EventArgs e)
        {
            this.Hide();
            GestDepApp menu = new GestDepApp(service);
            menu.Show();
        }


    }
}
