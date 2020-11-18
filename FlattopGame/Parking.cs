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
	public class Parking<T> where T : class, ITransport
	{
		/// <summary>
		/// Индекс объекта
		/// </summary>
		private static int index;
		/// <summary>
		/// Массив объектов, которые храним
		/// </summary>
		private readonly T[] _places;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private readonly int pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private readonly int pictureHeight;
		/// <summary>
		/// Размер парковочного места (ширина)
		/// </summary>
		private readonly int _placeSizeWidth = 320;
		/// <summary>
		/// Размер парковочного места (высота)
		/// </summary>
		private readonly int _placeSizeHeight = 90;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="picWidth">Рамзер парковки - ширина</param>
		/// <param name="picHeight">Рамзер парковки - высота</param>
		public Parking(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_places = new T[width * height];
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}
		/// <summary>
		/// Перегрузка оператора сложения
		/// Логика действия: на парковку добавляется автомобиль
		/// </summary>
		/// <param name="p">Парковка</param>
		/// <param name="armyShip">Добавляемый автомобиль</param>
		/// <returns></returns>
		public static bool operator +(Parking<T> p, T armyShip)
		{
			if(index < p._places.Length && p._places[index] == null)
			{
				p._places[index++] = armyShip;
				return true;
			}
			return false;
			
		}
		/// <summary>
		/// Перегрузка оператора вычитания
		/// Логика действия: с парковки забираем автомобиль
		/// </summary>
		/// <param name="p">Парковка</param>
		/// <param name="index">Индекс места, с которого пытаемся извлечь объект
		/// </param>
		/// <returns></returns>
		public static T operator -(Parking<T> p, int index)
		{
			return p._places[index];
		}
		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		/// <param name="g"></param>
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				int x = (i / (pictureHeight / _placeSizeHeight)) * _placeSizeWidth;
				int y = (i % (pictureHeight / _placeSizeHeight)) * _placeSizeHeight;
				_places[i]?.SetPosition(x, y, pictureWidth, pictureHeight);
				_places[i]?.DrawTransport(g);
			}
		}
		/// <summary>
		/// Метод отрисовки разметки парковочных мест
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
	}
}