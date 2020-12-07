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
	public partial class ArmyShipForm : Form
	{
		private ITransport armyShip;
		/// <summary>
		/// Ширина окна игрового поля
		/// </summary>
		public int GameFieldWidth { set { } get { return ArmyShipPictureBox.Width; } }
		/// <summary>
		/// Высота окна игрового поля
		/// </summary>
		public int GameFieldHeight { set { } get { return ArmyShipPictureBox.Height; } }
		/// <summary>
		/// Конструктор
		/// </summary>
		public ArmyShipForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Передача армейских кораблей на форму
		/// </summary>
		/// <param name="armyShip"></param>
		public void SetArmyShip(ITransport armyShip)
		{
			this.armyShip = armyShip;
			Draw();
	    }
		/// <summary>
		/// Метод отрисовки армейского корабля
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(ArmyShipPictureBox.Width, ArmyShipPictureBox.Height);
			Graphics gr = Graphics.FromImage(bmp);
			armyShip?.DrawTransport(gr);
			ArmyShipPictureBox.Image = bmp;
		}
		/// <summary>
		/// Обработка нажатия кнопок управления
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					armyShip.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					armyShip.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					armyShip.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					armyShip.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
