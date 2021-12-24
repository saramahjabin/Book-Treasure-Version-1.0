
namespace BookTreasure
{
    partial class InformationForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.UsertoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EmployeetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.LoginInfoButton = new System.Windows.Forms.ToolStripButton();
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.UsertoolStripButton,
            this.EmployeetoolStripButton,
            this.SearchTextBox,
            this.SearchButton,
            this.LoginInfoButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BookTreasure.Properties.Resources.backIcon1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 51);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // UsertoolStripButton
            // 
            this.UsertoolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsertoolStripButton.Image = global::BookTreasure.Properties.Resources.user_icon;
            this.UsertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsertoolStripButton.Name = "UsertoolStripButton";
            this.UsertoolStripButton.Size = new System.Drawing.Size(66, 51);
            this.UsertoolStripButton.Text = "User";
            this.UsertoolStripButton.Click += new System.EventHandler(this.UsertoolStripButton_Click);
            // 
            // EmployeetoolStripButton
            // 
            this.EmployeetoolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmployeetoolStripButton.Image = global::BookTreasure.Properties.Resources.employee_icon;
            this.EmployeetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmployeetoolStripButton.Name = "EmployeetoolStripButton";
            this.EmployeetoolStripButton.Size = new System.Drawing.Size(103, 51);
            this.EmployeetoolStripButton.Text = "Employee";
            this.EmployeetoolStripButton.Click += new System.EventHandler(this.EmployeetoolStripButton_Click);
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
            // LoginInfoButton
            // 
            this.LoginInfoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginInfoButton.Image = global::BookTreasure.Properties.Resources.logininfoicon;
            this.LoginInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoginInfoButton.Name = "LoginInfoButton";
            this.LoginInfoButton.Size = new System.Drawing.Size(100, 51);
            this.LoginInfoButton.Text = "LoginInfo";
            this.LoginInfoButton.Click += new System.EventHandler(this.LoginInfoButton_Click);
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.AllowUserToOrderColumns = true;
            this.UserdataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.UserdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserdataGridView.GridColor = System.Drawing.Color.Navy;
            this.UserdataGridView.Location = new System.Drawing.Point(0, 56);
            this.UserdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.RowHeadersWidth = 62;
            this.UserdataGridView.RowTemplate.Height = 28;
            this.UserdataGridView.Size = new System.Drawing.Size(712, 650);
            this.UserdataGridView.TabIndex = 1;
            this.UserdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserdataGridView_CellDoubleClick);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.FlatAppearance.BorderSize = 0;
            this.Deletebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Deletebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(593, 710);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(84, 37);
            this.Deletebutton.TabIndex = 6;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.FlatAppearance.BorderSize = 0;
            this.Updatebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Updatebutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(312, 710);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(91, 37);
            this.Updatebutton.TabIndex = 7;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.FlatAppearance.BorderSize = 0;
            this.Addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(34, 710);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(73, 37);
            this.Addbutton.TabIndex = 8;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(-3, 705);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(715, 51);
            this.label4.TabIndex = 21;
            this.label4.Text = "gjhvgbhhj";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(712, 752);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.UserdataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationForm";
            this.Load += new System.EventHandler(this.InformationForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UsertoolStripButton;
        private System.Windows.Forms.ToolStripButton EmployeetoolStripButton;
        private System.Windows.Forms.ToolStripTextBox SearchTextBox;
        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton LoginInfoButton;
    }
}