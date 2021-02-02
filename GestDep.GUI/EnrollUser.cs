using GestDep.Entities;
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
    public partial class EnrollUser : Form
    {

        IGestDepService service;
        int ActivitySelected = int.MinValue;
        double Preu = int.MinValue;

        public EnrollUser(IGestDepService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void cercar(object sender, EventArgs e)
        {
            if (ActivitySelected == int.MinValue)
            {
                MessageBox.Show("Has de seleccionar una activitat!", "Error al buscar l'usuari!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                Preu = service.GetUserDataNotInActivityAndFirstQuota(ActivitySelected, DNIres.Text, out string address, out string iban, out string name, out int zipCode,
                    out DateTime birthDate, out bool retired, out ICollection<int> enrollmentIds);
                DateTime datanaiximent = birthDate;
                string txtdatanaiximent = datanaiximent.ToShortDateString();
                infoUser.Text = ("DNI: " + DNIres.Text + "\n"
                                + "Nom: " + name + "\n"
                                + "Direcció: " + address + "\n"
                                + "IBAN: " + iban + "\n"
                                + "Data de naixement: " + txtdatanaiximent + "\n"
                                + "Codi Postal: " + zipCode + "\n"
                                + "Jubilat: " + (retired ? "Si" : "No") + "\n"
                                + "Preu a pagar: " + Preu);

                infoUser.Visible = true;

            } catch (ServiceException ex) { MessageBox.Show(ex.Message,"Error al buscar l'usuari!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listActs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivitySelected = Int32.Parse((string)listActs.Items[listActs.SelectedIndex]);
            service.GetActivityDataFromId(ActivitySelected, out Days activityDays, out String description, out TimeSpan duration,
                out DateTime finishDate, out int maximumEnrollments, out int minimumEnrollments, out double price,
                out DateTime startDate, out DateTime startHour, out ICollection<int> enrollmentIds,
                out String instructorId, out ICollection<int> roomIds);
            
            DateTime datafi = finishDate;
            string txtdatafi = datafi.ToShortDateString();
            DateTime inicidata = startDate;
            string txtinicidata = inicidata.ToShortDateString();
            DateTime horainici = startHour;
            string txthorainici = horainici.ToShortTimeString();
            infoAct.Text = ("Dias de la actividad: " + activityDays + "\n"
                            + "Descripción: " + description + "\n"
                            + "Duracion: " + duration + "\n"
                            + "Fecha de inicio: " + txtinicidata + "\n"
                            + "Hora de inicio: " + txthorainici + "\n"
                            + "Fecha de finalización" + txtdatafi + "\n"
                            + "Monitor:" + instructorId + "\n"
                            + "Precio: " + price + "\n");

            infoAct.Visible = true;
        }

        private void EnrollUser_Load(object sender, EventArgs e)
        {
            try
            {
                ICollection<int> acts = service.GetAllRunningOrFutureActivitiesIds();
                foreach (int act in acts) { listActs.Items.Add(act.ToString()); }
            } catch (ServiceException ex) { MessageBox.Show(ex.Message , "Error al carregar Enroll User", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestDepApp menu = new GestDepApp(service);
            menu.Show();
        }

        private void accept_Click(object sender, EventArgs e)
        {

            if (Preu == int.MinValue || ActivitySelected == int.MinValue)
            {
                MessageBox.Show("Has de seleccionar una activitat i un usuari", "Error al processar l'inscripció!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                try
                {
                    string msg = ("¿Segur que vols inscriure l'usuari amb DNI " + DNIres.Text +
                        " a l'activitat de ID " + ActivitySelected);
                    int res = (int)MessageBox.Show(msg, "Confirmació Inscripció", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == 6)
                    {
                        service.EnrollUserInActivity(ActivitySelected, DNIres.Text);

                        this.Hide();
                        GestDepApp menu = new GestDepApp(service);
                        menu.Show();
                    }
                } catch(ServiceException ex)
                {
                    MessageBox.Show(ex.Message, "Error al processar l'inscripció!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
