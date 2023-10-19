using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrastrarSoltar
{
    public partial class fmArrastrarSoltar : Form
    {
        public fmArrastrarSoltar()
        {
            InitializeComponent();
        }

        private void btBorra1_Click(object sender, EventArgs e)
        {
            if (sender == btBorra1)
                borralistbox(lb1); //Invocamos función pasando parámetro listbox 
            else
                borralistbox(lb2);
        }
        //Recibe como Parámetro el listbox donde se borran los ítems 
        private void borralistbox(ListBox lbBorra)
        {
            int i = 0;
            while (i < lbBorra.Items.Count)
            {
                if (lbBorra.GetSelected(i)) //Array con elementos seleccionados a 
                { //true
                    lbBorra.Items.RemoveAt(i); // Borramos el seleccionado 
                }
                else
                {
                    i++;
                }
            }
        }

        private void btBorraTodo1_Click(object sender, EventArgs e)
        {
            if (sender == btBorraTodo1)
                lb1.Items.Clear();
            else
                lb2.Items.Clear();
        }

        private void ckOrdena1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == ckOrdena1)
                lb1.Sorted = ckOrdena1.Checked;
            else
                lb2.Sorted = ckOrdena2.Checked;
        }

        private void lb1_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb1.SelectedIndex >= 0)
            {
                lb2.DoDragDrop(lb1.SelectedItem, DragDropEffects.All);//Inicia 
            } //operación de arrastre desde lb1
        }

        private void lb2_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb2.SelectedIndex >= 0)
            {
                lb1.DoDragDrop(lb2.SelectedItem, DragDropEffects.All);//Inicia 
            } //operación de arrastre desde lb2
        }

        private void lb1_DragEnter(object sender, DragEventArgs e)
        {
            //Averiguamos si es un archivo arrastrado o un String 
            if (e.Data.GetDataPresent(DataFormats.FileDrop) ||
             e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy; //El Efecto del posible arrastre es una 
            } //copia 
            else
            {
                e.Effect = DragDropEffects.None; //El destino no acepta el acople 
            }

        }

        private void lb1_DragDrop(object sender, DragEventArgs e)
        {
            ListBox milistbox = (ListBox)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))//true si el objeto 
            { // arrastrado es un archivo
                string[] ficheros = (string[])e.Data.GetData(DataFormats.FileDrop,
                false); //Obtiene lista ficheros arrastrados. 2º parámetro es 
                        // autoconvert significa si se convierten los datos al formato
                foreach (var fichero in ficheros) //Por cada archivo en la lista
                { //Leemos archivo como se explicó en anterior proyecto 
                    StreamReader miarchivo = new StreamReader(fichero, Encoding.Default);
                    while (miarchivo.Peek() >= 0) //Comprobamos siguiente línea archivo
                    { //Añadimos línea al ListBox
                        milistbox.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                    }
                    miarchivo.Close();
                }
            }
            else
            {
                if (e.Data.GetDataPresent(DataFormats.Text))//true si es texto lo 
                { // arrastrado
                    if (sender == lb1 && lb2.SelectedIndex > -1) //Identifica origen y
                    { // si hay elementos seleccionados 
                        anyadelistbox(lb1, lb2); // Añadimos al destino
                        borralistbox(lb2); //Eliminamos del origen
                    }
                    if (sender == lb2 && lb1.SelectedIndex > -1)//Repetimos para el otro 
                    { //Listbox
                        anyadelistbox(lb2, lb1);
                        borralistbox(lb1);
                    }
                }
            }
        }
        private void anyadelistbox(ListBox lbAcopla, ListBox lbArrastra)
        {
            for (int i = 0; i < lbArrastra.Items.Count; i++)
            {
                if (lbArrastra.GetSelected(i))
                {
                    lbAcopla.Items.Add(lbArrastra.Items[i]);
                }
            }
        }

        private void lb1_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox milistbox = (ListBox)sender; //sender indica listBox donde se teclea
            if ((e.Shift) && (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete))
            { // Si la tecla pulsada es shift+retroceso o suprime
                borralistbox(milistbox); //borramos definitivamente ítems seleccionados 
            }
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            { // Si las teclas pulsadas son retroceso o suprime enviamos a papelera
                anyadelistbox2(milistbox, Convert.ToInt32(milistbox.Tag));
                borralistbox(milistbox);
            }
        }
        private void anyadelistbox2(ListBox milistbox, int numlisBox)
        {
            for (int i = 0; i < milistbox.Items.Count; i++)
            {
                if (milistbox.GetSelected(i))
                {
                    VentanaPapelera.lbPapelera.Items.Add(milistbox.Items[i] + "-" + numlisBox);
                } // Añadimos ítem del listbox con nº 1 o 2 que identificará el origen
            }
        }

        private void btPapelera_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) // Devuelve true si es un 
            { //texto lo arrastrado
                if (lb1.SelectedIndex > -1)
                {
                    anyadelistbox2(lb1, 1); // Enviamos un 1 por lb1 
                    borralistbox(lb1);
                }

                if (lb2.SelectedIndex > -1)
                {
                    anyadelistbox2(lb2, 2); // Enviamos un 2 por lb2 
                    borralistbox(lb2);
                }
            }
        }

        private void btPapelera_Click(object sender, EventArgs e)
        {
            VentanaPapelera.milb1 = lb1; // Asociamos listbox con objetos de la 
            VentanaPapelera.milb2 = lb2; // misma clase del otro formulario
            VentanaPapelera.ShowDialog(); //.Show(); 
                                          //Se puede elegir entre dejar la ventana como modal ó que sea flotante.
        }

        private void vaciarPapeleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPapelera.lbPapelera.Items.Clear();//Vaciamos ListBox de fmPapelera

        }
    }
}
