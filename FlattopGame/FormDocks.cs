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
		/// Объект от класса-коллекции уровней доков
		/// </summary>
		private readonly DockCollection dockCollection;
		public FormDocks()
		{
			InitializeComponent();
			dockCollection = new DockCollection(pictureBoxDock.Width, pictureBoxDock.Height);
		}
		/// <summary>
		/// Заполнение listBoxLevels
		/// </summary>
		private void ReloadLevels()
		{
			int index = listBoxDocks.SelectedIndex;
			listBoxDocks.Items.Clear();
			foreach (var dock in dockCollection.Keys)
			{
				listBoxDocks.Items.Add(dock);
			}
			if (listBoxDocks.Items.Count > 0 && (index == -1 || index >=
		   listBoxDocks.Items.Count))
			{
				listBoxDocks.SelectedIndex = 0;
			}
			else if (listBoxDocks.Items.Count > 0 && index > -1 && index <
		   listBoxDocks.Items.Count)
			{
				listBoxDocks.SelectedIndex = index;
			}
		}
		/// <summary>
		/// Метод отрисовки доков
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
			Graphics gr = Graphics.FromImage(bmp);
			dockCollection[listBoxDocks.SelectedItem.ToString()].Draw(gr);
			pictureBoxDock.Image = bmp;
		}
		/// <summary>
		/// Обработка нажатия кнопки "Добавить уровень доков"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addLevel_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			dockCollection.AddDock(textBoxNewLevelName.Text);
			ReloadLevels();
		}
		/// <summary>
		/// Обработка нажатия кнопки "Удалить уровень с доками"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void delLevel_Click(object sender, EventArgs e)
		{
			if (listBoxDocks.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку { listBoxDocks.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
 {
					dockCollection.DelDock(textBoxNewLevelName.Text);
					ReloadLevels();
				}
			}
		}

		/// <summary>
		/// Обработка нажатия кнопки "Припарковать корабль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetArmyShip_Click(object sender, EventArgs e)
		{
			var formCarConfig = new FormShipConfig();
			formCarConfig.AddEvent(AddShip);
			formCarConfig.Show();
		}
		/// <summary>
		/// Обработка нажатия кнопки "Забрать"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonTakeShip_Click(object sender, EventArgs e)
		{
			if (listBoxDocks.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				var armyShip = dockCollection[listBoxDocks.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
				if (armyShip != null)
				{
					ArmyShipForm form = new ArmyShipForm();
					form.SetArmyShip(armyShip);
					form.ShowDialog();
				}
				Draw();
			}
		}
		/// <summary>
		/// Метод обработки выбора элемента на listBoxLevels
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxDocks_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}

		private void AddShip(Vehicle armyShip)
		{
			if (armyShip != null && listBoxDocks.SelectedIndex > -1)
			{
				if ((dockCollection[listBoxDocks.SelectedItem.ToString()]) + armyShip)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Машину не удалось поставить");
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (dockCollection.SaveData(saveFileDialog.FileName))
				{
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text files|*.txt|All files|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (dockCollection.LoadData(openFileDialog.FileName))
				{
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ReloadLevels();
					Draw();
				}
				else
				{
					MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
