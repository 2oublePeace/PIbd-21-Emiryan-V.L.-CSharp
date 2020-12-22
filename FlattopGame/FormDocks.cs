using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace FlattopGame
{
	public partial class FormDocks : Form
	{
		/// <summary>
		/// Объект от класса-коллекции уровней доков
		/// </summary>
		private readonly DockCollection dockCollection;

		/// <summary>
		/// Логгер
		/// </summary>
		private readonly Logger logger;

		public FormDocks()
		{
			InitializeComponent();
			dockCollection = new DockCollection(pictureBoxDock.Width, pictureBoxDock.Height);
			logger = LogManager.GetCurrentClassLogger();
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
				MessageBox.Show("Введите название дока", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			logger.Info($"Добавили док {textBoxNewLevelName.Text}");
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
				if (MessageBox.Show($"Удалить док { listBoxDocks.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
				try
				{
					var armyShip = dockCollection[listBoxDocks.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
					if (armyShip != null)
					{
						ArmyShipForm form = new ArmyShipForm();
						form.SetArmyShip(armyShip);
						form.ShowDialog();
						logger.Info($"Изъят корабль {armyShip} с места {maskedTextBox.Text}");
					}
					Draw();
				}
				catch (DockNotFoundException ex)
				{
					logger.Warn("Не найдено");
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Warn("Неизвестная ошибка");
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		/// <summary>
		/// Метод обработки выбора элемента на listBoxLevels
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxDocks_SelectedIndexChanged(object sender, EventArgs e)
		{
			logger.Info($"Перешли на док {listBoxDocks.SelectedItem.ToString()}");
			Draw();
		}

		private void AddShip(Vehicle armyShip)
		{
			if (armyShip != null && listBoxDocks.SelectedIndex > -1)
			{
				try
				{
					if ((dockCollection[listBoxDocks.SelectedItem.ToString()]) + armyShip)
					{
						Draw();
						logger.Info($"Добавлен корабль {armyShip}");
					}
					else
					{
						logger.Warn("Корабль не удалось поставить");
						MessageBox.Show("Корабль не удалось поставить");
					}
				} 
				catch(DockOverflowException ex)
				{
					logger.Warn("Переполнение");
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch(Exception ex)
				{
					logger.Warn("Неизвестная ошибка");
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					dockCollection.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch
				{
					logger.Warn("Не сохранилось", "Результат");
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
				try
				{
					dockCollection.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName);
					ReloadLevels();
					Draw();
				}
				catch (DockOccupiedPlaceException ex)
				{
					logger.Warn("Занятое место");
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Warn("Неизвестная ошибка при сохранении");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
