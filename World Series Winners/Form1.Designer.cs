namespace World_Series_Winners
{
	partial class frmWorldSeriesWinners
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorldSeriesWinners));
			this.lblProgramHeader = new System.Windows.Forms.Label();
			this.lstTeamSelector = new System.Windows.Forms.ListBox();
			this.lblTeamSelector = new System.Windows.Forms.Label();
			this.lblWinsHeading = new System.Windows.Forms.Label();
			this.lblNumberOfWins = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProgramHeader
			// 
			this.lblProgramHeader.AutoSize = true;
			this.lblProgramHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProgramHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblProgramHeader.Location = new System.Drawing.Point(120, 21);
			this.lblProgramHeader.Name = "lblProgramHeader";
			this.lblProgramHeader.Size = new System.Drawing.Size(353, 39);
			this.lblProgramHeader.TabIndex = 0;
			this.lblProgramHeader.Text = "World Series Winners";
			// 
			// lstTeamSelector
			// 
			this.lstTeamSelector.BackColor = System.Drawing.Color.Crimson;
			this.lstTeamSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstTeamSelector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lstTeamSelector.FormattingEnabled = true;
			this.lstTeamSelector.ItemHeight = 16;
			this.lstTeamSelector.Items.AddRange(new object[] {
            "Anaheim Angels",
            "Arizona Diamondbacks",
            "Atlanta Braves",
            "Baltimore Orioles",
            "Boston Americans",
            "Boston Braves",
            "Boston Red Sox",
            "Brooklyn Dodgers",
            "Chicago Cubs",
            "Chicago White Sox",
            "Cincinnati Reds",
            "Cleveland Indians",
            "Detroit Tigers",
            "Florida Marlins",
            "Kansas City Royals",
            "Los Angeles Dodgers",
            "Milwaukee Braves",
            "Minnesota Twins",
            "New York Giants",
            "New York Mets",
            "New York Yankees",
            "Oakland Athletics",
            "Philadelphia Athletics",
            "Philadelphia Phillies",
            "Pittsburgh Pirates",
            "San Francisco Giants",
            "St. Louis Cardinals",
            "Toronto Blue Jays",
            "Washington Senators"});
			this.lstTeamSelector.Location = new System.Drawing.Point(28, 120);
			this.lstTeamSelector.Name = "lstTeamSelector";
			this.lstTeamSelector.Size = new System.Drawing.Size(182, 180);
			this.lstTeamSelector.TabIndex = 1;
			this.lstTeamSelector.SelectedIndexChanged += new System.EventHandler(this.lstTeamSelector_SelectedIndexChanged);
			// 
			// lblTeamSelector
			// 
			this.lblTeamSelector.AutoSize = true;
			this.lblTeamSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTeamSelector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTeamSelector.Location = new System.Drawing.Point(55, 93);
			this.lblTeamSelector.Name = "lblTeamSelector";
			this.lblTeamSelector.Size = new System.Drawing.Size(116, 24);
			this.lblTeamSelector.TabIndex = 2;
			this.lblTeamSelector.Text = "Select Team";
			// 
			// lblWinsHeading
			// 
			this.lblWinsHeading.AutoSize = true;
			this.lblWinsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWinsHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblWinsHeading.Location = new System.Drawing.Point(45, 325);
			this.lblWinsHeading.Name = "lblWinsHeading";
			this.lblWinsHeading.Size = new System.Drawing.Size(165, 24);
			this.lblWinsHeading.TabIndex = 4;
			this.lblWinsHeading.Text = "World Series Wins";
			// 
			// lblNumberOfWins
			// 
			this.lblNumberOfWins.AutoSize = true;
			this.lblNumberOfWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumberOfWins.ForeColor = System.Drawing.Color.Crimson;
			this.lblNumberOfWins.Location = new System.Drawing.Point(105, 353);
			this.lblNumberOfWins.Name = "lblNumberOfWins";
			this.lblNumberOfWins.Size = new System.Drawing.Size(105, 42);
			this.lblNumberOfWins.TabIndex = 5;
			this.lblNumberOfWins.Text = "Wins";
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.Crimson;
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnReset.Location = new System.Drawing.Point(302, 352);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(103, 43);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Crimson;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExit.Location = new System.Drawing.Point(426, 352);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(103, 43);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(234, 110);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(304, 178);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// frmWorldSeriesWinners
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(565, 425);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblNumberOfWins);
			this.Controls.Add(this.lblWinsHeading);
			this.Controls.Add(this.lblTeamSelector);
			this.Controls.Add(this.lstTeamSelector);
			this.Controls.Add(this.lblProgramHeader);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmWorldSeriesWinners";
			this.Text = "World Series Winners";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblProgramHeader;
		private System.Windows.Forms.ListBox lstTeamSelector;
		private System.Windows.Forms.Label lblTeamSelector;
		private System.Windows.Forms.Label lblWinsHeading;
		private System.Windows.Forms.Label lblNumberOfWins;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

