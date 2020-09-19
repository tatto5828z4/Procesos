using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Procesos
{
    public partial class Procesos : Form
    {
        String nombreEliminar;
        public Procesos()
        {
            InitializeComponent();
            button2.Visible = false;

            Actualizar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
        }

        private void Procesos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Actualizar()
        {

            int cantidadProcesos = 1;

            foreach(Process Proc_Proceso in Process.GetProcesses() )
            {
                dataGridView_Proceso.Rows.Add(cantidadProcesos,Proc_Proceso.ProcessName,Proc_Proceso.BasePriority,Proc_Proceso.Id,Proc_Proceso.WorkingSet64,Proc_Proceso.VirtualMemorySize64);

                cantidadProcesos++;
            }
        }

        private void dataGridView_Proceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
