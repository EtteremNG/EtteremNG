namespace EtteremNG.GUI
{
    partial class TableMap
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
            this.outdoorReservationsContainer = new System.Windows.Forms.GroupBox();
            this.outdoorReservations = new System.Windows.Forms.DataGridView();
            this.outdoorReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outdoorReservationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outdoorReservationMerged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indoorReservationsContainer = new System.Windows.Forms.GroupBox();
            this.indoorReservations = new System.Windows.Forms.DataGridView();
            this.indoorReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indoorReservationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indoorReservationMerged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outdoorReservationsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorReservations)).BeginInit();
            this.indoorReservationsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indoorReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // outdoorReservationsContainer
            // 
            this.outdoorReservationsContainer.Controls.Add(this.outdoorReservations);
            this.outdoorReservationsContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.outdoorReservationsContainer.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outdoorReservationsContainer.Location = new System.Drawing.Point(422, 0);
            this.outdoorReservationsContainer.Name = "outdoorReservationsContainer";
            this.outdoorReservationsContainer.Size = new System.Drawing.Size(400, 531);
            this.outdoorReservationsContainer.TabIndex = 5;
            this.outdoorReservationsContainer.TabStop = false;
            this.outdoorReservationsContainer.Text = "Kinti";
            // 
            // outdoorReservations
            // 
            this.outdoorReservations.AllowUserToAddRows = false;
            this.outdoorReservations.AllowUserToDeleteRows = false;
            this.outdoorReservations.AllowUserToResizeColumns = false;
            this.outdoorReservations.AllowUserToResizeRows = false;
            this.outdoorReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outdoorReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outdoorReservationID,
            this.outdoorReservationStatus,
            this.outdoorReservationMerged});
            this.outdoorReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outdoorReservations.Location = new System.Drawing.Point(3, 28);
            this.outdoorReservations.Name = "outdoorReservations";
            this.outdoorReservations.ReadOnly = true;
            this.outdoorReservations.RowHeadersWidth = 51;
            this.outdoorReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.outdoorReservations.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outdoorReservations.Size = new System.Drawing.Size(394, 500);
            this.outdoorReservations.TabIndex = 1;
            // 
            // outdoorReservationID
            // 
            this.outdoorReservationID.HeaderText = "Azonosító";
            this.outdoorReservationID.MinimumWidth = 6;
            this.outdoorReservationID.Name = "outdoorReservationID";
            this.outdoorReservationID.ReadOnly = true;
            this.outdoorReservationID.Width = 115;
            // 
            // outdoorReservationStatus
            // 
            this.outdoorReservationStatus.HeaderText = "Állapot";
            this.outdoorReservationStatus.MinimumWidth = 6;
            this.outdoorReservationStatus.Name = "outdoorReservationStatus";
            this.outdoorReservationStatus.ReadOnly = true;
            this.outdoorReservationStatus.Width = 90;
            // 
            // outdoorReservationMerged
            // 
            this.outdoorReservationMerged.HeaderText = "Összetolva";
            this.outdoorReservationMerged.MinimumWidth = 6;
            this.outdoorReservationMerged.Name = "outdoorReservationMerged";
            this.outdoorReservationMerged.ReadOnly = true;
            this.outdoorReservationMerged.Width = 135;
            // 
            // indoorReservationsContainer
            // 
            this.indoorReservationsContainer.Controls.Add(this.indoorReservations);
            this.indoorReservationsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.indoorReservationsContainer.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.indoorReservationsContainer.Location = new System.Drawing.Point(0, 0);
            this.indoorReservationsContainer.Name = "indoorReservationsContainer";
            this.indoorReservationsContainer.Size = new System.Drawing.Size(394, 531);
            this.indoorReservationsContainer.TabIndex = 4;
            this.indoorReservationsContainer.TabStop = false;
            this.indoorReservationsContainer.Text = "Benti";
            // 
            // indoorReservations
            // 
            this.indoorReservations.AllowUserToAddRows = false;
            this.indoorReservations.AllowUserToDeleteRows = false;
            this.indoorReservations.AllowUserToResizeColumns = false;
            this.indoorReservations.AllowUserToResizeRows = false;
            this.indoorReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indoorReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indoorReservationID,
            this.indoorReservationStatus,
            this.indoorReservationMerged});
            this.indoorReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indoorReservations.Location = new System.Drawing.Point(3, 28);
            this.indoorReservations.Name = "indoorReservations";
            this.indoorReservations.ReadOnly = true;
            this.indoorReservations.RowHeadersWidth = 51;
            this.indoorReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.indoorReservations.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.indoorReservations.Size = new System.Drawing.Size(388, 500);
            this.indoorReservations.TabIndex = 0;
            // 
            // indoorReservationID
            // 
            this.indoorReservationID.HeaderText = "Azonosító";
            this.indoorReservationID.MinimumWidth = 6;
            this.indoorReservationID.Name = "indoorReservationID";
            this.indoorReservationID.ReadOnly = true;
            this.indoorReservationID.Width = 115;
            // 
            // indoorReservationStatus
            // 
            this.indoorReservationStatus.HeaderText = "Állapot";
            this.indoorReservationStatus.MinimumWidth = 6;
            this.indoorReservationStatus.Name = "indoorReservationStatus";
            this.indoorReservationStatus.ReadOnly = true;
            this.indoorReservationStatus.Width = 90;
            // 
            // indoorReservationMerged
            // 
            this.indoorReservationMerged.HeaderText = "Összetolva";
            this.indoorReservationMerged.MinimumWidth = 6;
            this.indoorReservationMerged.Name = "indoorReservationMerged";
            this.indoorReservationMerged.ReadOnly = true;
            this.indoorReservationMerged.Width = 135;
            // 
            // TableMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outdoorReservationsContainer);
            this.Controls.Add(this.indoorReservationsContainer);
            this.Name = "TableMap";
            this.Size = new System.Drawing.Size(822, 531);
            this.outdoorReservationsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outdoorReservations)).EndInit();
            this.indoorReservationsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indoorReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox outdoorReservationsContainer;
        private System.Windows.Forms.DataGridView outdoorReservations;
        private System.Windows.Forms.GroupBox indoorReservationsContainer;
        private System.Windows.Forms.DataGridView indoorReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdoorReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdoorReservationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdoorReservationMerged;
        private System.Windows.Forms.DataGridViewTextBoxColumn indoorReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn indoorReservationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn indoorReservationMerged;
    }
}
