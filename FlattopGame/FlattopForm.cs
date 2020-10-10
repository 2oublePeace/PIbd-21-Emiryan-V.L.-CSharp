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
	public partial class FlattopForm : Form
	{
		private Flattop flattop;

		public FlattopForm()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(FlattopPictureBox.Width, FlattopPictureBox.Height);
			Graphics gr = Graphics.FromImage(bmp);
			flattop.DrawTransport(gr);
			FlattopPictureBox.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			flattop = new Flattop(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true, true, true);
			flattop.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), FlattopPictureBox.Width, FlattopPictureBox.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					flattop.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					flattop.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					flattop.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					flattop.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}

		private void FlattopPictureBox_Click(object sender, EventArgs e)
		{

		}
	}
}
