namespace RIT_ClimbingApp
{
    partial class Form1
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
            this.Tabs = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.Maps = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.Links = new System.Windows.Forms.Button();
            this.Home_page = new System.Windows.Forms.Panel();
            this.Welcome_node = new System.Windows.Forms.Panel();
            this.Occupancy_node = new System.Windows.Forms.Panel();
            this.Hours_node = new System.Windows.Forms.Panel();
            this.Events_node = new System.Windows.Forms.Panel();
            this.Occupants = new System.Windows.Forms.Label();
            this.WelcomeImages = new System.Windows.Forms.PictureBox();
            this.Hours = new System.Windows.Forms.Label();
            this.Upcoming = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.Home_page.SuspendLayout();
            this.Welcome_node.SuspendLayout();
            this.Occupancy_node.SuspendLayout();
            this.Hours_node.SuspendLayout();
            this.Events_node.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomeImages)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Links);
            this.Tabs.Controls.Add(this.Profile);
            this.Tabs.Controls.Add(this.Maps);
            this.Tabs.Controls.Add(this.Home);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(181, 861);
            this.Tabs.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(42, 56);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(95, 100);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // Maps
            // 
            this.Maps.Location = new System.Drawing.Point(42, 181);
            this.Maps.Name = "Maps";
            this.Maps.Size = new System.Drawing.Size(95, 102);
            this.Maps.TabIndex = 1;
            this.Maps.Text = "Maps";
            this.Maps.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(42, 310);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(95, 100);
            this.Profile.TabIndex = 2;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // Links
            // 
            this.Links.Location = new System.Drawing.Point(42, 436);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(95, 97);
            this.Links.TabIndex = 3;
            this.Links.Text = "Links";
            this.Links.UseVisualStyleBackColor = true;
            // 
            // Home_page
            // 
            this.Home_page.Controls.Add(this.Events_node);
            this.Home_page.Controls.Add(this.Hours_node);
            this.Home_page.Controls.Add(this.Occupancy_node);
            this.Home_page.Controls.Add(this.Welcome_node);
            this.Home_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_page.Location = new System.Drawing.Point(181, 0);
            this.Home_page.Name = "Home_page";
            this.Home_page.Size = new System.Drawing.Size(1322, 861);
            this.Home_page.TabIndex = 1;
            // 
            // Welcome_node
            // 
            this.Welcome_node.Controls.Add(this.WelcomeImages);
            this.Welcome_node.Location = new System.Drawing.Point(58, 56);
            this.Welcome_node.Name = "Welcome_node";
            this.Welcome_node.Size = new System.Drawing.Size(849, 477);
            this.Welcome_node.TabIndex = 0;
            // 
            // Occupancy_node
            // 
            this.Occupancy_node.Controls.Add(this.Occupants);
            this.Occupancy_node.Location = new System.Drawing.Point(958, 56);
            this.Occupancy_node.Name = "Occupancy_node";
            this.Occupancy_node.Size = new System.Drawing.Size(323, 477);
            this.Occupancy_node.TabIndex = 1;
            // 
            // Hours_node
            // 
            this.Hours_node.Controls.Add(this.Hours);
            this.Hours_node.Location = new System.Drawing.Point(58, 566);
            this.Hours_node.Name = "Hours_node";
            this.Hours_node.Size = new System.Drawing.Size(460, 274);
            this.Hours_node.TabIndex = 2;
            // 
            // Events_node
            // 
            this.Events_node.Controls.Add(this.Upcoming);
            this.Events_node.Location = new System.Drawing.Point(566, 566);
            this.Events_node.Name = "Events_node";
            this.Events_node.Size = new System.Drawing.Size(715, 274);
            this.Events_node.TabIndex = 3;
            // 
            // Occupants
            // 
            this.Occupants.AutoSize = true;
            this.Occupants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Occupants.Location = new System.Drawing.Point(147, 40);
            this.Occupants.Name = "Occupants";
            this.Occupants.Size = new System.Drawing.Size(29, 20);
            this.Occupants.TabIndex = 0;
            this.Occupants.Text = "20";
            this.Occupants.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // WelcomeImages
            // 
            this.WelcomeImages.Location = new System.Drawing.Point(0, 0);
            this.WelcomeImages.Name = "WelcomeImages";
            this.WelcomeImages.Size = new System.Drawing.Size(849, 477);
            this.WelcomeImages.TabIndex = 0;
            this.WelcomeImages.TabStop = false;
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(35, 18);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(144, 20);
            this.Hours.TabIndex = 0;
            this.Hours.Text = "Hours of Operation";
            // 
            // Upcoming
            // 
            this.Upcoming.AutoSize = true;
            this.Upcoming.Location = new System.Drawing.Point(36, 18);
            this.Upcoming.Name = "Upcoming";
            this.Upcoming.Size = new System.Drawing.Size(134, 20);
            this.Upcoming.TabIndex = 1;
            this.Upcoming.Text = "Upcoming Events";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 861);
            this.Controls.Add(this.Home_page);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.Home_page.ResumeLayout(false);
            this.Welcome_node.ResumeLayout(false);
            this.Occupancy_node.ResumeLayout(false);
            this.Occupancy_node.PerformLayout();
            this.Hours_node.ResumeLayout(false);
            this.Hours_node.PerformLayout();
            this.Events_node.ResumeLayout(false);
            this.Events_node.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomeImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Tabs;
        private System.Windows.Forms.Button Links;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Maps;
        private System.Windows.Forms.Panel Home_page;
        private System.Windows.Forms.Panel Events_node;
        private System.Windows.Forms.Panel Hours_node;
        private System.Windows.Forms.Panel Occupancy_node;
        private System.Windows.Forms.Label Occupants;
        private System.Windows.Forms.Panel Welcome_node;
        private System.Windows.Forms.Label Upcoming;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.PictureBox WelcomeImages;
    }
}

