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
	public class Flattop
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
		private readonly int carWidth = 100;
		/// <summary>
		/// Высота отрисовки автомобиля
		/// </summary>
		private readonly int carHeight = 60;
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
		/// Признак наличия переднего спойлера
		/// </summary>
		public bool FrontSpoiler { private set; get; }
		/// <summary>
		/// Признак наличия боковых спойлеров
		/// </summary>
		public bool SideSpoiler { private set; get; }
		/// <summary>
		/// Признак наличия заднего спойлера
		/// </summary>
		public bool BackSpoiler { private set; get; }
		/// <summary>
		/// Признак наличия гоночной полосы
		/// </summary>
		public bool SportLine { private set; get; }
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
		public Flattop(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontSpoiler, bool sideSpoiler, bool backSpoiler, bool sportLine)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			FrontSpoiler = frontSpoiler;
			SideSpoiler = sideSpoiler;
			BackSpoiler = backSpoiler;
			SportLine = sportLine;
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
			int[] xPoints = {
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
			int[] yPoints = { 
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

			PointF[] pointF = new PointF[12];
			for (int i = 0; i < 12; i++)
			{
				pointF[i] = new Point(xPoints[i], yPoints[i]);
			}
			g.DrawPolygon(pen, pointF);
			Brush br = new SolidBrush(Color.LightSlateGray);
			g.FillPolygon(br, pointF);
			br = new SolidBrush(Color.DarkGray);
			g.FillRectangle(br, _startPosX, _startPosY + 30, 320, 30);
			pen = new Pen(Color.Yellow);
			PointF pointLine1 = new PointF(_startPosXtoInt, _startPosYtoInt + 45);
			PointF pointLine2 = new PointF(_startPosXtoInt + 320, _startPosYtoInt + 45);
			g.DrawLine(pen, pointLine1, pointLine2);
			br = new SolidBrush(Color.Red);
			g.FillRectangle(br, _startPosX + 85, _startPosY + 60, 60, 30);
			br = new SolidBrush(Color.DarkGray);
			g.FillEllipse(br, _startPosX + 85, _startPosY + 60, 30, 30);
			// рисуем задний спойлер автомобиля
			/*if (BackSpoiler)
			{
				Brush spoiler = new SolidBrush(DopColor);
				g.FillRectangle(spoiler, _startPosX - 5, _startPosY, 10, 50);
				g.DrawRectangle(pen, _startPosX - 5, _startPosY, 10, 50);
			}*/
		}
	}
}
