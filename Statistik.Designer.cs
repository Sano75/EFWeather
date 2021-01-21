
namespace EFWeather
{
    partial class Statistik
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
            this.btnHemStat = new System.Windows.Forms.Button();
            this.btnNCSVStat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpInne = new System.Windows.Forms.TabPage();
            this.dtimePickerInne = new System.Windows.Forms.DateTimePicker();
            this.btnInneTemp = new System.Windows.Forms.Button();
            this.btnInneAterst = new System.Windows.Forms.Button();
            this.btnInneMogelRisk = new System.Windows.Forms.Button();
            this.btnInneSearch = new System.Windows.Forms.Button();
            this.gvInne = new System.Windows.Forms.DataGridView();
            this.tbpUte = new System.Windows.Forms.TabPage();
            this.dTimePickerUte = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMetVinter = new System.Windows.Forms.Label();
            this.lblMetHost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUteMedelTemp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUteSearch = new System.Windows.Forms.Button();
            this.GvUte = new System.Windows.Forms.DataGridView();
            this.btnUteMogelRisk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpInne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInne)).BeginInit();
            this.tbpUte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvUte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHemStat
            // 
            this.btnHemStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHemStat.Location = new System.Drawing.Point(2, 2);
            this.btnHemStat.Name = "btnHemStat";
            this.btnHemStat.Size = new System.Drawing.Size(100, 29);
            this.btnHemStat.TabIndex = 3;
            this.btnHemStat.Text = "Hem";
            this.btnHemStat.UseVisualStyleBackColor = true;
            this.btnHemStat.Click += new System.EventHandler(this.btnHemStat_Click);
            // 
            // btnNCSVStat
            // 
            this.btnNCSVStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCSVStat.Location = new System.Drawing.Point(108, 2);
            this.btnNCSVStat.Name = "btnNCSVStat";
            this.btnNCSVStat.Size = new System.Drawing.Size(100, 29);
            this.btnNCSVStat.TabIndex = 2;
            this.btnNCSVStat.Text = "New CSV";
            this.btnNCSVStat.UseVisualStyleBackColor = true;
            this.btnNCSVStat.Click += new System.EventHandler(this.btnNCSVStat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpInne);
            this.tabControl1.Controls.Add(this.tbpUte);
            this.tabControl1.Location = new System.Drawing.Point(2, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 412);
            this.tabControl1.TabIndex = 4;
            // 
            // tbpInne
            // 
            this.tbpInne.Controls.Add(this.dtimePickerInne);
            this.tbpInne.Controls.Add(this.btnInneTemp);
            this.tbpInne.Controls.Add(this.btnInneAterst);
            this.tbpInne.Controls.Add(this.btnInneMogelRisk);
            this.tbpInne.Controls.Add(this.btnInneSearch);
            this.tbpInne.Controls.Add(this.gvInne);
            this.tbpInne.Location = new System.Drawing.Point(4, 22);
            this.tbpInne.Name = "tbpInne";
            this.tbpInne.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInne.Size = new System.Drawing.Size(867, 386);
            this.tbpInne.TabIndex = 0;
            this.tbpInne.Text = "Inne";
            this.tbpInne.UseVisualStyleBackColor = true;
            // 
            // dtimePickerInne
            // 
            this.dtimePickerInne.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimePickerInne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimePickerInne.Location = new System.Drawing.Point(7, 11);
            this.dtimePickerInne.Name = "dtimePickerInne";
            this.dtimePickerInne.Size = new System.Drawing.Size(200, 23);
            this.dtimePickerInne.TabIndex = 14;
            // 
            // btnInneTemp
            // 
            this.btnInneTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInneTemp.Location = new System.Drawing.Point(7, 66);
            this.btnInneTemp.Name = "btnInneTemp";
            this.btnInneTemp.Size = new System.Drawing.Size(124, 34);
            this.btnInneTemp.TabIndex = 13;
            this.btnInneTemp.Text = "Medel Temp";
            this.btnInneTemp.UseVisualStyleBackColor = true;
            this.btnInneTemp.Click += new System.EventHandler(this.btnInneTemp_Click);
            // 
            // btnInneAterst
            // 
            this.btnInneAterst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInneAterst.Location = new System.Drawing.Point(186, 66);
            this.btnInneAterst.Name = "btnInneAterst";
            this.btnInneAterst.Size = new System.Drawing.Size(124, 34);
            this.btnInneAterst.TabIndex = 12;
            this.btnInneAterst.Text = "Återställ";
            this.btnInneAterst.UseVisualStyleBackColor = true;
            this.btnInneAterst.Click += new System.EventHandler(this.Statistik_Load);
            // 
            // btnInneMogelRisk
            // 
            this.btnInneMogelRisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInneMogelRisk.Location = new System.Drawing.Point(6, 120);
            this.btnInneMogelRisk.Name = "btnInneMogelRisk";
            this.btnInneMogelRisk.Size = new System.Drawing.Size(124, 34);
            this.btnInneMogelRisk.TabIndex = 11;
            this.btnInneMogelRisk.Text = "Mögelrisk";
            this.btnInneMogelRisk.UseVisualStyleBackColor = true;
            this.btnInneMogelRisk.Click += new System.EventHandler(this.btnInneMogelRisk_Click);
            // 
            // btnInneSearch
            // 
            this.btnInneSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInneSearch.Location = new System.Drawing.Point(225, 6);
            this.btnInneSearch.Name = "btnInneSearch";
            this.btnInneSearch.Size = new System.Drawing.Size(85, 34);
            this.btnInneSearch.TabIndex = 8;
            this.btnInneSearch.Text = "Sök";
            this.btnInneSearch.UseVisualStyleBackColor = true;
            this.btnInneSearch.Click += new System.EventHandler(this.btnInneSearch_Click);
            // 
            // gvInne
            // 
            this.gvInne.AllowUserToAddRows = false;
            this.gvInne.AllowUserToDeleteRows = false;
            this.gvInne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInne.Location = new System.Drawing.Point(316, 6);
            this.gvInne.Name = "gvInne";
            this.gvInne.ReadOnly = true;
            this.gvInne.Size = new System.Drawing.Size(541, 373);
            this.gvInne.TabIndex = 0;
            // 
            // tbpUte
            // 
            this.tbpUte.Controls.Add(this.btnUteMogelRisk);
            this.tbpUte.Controls.Add(this.dTimePickerUte);
            this.tbpUte.Controls.Add(this.label4);
            this.tbpUte.Controls.Add(this.lblMetVinter);
            this.tbpUte.Controls.Add(this.lblMetHost);
            this.tbpUte.Controls.Add(this.label1);
            this.tbpUte.Controls.Add(this.btnUteMedelTemp);
            this.tbpUte.Controls.Add(this.button4);
            this.tbpUte.Controls.Add(this.button3);
            this.tbpUte.Controls.Add(this.btnUteSearch);
            this.tbpUte.Controls.Add(this.GvUte);
            this.tbpUte.Location = new System.Drawing.Point(4, 22);
            this.tbpUte.Name = "tbpUte";
            this.tbpUte.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUte.Size = new System.Drawing.Size(867, 386);
            this.tbpUte.TabIndex = 1;
            this.tbpUte.Text = "Ute";
            this.tbpUte.UseVisualStyleBackColor = true;
            // 
            // dTimePickerUte
            // 
            this.dTimePickerUte.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTimePickerUte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTimePickerUte.Location = new System.Drawing.Point(9, 11);
            this.dTimePickerUte.Name = "dTimePickerUte";
            this.dTimePickerUte.Size = new System.Drawing.Size(200, 23);
            this.dTimePickerUte.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Meteoroligsk Vinter:";
            // 
            // lblMetVinter
            // 
            this.lblMetVinter.AutoSize = true;
            this.lblMetVinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetVinter.Location = new System.Drawing.Point(4, 293);
            this.lblMetVinter.Name = "lblMetVinter";
            this.lblMetVinter.Size = new System.Drawing.Size(32, 17);
            this.lblMetVinter.TabIndex = 10;
            this.lblMetVinter.Text = "???";
            // 
            // lblMetHost
            // 
            this.lblMetHost.AutoSize = true;
            this.lblMetHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetHost.Location = new System.Drawing.Point(6, 211);
            this.lblMetHost.Name = "lblMetHost";
            this.lblMetHost.Size = new System.Drawing.Size(32, 17);
            this.lblMetHost.TabIndex = 9;
            this.lblMetHost.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Meteoroligsk Höst:";
            // 
            // btnUteMedelTemp
            // 
            this.btnUteMedelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUteMedelTemp.Location = new System.Drawing.Point(7, 61);
            this.btnUteMedelTemp.Name = "btnUteMedelTemp";
            this.btnUteMedelTemp.Size = new System.Drawing.Size(173, 34);
            this.btnUteMedelTemp.TabIndex = 7;
            this.btnUteMedelTemp.Text = "Medel Temp";
            this.btnUteMedelTemp.UseVisualStyleBackColor = true;
            this.btnUteMedelTemp.Click += new System.EventHandler(this.btnUteMedelTemp_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(186, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Återställ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Statistik_Load);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(7, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Torr (Medelfukt/dag)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUteSearch
            // 
            this.btnUteSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUteSearch.Location = new System.Drawing.Point(225, 7);
            this.btnUteSearch.Name = "btnUteSearch";
            this.btnUteSearch.Size = new System.Drawing.Size(85, 34);
            this.btnUteSearch.TabIndex = 2;
            this.btnUteSearch.Text = "Sök";
            this.btnUteSearch.UseVisualStyleBackColor = true;
            this.btnUteSearch.Click += new System.EventHandler(this.btnUteSearch_Click);
            // 
            // GvUte
            // 
            this.GvUte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvUte.Location = new System.Drawing.Point(316, 7);
            this.GvUte.Name = "GvUte";
            this.GvUte.Size = new System.Drawing.Size(541, 373);
            this.GvUte.TabIndex = 1;
            // 
            // btnUteMogelRisk
            // 
            this.btnUteMogelRisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUteMogelRisk.Location = new System.Drawing.Point(187, 116);
            this.btnUteMogelRisk.Name = "btnUteMogelRisk";
            this.btnUteMogelRisk.Size = new System.Drawing.Size(124, 34);
            this.btnUteMogelRisk.TabIndex = 16;
            this.btnUteMogelRisk.Text = "Mögelrisk";
            this.btnUteMogelRisk.UseVisualStyleBackColor = true;
            this.btnUteMogelRisk.Click += new System.EventHandler(this.btnUteMogelRisk_Click);
            // 
            // Statistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnHemStat);
            this.Controls.Add(this.btnNCSVStat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Statistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.St_FormClosing);
            this.Load += new System.EventHandler(this.Statistik_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpInne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvInne)).EndInit();
            this.tbpUte.ResumeLayout(false);
            this.tbpUte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvUte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHemStat;
        private System.Windows.Forms.Button btnNCSVStat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInne;
        private System.Windows.Forms.DataGridView gvInne;
        private System.Windows.Forms.TabPage tbpUte;
        private System.Windows.Forms.DataGridView GvUte;
        private System.Windows.Forms.Button btnUteMedelTemp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUteSearch;
        private System.Windows.Forms.Button btnInneTemp;
        private System.Windows.Forms.Button btnInneAterst;
        private System.Windows.Forms.Button btnInneMogelRisk;
        private System.Windows.Forms.Button btnInneSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMetVinter;
        private System.Windows.Forms.Label lblMetHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtimePickerInne;
        private System.Windows.Forms.DateTimePicker dTimePickerUte;
        private System.Windows.Forms.Button btnUteMogelRisk;
    }
}