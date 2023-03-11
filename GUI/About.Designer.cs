namespace EtteremNG.GUI
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.softwareNameLabel = new System.Windows.Forms.Label();
            this.licenseInformation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // softwareNameLabel
            // 
            this.softwareNameLabel.AutoSize = true;
            this.softwareNameLabel.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareNameLabel.Location = new System.Drawing.Point(234, 0);
            this.softwareNameLabel.Name = "softwareNameLabel";
            this.softwareNameLabel.Size = new System.Drawing.Size(342, 72);
            this.softwareNameLabel.TabIndex = 0;
            this.softwareNameLabel.Text = "EtteremNG";
            // 
            // licenseInformation
            // 
            this.licenseInformation.BackColor = System.Drawing.Color.White;
            this.licenseInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.licenseInformation.Font = new System.Drawing.Font("Bell MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseInformation.Location = new System.Drawing.Point(10, 75);
            this.licenseInformation.Margin = new System.Windows.Forms.Padding(10);
            this.licenseInformation.Name = "licenseInformation";
            this.licenseInformation.ReadOnly = true;
            this.licenseInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.licenseInformation.ShortcutsEnabled = false;
            this.licenseInformation.Size = new System.Drawing.Size(802, 446);
            this.licenseInformation.TabIndex = 2;
            this.licenseInformation.Text = resources.GetString("licenseInformation.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.licenseInformation);
            this.Controls.Add(this.softwareNameLabel);
            this.Name = "About";
            this.Size = new System.Drawing.Size(822, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label softwareNameLabel;
        private System.Windows.Forms.RichTextBox licenseInformation;
    }
}
