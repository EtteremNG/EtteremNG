namespace EtteremNG.GUI
{
    partial class Statistics
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.StatisticsView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.calculateBtn.FlatAppearance.BorderSize = 0;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateBtn.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculateBtn.ForeColor = System.Drawing.Color.Black;
            this.calculateBtn.Location = new System.Drawing.Point(658, 80);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(161, 44);
            this.calculateBtn.TabIndex = 29;
            this.calculateBtn.Text = "Számolás";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.CalculateStatistics);
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(297, 74);
            this.endDate.Margin = new System.Windows.Forms.Padding(2);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(167, 32);
            this.endDate.TabIndex = 28;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endDateLabel.Location = new System.Drawing.Point(34, 80);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(176, 24);
            this.endDateLabel.TabIndex = 27;
            this.endDateLabel.Text = "Statisztika vége:";
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(297, 25);
            this.startDate.Margin = new System.Windows.Forms.Padding(2);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(167, 32);
            this.startDate.TabIndex = 26;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDateLabel.Location = new System.Drawing.Point(34, 31);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(209, 24);
            this.startDateLabel.TabIndex = 25;
            this.startDateLabel.Text = "Statisztika kezdete:";
            // 
            // StatisticsView
            // 
            this.StatisticsView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatisticsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatisticsView.Location = new System.Drawing.Point(0, 131);
            this.StatisticsView.Name = "StatisticsView";
            this.StatisticsView.Size = new System.Drawing.Size(822, 400);
            this.StatisticsView.TabIndex = 30;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatisticsView);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.startDateLabel);
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size(822, 531);
            this.Leave += new System.EventHandler(this.OnLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TreeView StatisticsView;
        public System.Windows.Forms.DateTimePicker endDate;
    }
}
