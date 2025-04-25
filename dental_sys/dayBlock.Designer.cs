namespace dental_sys
{
    partial class dayBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(75, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(19, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "00";
            // 
            // dayBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDay);
            this.Name = "dayBlock";
            this.Size = new System.Drawing.Size(110, 70);
            this.Click += new System.EventHandler(this.dayBlock_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

            // Today lbl
            this.lblToday = new System.Windows.Forms.Label();
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblToday.ForeColor = System.Drawing.Color.Red;
            this.lblToday.Location = new System.Drawing.Point(5, 5); // Đặt vị trí phù hợp
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(40, 13);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "Today";
            this.lblToday.Visible = false; // Mặc định ẩn
            this.Controls.Add(this.lblToday);
        }

        #endregion
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblDay;
    }
}
