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
    public partial class AddMonitor : Form
    {
        private IGestDepService service;

        public AddMonitor(IGestDepService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void AddMonitor_Load(object sender, EventArgs e)
        {
            this.Text = "Afegir monitor a una activitat";
            string kk;
            ICollection<int> acts = service.GetAllActivitiesIds();
            foreach (int act in acts) {
                kk = act.ToString();
                listActs.Items.Add(kk);
             }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listActs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse((string)listActs.Items[listActs.SelectedIndex]);
                service.GetActivityDataFromId(id, out Days activityDays, out String description, out TimeSpan duration,
                    out DateTime finishDate, out int maximumEnrollments, out int minimumEnrollments, out double price,
                    out DateTime startDate, out DateTime startHour, out ICollection<int> enrollmentIds,
                    out String instructorId, out ICollection<int> roomIds);
                monitorAfegit.Text = "";

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
                //posar try catch
                ICollection<string> monitors = service.GetAvailableInstructorsIds(activityDays, duration, finishDate, startDate, startHour);
                listMonitor.Items.Clear();
                foreach (string ids in monitors)
                {
                    listMonitor.Items.Add(ids);
                }

            }
            catch (ServiceException ser) {MessageBox.Show(ser.Message, "Error al afegir monitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                GestDepApp menu = new GestDepApp(service);
                menu.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string idMonitor = (string)listMonitor.Items[listMonitor.SelectedIndex];
                int idAct = Int32.Parse((string)listActs.Items[listActs.SelectedIndex]);
                service.AssignInstructorToActivity(idAct, idMonitor);
                monitorAfegit.Text = "Monitor Afegit";
            }
            catch (Exception error) { MessageBox.Show("No s'ha selecionat l'activitat o el monitor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestDepApp menu = new GestDepApp(service);
            menu.Show();
        }
    }
}
