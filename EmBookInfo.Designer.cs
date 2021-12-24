
namespace BookTreasure
{
    partial class EmBookInfo
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
            this.BookdataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.SearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Downloadbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookdataGridView
            // 
            this.BookdataGridView.AllowUserToOrderColumns = true;
            this.BookdataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.BookdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookdataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookdataGridView.GridColor = System.Drawing.Color.Navy;
            this.BookdataGridView.Location = new System.Drawing.Point(0, 56);
            this.BookdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookdataGridView.Name = "BookdataGridView";
            this.BookdataGridView.RowHeadersVisible = false;
            this.BookdataGridView.RowHeadersWidth = 62;
            this.BookdataGridView.RowTemplate.Height = 28;
            this.BookdataGridView.Size = new System.Drawing.Size(712, 650);
            this.BookdataGridView.TabIndex = 21;
            this.BookdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookdataGridView_CellDoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.SearchTextBox,
            this.SearchButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(712, 54);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
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
            // SearchTextBox
            // 
            this.SearchTextBox.AutoSize = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(267, 27);
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
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
            // Addbutton
            // 
            this.Addbutton.FlatAppearance.BorderSize = 0;
            this.Addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(34, 713);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(73, 37);
            this.Addbutton.TabIndex = 28;
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
            this.Downloadbutton.Location = new System.Drawing.Point(303, 713);
            this.Downloadbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Downloadbutton.Name = "Downloadbutton";
            this.Downloadbutton.Size = new System.Drawing.Size(100, 37);
            this.Downloadbutton.TabIndex = 27;
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
            this.Deletebutton.Location = new System.Drawing.Point(593, 713);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(84, 37);
            this.Deletebutton.TabIndex = 26;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(-3, 708);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(715, 51);
            this.label4.TabIndex = 29;
            this.label4.Text = "gjhvgbhhj";
            // 
            // EmBookInfo
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
            this.Name = "EmBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmBookInfo";
            this.Load += new System.EventHandler(this.EmBookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookdataGridView;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripTextBox SearchTextBox;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Downloadbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label label4;
    }
}