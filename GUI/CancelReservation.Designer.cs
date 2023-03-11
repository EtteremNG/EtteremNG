namespace EtteremNG.GUI
{
    partial class CancelReservation
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
            this.guestName = new System.Windows.Forms.TextBox();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startDateTimeLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guestName
            // 
            this.guestName.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guestName.Location = new System.Drawing.Point(290, 47);
            this.guestName.Name = "guestName";
            this.guestName.Size = new System.Drawing.Size(277, 32);
            this.guestName.TabIndex = 2;
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.AutoSize = true;
            this.guestNameLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guestNameLabel.Location = new System.Drawing.Point(27, 50);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(146, 24);
            this.guestNameLabel.TabIndex = 5;
            this.guestNameLabel.Text = "Vendég neve:";
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "HH:mm";
            this.startTime.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(480, 124);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(87, 32);
            this.startTime.TabIndex = 11;
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startDate.Location = new System.Drawing.Point(290, 124);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(158, 32);
            this.startDate.TabIndex = 10;
            // 
            // startDateTimeLabel
            // 
            this.startDateTimeLabel.AutoSize = true;
            this.startDateTimeLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDateTimeLabel.Location = new System.Drawing.Point(27, 130);
            this.startDateTimeLabel.Name = "startDateTimeLabel";
            this.startDateTimeLabel.Size = new System.Drawing.Size(184, 24);
            this.startDateTimeLabel.TabIndex = 9;
            this.startDateTimeLabel.Text = "Foglalás kezdete:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(639, 473);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(161, 44);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Lemondás";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.ProcessCancellation);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel.Location = new System.Drawing.Point(33, 176);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 36);
            this.statusLabel.TabIndex = 13;
            // 
            // CancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.startDateTimeLabel);
            this.Controls.Add(this.guestNameLabel);
            this.Controls.Add(this.guestName);
            this.Name = "CancelReservation";
            this.Size = new System.Drawing.Size(822, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox guestName;
        private System.Windows.Forms.Label guestNameLabel;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label startDateTimeLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label statusLabel;
    }
}
