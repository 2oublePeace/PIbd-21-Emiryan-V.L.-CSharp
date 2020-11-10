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
		protected readonly int carWidth = 90;
		/// <summary>
		/// Высота отрисовки армейского корабля
		/// </summary>
		protected readonly int carHeight = 50;
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
		/// Конструкторс изменением размеров армейского корабля
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
			this.carWidth = shipWidth;
			this.carHeight = shipHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
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
					if (_startPosY + step < _pictureHeight - carHeight)
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
			//Отрисовкв полосы
			pen = new Pen(Color.White);
			PointF pointLine1 = new PointF(_startPosXtoInt, _startPosYtoInt + 45);
			PointF pointLine2 = new PointF(_startPosXtoInt + 320, _startPosYtoInt + 45);
			g.DrawLine(pen, pointLine1, pointLine2);
			//Отрисовка кабины
			pen = new Pen(Color.Black);
			g.DrawEllipse(pen, _startPosX + 85, _startPosY + 60, 60, 30);
			br = new SolidBrush(Color.Gray);
			g.FillEllipse(br, _startPosX + 85, _startPosY + 60, 60, 30);
		}
	}
}
