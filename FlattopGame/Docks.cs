using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattopGame
{
	/// <summary>
	/// Параметризованный класс для хранения набора объектов от интерфейса ITransport
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Docks<T> where T : class, ITransport
	{
		/// <summary>
		/// Список объектов, которые храним
		/// </summary>
		private readonly List<T> _places;
		/// <summary>
		/// Максимальное количество мест на уровне
		/// </summary>
		private readonly int _maxCount;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private readonly int pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private readonly int pictureHeight;
		/// <summary>
		/// Размер дока (ширина)
		/// </summary>
		private readonly int _placeSizeWidth = 330;
		/// <summary>
		/// Размер дока (высота)
		/// </summary>
		private readonly int _placeSizeHeight = 110;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="pictureWidthParam">Рамзер дока - ширина</param>
		/// <param name="pictureHeightParam">Рамзер дока на причале - высота</param>
		public Docks(int pictureWidthParam, int pictureHeightParam)
		{
			int width = pictureWidthParam / _placeSizeWidth;
			int height = pictureHeightParam / _placeSizeHeight;
			_maxCount = width * height;
			pictureWidth = pictureWidthParam;
			pictureHeight = pictureHeightParam;
			_places = new List<T>();
		}
		/// <summary>
		/// Перегрузка оператора сложения
		/// Логика действия: на парковку добавляется корабль
		/// </summary>
		/// <param name="p">Доки</param>
		/// <param name="armyShip">Добавляемый корабль</param>
		/// <returns></returns>
		public static bool operator +(Docks<T> p, T armyShip)
		{
			if (p._places.Count >= p._maxCount)
			{
				return false;
			}
			p._places.Add(armyShip);
			return true;
		}
		/// <summary>
		/// Перегрузка оператора вычитания
		/// Логика действия: с дока забираем корабль
		/// </summary>
		/// <param name="p">Доки</param>
		/// <param name="index">Индекс места, с которого пытаемся извлечь объект
		/// </param>
		/// <returns></returns>
		public static T operator -(Docks<T> p, int index)
		{
			if (index < -1 || index > p._places.Count)
			{
				return null;
			}
			T armyShip = p._places[index];
			p._places.RemoveAt(index);
			return armyShip;
		}
		/// <summary>
		/// Метод отрисовки доков
		/// </summary>
		/// <param name="g"></param>
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			ArmyShipForm armyShipForm = new ArmyShipForm();
			for (int i = 0; i < _places.Count; i++)
			{
				int x = (i / (pictureHeight / _placeSizeHeight)) * _placeSizeWidth + ((_placeSizeWidth - 320) / 2);
				int y = (i % (pictureHeight / _placeSizeHeight)) * _placeSizeHeight + ((_placeSizeHeight - 90) / 2);
				_places[i]?.SetPosition(x, y, armyShipForm.GameFieldWidth, armyShipForm.GameFieldHeight);
				_places[i]?.DrawTransport(g);
			}
		}
		/// <summary>
		/// Метод отрисовки разметки доков
		/// </summary>
		/// <param name="g"></param>
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
			{
				for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
				{
					//линия рамзетки места
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
		/// <summary>
		/// Функция получения элементы из списка
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public T GetNext(int index)
		{
			if (index < 0 || index >= _places.Count)
			{
				return null;
			}
			return _places[index];
		}
	}
}