using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlattopGame
{
	/// <summary>
	/// Класс отрисовки автомобиля
	/// </summary>
	public class ArmyShip
	{
		/// <summary>
		/// Левая координата отрисовки автомобиля
		/// </summary>
		private float _startPosX;
		/// <summary>
		/// Правая кооридната отрисовки автомобиля
		/// </summary>
		private float _startPosY;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private int _pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private int _pictureHeight;
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		private readonly int carWidth = 320;
		/// <summary>
		/// Высота отрисовки автомобиля
		/// </summary>
		private readonly int carHeight = 90;
		/// <summary>
		/// Максимальная скорость
		/// </summary>
		public int MaxSpeed { private set; get; }
		/// <summary>
		/// Вес автомобиля
		/// </summary>
		public float Weight { private set; get; }
		/// <summary>
		/// Основной цвет кузова
		/// </summary>
		public Color MainColor { private set; get; }
		/// <summary>
		/// Дополнительный цвет
		/// </summary>
		public Color DopColor { private set; get; }
		/// <summary>
		/// Признак наличия передней пушки
		/// </summary>
		public bool FrontGun { private set; get; }
		/// <summary>
		/// Признак наличия посадочной площадки для вертолета
		/// </summary>
		public bool HelicopterStand { private set; get; }
		/// <summary>
		/// Признак наличия спутникого локатора
		/// </summary>
		public bool SatelliteLocator { private set; get; }
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="dopColor">Дополнительный цвет</param>
		/// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
		/// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
		/// <param name="backSpoiler">Признак наличия заднего спойлера</param>
		/// <param name="sportLine">Признак наличия гоночной полосы</param>
		public ArmyShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool satelliteLocator, bool helicopterStand, bool frontGun)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			SatelliteLocator = satelliteLocator;
			HelicopterStand = helicopterStand;
			FrontGun = frontGun;
		}
		/// <summary>
		/// Установка позиции автомобиля
		/// </summary>
		/// <param name="x">Координата X</param>
		/// <param name="y">Координата Y</param>
		/// <param name="width">Ширина картинки</param>
		/// <param name="height">Высота картинки</param>
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		/// <summary>
		/// Изменение направления пермещения
		/// </summary>
		/// <param name="direction">Направление</param>
		public void MoveTransport(Direction direction)
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
		public void DrawTransport(Graphics g)
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
			br = new SolidBrush(DopColor);
			g.FillRectangle(br, _startPosX, _startPosY + 30, 320, 30);
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
			// рисуем задний спойлер автомобиля
			if (FrontGun)
			{
				int[] xGun1Points = {
					_startPosXtoInt + 210,
					_startPosXtoInt + 290,
					_startPosXtoInt + 290
				};
				int[] yGun1Points = {
					_startPosYtoInt + 7,
					_startPosYtoInt + 7,
					_startPosYtoInt + 23
				};
				PointF[] gunSpritePoints = new PointF[3];
				for (int i = 0; i < 3; i++)
				{
					gunSpritePoints[i] = new Point(xGun1Points[i], yGun1Points[i]);
				}
				g.DrawPolygon(pen, gunSpritePoints);
				br = new SolidBrush(DopColor);
				g.FillPolygon(br, gunSpritePoints);
				int[] yGun2Points = {
					_startPosYtoInt + 82,
					_startPosYtoInt + 82,
					_startPosYtoInt + 66
				};
				for (int i = 0; i < 3; i++)
				{
					gunSpritePoints[i] = new Point(xGun1Points[i], yGun2Points[i]);
				}
				g.DrawPolygon(pen, gunSpritePoints);
				g.FillPolygon(br, gunSpritePoints);
			}
			if (HelicopterStand)
			{
				br = new SolidBrush(Color.Black);
				g.FillEllipse(br, _startPosX + 30, _startPosY, 45, 45);
				pen = new Pen(Color.Black);
				g.DrawEllipse(pen, _startPosX + 30, _startPosY, 45, 45);
				g.DrawString("H", new Font("Arial", 24, FontStyle.Bold), Brushes.Yellow, _startPosX + 36, _startPosY + 5);
			}
			if (SatelliteLocator)
			{
				br = new SolidBrush(Color.White);
				g.FillEllipse(br, _startPosX + 30, _startPosY + 50, 45, 45);
				pen = new Pen(Color.Black);
				g.DrawEllipse(pen, _startPosX + 30, _startPosY + 50, 45, 45);
				g.DrawLine(pen, _startPosX + 37, _startPosY + 57, _startPosX + 68, _startPosY + 88);
				g.DrawLine(pen, _startPosX + 37, _startPosY + 88, _startPosX + 68, _startPosY + 57);
			}
		}
	}
}
