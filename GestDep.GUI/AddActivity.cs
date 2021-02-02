using System;
using GestDep.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestDep.Entities;

namespace GestDep.GUI
{
    public partial class AddActivity : Form
    {
        private IGestDepService service;
        public AddActivity(IGestDepService service)
        {
            InitializeComponent();
            this.service = service;

        }

        private void AddActivity_Load(object sender, EventArgs e)
        {
            this.Text = "Afegir Activitat";
            ICollection<int> roomsId = service.GetRooms();
            foreach (int r in roomsId)
            {
                checkRooms.Items.Add(r);
            }
            //horainici.Format = DateTimePickerFormat.Time;
        }

        private void afegirActivitat(object sender, EventArgs e)
        {
            try
            {
                ICollection<int> roomsId = new List<int>();
                foreach (object item in checkRooms.CheckedItems)
                {

                roomsId.Add(Int32.Parse(item.ToString()));
                }

            ICollection<int> dias = new List<int>();
            foreach (int indice in checkDays.CheckedIndices)
            {
                dias.Add(indice+1);
            }

            Days activityDays = 0;

            foreach (int dia in dias) {
                activityDays = activityDays | service.returnDays(dia);
            }
            
                //  Days activityDays = dia_activitat.Text;
                string description = descripcio.Text;
                TimeSpan duration = TimeSpan.Parse(duracio.Text);
                DateTime firstDate = datainici.Value;
                DateTime endDate = datafi.Value;
                DateTime startHour = DateTime.Parse(horainici.Text);
                
                int maxiumEnrollments = Int32.Parse(aforomaxim.Text);
                int miniumEnrollments = Int32.Parse(minimaforo.Text);
                int price = Int32.Parse(preu.Text);
           
                service.AddNewActivity(activityDays, description, duration, endDate, maxiumEnrollments, miniumEnrollments, price, firstDate, startHour, roomsId);



                this.Hide();
                GestDepApp menu = new GestDepApp(service);
                menu.Show();
            } catch (ServiceException ex) {
                MessageBox.Show(ex.Message, "Error al crear l'Activitat",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error al crear l'Activitat",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelarActivitat(object sender, EventArgs e)
        {
            this.Hide();
            GestDepApp menu = new GestDepApp(service);
            menu.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
            

    }
}
