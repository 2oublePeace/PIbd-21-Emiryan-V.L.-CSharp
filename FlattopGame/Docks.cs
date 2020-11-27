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
	public class Parking<T, U>
		where U : ArmyShipForm, new()
		where T : class, ITransport
	{
		/// <summary>
		/// Индекс объекта
		/// </summary>
		private static int placeIndex;
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
		/// <param name="pitureWidthParam">Рамзер дока - ширина</param>
		/// <param name="pictureHeightParam">Рамзер дока на причале - высота</param>
		public Parking(int pitureWidthParam, int pictureHeightParam)
		{
			int width = pitureWidthParam / _placeSizeWidth;
			int height = pictureHeightParam / _placeSizeHeight;
			_places = new T[width * height];
			pictureWidth = pitureWidthParam;
			pictureHeight = pictureHeightParam;
		}
		/// <summary>
		/// Перегрузка оператора сложения
		/// Логика действия: на парковку добавляется корабль
		/// </summary>
		/// <param name="p">Доки</param>
		/// <param name="armyShip">Добавляемый корабль</param>
		/// <returns></returns>
		public static bool operator +(Parking<T,U> p, T armyShip)
		{
			if(placeIndex < p._places.Length && p._places[placeIndex] == null)
			{
				p._places[placeIndex++] = armyShip;
				return true;
			}
			return false;
		}
		/// <summary>
		/// Перегрузка оператора вычитания
		/// Логика действия: с дока забираем корабль
		/// </summary>
		/// <param name="p">Доки</param>
		/// <param name="index">Индекс места, с которого пытаемся извлечь объект
		/// </param>
		/// <returns></returns>
		public static T operator -(Parking<T, U> p, int index)
		{
			placeIndex = index;
			T gettingTransport = p._places[index];
			p._places[index] = null;
			return gettingTransport;
		}
		/// <summary>
		/// Метод отрисовки доков
		/// </summary>
		/// <param name="g"></param>
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			U armyShipForm = new U();
			for (int i = 0; i < _places.Length; i++)
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
	}
}