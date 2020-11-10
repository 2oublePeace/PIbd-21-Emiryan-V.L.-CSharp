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
		/// Ширина отрисовки автомобиля
		/// </summary>
		protected readonly int carWidth = 90;
		/// <summary>
		/// Высота отрисовки автомобиля
		/// </summary>
		protected readonly int carHeight = 50;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		public ArmyShip(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		/// <summary>
		/// Конструкторс изменением размеров машины
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="carWidth">Ширина отрисовки автомобиля</param>
		/// <param name="carHeight">Высота отрисовки автомобиля</param>
		protected ArmyShip(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.carWidth = carWidth;
			this.carHeight = carHeight;
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
		/// Отрисовка автомобиля
		/// </summary>
		/// <param name="g"></param>
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			// отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка автомобиля на него "легла")

			// теперь отрисуем основной кузов автомобиля
			//границы автомобиля
			int _startPosXtoInt = (int)_startPosX;
			int _startPosYtoInt = (int)_startPosY;
			int[] xSheepPoints = {
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
			int[] ySheepPoints = { 
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

			PointF[] sheepSpritePoints = new PointF[12];
			for (int i = 0; i < 12; i++)
			{
				sheepSpritePoints[i] = new Point(xSheepPoints[i], ySheepPoints[i]);
			}
			g.DrawPolygon(pen, sheepSpritePoints);
			Brush br = new SolidBrush(MainColor);
			g.FillPolygon(br, sheepSpritePoints);
			//Полоса
			pen = new Pen(Color.White);
			PointF pointLine1 = new PointF(_startPosXtoInt, _startPosYtoInt + 45);
			PointF pointLine2 = new PointF(_startPosXtoInt + 320, _startPosYtoInt + 45);
			g.DrawLine(pen, pointLine1, pointLine2);
			//Кабина
			pen = new Pen(Color.Black);
			g.DrawEllipse(pen, _startPosX + 85, _startPosY + 60, 60, 30);
			br = new SolidBrush(Color.Gray);
			g.FillEllipse(br, _startPosX + 85, _startPosY + 60, 60, 30);
		}
	}
}
