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
	public partial class FormShipConfig : Form
	{
		/// <summary>
		/// Переменная-выбранная машина
		/// </summary>
		Vehicle armyShip = null;
		private event CarDelegate eventAddCar;
		public FormShipConfig()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Отправляем цвет с панели
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			Panel panel = sender as Panel;
			panel.DoDragDrop(panel.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
		}
		/// <summary>
		/// Проверка получаемой информации (ее типа на соответствие требуемому)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent("Color"))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		/// <summary>
		/// Принимаем основной цвет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Red":
					armyShip.SetMainColor(Color.Red);
					break;
			}
			DrawShip();
		}
		/// <summary>
		/// Принимаем дополнительный цвет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			Flattop vehicle = sender as Flattop;
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Red":
					vehicle.SetDopColor(Color.Red);
					break;
			}
			DrawShip();
		}

		/// <summary>
		/// Отрисовать машину
		/// </summary>
		private void DrawShip()
		{
			if (armyShip != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
				Graphics gr = Graphics.FromImage(bmp);
				armyShip.SetPosition(5, 5, pictureBoxShip.Width, pictureBoxShip.Height);
				armyShip.DrawTransport(gr);
				pictureBoxShip.Image = bmp;
			}
		}
		/// <summary>
		/// Добавление события
		/// </summary>
		/// <param name="ev"></param>
		public void AddEvent(CarDelegate ev)
		{
			if (eventAddCar == null)
			{
				eventAddCar = new CarDelegate(ev);
			}
			else
			{
				eventAddCar += ev;
			}
		}
		/// <summary>
		/// Передаем информацию при нажатии на Label
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void armyShipLabel_MouseDown(object sender, MouseEventArgs e)
		{
			armyShipLabel.DoDragDrop(armyShipLabel.Text, DragDropEffects.Move | DragDropEffects.Copy);
	    }
		/// <summary>
		/// Передаем информацию при нажатии на Label
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void flattopLabel_MouseDown(object sender, MouseEventArgs e)
		{
			flattopLabel.DoDragDrop(flattopLabel.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}
		/// <summary>
		/// Проверка получаемой информации (ее типа на соответствие требуемому)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void shipPanel_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		/// <summary>
		/// Действия при приеме перетаскиваемой информации
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void shipPanel_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Военный корабль":
					armyShip = new ArmyShip(100, 500, Color.White);
					break;
				case "Авианосец":
					armyShip = new Flattop(100, 500, Color.White, Color.Black, true, true,true,true,true);
					break;
			}
			DrawShip();
		}
	}
}
