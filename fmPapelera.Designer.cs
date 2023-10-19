namespace ArrastrarSoltar
{
    partial class fmPapelera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVaciar = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btSeleccionados = new System.Windows.Forms.Button();
            this.lbPapelera = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSeleccionados);
            this.panel1.Controls.Add(this.btTodos);
            this.panel1.Controls.Add(this.btVaciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 100);
            this.panel1.TabIndex = 0;
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(59, 35);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(75, 46);
            this.btVaciar.TabIndex = 0;
            this.btVaciar.Text = "Vaciar Papelera";
            this.btVaciar.UseVisualStyleBackColor = true;
            // 
            // btTodos
            // 
            this.btTodos.Location = new System.Drawing.Point(204, 35);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(75, 47);
            this.btTodos.TabIndex = 1;
            this.btTodos.Text = "Restaurar Todos Elementos";
            this.btTodos.UseVisualStyleBackColor = true;
            // 
            // btSeleccionados
            // 
            this.btSeleccionados.Location = new System.Drawing.Point(337, 35);
            this.btSeleccionados.Name = "btSeleccionados";
            this.btSeleccionados.Size = new System.Drawing.Size(87, 48);
            this.btSeleccionados.TabIndex = 2;
            this.btSeleccionados.Text = "Restaurar Elementos Seleccionados";
            this.btSeleccionados.UseVisualStyleBackColor = true;
            // 
            // lbPapelera
            // 
            this.lbPapelera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPapelera.FormattingEnabled = true;
            this.lbPapelera.HorizontalScrollbar = true;
            this.lbPapelera.Location = new System.Drawing.Point(0, 100);
            this.lbPapelera.Name = "lbPapelera";
            this.lbPapelera.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPapelera.Size = new System.Drawing.Size(484, 350);
            this.lbPapelera.TabIndex = 1;
            // 
            // fmPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.lbPapelera);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmPapelera";
            this.Text = "fmPapelera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmPapelera_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSeleccionados;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btVaciar;
        public System.Windows.Forms.ListBox lbPapelera;
    }
}