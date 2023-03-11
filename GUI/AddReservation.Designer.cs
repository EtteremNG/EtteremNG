namespace EtteremNG.GUI
{
    partial class AddReservation
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
            this.addReservationBtn = new System.Windows.Forms.Button();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.startDateTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.chairAmountLabel = new System.Windows.Forms.Label();
            this.reservationTypeLabel = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.reservationType = new System.Windows.Forms.ComboBox();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.guestName = new System.Windows.Forms.TextBox();
            this.chairAmount = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addReservationBtn
            // 
            this.addReservationBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.addReservationBtn.FlatAppearance.BorderSize = 0;
            this.addReservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addReservationBtn.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addReservationBtn.ForeColor = System.Drawing.Color.Black;
            this.addReservationBtn.Location = new System.Drawing.Point(639, 473);
            this.addReservationBtn.Name = "addReservationBtn";
            this.addReservationBtn.Size = new System.Drawing.Size(161, 44);
            this.addReservationBtn.TabIndex = 0;
            this.addReservationBtn.Text = "Rögzítés";
            this.addReservationBtn.UseVisualStyleBackColor = false;
            this.addReservationBtn.Click += new System.EventHandler(this.ProcessAdd);
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.AutoSize = true;
            this.guestNameLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guestNameLabel.Location = new System.Drawing.Point(27, 50);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(146, 24);
            this.guestNameLabel.TabIndex = 1;
            this.guestNameLabel.Text = "Vendég neve:";
            // 
            // startDateTimeLabel
            // 
            this.startDateTimeLabel.AutoSize = true;
            this.startDateTimeLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDateTimeLabel.Location = new System.Drawing.Point(27, 107);
            this.startDateTimeLabel.Name = "startDateTimeLabel";
            this.startDateTimeLabel.Size = new System.Drawing.Size(184, 24);
            this.startDateTimeLabel.TabIndex = 2;
            this.startDateTimeLabel.Text = "Foglalás kezdete:";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endTimeLabel.Location = new System.Drawing.Point(27, 157);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(151, 24);
            this.endTimeLabel.TabIndex = 3;
            this.endTimeLabel.Text = "Foglalás vége:";
            // 
            // chairAmountLabel
            // 
            this.chairAmountLabel.AutoSize = true;
            this.chairAmountLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chairAmountLabel.Location = new System.Drawing.Point(27, 203);
            this.chairAmountLabel.Name = "chairAmountLabel";
            this.chairAmountLabel.Size = new System.Drawing.Size(160, 24);
            this.chairAmountLabel.TabIndex = 4;
            this.chairAmountLabel.Text = "Székek száma:";
            // 
            // reservationTypeLabel
            // 
            this.reservationTypeLabel.AutoSize = true;
            this.reservationTypeLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservationTypeLabel.Location = new System.Drawing.Point(27, 255);
            this.reservationTypeLabel.Name = "reservationTypeLabel";
            this.reservationTypeLabel.Size = new System.Drawing.Size(171, 24);
            this.reservationTypeLabel.TabIndex = 5;
            this.reservationTypeLabel.Text = "Foglalás típusa:";
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startDate.Location = new System.Drawing.Point(290, 101);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(158, 32);
            this.startDate.TabIndex = 7;
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "HH:mm";
            this.startTime.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(480, 101);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(87, 32);
            this.startTime.TabIndex = 8;
            // 
            // reservationType
            // 
            this.reservationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reservationType.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservationType.FormattingEnabled = true;
            this.reservationType.Items.AddRange(new object[] {
            "Beltéri",
            "Kültéri"});
            this.reservationType.Location = new System.Drawing.Point(290, 252);
            this.reservationType.Name = "reservationType";
            this.reservationType.Size = new System.Drawing.Size(277, 32);
            this.reservationType.TabIndex = 12;
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "HH:mm";
            this.endTime.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime.Location = new System.Drawing.Point(290, 151);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(87, 32);
            this.endTime.TabIndex = 14;
            // 
            // guestName
            // 
            this.guestName.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guestName.Location = new System.Drawing.Point(290, 47);
            this.guestName.Name = "guestName";
            this.guestName.Size = new System.Drawing.Size(277, 32);
            this.guestName.TabIndex = 17;
            // 
            // chairAmount
            // 
            this.chairAmount.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chairAmount.Location = new System.Drawing.Point(290, 200);
            this.chairAmount.Name = "chairAmount";
            this.chairAmount.Size = new System.Drawing.Size(277, 32);
            this.chairAmount.TabIndex = 19;
            this.chairAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnsureChairInputIsNumber);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel.Location = new System.Drawing.Point(3, 287);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(816, 183);
            this.statusLabel.TabIndex = 20;
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.chairAmount);
            this.Controls.Add(this.guestName);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.reservationType);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.reservationTypeLabel);
            this.Controls.Add(this.chairAmountLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startDateTimeLabel);
            this.Controls.Add(this.guestNameLabel);
            this.Controls.Add(this.addReservationBtn);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AddReservation";
            this.Size = new System.Drawing.Size(822, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addReservationBtn;
        private System.Windows.Forms.Label guestNameLabel;
        private System.Windows.Forms.Label startDateTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label chairAmountLabel;
        private System.Windows.Forms.Label reservationTypeLabel;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
        protected internal System.Windows.Forms.ComboBox reservationType;
        public System.Windows.Forms.TextBox chairAmount;
        public System.Windows.Forms.TextBox guestName;
        private System.Windows.Forms.Label statusLabel;
    }
}
