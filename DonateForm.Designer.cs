
namespace BookTreasure
{
    partial class DonateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.BookNametextBox = new System.Windows.Forms.TextBox();
            this.WritertextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Backbutton = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 445);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Writer Name :";
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadButton.Location = new System.Drawing.Point(286, 621);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(4);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(107, 46);
            this.UploadButton.TabIndex = 4;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = false;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // BookNametextBox
            // 
            this.BookNametextBox.Location = new System.Drawing.Point(259, 437);
            this.BookNametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookNametextBox.Name = "BookNametextBox";
            this.BookNametextBox.Size = new System.Drawing.Size(317, 22);
            this.BookNametextBox.TabIndex = 6;
            // 
            // WritertextBox
            // 
            this.WritertextBox.Location = new System.Drawing.Point(261, 493);
            this.WritertextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WritertextBox.Name = "WritertextBox";
            this.WritertextBox.Size = new System.Drawing.Size(315, 22);
            this.WritertextBox.TabIndex = 7;
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
            // label3
            // 
            this.label3.Image = global::BookTreasure.Properties.Resources.BDonate;
            this.label3.Location = new System.Drawing.Point(37, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(630, 354);
            this.label3.TabIndex = 8;
            // 
            // DonateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(712, 752);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.WritertextBox);
            this.Controls.Add(this.BookNametextBox);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DonateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Donate Page";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TextBox BookNametextBox;
        private System.Windows.Forms.TextBox WritertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Backbutton;
    }
}