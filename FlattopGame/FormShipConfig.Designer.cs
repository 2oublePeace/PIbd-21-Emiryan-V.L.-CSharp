﻿namespace FlattopGame
{
	partial class FormShipConfig
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
			this.typeGroupBox = new System.Windows.Forms.GroupBox();
			this.flattopLabel = new System.Windows.Forms.Label();
			this.armyShipLabel = new System.Windows.Forms.Label();
			this.paramGroupBox = new System.Windows.Forms.GroupBox();
			this.planeCheck = new System.Windows.Forms.CheckBox();
			this.helicopterStandCheck = new System.Windows.Forms.CheckBox();
			this.satelliteLocatorCheck = new System.Windows.Forms.CheckBox();
			this.frontGunsCheck = new System.Windows.Forms.CheckBox();
			this.shipWeightLabel = new System.Windows.Forms.Label();
			this.maxSpeedLabel = new System.Windows.Forms.Label();
			this.numericMaxSpeed = new System.Windows.Forms.NumericUpDown();
			this.numericWeight = new System.Windows.Forms.NumericUpDown();
			this.pictureBoxShip = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mainColorLabel = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.addButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.typeGroupBox.SuspendLayout();
			this.paramGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// typeGroupBox
			// 
			this.typeGroupBox.Controls.Add(this.flattopLabel);
			this.typeGroupBox.Controls.Add(this.armyShipLabel);
			this.typeGroupBox.Location = new System.Drawing.Point(12, 12);
			this.typeGroupBox.Name = "typeGroupBox";
			this.typeGroupBox.Size = new System.Drawing.Size(143, 106);
			this.typeGroupBox.TabIndex = 0;
			this.typeGroupBox.TabStop = false;
			this.typeGroupBox.Text = "Тип корабля";
			// 
			// flattopLabel
			// 
			this.flattopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flattopLabel.Location = new System.Drawing.Point(9, 58);
			this.flattopLabel.Name = "flattopLabel";
			this.flattopLabel.Size = new System.Drawing.Size(125, 35);
			this.flattopLabel.TabIndex = 1;
			this.flattopLabel.Text = "Авианосец";
			this.flattopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.flattopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flattopLabel_MouseDown);
			// 
			// armyShipLabel
			// 
			this.armyShipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.armyShipLabel.Location = new System.Drawing.Point(9, 19);
			this.armyShipLabel.Name = "armyShipLabel";
			this.armyShipLabel.Size = new System.Drawing.Size(125, 35);
			this.armyShipLabel.TabIndex = 0;
			this.armyShipLabel.Text = "Военный корабль";
			this.armyShipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.armyShipLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.armyShipLabel_MouseDown);
			// 
			// paramGroupBox
			// 
			this.paramGroupBox.Controls.Add(this.planeCheck);
			this.paramGroupBox.Controls.Add(this.helicopterStandCheck);
			this.paramGroupBox.Controls.Add(this.satelliteLocatorCheck);
			this.paramGroupBox.Controls.Add(this.frontGunsCheck);
			this.paramGroupBox.Controls.Add(this.shipWeightLabel);
			this.paramGroupBox.Controls.Add(this.maxSpeedLabel);
			this.paramGroupBox.Controls.Add(this.numericMaxSpeed);
			this.paramGroupBox.Controls.Add(this.numericWeight);
			this.paramGroupBox.Location = new System.Drawing.Point(12, 124);
			this.paramGroupBox.Name = "paramGroupBox";
			this.paramGroupBox.Size = new System.Drawing.Size(374, 146);
			this.paramGroupBox.TabIndex = 1;
			this.paramGroupBox.TabStop = false;
			this.paramGroupBox.Text = "Параметры";
			// 
			// planeCheck
			// 
			this.planeCheck.AutoSize = true;
			this.planeCheck.Location = new System.Drawing.Point(225, 98);
			this.planeCheck.Name = "planeCheck";
			this.planeCheck.Size = new System.Drawing.Size(70, 17);
			this.planeCheck.TabIndex = 7;
			this.planeCheck.Text = "Самолет";
			this.planeCheck.UseVisualStyleBackColor = true;
			// 
			// helicopterStandCheck
			// 
			this.helicopterStandCheck.AutoSize = true;
			this.helicopterStandCheck.Location = new System.Drawing.Point(225, 79);
			this.helicopterStandCheck.Name = "helicopterStandCheck";
			this.helicopterStandCheck.Size = new System.Drawing.Size(145, 17);
			this.helicopterStandCheck.TabIndex = 6;
			this.helicopterStandCheck.Text = "Вертолетная площадка";
			this.helicopterStandCheck.UseVisualStyleBackColor = true;
			// 
			// satelliteLocatorCheck
			// 
			this.satelliteLocatorCheck.AutoSize = true;
			this.satelliteLocatorCheck.Location = new System.Drawing.Point(225, 59);
			this.satelliteLocatorCheck.Name = "satelliteLocatorCheck";
			this.satelliteLocatorCheck.Size = new System.Drawing.Size(137, 17);
			this.satelliteLocatorCheck.TabIndex = 5;
			this.satelliteLocatorCheck.Text = "Спутниковый локатор";
			this.satelliteLocatorCheck.UseVisualStyleBackColor = true;
			// 
			// frontGunsCheck
			// 
			this.frontGunsCheck.AutoSize = true;
			this.frontGunsCheck.Location = new System.Drawing.Point(225, 40);
			this.frontGunsCheck.Name = "frontGunsCheck";
			this.frontGunsCheck.Size = new System.Drawing.Size(132, 17);
			this.frontGunsCheck.TabIndex = 4;
			this.frontGunsCheck.Text = "Фронтальные пушки";
			this.frontGunsCheck.UseVisualStyleBackColor = true;
			// 
			// shipWeightLabel
			// 
			this.shipWeightLabel.AutoSize = true;
			this.shipWeightLabel.Location = new System.Drawing.Point(33, 86);
			this.shipWeightLabel.Name = "shipWeightLabel";
			this.shipWeightLabel.Size = new System.Drawing.Size(74, 13);
			this.shipWeightLabel.TabIndex = 3;
			this.shipWeightLabel.Text = "Вес корабля:";
			// 
			// maxSpeedLabel
			// 
			this.maxSpeedLabel.AutoSize = true;
			this.maxSpeedLabel.Location = new System.Drawing.Point(33, 47);
			this.maxSpeedLabel.Name = "maxSpeedLabel";
			this.maxSpeedLabel.Size = new System.Drawing.Size(90, 13);
			this.maxSpeedLabel.TabIndex = 2;
			this.maxSpeedLabel.Text = "Макс. скорость:";
			// 
			// numericMaxSpeed
			// 
			this.numericMaxSpeed.Location = new System.Drawing.Point(129, 44);
			this.numericMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericMaxSpeed.Name = "numericMaxSpeed";
			this.numericMaxSpeed.Size = new System.Drawing.Size(50, 20);
			this.numericMaxSpeed.TabIndex = 1;
			this.numericMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericWeight
			// 
			this.numericWeight.Location = new System.Drawing.Point(129, 83);
			this.numericWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericWeight.Name = "numericWeight";
			this.numericWeight.Size = new System.Drawing.Size(50, 20);
			this.numericWeight.TabIndex = 0;
			this.numericWeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// pictureBoxShip
			// 
			this.pictureBoxShip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxShip.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxShip.Name = "pictureBoxShip";
			this.pictureBoxShip.Size = new System.Drawing.Size(358, 106);
			this.pictureBoxShip.TabIndex = 2;
			this.pictureBoxShip.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.Controls.Add(this.pictureBoxShip);
			this.panel1.Location = new System.Drawing.Point(161, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(358, 106);
			this.panel1.TabIndex = 8;
			this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.shipPanel_DragDrop);
			this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.shipPanel_DragEnter);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.mainColorLabel);
			this.groupBox1.Controls.Add(this.panel9);
			this.groupBox1.Controls.Add(this.panel8);
			this.groupBox1.Controls.Add(this.panel7);
			this.groupBox1.Controls.Add(this.panel6);
			this.groupBox1.Controls.Add(this.panel4);
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Location = new System.Drawing.Point(411, 124);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 146);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(112, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 35);
			this.label2.TabIndex = 3;
			this.label2.Text = "Доп. цвет";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// mainColorLabel
			// 
			this.mainColorLabel.AllowDrop = true;
			this.mainColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mainColorLabel.Location = new System.Drawing.Point(23, 19);
			this.mainColorLabel.Name = "mainColorLabel";
			this.mainColorLabel.Size = new System.Drawing.Size(85, 35);
			this.mainColorLabel.TabIndex = 2;
			this.mainColorLabel.Text = "Основной цвет";
			this.mainColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mainColorLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.mainColorLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panel9.Location = new System.Drawing.Point(167, 101);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(30, 30);
			this.panel9.TabIndex = 1;
			this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.panel8.Location = new System.Drawing.Point(121, 101);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(30, 30);
			this.panel8.TabIndex = 1;
			this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel7.Location = new System.Drawing.Point(73, 101);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(30, 30);
			this.panel7.TabIndex = 1;
			this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Gray;
			this.panel6.Location = new System.Drawing.Point(23, 101);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(30, 30);
			this.panel6.TabIndex = 1;
			this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.Location = new System.Drawing.Point(121, 65);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(30, 30);
			this.panel4.TabIndex = 1;
			this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Yellow;
			this.panel5.Location = new System.Drawing.Point(73, 65);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(30, 30);
			this.panel5.TabIndex = 1;
			this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(167, 65);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(30, 30);
			this.panel3.TabIndex = 1;
			this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Red;
			this.panel2.Location = new System.Drawing.Point(23, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(30, 30);
			this.panel2.TabIndex = 0;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(433, 276);
			this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(81, 26);
			this.addButton.TabIndex = 10;
			this.addButton.Text = "Добавить";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(532, 276);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 26);
			this.cancelButton.TabIndex = 11;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// FormShipConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 309);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.paramGroupBox);
			this.Controls.Add(this.typeGroupBox);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormShipConfig";
			this.Text = "FormShipConfig";
			this.typeGroupBox.ResumeLayout(false);
			this.paramGroupBox.ResumeLayout(false);
			this.paramGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox typeGroupBox;
		private System.Windows.Forms.GroupBox paramGroupBox;
		private System.Windows.Forms.PictureBox pictureBoxShip;
		private System.Windows.Forms.Label flattopLabel;
		private System.Windows.Forms.Label armyShipLabel;
		private System.Windows.Forms.CheckBox planeCheck;
		private System.Windows.Forms.CheckBox helicopterStandCheck;
		private System.Windows.Forms.CheckBox satelliteLocatorCheck;
		private System.Windows.Forms.CheckBox frontGunsCheck;
		private System.Windows.Forms.Label shipWeightLabel;
		private System.Windows.Forms.Label maxSpeedLabel;
		private System.Windows.Forms.NumericUpDown numericMaxSpeed;
		private System.Windows.Forms.NumericUpDown numericWeight;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label mainColorLabel;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button cancelButton;
	}
}