namespace DateTimePicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datPicker1 = new System.Windows.Forms.DateTimePicker();
            this.datPicker2 = new System.Windows.Forms.DateTimePicker();
            this.datPicker3 = new System.Windows.Forms.DateTimePicker();
            this.datPicker4 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPlusTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Eigenes Format:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "UpDown:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Uhrzeit:";
            // 
            // datPicker1
            // 
            this.datPicker1.Location = new System.Drawing.Point(377, 9);
            this.datPicker1.Name = "datPicker1";
            this.datPicker1.Size = new System.Drawing.Size(500, 47);
            this.datPicker1.TabIndex = 1;
            this.datPicker1.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // datPicker2
            // 
            this.datPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datPicker2.Location = new System.Drawing.Point(377, 67);
            this.datPicker2.Name = "datPicker2";
            this.datPicker2.Size = new System.Drawing.Size(287, 47);
            this.datPicker2.TabIndex = 1;
            this.datPicker2.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // datPicker3
            // 
            this.datPicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPicker3.Location = new System.Drawing.Point(377, 132);
            this.datPicker3.Name = "datPicker3";
            this.datPicker3.ShowUpDown = true;
            this.datPicker3.Size = new System.Drawing.Size(287, 47);
            this.datPicker3.TabIndex = 1;
            this.datPicker3.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // datPicker4
            // 
            this.datPicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datPicker4.Location = new System.Drawing.Point(377, 194);
            this.datPicker4.Name = "datPicker4";
            this.datPicker4.ShowUpDown = true;
            this.datPicker4.Size = new System.Drawing.Size(287, 47);
            this.datPicker4.TabIndex = 1;
            this.datPicker4.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(599, 384);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(278, 41);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "00.00.0000 00:00:00";
            // 
            // lblPlusTime
            // 
            this.lblPlusTime.AutoSize = true;
            this.lblPlusTime.Location = new System.Drawing.Point(599, 447);
            this.lblPlusTime.Name = "lblPlusTime";
            this.lblPlusTime.Size = new System.Drawing.Size(278, 41);
            this.lblPlusTime.TabIndex = 2;
            this.lblPlusTime.Text = "00.00.0000 00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 506);
            this.Controls.Add(this.lblPlusTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.datPicker4);
            this.Controls.Add(this.datPicker3);
            this.Controls.Add(this.datPicker2);
            this.Controls.Add(this.datPicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.DateTimePicker datPicker1;
        private System.Windows.Forms.DateTimePicker datPicker2;
        private System.Windows.Forms.DateTimePicker datPicker3;
        private System.Windows.Forms.DateTimePicker datPicker4;
        private Label lblDate;
        private Label lblPlusTime;
    }
}