﻿namespace LEARNING_ENTITY_FRAMEWORK
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPageIndex = new System.Windows.Forms.Label();
            this.lastButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // countriesListBox
            // 
            this.countriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(0, 0);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(426, 223);
            this.countriesListBox.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.labelPageCount);
            this.pnlButtons.Controls.Add(this.label2);
            this.pnlButtons.Controls.Add(this.labelPageIndex);
            this.pnlButtons.Controls.Add(this.lastButton);
            this.pnlButtons.Controls.Add(this.firstButton);
            this.pnlButtons.Controls.Add(this.nextButton);
            this.pnlButtons.Controls.Add(this.previousButton);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 223);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(426, 41);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlButtons_Paint);
            // 
            // labelPageCount
            // 
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Location = new System.Drawing.Point(371, 11);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(22, 13);
            this.labelPageCount.TabIndex = 6;
            this.labelPageCount.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // labelPageIndex
            // 
            this.labelPageIndex.AutoSize = true;
            this.labelPageIndex.Location = new System.Drawing.Point(327, 11);
            this.labelPageIndex.Name = "labelPageIndex";
            this.labelPageIndex.Size = new System.Drawing.Size(22, 13);
            this.labelPageIndex.TabIndex = 4;
            this.labelPageIndex.Text = "-----";
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(246, 6);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 23);
            this.lastButton.TabIndex = 3;
            this.lastButton.Text = "&Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(3, 6);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 23);
            this.firstButton.TabIndex = 2;
            this.firstButton.Text = "&First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(165, 6);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "&Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(84, 6);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "&Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 264);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.pnlButtons);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox countriesListBox;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button previousButton;
		private System.Windows.Forms.Button lastButton;
		private System.Windows.Forms.Button firstButton;
		private System.Windows.Forms.Label labelPageCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelPageIndex;


	}
}