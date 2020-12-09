namespace FlattopGame
{
	partial class FormDocks
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxDock = new System.Windows.Forms.PictureBox();
			this.listBoxDocks = new System.Windows.Forms.ListBox();
			this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.addLevel = new System.Windows.Forms.Button();
			this.delLevel = new System.Windows.Forms.Button();
			this.addShip = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.maskedTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(1017, 595);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(171, 149);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать корабль";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(32, 92);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 38);
			this.button3.TabIndex = 2;
			this.button3.Text = "Забрать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.buttonTakeShip_Click);
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(94, 46);
			this.maskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(50, 26);
			this.maskedTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Место:";
			// 
			// pictureBoxDock
			// 
			this.pictureBoxDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxDock.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxDock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBoxDock.Name = "pictureBoxDock";
			this.pictureBoxDock.Size = new System.Drawing.Size(1008, 763);
			this.pictureBoxDock.TabIndex = 3;
			this.pictureBoxDock.TabStop = false;
			// 
			// listBoxDocks
			// 
			this.listBoxDocks.Cursor = System.Windows.Forms.Cursors.Default;
			this.listBoxDocks.FormattingEnabled = true;
			this.listBoxDocks.ItemHeight = 20;
			this.listBoxDocks.Location = new System.Drawing.Point(1017, 126);
			this.listBoxDocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBoxDocks.Name = "listBoxDocks";
			this.listBoxDocks.Size = new System.Drawing.Size(169, 124);
			this.listBoxDocks.TabIndex = 4;
			this.listBoxDocks.SelectedIndexChanged += new System.EventHandler(this.listBoxDocks_SelectedIndexChanged);
			// 
			// textBoxNewLevelName
			// 
			this.textBoxNewLevelName.Location = new System.Drawing.Point(1017, 45);
			this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxNewLevelName.Name = "textBoxNewLevelName";
			this.textBoxNewLevelName.Size = new System.Drawing.Size(168, 26);
			this.textBoxNewLevelName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1070, 20);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Уровни";
			// 
			// addLevel
			// 
			this.addLevel.Location = new System.Drawing.Point(1017, 85);
			this.addLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.addLevel.Name = "addLevel";
			this.addLevel.Size = new System.Drawing.Size(171, 32);
			this.addLevel.TabIndex = 7;
			this.addLevel.Text = "Добавить уровень";
			this.addLevel.UseVisualStyleBackColor = true;
			this.addLevel.Click += new System.EventHandler(this.addLevel_Click);
			// 
			// delLevel
			// 
			this.delLevel.Location = new System.Drawing.Point(1017, 262);
			this.delLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.delLevel.Name = "delLevel";
			this.delLevel.Size = new System.Drawing.Size(171, 34);
			this.delLevel.TabIndex = 8;
			this.delLevel.Text = "Удалить уровень";
			this.delLevel.UseVisualStyleBackColor = true;
			this.delLevel.Click += new System.EventHandler(this.delLevel_Click);
			// 
			// addShip
			// 
			this.addShip.Location = new System.Drawing.Point(1017, 520);
			this.addShip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.addShip.Name = "addShip";
			this.addShip.Size = new System.Drawing.Size(171, 65);
			this.addShip.TabIndex = 9;
			this.addShip.Text = "Добавить корабль";
			this.addShip.UseVisualStyleBackColor = true;
			this.addShip.Click += new System.EventHandler(this.buttonSetArmyShip_Click);
			// 
			// FormDocks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 763);
			this.Controls.Add(this.addShip);
			this.Controls.Add(this.delLevel);
			this.Controls.Add(this.addLevel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNewLevelName);
			this.Controls.Add(this.listBoxDocks);
			this.Controls.Add(this.pictureBoxDock);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormDocks";
			this.Text = "FormParking";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.PictureBox pictureBoxDock;
		private System.Windows.Forms.ListBox listBoxDocks;
		private System.Windows.Forms.TextBox textBoxNewLevelName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button addLevel;
		private System.Windows.Forms.Button delLevel;
		private System.Windows.Forms.Button addShip;
	}
}