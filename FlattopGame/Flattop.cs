using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlattopGame
{
	/// <summary>
	/// Класс отрисовки авианосца
	/// </summary>
	public class Flattop
	{
		/// <summary>
		/// Левая координата отрисовки авианоссца
		/// </summary>
		private float _startPosX;
		/// <summary>
		/// Правая кооридната отрисовки авианоссца
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
		/// Ширина отрисовки авианоссца
		/// </summary>
		private readonly int shipWidth = 320;
		/// <summary>
		/// Высота отрисовки авианоссца
		/// </summary>
		private readonly int shipHeight = 90;
		/// <summary>
		/// Максимальная авианоссца
		/// </summary>
		public int MaxSpeed { private set; get; }
		/// <summary>
		/// Вес авианоссца
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
		/// Признак наличия передних пушек
		/// </summary>
		public bool FrontGun { private set; get; }
		/// <summary>
		/// Признак наличия посадочной площадки для вертолета
		/// </summary>
		public bool HelicopterStand { private set; get; }
		/// <summary>
		/// Признак наличия самолета на авианосце
		/// </summary>
		public bool Plane { private set; get; }
		/// <summary>
		/// Признак наличия взлетно-посадочной полосы
		/// </summary>
		public bool LandingStrip { private set; get; }
		/// <summary>
		/// Признак наличия спутникого локатора
		/// </summary>
		public bool SatelliteLocator { private set; get; }
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес авианоссца</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="dopColor">Дополнительный цвет</param>
		/// <param name="satelliteLocator">Признак наличия спутникого локатора</param>
		/// <param name="helicopterStand">Признак наличия вертолетной площадки</param>
		/// <param name="frontGun">Признак наличия передних пушек</param>
		/// <param name="plane">Признак наличия передних пушек</param>
		/// <param name="landingStrip">Признак наличия передних пушек</param>
		public Flattop(int maxSpeed, float weight, Color mainColor, Color dopColor, bool satelliteLocator, bool helicopterStand, bool frontGun, bool plane, bool landingStrip)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			SatelliteLocator = satelliteLocator;
			HelicopterStand = helicopterStand;
			FrontGun = frontGun;
			Plane = plane;
			LandingStrip = landingStrip;
		}
		/// <summary>
		/// Установка позиции авианосца
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
		/// Отрисовка авианосца
		/// </summary>
		/// <param name="g"></param>
		public void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			//границы авианосца
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
			//Кабина
			pen = new Pen(Color.Black);
			g.DrawEllipse(pen, _startPosX + 85, _startPosY + 60, 60, 30);
			br = new SolidBrush(Color.Gray);
			g.FillEllipse(br, _startPosX + 85, _startPosY + 60, 60, 30);
			//Условие наличия взлетно-посадочной полосы
			if (LandingStrip)
			{
				//Взлетно-посадочная полоса
				br = new SolidBrush(Color.Gray);
				g.FillRectangle(br, _startPosX, _startPosY + 30, 320, 30);
				//Полоса
				pen = new Pen(Color.White);
				PointF pointLine1 = new PointF(_startPosXtoInt, _startPosYtoInt + 45);
				PointF pointLine2 = new PointF(_startPosXtoInt + 320, _startPosYtoInt + 45);
				g.DrawLine(pen, pointLine1, pointLine2);
			}
			// рисуем передние пушки
			if (FrontGun)
			{
				//Левая пушка
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
				PointF[] gunSpritePoints = new PointF[xGun1Points.Length];
				for (int i = 0; i < xGun1Points.Length; i++)
				{
					gunSpritePoints[i] = new Point(xGun1Points[i], yGun1Points[i]);
				}
				g.DrawPolygon(pen, gunSpritePoints);
				br = new SolidBrush(DopColor);
				g.FillPolygon(br, gunSpritePoints);
				//правая пушка
				int[] xGun2Points = {
					_startPosXtoInt + 210,
					_startPosXtoInt + 290,
					_startPosXtoInt + 290
				};
				int[] yGun2Points = {
					_startPosYtoInt + 82,
					_startPosYtoInt + 82,
					_startPosYtoInt + 66
				};
				for (int i = 0; i < xGun1Points.Length; i++)
				{
					gunSpritePoints[i] = new Point(xGun2Points[i], yGun2Points[i]);
				}
				g.DrawPolygon(pen, gunSpritePoints);
				g.FillPolygon(br, gunSpritePoints);
			}
			//Условие наличия вертолетной площадки
			if (HelicopterStand)
			{
				br = new SolidBrush(Color.Black);
				g.FillEllipse(br, _startPosX + 30, _startPosY, 45, 45);
				pen = new Pen(Color.Black);
				g.DrawEllipse(pen, _startPosX + 30, _startPosY, 45, 45);
				g.DrawString("H", new Font("Arial", 24, FontStyle.Bold), Brushes.Yellow, _startPosX + 36, _startPosY + 5);
			}
			//Условие наличия спутникого локатора
			if (SatelliteLocator)
			{
				br = new SolidBrush(Color.White);
				g.FillEllipse(br, _startPosX + 30, _startPosY + 50, 45, 45);
				pen = new Pen(Color.Black);
				g.DrawEllipse(pen, _startPosX + 30, _startPosY + 50, 45, 45);
				g.DrawLine(pen, _startPosX + 37, _startPosY + 57, _startPosX + 68, _startPosY + 88);
				g.DrawLine(pen, _startPosX + 37, _startPosY + 88, _startPosX + 68, _startPosY + 57);
			}
			//Условие наличия самолета
			if (Plane)
			{
				int[] xPlanePoints = {
					_startPosXtoInt + 140,
					_startPosXtoInt + 140,
					_startPosXtoInt + 100,
					_startPosXtoInt + 125,
					_startPosXtoInt + 140
				};
				int[] yPlanePoints = {
					_startPosYtoInt + 35,
					_startPosYtoInt + 5,
					_startPosYtoInt + 15,
					_startPosYtoInt + 18,
					_startPosYtoInt + 35,
				};
				PointF[] planeSpritePoints = new PointF[xPlanePoints.Length];
				for (int i = 0; i < xPlanePoints.Length; i++)
				{
					planeSpritePoints[i] = new Point(xPlanePoints[i], yPlanePoints[i]);
				}
				g.DrawPolygon(pen, planeSpritePoints);
				br = new SolidBrush(DopColor);
				g.FillPolygon(br, planeSpritePoints);
			}
		}
	}
}
