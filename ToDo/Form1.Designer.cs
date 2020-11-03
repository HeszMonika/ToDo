namespace ToDo
{
    partial class frmKezdo
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
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.listákKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBeolvasas = new System.Windows.Forms.ToolStripMenuItem();
            this.mMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEltavolit = new System.Windows.Forms.Button();
            this.btnKivesz = new System.Windows.Forms.Button();
            this.btnListabol = new System.Windows.Forms.Button();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbToDo = new System.Windows.Forms.ListBox();
            this.tbBevitel = new System.Windows.Forms.TextBox();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.ofdMegnyitas = new System.Windows.Forms.OpenFileDialog();
            this.sfdMentes = new System.Windows.Forms.SaveFileDialog();
            this.mMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listákKezeléseToolStripMenuItem});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(584, 24);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "menuStrip1";
            // 
            // listákKezeléseToolStripMenuItem
            // 
            this.listákKezeléseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBeolvasas,
            this.mMentes,
            this.toolStripMenuItem1,
            this.mKilepes});
            this.listákKezeléseToolStripMenuItem.Name = "listákKezeléseToolStripMenuItem";
            this.listákKezeléseToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.listákKezeléseToolStripMenuItem.Text = "Listák kezelése";
            // 
            // mBeolvasas
            // 
            this.mBeolvasas.Name = "mBeolvasas";
            this.mBeolvasas.Size = new System.Drawing.Size(180, 22);
            this.mBeolvasas.Text = "Beolvasás";
            this.mBeolvasas.Click += new System.EventHandler(this.mBeolvasas_Click);
            // 
            // mMentes
            // 
            this.mMentes.Name = "mMentes";
            this.mMentes.Size = new System.Drawing.Size(180, 22);
            this.mMentes.Text = "Mentés";
            this.mMentes.Click += new System.EventHandler(this.mMentes_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mKilepes
            // 
            this.mKilepes.Name = "mKilepes";
            this.mKilepes.Size = new System.Drawing.Size(180, 22);
            this.mKilepes.Text = "Kilépés";
            this.mKilepes.Click += new System.EventHandler(this.mKilepes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnEltavolit);
            this.panel1.Controls.Add(this.btnKivesz);
            this.panel1.Controls.Add(this.btnListabol);
            this.panel1.Controls.Add(this.btnFelvitel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbToDo);
            this.panel1.Controls.Add(this.tbBevitel);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 377);
            this.panel1.TabIndex = 1;
            // 
            // btnEltavolit
            // 
            this.btnEltavolit.BackgroundImage = global::ToDo.Properties.Resources.delete;
            this.btnEltavolit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEltavolit.Location = new System.Drawing.Point(282, 328);
            this.btnEltavolit.Name = "btnEltavolit";
            this.btnEltavolit.Size = new System.Drawing.Size(30, 30);
            this.btnEltavolit.TabIndex = 6;
            this.btnEltavolit.UseVisualStyleBackColor = true;
            this.btnEltavolit.Click += new System.EventHandler(this.btnEltavolit_Click);
            // 
            // btnKivesz
            // 
            this.btnKivesz.BackgroundImage = global::ToDo.Properties.Resources.minus;
            this.btnKivesz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKivesz.Location = new System.Drawing.Point(282, 135);
            this.btnKivesz.Name = "btnKivesz";
            this.btnKivesz.Size = new System.Drawing.Size(30, 30);
            this.btnKivesz.TabIndex = 5;
            this.btnKivesz.UseVisualStyleBackColor = true;
            this.btnKivesz.Click += new System.EventHandler(this.btnKivesz_Click);
            // 
            // btnListabol
            // 
            this.btnListabol.BackgroundImage = global::ToDo.Properties.Resources.add;
            this.btnListabol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListabol.Location = new System.Drawing.Point(282, 94);
            this.btnListabol.Name = "btnListabol";
            this.btnListabol.Size = new System.Drawing.Size(30, 30);
            this.btnListabol.TabIndex = 4;
            this.btnListabol.UseVisualStyleBackColor = true;
            this.btnListabol.Click += new System.EventHandler(this.btnListabol_Click);
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.BackgroundImage = global::ToDo.Properties.Resources.add;
            this.btnFelvitel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFelvitel.Location = new System.Drawing.Point(282, 13);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(30, 30);
            this.btnFelvitel.TabIndex = 3;
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tennivalók";
            // 
            // lbToDo
            // 
            this.lbToDo.FormattingEnabled = true;
            this.lbToDo.ItemHeight = 20;
            this.lbToDo.Location = new System.Drawing.Point(12, 94);
            this.lbToDo.Name = "lbToDo";
            this.lbToDo.Size = new System.Drawing.Size(253, 264);
            this.lbToDo.TabIndex = 1;
            // 
            // tbBevitel
            // 
            this.tbBevitel.Location = new System.Drawing.Point(12, 15);
            this.tbBevitel.Name = "tbBevitel";
            this.tbBevitel.Size = new System.Drawing.Size(253, 26);
            this.tbBevitel.TabIndex = 0;
            // 
            // btnKilepes
            // 
            this.btnKilepes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKilepes.Image = global::ToDo.Properties.Resources.exit_small;
            this.btnKilepes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKilepes.Location = new System.Drawing.Point(412, 355);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnKilepes.Size = new System.Drawing.Size(139, 49);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // ofdMegnyitas
            // 
            this.ofdMegnyitas.Filter = "ToDo lista|*.txt";
            this.ofdMegnyitas.Title = "ToDo lista beolvasasa";
            // 
            // sfdMentes
            // 
            this.sfdMentes.DefaultExt = "txt";
            this.sfdMentes.Filter = "ToDo lista|*.txt";
            this.sfdMentes.Title = "ToDo lista mentese";
            // 
            // frmKezdo
            // 
            this.AcceptButton = this.btnFelvitel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKezdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo lista keszites";
            this.Shown += new System.EventHandler(this.frmKezdo_Shown);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem listákKezeléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mBeolvasas;
        private System.Windows.Forms.ToolStripMenuItem mMentes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mKilepes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEltavolit;
        private System.Windows.Forms.Button btnKivesz;
        private System.Windows.Forms.Button btnListabol;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbToDo;
        private System.Windows.Forms.TextBox tbBevitel;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.OpenFileDialog ofdMegnyitas;
        private System.Windows.Forms.SaveFileDialog sfdMentes;
    }
}

