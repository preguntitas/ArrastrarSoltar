namespace ArrastrarSoltar
{
    partial class fmArrastrarSoltar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.ckOrdena1 = new System.Windows.Forms.CheckBox();
            this.ckOrdena2 = new System.Windows.Forms.CheckBox();
            this.btAcercade = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmnPapelera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itcAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.vaciarPapeleraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btPapelera = new System.Windows.Forms.Button();
            this.btBorraTodo2 = new System.Windows.Forms.Button();
            this.btBorra2 = new System.Windows.Forms.Button();
            this.btBorraTodo1 = new System.Windows.Forms.Button();
            this.btBorra1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmnPapelera.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrastra Uno/os Archivo/s de Texto a los ListBox Intercambia los Elementos entre " +
    "ellos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb1
            // 
            this.lb1.AllowDrop = true;
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(101, 153);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb1.Size = new System.Drawing.Size(141, 160);
            this.lb1.TabIndex = 5;
            this.lb1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb1_DragEnter);
            this.lb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb1_KeyDown);
            this.lb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseDown);
            // 
            // lb2
            // 
            this.lb2.AllowDrop = true;
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(582, 153);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(148, 160);
            this.lb2.TabIndex = 6;
            this.lb2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb1_DragEnter);
            this.lb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseDown);
            // 
            // ckOrdena1
            // 
            this.ckOrdena1.AutoSize = true;
            this.ckOrdena1.Location = new System.Drawing.Point(141, 352);
            this.ckOrdena1.Name = "ckOrdena1";
            this.ckOrdena1.Size = new System.Drawing.Size(61, 17);
            this.ckOrdena1.TabIndex = 7;
            this.ckOrdena1.Text = "Ordena";
            this.ckOrdena1.UseVisualStyleBackColor = true;
            this.ckOrdena1.CheckedChanged += new System.EventHandler(this.ckOrdena1_CheckedChanged);
            // 
            // ckOrdena2
            // 
            this.ckOrdena2.AutoSize = true;
            this.ckOrdena2.Location = new System.Drawing.Point(626, 350);
            this.ckOrdena2.Name = "ckOrdena2";
            this.ckOrdena2.Size = new System.Drawing.Size(61, 17);
            this.ckOrdena2.TabIndex = 8;
            this.ckOrdena2.Text = "Ordena";
            this.ckOrdena2.UseVisualStyleBackColor = true;
            this.ckOrdena2.CheckedChanged += new System.EventHandler(this.ckOrdena1_CheckedChanged);
            // 
            // btAcercade
            // 
            this.btAcercade.Location = new System.Drawing.Point(554, 407);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(75, 23);
            this.btAcercade.TabIndex = 9;
            this.btAcercade.Text = "Acerca de";
            this.btAcercade.UseVisualStyleBackColor = true;
            this.btAcercade.Click += new System.EventHandler(this.btAcercade_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(666, 406);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 10;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pulsa <SUPR> ó <BACK> para enciar a Papelera";
            // 
            // cmnPapelera
            // 
            this.cmnPapelera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itcAbrir,
            this.toolStripSeparator1,
            this.vaciarPapeleraToolStripMenuItem});
            this.cmnPapelera.Name = "cmnPapelera";
            this.cmnPapelera.Size = new System.Drawing.Size(154, 54);
            // 
            // itcAbrir
            // 
            this.itcAbrir.Name = "itcAbrir";
            this.itcAbrir.Size = new System.Drawing.Size(153, 22);
            this.itcAbrir.Text = "Abrir";
            this.itcAbrir.Click += new System.EventHandler(this.btPapelera_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // vaciarPapeleraToolStripMenuItem
            // 
            this.vaciarPapeleraToolStripMenuItem.Name = "vaciarPapeleraToolStripMenuItem";
            this.vaciarPapeleraToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.vaciarPapeleraToolStripMenuItem.Text = "Vaciar Papelera";
            // 
            // btPapelera
            // 
            this.btPapelera.AllowDrop = true;
            this.btPapelera.BackColor = System.Drawing.Color.Transparent;
            this.btPapelera.ContextMenuStrip = this.cmnPapelera;
            this.btPapelera.FlatAppearance.BorderSize = 0;
            this.btPapelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPapelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPapelera.Image = global::ArrastrarSoltar.Properties.Resources.papelera;
            this.btPapelera.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPapelera.Location = new System.Drawing.Point(376, 306);
            this.btPapelera.Name = "btPapelera";
            this.btPapelera.Size = new System.Drawing.Size(83, 113);
            this.btPapelera.TabIndex = 13;
            this.btPapelera.Text = "Papelera de Reciclaje";
            this.btPapelera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPapelera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPapelera.UseVisualStyleBackColor = false;
            this.btPapelera.Click += new System.EventHandler(this.btPapelera_Click);
            this.btPapelera.DragDrop += new System.Windows.Forms.DragEventHandler(this.btPapelera_DragDrop);
            this.btPapelera.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb1_DragEnter);
            // 
            // btBorraTodo2
            // 
            this.btBorraTodo2.Image = global::ArrastrarSoltar.Properties.Resources.borrartodo;
            this.btBorraTodo2.Location = new System.Drawing.Point(666, 83);
            this.btBorraTodo2.Name = "btBorraTodo2";
            this.btBorraTodo2.Size = new System.Drawing.Size(64, 64);
            this.btBorraTodo2.TabIndex = 4;
            this.btBorraTodo2.UseVisualStyleBackColor = true;
            this.btBorraTodo2.Click += new System.EventHandler(this.btBorraTodo1_Click);
            // 
            // btBorra2
            // 
            this.btBorra2.Image = global::ArrastrarSoltar.Properties.Resources.borrar;
            this.btBorra2.Location = new System.Drawing.Point(582, 83);
            this.btBorra2.Name = "btBorra2";
            this.btBorra2.Size = new System.Drawing.Size(64, 64);
            this.btBorra2.TabIndex = 3;
            this.btBorra2.UseVisualStyleBackColor = true;
            this.btBorra2.Click += new System.EventHandler(this.btBorra1_Click);
            // 
            // btBorraTodo1
            // 
            this.btBorraTodo1.Image = global::ArrastrarSoltar.Properties.Resources.borrartodo;
            this.btBorraTodo1.Location = new System.Drawing.Point(178, 83);
            this.btBorraTodo1.Name = "btBorraTodo1";
            this.btBorraTodo1.Size = new System.Drawing.Size(64, 64);
            this.btBorraTodo1.TabIndex = 2;
            this.btBorraTodo1.UseVisualStyleBackColor = true;
            this.btBorraTodo1.Click += new System.EventHandler(this.btBorraTodo1_Click);
            // 
            // btBorra1
            // 
            this.btBorra1.Image = global::ArrastrarSoltar.Properties.Resources.borrar;
            this.btBorra1.Location = new System.Drawing.Point(97, 83);
            this.btBorra1.Name = "btBorra1";
            this.btBorra1.Size = new System.Drawing.Size(64, 64);
            this.btBorra1.TabIndex = 1;
            this.btBorra1.UseVisualStyleBackColor = true;
            this.btBorra1.Click += new System.EventHandler(this.btBorra1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Botones para eliminacion Definitiva";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 79);
            this.label4.TabIndex = 15;
            this.label4.Text = "Para eliminación definitiva pulsa <SHIFT> y <SUPR> ó <SHIFT> y <BACK>";
            // 
            // fmArrastrarSoltar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPapelera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAcercade);
            this.Controls.Add(this.ckOrdena2);
            this.Controls.Add(this.ckOrdena1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btBorraTodo2);
            this.Controls.Add(this.btBorra2);
            this.Controls.Add(this.btBorraTodo1);
            this.Controls.Add(this.btBorra1);
            this.Controls.Add(this.label1);
            this.Name = "fmArrastrarSoltar";
            this.Text = "Arrastrar y Soltar";
            this.cmnPapelera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBorra1;
        private System.Windows.Forms.Button btBorraTodo1;
        private System.Windows.Forms.Button btBorra2;
        private System.Windows.Forms.Button btBorraTodo2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.CheckBox ckOrdena1;
        private System.Windows.Forms.CheckBox ckOrdena2;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPapelera;
        private System.Windows.Forms.ContextMenuStrip cmnPapelera;
        private System.Windows.Forms.ToolStripMenuItem itcAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem vaciarPapeleraToolStripMenuItem;
        private System.Windows.Forms.Button btAcercade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

