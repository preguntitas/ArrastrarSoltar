using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrastrarSoltar
{
    public partial class fmPapelera : Form
    {
        public ListBox milb1;
        public ListBox milb2;
        public fmPapelera()
        {
            InitializeComponent();
        }

        private void fmPapelera_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancelamos el evento de cerrado
            this.Hide(); // Ocultamos el formulario sin desecharlo
        }
        public void pasardatos(int i)
        {
            string elemento = lbPapelera.Items[i].ToString();
            string[] lisboxOrigen = elemento.Split('-'); //Separamos valor 1 ó 2 
                                                         // del ítem
            if (lisboxOrigen[1].ToString() == "1") //Identificamos origen borrado 
            {
                milb1.Items.Add(lisboxOrigen[0]);
            }
            else
            {
                milb2.Items.Add(lisboxOrigen[0]);
            }
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbPapelera.Items.Count; i++)
            {
                pasardatos(i);
            }
            lbPapelera.Items.Clear();
        }

        private void btSeleccionados_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < lbPapelera.Items.Count; i++)
            {
                if (lbPapelera.GetSelected(i))
                {
                    pasardatos(i);
                    //lbPapelera.Items.RemoveAt(i); //No funciona bien
                }
            }
            i = 0; // Hay que poner doble ciclo porque si pasamos y 
                   // borramos a la vez el último se queda sin borrar
            while (i < lbPapelera.Items.Count)
            {
                if (lbPapelera.GetSelected(i))
                {
                    lbPapelera.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btVaciar_Click(object sender, EventArgs e)
        {
            lbPapelera.Items.Clear();
        }
    }
}
