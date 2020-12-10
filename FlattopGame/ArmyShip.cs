using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlattopGame
{
	public class ArmyShip : Vehicle
	{
		/// <summary>
		/// Ширина отрисовки армейского корабля
		/// </summary>
		protected readonly int shipWidth = 320;
		/// <summary>
		/// Высота отрисовки армейского корабля
		/// </summary>
		protected readonly int shipHeight = 90;
		/// <summary>
		/// Разделитель для записи информации по объекту в файл
		/// </summary>
		protected readonly char separator = ';';
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес армейского корабля</param>
		/// <param name="mainColor">Основной цвет армейского корабля</param>
		public ArmyShip(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		/// <summary>
		/// Конструктор для загрузки с файла
		/// </summary>
		/// <summary>
		public ArmyShip(string info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
		}
		/// Конструктор с изменением размеров армейского корабля
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес армейского корабля</param>
		/// <param name="mainColor">Основной цвет армейского корабля</param>
		/// <param name="shipWidth">Ширина отрисовки армейского корабля</param>
		/// <param name="shipHeight">Высота отрисовки армейского корабля</param>
		protected ArmyShip(int maxSpeed, float weight, Color mainColor, int shipWidth, int shipHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.shipWidth = shipWidth;
			this.shipHeight = shipHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - shipWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX > _pictureWidth - (_pictureWidth - step))
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY > _pictureHeight - (_pictureHeight - step))
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - shipHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		/// <summary>
		/// Отрисовка армейского корабля
		/// </summary>
		/// <param name="g"></param>
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			int _startPosXtoInt = (int)_startPosX;
			int _startPosYtoInt = (int)_startPosY;
			int[] xShipPoints = {
				_startPosXtoInt,
				_startPosXtoInt + 15,
				_startPosXtoInt + 30,
				_startPosXtoInt + 45,
				_startPosXtoInt + 175, 
				_startPosXtoInt + 320, 
				_startPosXtoInt + 320, 
				_startPosXtoInt + 175,
				_startPosXtoInt + 45,
				_startPosXtoInt + 30,
				_startPosXtoInt + 15,
				_startPosXtoInt
			};
			int[] yShipPoints = { 
				_startPosYtoInt + 30,  
				_startPosYtoInt + 15,  
				_startPosYtoInt + 15,  
				_startPosYtoInt, 
				_startPosYtoInt,
				_startPosYtoInt + 30, 
				_startPosYtoInt + 60,
				_startPosYtoInt + 90,
				_startPosYtoInt + 90,
				_startPosYtoInt + 75,
				_startPosYtoInt + 75,
				_startPosYtoInt + 60,
			};
			PointF[] shipSpritePoints = new PointF[12];
			for (int i = 0; i < 12; i++)
			{
				shipSpritePoints[i] = new Point(xShipPoints[i], yShipPoints[i]);
			}
			//Отрисовка кузова корабля
			g.DrawPolygon(pen, shipSpritePoints);
			Brush br = new SolidBrush(MainColor);
			g.FillPolygon(br, shipSpritePoints);
			//Отрисовка кабины
			pen = new Pen(Color.Black);
			g.DrawEllipse(pen, _startPosX + 85, _startPosY + 60, 60, 30);
			br = new SolidBrush(Color.Gray);
			g.FillEllipse(br, _startPosX + 85, _startPosY + 60, 60, 30);
		}
		public override string ToString()
		{
			return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
		}
	}
}
