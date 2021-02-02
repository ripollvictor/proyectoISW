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
    public partial class GestDepApp : Form
    {
        private IGestDepService service;
        private DateTime actual;


        public GestDepApp(IGestDepService service)
        {
            InitializeComponent();
            this.service = service;

            DateTime monday = service.CalcularLunes(DateTime.Today);
            actualizarCalendario(monday);
            actual = monday;


        }


        private void GestDepApp_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void crearUsuari(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUser nuevaVentana = new AddNewUser(service);
            nuevaVentana.Show();
        }

        private void afegirActivitat(object sender, EventArgs e)
        {
            this.Hide();
            AddActivity nuevaVentana = new AddActivity(service);
            nuevaVentana.Show();

        }



        private void diaSelect_ValueChanged(object sender, EventArgs e)
        {

            DateTime diaSeleccionado = diaSelect.Value;
            
            actual = service.CalcularLunes(diaSeleccionado);
            actualizarCalendario(actual);

        }

        private void actualizarCalendario(DateTime diaSeleccionado)
        {
            dataGridView1.Rows.Clear();

            Dictionary<DateTime, int> diccSemana = service.GetListAvailableRoomsPerWeek(diaSeleccionado);

            service.GetGymData(out int gymId, out DateTime closingHour, out int discountLocal, out int discountRetired, 
                out double freeUserPrice, out String name, out DateTime openingHour, out int zipCode, 
                out ICollection<int> activityIds, out ICollection<int> roomIds);
            int i = 0;


            for (DateTime hora = openingHour; hora < closingHour; hora = hora.AddMinutes(45))
            {
                
                Label h = new Label();
                h.Text = hora.TimeOfDay.ToString();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = h.Text;
                i++;
            }

            int cont = 0;
            for (int dia = 0; dia < 7; dia++)
            {
                i = 0;
                for (DateTime hora = openingHour; hora < closingHour; hora = hora.AddMinutes(45))
                {
                    if (dia < 6)
                    {
                        //datagridview1.rows[i].cells[dia].value = diccsemana.elementat(cont).value;
                        dataGridView1.Rows[i].Cells[dia].Value = diccSemana.ElementAt(cont).Value;
                        i++;
                    }
                    cont++;

                }
            }
        }

        private void AfigActSala_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMonitor nuevaVentana = new AddMonitor(service);
            nuevaVentana.Show();
        }

        private void AfigUserAct_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollUser nuevaVentana = new EnrollUser(service);
            nuevaVentana.Show();
        }
    }
}