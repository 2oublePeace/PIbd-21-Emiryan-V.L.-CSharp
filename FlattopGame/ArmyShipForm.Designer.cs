﻿namespace FlattopGame
{
	partial class ArmyShipForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmyShipForm));
			this.ArmyShipPictureBox = new System.Windows.Forms.PictureBox();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ArmyShipPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ArmyShipPictureBox
			// 
			this.ArmyShipPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ArmyShipPictureBox.Location = new System.Drawing.Point(0, 0);
			this.ArmyShipPictureBox.Name = "ArmyShipPictureBox";
			this.ArmyShipPictureBox.Size = new System.Drawing.Size(884, 461);
			this.ArmyShipPictureBox.TabIndex = 0;
			this.ArmyShipPictureBox.TabStop = false;
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(735, 312);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(65, 65);
			this.buttonUp.TabIndex = 2;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(806, 383);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(65, 65);
			this.buttonRight.TabIndex = 3;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(735, 383);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(65, 65);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(664, 383);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(65, 65);
			this.buttonLeft.TabIndex = 5;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// ArmyShipForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.ArmyShipPictureBox);
			this.Name = "ArmyShipForm";
			this.Text = "FlattopForm";
			((System.ComponentModel.ISupportInitialize)(this.ArmyShipPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ArmyShipPictureBox;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonLeft;
	}
}

