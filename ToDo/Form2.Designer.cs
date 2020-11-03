namespace ToDo
{
    partial class frmLista
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
            this.lbTargyak = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTargyak
            // 
            this.lbTargyak.FormattingEnabled = true;
            this.lbTargyak.ItemHeight = 20;
            this.lbTargyak.Location = new System.Drawing.Point(16, 17);
            this.lbTargyak.Name = "lbTargyak";
            this.lbTargyak.Size = new System.Drawing.Size(295, 464);
            this.lbTargyak.TabIndex = 0;
            this.lbTargyak.DoubleClick += new System.EventHandler(this.lbTargyak_DoubleClick);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 495);
            this.Controls.Add(this.lbTargyak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Választható elemek";
            this.Shown += new System.EventHandler(this.frmLista_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTargyak;
    }
}