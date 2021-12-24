
namespace BookTreasure
{
    partial class BookInfoForm
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.SearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.BookdataGridView = new System.Windows.Forms.DataGridView();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Downloadbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.BookInfoButton = new System.Windows.Forms.ToolStripButton();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.BookRqstDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ApproveRqstMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NonApprovedRqstMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.BookInfoButton,
            this.SearchTextBox,
            this.SearchButton,
            this.BookRqstDropDownButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(712, 54);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AutoSize = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(267, 27);
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // BookdataGridView
            // 
            this.BookdataGridView.AllowUserToOrderColumns = true;
            this.BookdataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.BookdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookdataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookdataGridView.GridColor = System.Drawing.Color.Navy;
            this.BookdataGridView.Location = new System.Drawing.Point(0, 51);
            this.BookdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookdataGridView.Name = "BookdataGridView";
            this.BookdataGridView.RowHeadersWidth = 62;
            this.BookdataGridView.RowTemplate.Height = 28;
            this.BookdataGridView.Size = new System.Drawing.Size(712, 650);
            this.BookdataGridView.TabIndex = 19;
            this.BookdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookdataGridView_CellDoubleClick);
            // 
            // Addbutton
            // 
            this.Addbutton.FlatAppearance.BorderSize = 0;
            this.Addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(34, 708);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(73, 37);
            this.Addbutton.TabIndex = 24;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Downloadbutton
            // 
            this.Downloadbutton.FlatAppearance.BorderSize = 0;
            this.Downloadbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Downloadbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Downloadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Downloadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Downloadbutton.Location = new System.Drawing.Point(291, 708);
            this.Downloadbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Downloadbutton.Name = "Downloadbutton";
            this.Downloadbutton.Size = new System.Drawing.Size(112, 37);
            this.Downloadbutton.TabIndex = 23;
            this.Downloadbutton.Text = "Download";
            this.Downloadbutton.UseVisualStyleBackColor = true;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.FlatAppearance.BorderSize = 0;
            this.Deletebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Deletebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(593, 708);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(84, 37);
            this.Deletebutton.TabIndex = 22;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(-3, 703);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(715, 51);
            this.label4.TabIndex = 25;
            this.label4.Text = "gjhvgbhhj";
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = global::BookTreasure.Properties.Resources.backIcon1;
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(29, 51);
            this.BackButton.Text = "BackButton";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BookInfoButton
            // 
            this.BookInfoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookInfoButton.Image = global::BookTreasure.Properties.Resources.book;
            this.BookInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookInfoButton.Name = "BookInfoButton";
            this.BookInfoButton.Size = new System.Drawing.Size(77, 51);
            this.BookInfoButton.Text = "Books";
            this.BookInfoButton.Click += new System.EventHandler(this.BookInfoButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Image = global::BookTreasure.Properties.Resources.search_icon;
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(81, 51);
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BookRqstDropDownButton
            // 
            this.BookRqstDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApproveRqstMenuItem,
            this.NonApprovedRqstMenuItem});
            this.BookRqstDropDownButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookRqstDropDownButton.Image = global::BookTreasure.Properties.Resources.bkup1;
            this.BookRqstDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookRqstDropDownButton.Name = "BookRqstDropDownButton";
            this.BookRqstDropDownButton.Size = new System.Drawing.Size(144, 51);
            this.BookRqstDropDownButton.Text = "Book Requests";
            this.BookRqstDropDownButton.Click += new System.EventHandler(this.BookRqstDropDownButton_Click);
            // 
            // ApproveRqstMenuItem
            // 
            this.ApproveRqstMenuItem.BackColor = System.Drawing.Color.Black;
            this.ApproveRqstMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveRqstMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApproveRqstMenuItem.Image = global::BookTreasure.Properties.Resources.tik1;
            this.ApproveRqstMenuItem.Name = "ApproveRqstMenuItem";
            this.ApproveRqstMenuItem.Size = new System.Drawing.Size(199, 30);
            this.ApproveRqstMenuItem.Text = "Approved";
            this.ApproveRqstMenuItem.Click += new System.EventHandler(this.ApproveRqstMenuItem_Click);
            // 
            // NonApprovedRqstMenuItem
            // 
            this.NonApprovedRqstMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.NonApprovedRqstMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NonApprovedRqstMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NonApprovedRqstMenuItem.Image = global::BookTreasure.Properties.Resources.cross1;
            this.NonApprovedRqstMenuItem.Name = "NonApprovedRqstMenuItem";
            this.NonApprovedRqstMenuItem.Size = new System.Drawing.Size(199, 30);
            this.NonApprovedRqstMenuItem.Text = "Non Approved";
            this.NonApprovedRqstMenuItem.Click += new System.EventHandler(this.NonApprovedRqstMenuItem_Click);
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(712, 752);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Downloadbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookdataGridView);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BookInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoForm";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton BookInfoButton;
        private System.Windows.Forms.ToolStripTextBox SearchTextBox;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripDropDownButton BookRqstDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem ApproveRqstMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NonApprovedRqstMenuItem;
        private System.Windows.Forms.DataGridView BookdataGridView;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Downloadbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label label4;
    }
}