
namespace EFWeather
{
    partial class Start
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
            this.btnNewCSV = new System.Windows.Forms.Button();
            this.btnStatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewCSV
            // 
            this.btnNewCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCSV.Location = new System.Drawing.Point(105, 72);
            this.btnNewCSV.Name = "btnNewCSV";
            this.btnNewCSV.Size = new System.Drawing.Size(186, 80);
            this.btnNewCSV.TabIndex = 0;
            this.btnNewCSV.Text = "Ny CSV";
            this.btnNewCSV.UseVisualStyleBackColor = true;
            this.btnNewCSV.Click += new System.EventHandler(this.btnNewCSV_Click);
            // 
            // btnStatistik
            // 
            this.btnStatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistik.Location = new System.Drawing.Point(105, 194);
            this.btnStatistik.Name = "btnStatistik";
            this.btnStatistik.Size = new System.Drawing.Size(186, 80);
            this.btnStatistik.TabIndex = 1;
            this.btnStatistik.Text = "Statistik";
            this.btnStatistik.UseVisualStyleBackColor = true;
            this.btnStatistik.Click += new System.EventHandler(this.btnStatistik_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 389);
            this.Controls.Add(this.btnStatistik);
            this.Controls.Add(this.btnNewCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherEF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCSV;
        private System.Windows.Forms.Button btnStatistik;
    }
}

