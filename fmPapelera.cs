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
        public fmPapelera()
        {
            InitializeComponent();
        }

        private void fmPapelera_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancelamos el evento de cerrado
            this.Hide(); // Ocultamos el formulario sin desecharlo
        }
    }
}
