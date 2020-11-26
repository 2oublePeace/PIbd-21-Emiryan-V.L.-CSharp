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
		/// Обработка нажатия кнопки "Создать армейский корабль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCreateArmyShip_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			armyShip = new ArmyShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			armyShip.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), ArmyShipPictureBox.Width, ArmyShipPictureBox.Height);
			Draw();
		}
		/// <summary>
		/// Обработка нажатия кнопки "Создать авианосец"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCreateFlattop_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			armyShip = new Flattop(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Red, true, true, true, true, true);
			armyShip.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), ArmyShipPictureBox.Width, ArmyShipPictureBox.Height);
			Draw();
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
