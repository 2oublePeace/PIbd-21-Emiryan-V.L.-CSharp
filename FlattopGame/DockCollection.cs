using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattopGame
{
	class DockCollection
	{
		/// <summary>
		/// Словарь (хранилище) с доками
		/// </summary>
		readonly Dictionary<string, Docks<Vehicle>> dockStages;
		/// <summary>
		/// Возвращение списка названий доков
		/// </summary>
		public List<string> Keys => dockStages.Keys.ToList();
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private readonly int pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private readonly int pictureHeight;
		/// <summary>
		/// Разделитель для записи информации в файл
		/// </summary>
		private readonly char separator = ':';
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="pictureWidth"></param>
		/// <param name="pictureHeight"></param>
		public DockCollection(int pictureWidth, int pictureHeight)
		{
			dockStages = new Dictionary<string, Docks<Vehicle>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}
		/// <summary>
		/// Добавление дока
		/// </summary>
		/// <param name="name">Название дока</param>
		public void AddDock(string name)
		{
			if (dockStages.ContainsKey(name))
			{
				return;
			}
			dockStages.Add(name, new Docks<Vehicle>(pictureWidth, pictureHeight));
		}
		/// <summary>
		/// Удаление дока
		/// </summary>
		/// <param name="name">Название дока</param>
		public void DelDock(string name)
		{
			if (dockStages.ContainsKey(name))
			{
				dockStages.Remove(name);
			}
		}
		/// <summary>
		/// Доступ к доку
		/// </summary>
		/// <param name="ind"></param>
		/// <returns></returns>
		public Docks<Vehicle> this[string ind]
		{
			set { }
			get
			{
				if(dockStages.ContainsKey(ind))
				{
					return dockStages[ind];
				} 
				return null;
			}
		}
		/// <summary>
		/// Метод записи информации в файл
		/// </summary>
		/// <param name="text">Строка, которую следует записать</param>
		/// <param name="stream">Поток для записи</param>
		private void WriteToFile(string text, FileStream stream)
		{
			byte[] info = new UTF8Encoding(true).GetBytes(text);
			stream.Write(info, 0, info.Length);
		}
		/// <summary>
		/// Сохранение информации по автомобилям на парковках в файл
		/// </summary>
		/// <param name="filename">Путь и имя файла</param>
		/// <returns></returns>
		public bool SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.WriteLine($"DockCollection{Environment.NewLine}");
				foreach (var level in dockStages)
				{
					//Начинаем парковку
					sw.WriteLine($"DockCollection{Environment.NewLine}");
					ITransport armyShip = null;
					for (int i = 0; (armyShip = level.Value.GetNext(i)) != null; i++)
					{
						if (armyShip != null)
						{
							//если место не пустое
							//Записываем тип машины
							if (armyShip.GetType().Name == "ArmyShip")
							{
								sw.WriteLine($"ArmyShip{separator}");
							}
							if (armyShip.GetType().Name == "Flattop")
							{
								sw.WriteLine($"Flattop{separator}");
							}
							//Записываемые параметры
							sw.WriteLine(armyShip + Environment.NewLine);
						}
					}
				}
			}
			return true;
		}
		/// <summary>
		/// Загрузка нформации по автомобилям на парковках из файла
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public bool LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				throw new FileNotFoundException();
			}
			
			using (StreamReader sr = new StreamReader(filename))
			{
				string line = sr.ReadLine();
				Vehicle armyShip = null;
				string key = string.Empty;
				if (line.Contains("DockCollection"));
				{
					dockStages.Clear();
					line = sr.ReadLine();
					while (line != null)
					{
						//идем по считанным записям
						if (line.Contains("Dock"))
						{
							//начинаем новую парковку
							key = line.Split(separator)[1];
							dockStages.Add(key, new Docks<Vehicle>(pictureWidth, pictureHeight));
							line = sr.ReadLine();
							continue;
						}
						if (string.IsNullOrEmpty(line))
						{
							continue;
						}
						if (line.Split(separator)[0] == "ArmyShip")
						{
							armyShip = new ArmyShip(line.Split(separator)[1]);
						}
						else if (line.Split(separator)[0] == "Flattop")
						{
							armyShip = new Flattop(line.Split(separator)[1]);
						}
						var result = dockStages[key] + armyShip;
						if (!result)
						{
							return false;
						}
						line = sr.ReadLine();
					}
					return true;
				}
			}
		}

		internal bool SaveData(object fileName)
		{
			throw new NotImplementedException();
		}
	}
}