
namespace BookTreasure
{
    partial class PasswordchangeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentPasstextBox = new System.Windows.Forms.TextBox();
            this.NewPasstextBox = new System.Windows.Forms.TextBox();
            this.ConformNewPasstextBox = new System.Windows.Forms.TextBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Backbutton = new System.Windows.Forms.ToolStripButton();
            this.ErrortextBox = new System.Windows.Forms.TextBox();
            this.PassErrorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(84, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(10, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confrom New Password :";
            // 
            // CurrentPasstextBox
            // 
            this.CurrentPasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.CurrentPasstextBox.Location = new System.Drawing.Point(217, 400);
            this.CurrentPasstextBox.Name = "CurrentPasstextBox";
            this.CurrentPasstextBox.Size = new System.Drawing.Size(434, 27);
            this.CurrentPasstextBox.TabIndex = 3;
            this.CurrentPasstextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPasstextBox_KeyPress);
            // 
            // NewPasstextBox
            // 
            this.NewPasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.NewPasstextBox.Location = new System.Drawing.Point(217, 454);
            this.NewPasstextBox.Name = "NewPasstextBox";
            this.NewPasstextBox.Size = new System.Drawing.Size(434, 27);
            this.NewPasstextBox.TabIndex = 4;
            // 
            // ConformNewPasstextBox
            // 
            this.ConformNewPasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ConformNewPasstextBox.Location = new System.Drawing.Point(217, 503);
            this.ConformNewPasstextBox.Name = "ConformNewPasstextBox";
            this.ConformNewPasstextBox.Size = new System.Drawing.Size(434, 27);
            this.ConformNewPasstextBox.TabIndex = 5;
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.SystemColors.ControlText;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Updatebutton.Location = new System.Drawing.Point(273, 629);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(91, 44);
            this.Updatebutton.TabIndex = 6;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.SystemColors.ControlText;
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelbutton.Location = new System.Drawing.Point(409, 629);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(91, 44);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
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
            // ErrortextBox
            // 
            this.ErrortextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrortextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrortextBox.Location = new System.Drawing.Point(217, 536);
            this.ErrortextBox.Name = "ErrortextBox";
            this.ErrortextBox.Size = new System.Drawing.Size(434, 15);
            this.ErrortextBox.TabIndex = 13;
            // 
            // PassErrorBox
            // 
            this.PassErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassErrorBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PassErrorBox.Location = new System.Drawing.Point(217, 433);
            this.PassErrorBox.Name = "PassErrorBox";
            this.PassErrorBox.Size = new System.Drawing.Size(434, 15);
            this.PassErrorBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Image = global::BookTreasure.Properties.Resources.pass;
            this.label4.Location = new System.Drawing.Point(139, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 226);
            this.label4.TabIndex = 15;
            // 
            // PasswordchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(712, 752);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassErrorBox);
            this.Controls.Add(this.ErrortextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.ConformNewPasstextBox);
            this.Controls.Add(this.NewPasstextBox);
            this.Controls.Add(this.CurrentPasstextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PasswordchangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordchangeForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CurrentPasstextBox;
        private System.Windows.Forms.TextBox NewPasstextBox;
        private System.Windows.Forms.TextBox ConformNewPasstextBox;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Backbutton;
        private System.Windows.Forms.TextBox ErrortextBox;
        private System.Windows.Forms.TextBox PassErrorBox;
        private System.Windows.Forms.Label label4;
    }
}