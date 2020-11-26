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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
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
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(678, 271);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 44);
			this.button1.TabIndex = 0;
			this.button1.Text = "Пришвартовать корабль";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.buttonSetArmyShip_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(678, 321);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 60);
			this.button2.TabIndex = 1;
			this.button2.Text = "Пришвартовать авианосец";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.buttonSetFlattop_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.maskedTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(678, 387);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(114, 97);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать корабль";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(21, 60);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(77, 25);
			this.button3.TabIndex = 2;
			this.button3.Text = "Забрать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.buttonTakeShip_Click);
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(63, 30);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(35, 20);
			this.maskedTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Место:";
			// 
			// pictureBoxDock
			// 
			this.pictureBoxDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxDock.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxDock.Name = "pictureBoxDock";
			this.pictureBoxDock.Size = new System.Drawing.Size(672, 496);
			this.pictureBoxDock.TabIndex = 3;
			this.pictureBoxDock.TabStop = false;
			// 
			// listBoxDocks
			// 
			this.listBoxDocks.FormattingEnabled = true;
			this.listBoxDocks.Location = new System.Drawing.Point(678, 82);
			this.listBoxDocks.Name = "listBoxDocks";
			this.listBoxDocks.Size = new System.Drawing.Size(114, 82);
			this.listBoxDocks.TabIndex = 4;
			// 
			// textBoxNewLevelName
			// 
			this.textBoxNewLevelName.Location = new System.Drawing.Point(678, 29);
			this.textBoxNewLevelName.Name = "textBoxNewLevelName";
			this.textBoxNewLevelName.Size = new System.Drawing.Size(113, 20);
			this.textBoxNewLevelName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(694, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "label2";
			// 
			// addLevel
			// 
			this.addLevel.Location = new System.Drawing.Point(678, 55);
			this.addLevel.Name = "addLevel";
			this.addLevel.Size = new System.Drawing.Size(114, 21);
			this.addLevel.TabIndex = 7;
			this.addLevel.Text = "button4";
			this.addLevel.UseVisualStyleBackColor = true;
			this.addLevel.Click += new System.EventHandler(this.addLevel_Click);
			// 
			// delLevel
			// 
			this.delLevel.Location = new System.Drawing.Point(678, 170);
			this.delLevel.Name = "delLevel";
			this.delLevel.Size = new System.Drawing.Size(114, 22);
			this.delLevel.TabIndex = 8;
			this.delLevel.Text = "button5";
			this.delLevel.UseVisualStyleBackColor = true;
			// 
			// FormDocks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 496);
			this.Controls.Add(this.delLevel);
			this.Controls.Add(this.addLevel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNewLevelName);
			this.Controls.Add(this.listBoxDocks);
			this.Controls.Add(this.pictureBoxDock);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "FormDocks";
			this.Text = "FormParking";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
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
	}
}