
namespace EFWeather
{
    partial class NewCSV
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
            this.btnStatNCSV = new System.Windows.Forms.Button();
            this.btnHemNCSV = new System.Windows.Forms.Button();
            this.tbGetFile = new System.Windows.Forms.TextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.btnAddNewRecords = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.gvNewCSV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAntalRader = new System.Windows.Forms.Label();
            this.lblRaderDB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvNewCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStatNCSV
            // 
            this.btnStatNCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatNCSV.Location = new System.Drawing.Point(108, 3);
            this.btnStatNCSV.Name = "btnStatNCSV";
            this.btnStatNCSV.Size = new System.Drawing.Size(100, 29);
            this.btnStatNCSV.TabIndex = 0;
            this.btnStatNCSV.Text = "Statistik";
            this.btnStatNCSV.UseVisualStyleBackColor = true;
            this.btnStatNCSV.Click += new System.EventHandler(this.btnStatNCSV_Click);
            // 
            // btnHemNCSV
            // 
            this.btnHemNCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHemNCSV.Location = new System.Drawing.Point(2, 3);
            this.btnHemNCSV.Name = "btnHemNCSV";
            this.btnHemNCSV.Size = new System.Drawing.Size(100, 29);
            this.btnHemNCSV.TabIndex = 1;
            this.btnHemNCSV.Text = "Hem";
            this.btnHemNCSV.UseVisualStyleBackColor = true;
            this.btnHemNCSV.Click += new System.EventHandler(this.btnHemNCSV_Click);
            // 
            // tbGetFile
            // 
            this.tbGetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGetFile.Location = new System.Drawing.Point(2, 38);
            this.tbGetFile.Name = "tbGetFile";
            this.tbGetFile.Size = new System.Drawing.Size(547, 26);
            this.tbGetFile.TabIndex = 2;
            // 
            // btnGetFile
            // 
            this.btnGetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFile.Location = new System.Drawing.Point(555, 35);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(149, 29);
            this.btnGetFile.TabIndex = 3;
            this.btnGetFile.Text = "Hämta CSV Fil";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnAddNewRecords
            // 
            this.btnAddNewRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRecords.Location = new System.Drawing.Point(555, 206);
            this.btnAddNewRecords.Name = "btnAddNewRecords";
            this.btnAddNewRecords.Size = new System.Drawing.Size(149, 29);
            this.btnAddNewRecords.TabIndex = 4;
            this.btnAddNewRecords.Text = "Lägg till ny data";
            this.btnAddNewRecords.UseVisualStyleBackColor = true;
            this.btnAddNewRecords.Click += new System.EventHandler(this.btnAddNewRecords_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNew.Location = new System.Drawing.Point(555, 155);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(149, 29);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "Spara ny data";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // gvNewCSV
            // 
            this.gvNewCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNewCSV.Location = new System.Drawing.Point(2, 70);
            this.gvNewCSV.Name = "gvNewCSV";
            this.gvNewCSV.Size = new System.Drawing.Size(547, 368);
            this.gvNewCSV.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Antal rader i filen:";
            // 
            // lblAntalRader
            // 
            this.lblAntalRader.AutoSize = true;
            this.lblAntalRader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntalRader.Location = new System.Drawing.Point(606, 102);
            this.lblAntalRader.Name = "lblAntalRader";
            this.lblAntalRader.Size = new System.Drawing.Size(40, 17);
            this.lblAntalRader.TabIndex = 8;
            this.lblAntalRader.Text = "????";
            // 
            // lblRaderDB
            // 
            this.lblRaderDB.AutoSize = true;
            this.lblRaderDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaderDB.Location = new System.Drawing.Point(606, 271);
            this.lblRaderDB.Name = "lblRaderDB";
            this.lblRaderDB.Size = new System.Drawing.Size(40, 17);
            this.lblRaderDB.TabIndex = 12;
            this.lblRaderDB.Text = "????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Antal rader i DB";
            // 
            // NewCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.lblRaderDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAntalRader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvNewCSV);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnAddNewRecords);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.tbGetFile);
            this.Controls.Add(this.btnHemNCSV);
            this.Controls.Add(this.btnStatNCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ncsv_FormClosing);
            this.Load += new System.EventHandler(this.NewCSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvNewCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatNCSV;
        private System.Windows.Forms.Button btnHemNCSV;
        private System.Windows.Forms.TextBox tbGetFile;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Button btnAddNewRecords;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.DataGridView gvNewCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAntalRader;
        private System.Windows.Forms.Label lblRaderDB;
        private System.Windows.Forms.Label label5;
    }
}