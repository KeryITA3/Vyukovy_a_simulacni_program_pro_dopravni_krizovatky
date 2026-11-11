namespace DopravniKrizovatky
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOvladani = new System.Windows.Forms.Panel();
            this.platnoKrizovatky = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHorniMenu = new System.Windows.Forms.Panel();
            this.cmbSablona = new System.Windows.Forms.ComboBox();
            this.chkSipky = new System.Windows.Forms.CheckBox();
            this.btnNapoveda = new System.Windows.Forms.Button();
            this.rbVyuka = new System.Windows.Forms.RadioButton();
            this.rbProcvicovani = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelOvladani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platnoKrizovatky)).BeginInit();
            this.panelHorniMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOvladani
            // 
            this.panelOvladani.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOvladani.Controls.Add(this.lblInfo);
            this.panelOvladani.Controls.Add(this.rbProcvicovani);
            this.panelOvladani.Controls.Add(this.rbVyuka);
            this.panelOvladani.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOvladani.Location = new System.Drawing.Point(933, 0);
            this.panelOvladani.Name = "panelOvladani";
            this.panelOvladani.Size = new System.Drawing.Size(325, 461);
            this.panelOvladani.TabIndex = 0;
            // 
            // platnoKrizovatky
            // 
            this.platnoKrizovatky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.platnoKrizovatky.Location = new System.Drawing.Point(0, 35);
            this.platnoKrizovatky.Name = "platnoKrizovatky";
            this.platnoKrizovatky.Size = new System.Drawing.Size(933, 426);
            this.platnoKrizovatky.TabIndex = 1;
            this.platnoKrizovatky.TabStop = false;
            this.platnoKrizovatky.Paint += new System.Windows.Forms.PaintEventHandler(this.platnoKrizovatky_Paint);
            this.platnoKrizovatky.Resize += new System.EventHandler(this.platnoKrizovatky_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Křižovatka:";
            // 
            // panelHorniMenu
            // 
            this.panelHorniMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHorniMenu.Controls.Add(this.btnNapoveda);
            this.panelHorniMenu.Controls.Add(this.chkSipky);
            this.panelHorniMenu.Controls.Add(this.cmbSablona);
            this.panelHorniMenu.Controls.Add(this.label1);
            this.panelHorniMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorniMenu.Location = new System.Drawing.Point(0, 0);
            this.panelHorniMenu.Name = "panelHorniMenu";
            this.panelHorniMenu.Size = new System.Drawing.Size(933, 35);
            this.panelHorniMenu.TabIndex = 2;
            // 
            // cmbSablona
            // 
            this.cmbSablona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSablona.FormattingEnabled = true;
            this.cmbSablona.Location = new System.Drawing.Point(75, 6);
            this.cmbSablona.Name = "cmbSablona";
            this.cmbSablona.Size = new System.Drawing.Size(121, 21);
            this.cmbSablona.TabIndex = 1;
            this.cmbSablona.SelectedIndexChanged += new System.EventHandler(this.cmbSablona_SelectedIndexChanged);
            // 
            // chkSipky
            // 
            this.chkSipky.AutoSize = true;
            this.chkSipky.Checked = true;
            this.chkSipky.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSipky.Location = new System.Drawing.Point(208, 9);
            this.chkSipky.Name = "chkSipky";
            this.chkSipky.Size = new System.Drawing.Size(134, 17);
            this.chkSipky.TabIndex = 2;
            this.chkSipky.Text = "Zobrazit směrové šipky";
            this.chkSipky.UseVisualStyleBackColor = true;
            this.chkSipky.CheckedChanged += new System.EventHandler(this.chkSipky_CheckedChanged);
            // 
            // btnNapoveda
            // 
            this.btnNapoveda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNapoveda.Location = new System.Drawing.Point(863, 0);
            this.btnNapoveda.Name = "btnNapoveda";
            this.btnNapoveda.Size = new System.Drawing.Size(70, 35);
            this.btnNapoveda.TabIndex = 3;
            this.btnNapoveda.Text = "Nápověda";
            this.btnNapoveda.UseVisualStyleBackColor = true;
            this.btnNapoveda.Click += new System.EventHandler(this.btnNapoveda_Click);
            // 
            // rbVyuka
            // 
            this.rbVyuka.AutoSize = true;
            this.rbVyuka.Location = new System.Drawing.Point(6, 7);
            this.rbVyuka.Name = "rbVyuka";
            this.rbVyuka.Size = new System.Drawing.Size(85, 17);
            this.rbVyuka.TabIndex = 0;
            this.rbVyuka.TabStop = true;
            this.rbVyuka.Text = "Režim výuky";
            this.rbVyuka.UseVisualStyleBackColor = true;
            // 
            // rbProcvicovani
            // 
            this.rbProcvicovani.AutoSize = true;
            this.rbProcvicovani.Location = new System.Drawing.Point(6, 30);
            this.rbProcvicovani.Name = "rbProcvicovani";
            this.rbProcvicovani.Size = new System.Drawing.Size(120, 17);
            this.rbProcvicovani.TabIndex = 1;
            this.rbProcvicovani.TabStop = true;
            this.rbProcvicovani.Text = "Režim procvičování";
            this.rbProcvicovani.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(3, 64);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(319, 388);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Zde se zobrazí popis pravidel.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 461);
            this.Controls.Add(this.platnoKrizovatky);
            this.Controls.Add(this.panelHorniMenu);
            this.Controls.Add(this.panelOvladani);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOvladani.ResumeLayout(false);
            this.panelOvladani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platnoKrizovatky)).EndInit();
            this.panelHorniMenu.ResumeLayout(false);
            this.panelHorniMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOvladani;
        private System.Windows.Forms.PictureBox platnoKrizovatky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHorniMenu;
        private System.Windows.Forms.Button btnNapoveda;
        private System.Windows.Forms.CheckBox chkSipky;
        private System.Windows.Forms.ComboBox cmbSablona;
        private System.Windows.Forms.RadioButton rbProcvicovani;
        private System.Windows.Forms.RadioButton rbVyuka;
        private System.Windows.Forms.Label lblInfo;
    }
}

