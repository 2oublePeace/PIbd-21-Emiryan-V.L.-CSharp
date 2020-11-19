using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlattopGame
{
	public partial class FormDocks : Form
	{
		/// <summary>
		/// Объект от класса-доков
		/// </summary>
		private readonly Parking<ArmyShip> docks;
		public FormDocks()
		{
			InitializeComponent();
			docks = new Parking<ArmyShip>(pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}
		/// <summary>
		/// Метод отрисовки доков
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			docks.Draw(gr);
			pictureBoxParking.Image = bmp;
		}
		/// <summary>
		/// Обработка нажатия кнопки "Припарковать корабль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetArmyShip_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var armyShip = new ArmyShip(100, 1000, dialog.Color);
				if (docks + armyShip)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Все доки заняты");
				}
			}
		}
		/// <summary>
		/// Обработка нажатия кнопки "Припарковать Авианосец"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetFlattop_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var armyShip = new Flattop(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true, true);
					if (docks + armyShip)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Все доки заняты");
					}
				}
			}
		}
		/// <summary>
		/// Обработка нажатия кнопки "Забрать"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonTakeShip_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				var armyShip = docks - Convert.ToInt32(maskedTextBox.Text);
				if (armyShip != null)
				{
					ArmyShipForm form = new ArmyShipForm();
					form.SetArmyShip(armyShip);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}
