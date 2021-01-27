
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
            this.btnInneFukt = new System.Windows.Forms.Button();
            this.lblMatningInne = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRaderDBInne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtimePickerInne = new System.Windows.Forms.DateTimePicker();
            this.btnInneTemp = new System.Windows.Forms.Button();
            this.btnInneAterst = new System.Windows.Forms.Button();
            this.btnInneMogelRisk = new System.Windows.Forms.Button();
            this.btnInneSearch = new System.Windows.Forms.Button();
            this.gvInne = new System.Windows.Forms.DataGridView();
            this.tbpUte = new System.Windows.Forms.TabPage();
            this.lblMatningUte = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUteAntalRaderDB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUteMogelRisk = new System.Windows.Forms.Button();
            this.dTimePickerUte = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMetVinter = new System.Windows.Forms.Label();
            this.lblMetHost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUteMedelTemp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUteFukt = new System.Windows.Forms.Button();
            this.btnUteSearch = new System.Windows.Forms.Button();
            this.GvUte = new System.Windows.Forms.DataGridView();
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
            this.tbpInne.Controls.Add(this.btnInneFukt);
            this.tbpInne.Controls.Add(this.lblMatningInne);
            this.tbpInne.Controls.Add(this.label6);
            this.tbpInne.Controls.Add(this.lblRaderDBInne);
            this.tbpInne.Controls.Add(this.label2);
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
            // btnInneFukt
            // 
            this.btnInneFukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInneFukt.Location = new System.Drawing.Point(8, 170);
            this.btnInneFukt.Name = "btnInneFukt";
            this.btnInneFukt.Size = new System.Drawing.Size(124, 34);
            this.btnInneFukt.TabIndex = 19;
            this.btnInneFukt.Text = "Fuktighet";
            this.btnInneFukt.UseVisualStyleBackColor = true;
            this.btnInneFukt.Click += new System.EventHandler(this.btnInneFukt_Click);
            // 
            // lblMatningInne
            // 
            this.lblMatningInne.AutoSize = true;
            this.lblMatningInne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatningInne.Location = new System.Drawing.Point(123, 82);
            this.lblMatningInne.Name = "lblMatningInne";
            this.lblMatningInne.Size = new System.Drawing.Size(32, 17);
            this.lblMatningInne.TabIndex = 18;
            this.lblMatningInne.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mätning inomhus:";
            // 
            // lblRaderDBInne
            // 
            this.lblRaderDBInne.AutoSize = true;
            this.lblRaderDBInne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaderDBInne.Location = new System.Drawing.Point(123, 56);
            this.lblRaderDBInne.Name = "lblRaderDBInne";
            this.lblRaderDBInne.Size = new System.Drawing.Size(32, 17);
            this.lblRaderDBInne.TabIndex = 16;
            this.lblRaderDBInne.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Antal rader i DB:";
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
            this.btnInneTemp.Location = new System.Drawing.Point(7, 116);
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
            this.btnInneAterst.Location = new System.Drawing.Point(186, 116);
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
            this.btnInneMogelRisk.Location = new System.Drawing.Point(184, 170);
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
            this.tbpUte.Controls.Add(this.lblMatningUte);
            this.tbpUte.Controls.Add(this.label5);
            this.tbpUte.Controls.Add(this.lblUteAntalRaderDB);
            this.tbpUte.Controls.Add(this.label8);
            this.tbpUte.Controls.Add(this.btnUteMogelRisk);
            this.tbpUte.Controls.Add(this.dTimePickerUte);
            this.tbpUte.Controls.Add(this.label4);
            this.tbpUte.Controls.Add(this.lblMetVinter);
            this.tbpUte.Controls.Add(this.lblMetHost);
            this.tbpUte.Controls.Add(this.label1);
            this.tbpUte.Controls.Add(this.btnUteMedelTemp);
            this.tbpUte.Controls.Add(this.button4);
            this.tbpUte.Controls.Add(this.btnUteFukt);
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
            // lblMatningUte
            // 
            this.lblMatningUte.AutoSize = true;
            this.lblMatningUte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatningUte.Location = new System.Drawing.Point(124, 72);
            this.lblMatningUte.Name = "lblMatningUte";
            this.lblMatningUte.Size = new System.Drawing.Size(32, 17);
            this.lblMatningUte.TabIndex = 22;
            this.lblMatningUte.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mätning utomhus:";
            // 
            // lblUteAntalRaderDB
            // 
            this.lblUteAntalRaderDB.AutoSize = true;
            this.lblUteAntalRaderDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUteAntalRaderDB.Location = new System.Drawing.Point(124, 46);
            this.lblUteAntalRaderDB.Name = "lblUteAntalRaderDB";
            this.lblUteAntalRaderDB.Size = new System.Drawing.Size(32, 17);
            this.lblUteAntalRaderDB.TabIndex = 20;
            this.lblUteAntalRaderDB.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Antal rader i DB:";
            // 
            // btnUteMogelRisk
            // 
            this.btnUteMogelRisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUteMogelRisk.Location = new System.Drawing.Point(187, 147);
            this.btnUteMogelRisk.Name = "btnUteMogelRisk";
            this.btnUteMogelRisk.Size = new System.Drawing.Size(124, 34);
            this.btnUteMogelRisk.TabIndex = 16;
            this.btnUteMogelRisk.Text = "Mögelrisk";
            this.btnUteMogelRisk.UseVisualStyleBackColor = true;
            this.btnUteMogelRisk.Click += new System.EventHandler(this.btnUteMogelRisk_Click);
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
            this.lblMetHost.Location = new System.Drawing.Point(6, 228);
            this.lblMetHost.Name = "lblMetHost";
            this.lblMetHost.Size = new System.Drawing.Size(32, 17);
            this.lblMetHost.TabIndex = 9;
            this.lblMetHost.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Meteoroligsk Höst:";
            // 
            // btnUteMedelTemp
            // 
            this.btnUteMedelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUteMedelTemp.Location = new System.Drawing.Point(7, 103);
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
            this.button4.Location = new System.Drawing.Point(186, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Återställ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Statistik_Load);
            // 
            // btnUteFukt
            // 
            this.btnUteFukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUteFukt.Location = new System.Drawing.Point(7, 147);
            this.btnUteFukt.Name = "btnUteFukt";
            this.btnUteFukt.Size = new System.Drawing.Size(175, 34);
            this.btnUteFukt.TabIndex = 5;
            this.btnUteFukt.Text = "Torr (Medelfukt/dag)";
            this.btnUteFukt.UseVisualStyleBackColor = true;
            this.btnUteFukt.Click += new System.EventHandler(this.btnUteFukt_Click);
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
            this.tbpInne.PerformLayout();
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
        private System.Windows.Forms.Button btnUteFukt;
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
        private System.Windows.Forms.Label lblMatningInne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRaderDBInne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatningUte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUteAntalRaderDB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInneFukt;
    }
}