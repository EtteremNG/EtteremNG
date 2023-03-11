namespace EtteremNG.GUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.currentTime = new System.Windows.Forms.Label();
            this.AddReservationBtn = new System.Windows.Forms.Button();
            this.SelectedTabMarker = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.StatisticsBtn = new System.Windows.Forms.Button();
            this.TableMapBtn = new System.Windows.Forms.Button();
            this.CancelReservationBtn = new System.Windows.Forms.Button();
            this.buttonAnimationHandler = new System.Windows.Forms.Timer(this.components);
            this.timeCounter = new System.Windows.Forms.Timer(this.components);
            this.AboutPage = new EtteremNG.GUI.About();
            this.TableMapPage = new EtteremNG.GUI.TableMap();
            this.StatisticsPage = new EtteremNG.GUI.Statistics();
            this.CancelReservationPage = new EtteremNG.GUI.CancelReservation();
            this.AddReservationPage = new EtteremNG.GUI.AddReservation();
            this.Background = new System.Windows.Forms.Panel();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.DimGray;
            this.Sidebar.Controls.Add(this.currentTime);
            this.Sidebar.Controls.Add(this.AddReservationBtn);
            this.Sidebar.Controls.Add(this.SelectedTabMarker);
            this.Sidebar.Controls.Add(this.ExitBtn);
            this.Sidebar.Controls.Add(this.AboutBtn);
            this.Sidebar.Controls.Add(this.StatisticsBtn);
            this.Sidebar.Controls.Add(this.TableMapBtn);
            this.Sidebar.Controls.Add(this.CancelReservationBtn);
            this.Sidebar.Location = new System.Drawing.Point(0, -2);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(205, 546);
            this.Sidebar.TabIndex = 0;
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentTime.ForeColor = System.Drawing.Color.Black;
            this.currentTime.Location = new System.Drawing.Point(32, 502);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(134, 32);
            this.currentTime.TabIndex = 8;
            this.currentTime.Text = "00:00:00";
            this.currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddReservationBtn
            // 
            this.AddReservationBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddReservationBtn.FlatAppearance.BorderSize = 0;
            this.AddReservationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddReservationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddReservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReservationBtn.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddReservationBtn.ForeColor = System.Drawing.Color.Black;
            this.AddReservationBtn.Location = new System.Drawing.Point(13, 40);
            this.AddReservationBtn.Name = "AddReservationBtn";
            this.AddReservationBtn.Size = new System.Drawing.Size(192, 38);
            this.AddReservationBtn.TabIndex = 1;
            this.AddReservationBtn.Text = "Foglalás felvétel";
            this.AddReservationBtn.UseVisualStyleBackColor = false;
            this.AddReservationBtn.Click += new System.EventHandler(this.GenericButtonClickHandler);
            // 
            // SelectedTabMarker
            // 
            this.SelectedTabMarker.BackColor = System.Drawing.Color.LightGray;
            this.SelectedTabMarker.Location = new System.Drawing.Point(-2, 35);
            this.SelectedTabMarker.Name = "SelectedTabMarker";
            this.SelectedTabMarker.Size = new System.Drawing.Size(10, 58);
            this.SelectedTabMarker.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DimGray;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(15, 440);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(202, 38);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Kilépés";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.OnExitButtonClick);
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBtn.ForeColor = System.Drawing.Color.Black;
            this.AboutBtn.Location = new System.Drawing.Point(13, 360);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(202, 38);
            this.AboutBtn.TabIndex = 5;
            this.AboutBtn.Text = "Névjegy";
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.GenericButtonClickHandler);
            // 
            // StatisticsBtn
            // 
            this.StatisticsBtn.BackColor = System.Drawing.Color.Transparent;
            this.StatisticsBtn.FlatAppearance.BorderSize = 0;
            this.StatisticsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StatisticsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsBtn.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsBtn.ForeColor = System.Drawing.Color.Black;
            this.StatisticsBtn.Location = new System.Drawing.Point(12, 200);
            this.StatisticsBtn.Name = "StatisticsBtn";
            this.StatisticsBtn.Size = new System.Drawing.Size(202, 38);
            this.StatisticsBtn.TabIndex = 3;
            this.StatisticsBtn.Text = "Statisztika";
            this.StatisticsBtn.UseVisualStyleBackColor = false;
            this.StatisticsBtn.Click += new System.EventHandler(this.GenericButtonClickHandler);
            // 
            // TableMapBtn
            // 
            this.TableMapBtn.BackColor = System.Drawing.Color.Transparent;
            this.TableMapBtn.FlatAppearance.BorderSize = 0;
            this.TableMapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TableMapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TableMapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableMapBtn.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableMapBtn.ForeColor = System.Drawing.Color.Black;
            this.TableMapBtn.Location = new System.Drawing.Point(13, 280);
            this.TableMapBtn.Name = "TableMapBtn";
            this.TableMapBtn.Size = new System.Drawing.Size(202, 38);
            this.TableMapBtn.TabIndex = 4;
            this.TableMapBtn.Text = "Asztal térkép";
            this.TableMapBtn.UseVisualStyleBackColor = false;
            this.TableMapBtn.Click += new System.EventHandler(this.GenericButtonClickHandler);
            // 
            // CancelReservationBtn
            // 
            this.CancelReservationBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelReservationBtn.FlatAppearance.BorderSize = 0;
            this.CancelReservationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CancelReservationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CancelReservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelReservationBtn.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelReservationBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelReservationBtn.Location = new System.Drawing.Point(3, 120);
            this.CancelReservationBtn.Name = "CancelReservationBtn";
            this.CancelReservationBtn.Size = new System.Drawing.Size(202, 38);
            this.CancelReservationBtn.TabIndex = 2;
            this.CancelReservationBtn.Text = "Foglalás lemondás";
            this.CancelReservationBtn.UseVisualStyleBackColor = false;
            this.CancelReservationBtn.Click += new System.EventHandler(this.GenericButtonClickHandler);
            // 
            // buttonAnimationHandler
            // 
            this.buttonAnimationHandler.Interval = 20;
            this.buttonAnimationHandler.Tick += new System.EventHandler(this.MoveSelectedItem);
            // 
            // timeCounter
            // 
            this.timeCounter.Enabled = true;
            this.timeCounter.Interval = 1;
            this.timeCounter.Tick += new System.EventHandler(this.UpdateTime);
            // 
            // AboutPage
            // 
            this.AboutPage.Location = new System.Drawing.Point(203, 13);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.Size = new System.Drawing.Size(826, 540);
            this.AboutPage.TabIndex = 12;
            this.AboutPage.Load += new System.EventHandler(this.OnLoad);
            // 
            // TableMapPage
            // 
            this.TableMapPage.Location = new System.Drawing.Point(203, 13);
            this.TableMapPage.Name = "TableMapPage";
            this.TableMapPage.Size = new System.Drawing.Size(826, 540);
            this.TableMapPage.TabIndex = 11;
            // 
            // StatisticsPage
            // 
            this.StatisticsPage.Location = new System.Drawing.Point(203, 13);
            this.StatisticsPage.Name = "StatisticsPage";
            this.StatisticsPage.Size = new System.Drawing.Size(826, 541);
            this.StatisticsPage.TabIndex = 10;
            // 
            // CancelReservationPage
            // 
            this.CancelReservationPage.Location = new System.Drawing.Point(203, 13);
            this.CancelReservationPage.Name = "CancelReservationPage";
            this.CancelReservationPage.Size = new System.Drawing.Size(826, 541);
            this.CancelReservationPage.TabIndex = 9;
            // 
            // AddReservationPage
            // 
            this.AddReservationPage.BackColor = System.Drawing.SystemColors.Control;
            this.AddReservationPage.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AddReservationPage.Location = new System.Drawing.Point(203, 13);
            this.AddReservationPage.Name = "AddReservationPage";
            this.AddReservationPage.Size = new System.Drawing.Size(826, 541);
            this.AddReservationPage.TabIndex = 8;
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.DimGray;
            this.Background.Location = new System.Drawing.Point(0, -2);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1029, 18);
            this.Background.TabIndex = 6;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackgroundMoveEnd);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackgroundMove);
            this.Background.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackgroundMoveStart);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1028, 541);
            this.Controls.Add(this.AboutPage);
            this.Controls.Add(this.TableMapPage);
            this.Controls.Add(this.StatisticsPage);
            this.Controls.Add(this.CancelReservationPage);
            this.Controls.Add(this.AddReservationPage);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtteremNG";
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button AddReservationBtn;
        private System.Windows.Forms.Button StatisticsBtn;
        private System.Windows.Forms.Button CancelReservationBtn;
        private System.Windows.Forms.Button TableMapBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button ExitBtn;
        private AddReservation AddReservationPage;
        private System.Windows.Forms.Panel SelectedTabMarker;
        private System.Windows.Forms.Timer buttonAnimationHandler;
        private CancelReservation CancelReservationPage;
        private Statistics StatisticsPage;
        private TableMap TableMapPage;
        private About AboutPage;
        private System.Windows.Forms.Timer timeCounter;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Panel Background;
    }
}

