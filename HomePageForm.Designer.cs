
namespace BookTreasure
{
    partial class HomePageForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BookdataGridView = new System.Windows.Forms.DataGridView();
            this.Downloadbutton = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Searchbutton = new System.Windows.Forms.ToolStripButton();
            this.DonateButton = new System.Windows.Forms.ToolStripButton();
            this.Profilebutton = new System.Windows.Forms.ToolStripButton();
            this.AboutUsbutton = new System.Windows.Forms.ToolStripButton();
            this.SettingsDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.passwordChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.SearchTextBox,
            this.toolStripButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 42);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(450, 42);
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BookTreasure.Properties.Resources.search_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 39);
            this.toolStripLabel1.Text = "Search";
            // 
            // BookdataGridView
            // 
            this.BookdataGridView.AllowUserToAddRows = false;
            this.BookdataGridView.AllowUserToOrderColumns = true;
            this.BookdataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.BookdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookdataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.BookdataGridView.Location = new System.Drawing.Point(0, 45);
            this.BookdataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.BookdataGridView.Name = "BookdataGridView";
            this.BookdataGridView.RowHeadersWidth = 51;
            this.BookdataGridView.RowTemplate.Height = 24;
            this.BookdataGridView.Size = new System.Drawing.Size(708, 591);
            this.BookdataGridView.TabIndex = 7;
            this.BookdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookdataGridView_CellDoubleClick);
            // 
            // Downloadbutton
            // 
            this.Downloadbutton.BackColor = System.Drawing.SystemColors.ControlText;
            this.Downloadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Downloadbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Downloadbutton.Location = new System.Drawing.Point(595, 639);
            this.Downloadbutton.Name = "Downloadbutton";
            this.Downloadbutton.Size = new System.Drawing.Size(117, 40);
            this.Downloadbutton.TabIndex = 8;
            this.Downloadbutton.Text = "Download";
            this.Downloadbutton.UseVisualStyleBackColor = false;
            this.Downloadbutton.Click += new System.EventHandler(this.Downloadbutton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Searchbutton,
            this.DonateButton,
            this.Profilebutton,
            this.AboutUsbutton,
            this.SettingsDropDownButton});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 682);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(712, 70);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Searchbutton
            // 
            this.Searchbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Searchbutton.Image = global::BookTreasure.Properties.Resources.Booksicon;
            this.Searchbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(157, 67);
            this.Searchbutton.Text = "Search Books         ";
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // DonateButton
            // 
            this.DonateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DonateButton.Image = global::BookTreasure.Properties.Resources.BookDIcon;
            this.DonateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(158, 67);
            this.DonateButton.Text = "Donate Books        ";
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click_1);
            // 
            // Profilebutton
            // 
            this.Profilebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Profilebutton.Image = global::BookTreasure.Properties.Resources.Profile_icon;
            this.Profilebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Profilebutton.Name = "Profilebutton";
            this.Profilebutton.Size = new System.Drawing.Size(96, 67);
            this.Profilebutton.Text = "Profile     ";
            this.Profilebutton.Click += new System.EventHandler(this.Profilebutton_Click);
            // 
            // AboutUsbutton
            // 
            this.AboutUsbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutUsbutton.Image = global::BookTreasure.Properties.Resources.about_us_icon;
            this.AboutUsbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutUsbutton.Name = "AboutUsbutton";
            this.AboutUsbutton.Size = new System.Drawing.Size(122, 67);
            this.AboutUsbutton.Text = "About Us       ";
            this.AboutUsbutton.Click += new System.EventHandler(this.AboutUsbutton_Click);
            // 
            // SettingsDropDownButton
            // 
            this.SettingsDropDownButton.AutoSize = false;
            this.SettingsDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordChangeToolStripMenuItem,
            this.ogOutToolStripMenuItem,
            this.toolStripSeparator1});
            this.SettingsDropDownButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingsDropDownButton.Image = global::BookTreasure.Properties.Resources.settings_icon;
            this.SettingsDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsDropDownButton.Name = "SettingsDropDownButton";
            this.SettingsDropDownButton.Size = new System.Drawing.Size(96, 67);
            this.SettingsDropDownButton.Text = "Settings";
            // 
            // passwordChangeToolStripMenuItem
            // 
            this.passwordChangeToolStripMenuItem.AutoSize = false;
            this.passwordChangeToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.passwordChangeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordChangeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordChangeToolStripMenuItem.Image = global::BookTreasure.Properties.Resources.Passwordchange_icon;
            this.passwordChangeToolStripMenuItem.Name = "passwordChangeToolStripMenuItem";
            this.passwordChangeToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.passwordChangeToolStripMenuItem.Text = "Password Change";
            this.passwordChangeToolStripMenuItem.Click += new System.EventHandler(this.passwordChangeToolStripMenuItem_Click);
            // 
            // ogOutToolStripMenuItem
            // 
            this.ogOutToolStripMenuItem.AutoSize = false;
            this.ogOutToolStripMenuItem.AutoToolTip = true;
            this.ogOutToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite;
            this.ogOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogOutToolStripMenuItem.Image = global::BookTreasure.Properties.Resources.logout_icon;
            this.ogOutToolStripMenuItem.Name = "ogOutToolStripMenuItem";
            this.ogOutToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.ogOutToolStripMenuItem.Text = "Log Out";
            this.ogOutToolStripMenuItem.Click += new System.EventHandler(this.ogOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 64);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlText;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(14, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Get Knowledge, Spread Knowledge.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlText;
            this.label9.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 43);
            this.label9.TabIndex = 18;
            this.label9.Text = "Book Treasure";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 93);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(382, 515);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(302, 515);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookTreasure.Properties.Resources.DP1;
            this.pictureBox1.Location = new System.Drawing.Point(216, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookTreasure.Properties.Resources.DP2;
            this.pictureBox2.Location = new System.Drawing.Point(216, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = global::BookTreasure.Properties.Resources.backIcon1;
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(29, 39);
            this.BackButton.Text = "toolStripButton2";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(712, 752);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.Downloadbutton);
            this.Controls.Add(this.BookdataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox SearchTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView BookdataGridView;
        private System.Windows.Forms.Button Downloadbutton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Searchbutton;
        private System.Windows.Forms.ToolStripButton DonateButton;
        private System.Windows.Forms.ToolStripButton AboutUsbutton;
        private System.Windows.Forms.ToolStripButton Profilebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton SettingsDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem passwordChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripButton BackButton;
    }
}