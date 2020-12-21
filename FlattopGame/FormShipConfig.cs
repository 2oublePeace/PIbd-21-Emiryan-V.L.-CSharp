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
		/// Переменная-выбранный корабль
		/// </summary>
		Vehicle armyShip = null;
		private event Action<Vehicle> eventAddShip;
		public FormShipConfig()
		{
			InitializeComponent();
			foreach (Control control in colorGroupBox.Controls)
			{
				if (control.GetType() == typeof(Panel))
				{
					control.MouseDown += new MouseEventHandler(this.panelColor_MouseDown);
				}
			}
			cancelButton.Click += (object sender, EventArgs e) => { Close(); };
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
			if (e.Data.GetDataPresent(typeof(Color)) && armyShip != null)
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
		Color color = Color.White;
		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			Color shipColor = (Color) e.Data.GetData(typeof(Color));
			armyShip.SetMainColor(shipColor);					
			DrawShip();
		}
		/// <summary>
		/// Принимаем дополнительный цвет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			Color shipColor = (Color)e.Data.GetData(typeof(Color));
			if (armyShip.GetType() == typeof(Flattop))
			{
				Flattop flattop = (Flattop)armyShip;
				flattop.SetDopColor(shipColor);
				DrawShip();
			}
		}
		/// <summary>
		/// Добавление корабля
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addButton_Click(object sender, EventArgs e)
		{
			eventAddShip?.Invoke(armyShip);
			Close();
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
		public void AddEvent(Action<Vehicle> ev)
		{
			if (eventAddShip == null)
			{
				eventAddShip = new Action<Vehicle>(ev);
			}
			else
			{
				eventAddShip += ev;
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
					armyShip = new ArmyShip((int)numericMaxSpeed.Value, (int)numericWeight.Value, Color.White);
					break;
				case "Авианосец":
					armyShip = new Flattop((int)numericMaxSpeed.Value, (int)numericWeight.Value, Color.White, Color.Black, frontGunsCheck.Checked, helicopterStandCheck.Checked, satelliteLocatorCheck.Checked, planeCheck.Checked, true);
					break;
			}
			DrawShip();
		}
	}
}