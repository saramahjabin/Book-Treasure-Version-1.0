
namespace BookTreasure
{
    partial class EmBookUpRqstDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmBookUpRqstDetailsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ViewDetailsbutton = new System.Windows.Forms.Button();
            this.Hidebutton = new System.Windows.Forms.Button();
            this.Declinebutton = new System.Windows.Forms.Button();
            this.Approvebutton = new System.Windows.Forms.Button();
            this.BookRqstGridView = new System.Windows.Forms.DataGridView();
            this.Book_rqst_label = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.Viewbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Textlabel = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookRqstGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Backbutton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 45);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ViewDetailsbutton
            // 
            this.ViewDetailsbutton.FlatAppearance.BorderSize = 0;
            this.ViewDetailsbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ViewDetailsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewDetailsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDetailsbutton.Location = new System.Drawing.Point(584, 119);
            this.ViewDetailsbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewDetailsbutton.Name = "ViewDetailsbutton";
            this.ViewDetailsbutton.Size = new System.Drawing.Size(106, 27);
            this.ViewDetailsbutton.TabIndex = 17;
            this.ViewDetailsbutton.Text = "ViewDetails";
            this.ViewDetailsbutton.UseVisualStyleBackColor = true;
            this.ViewDetailsbutton.Click += new System.EventHandler(this.ViewDetailsbutton_Click);
            // 
            // Hidebutton
            // 
            this.Hidebutton.FlatAppearance.BorderSize = 0;
            this.Hidebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Hidebutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hidebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hidebutton.Location = new System.Drawing.Point(584, 119);
            this.Hidebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hidebutton.Name = "Hidebutton";
            this.Hidebutton.Size = new System.Drawing.Size(106, 27);
            this.Hidebutton.TabIndex = 19;
            this.Hidebutton.Text = "Hide";
            this.Hidebutton.UseVisualStyleBackColor = true;
            this.Hidebutton.Click += new System.EventHandler(this.Hidebutton_Click);
            // 
            // Declinebutton
            // 
            this.Declinebutton.Location = new System.Drawing.Point(584, 651);
            this.Declinebutton.Name = "Declinebutton";
            this.Declinebutton.Size = new System.Drawing.Size(75, 29);
            this.Declinebutton.TabIndex = 16;
            this.Declinebutton.Text = "Decline";
            this.Declinebutton.UseVisualStyleBackColor = true;
            this.Declinebutton.Click += new System.EventHandler(this.Declinebutton_Click);
            // 
            // Approvebutton
            // 
            this.Approvebutton.Location = new System.Drawing.Point(470, 651);
            this.Approvebutton.Name = "Approvebutton";
            this.Approvebutton.Size = new System.Drawing.Size(75, 29);
            this.Approvebutton.TabIndex = 15;
            this.Approvebutton.Text = "Approve";
            this.Approvebutton.UseVisualStyleBackColor = true;
            this.Approvebutton.Click += new System.EventHandler(this.Approvebutton_Click);
            // 
            // BookRqstGridView
            // 
            this.BookRqstGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.BookRqstGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookRqstGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.BookRqstGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookRqstGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BookRqstGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookRqstGridView.EnableHeadersVisualStyles = false;
            this.BookRqstGridView.GridColor = System.Drawing.SystemColors.ControlText;
            this.BookRqstGridView.Location = new System.Drawing.Point(0, 173);
            this.BookRqstGridView.Name = "BookRqstGridView";
            this.BookRqstGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.BookRqstGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.BookRqstGridView.RowTemplate.Height = 24;
            this.BookRqstGridView.Size = new System.Drawing.Size(712, 435);
            this.BookRqstGridView.TabIndex = 14;
            this.BookRqstGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookRqstGridView_CellDoubleClick);
            // 
            // Book_rqst_label
            // 
            this.Book_rqst_label.AutoSize = true;
            this.Book_rqst_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_rqst_label.Location = new System.Drawing.Point(12, 73);
            this.Book_rqst_label.Name = "Book_rqst_label";
            this.Book_rqst_label.Size = new System.Drawing.Size(53, 25);
            this.Book_rqst_label.TabIndex = 13;
            this.Book_rqst_label.Text = "label";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 45);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(712, 707);
            this.axAcroPDF1.TabIndex = 21;
            // 
            // Viewbutton
            // 
            this.Viewbutton.Location = new System.Drawing.Point(347, 651);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(97, 29);
            this.Viewbutton.TabIndex = 22;
            this.Viewbutton.Text = "View";
            this.Viewbutton.UseVisualStyleBackColor = true;
            this.Viewbutton.Click += new System.EventHandler(this.Viewbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Location = new System.Drawing.Point(605, 12);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(95, 30);
            this.Closebutton.TabIndex = 23;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = false;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Textlabel
            // 
            this.Textlabel.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textlabel.Image = global::BookTreasure.Properties.Resources.ss;
            this.Textlabel.Location = new System.Drawing.Point(53, 184);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(571, 401);
            this.Textlabel.TabIndex = 18;
            this.Textlabel.Text = "label";
            // 
            // Backbutton
            // 
            this.Backbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Backbutton.Image = global::BookTreasure.Properties.Resources.backIcon1;
            this.Backbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(29, 42);
            this.Backbutton.Text = "toolStripButton1";
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // EmBookUpRqstDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(712, 752);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.ViewDetailsbutton);
            this.Controls.Add(this.Hidebutton);
            this.Controls.Add(this.Textlabel);
            this.Controls.Add(this.Declinebutton);
            this.Controls.Add(this.Approvebutton);
            this.Controls.Add(this.BookRqstGridView);
            this.Controls.Add(this.Book_rqst_label);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Viewbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmBookUpRqstDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmBookUpRqstDetailsForm";
            this.Load += new System.EventHandler(this.EmBookUpRqstDetailsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookRqstGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Backbutton;
        private System.Windows.Forms.Button ViewDetailsbutton;
        private System.Windows.Forms.Button Hidebutton;
        private System.Windows.Forms.Label Textlabel;
        private System.Windows.Forms.Button Declinebutton;
        private System.Windows.Forms.Button Approvebutton;
        private System.Windows.Forms.DataGridView BookRqstGridView;
        private System.Windows.Forms.Label Book_rqst_label;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button Viewbutton;
        private System.Windows.Forms.Button Closebutton;
    }
}