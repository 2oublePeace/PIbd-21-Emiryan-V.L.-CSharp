using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattopGame
{
	class Flattop : ArmyShip
	{
		/// <summary>
		/// Дополнительный цвет
		/// </summary>
		public Color DopColor { private set; get; }
		/// <summary>
		/// Признак наличия передних пушек
		/// </summary>
		public bool FrontGun { private set; get; }
		/// <summary>
		/// Признак наличия вертолетной площадки
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
		/// <param name="weight">Вес авианосца</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="dopColor">Дополнительный цвет</param>
		/// <param name="FrontGun">Признак наличия передних пушек</param>
		/// <param name="HelicopterStand">Признак наличия вертолетной площадки</param>
		/// <param name="SatelliteLocator">Признак наличия спутникого локатора</param>
		public Flattop(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontGun, bool hellicopterStand, bool satelliteLocator) : base(maxSpeed, weight, mainColor, 100, 60)
		{
			DopColor = dopColor;
			FrontGun = frontGun;
			HelicopterStand = hellicopterStand;
			SatelliteLocator = satelliteLocator;
		}
		public override void DrawTransport(Graphics g)
		{
			int _startPosXtoInt = (int)_startPosX;
			int _startPosYtoInt = (int)_startPosY;
			Pen pen = new Pen(Color.Black);
			Brush dopBrush = new SolidBrush(DopColor);
			g.FillRectangle(dopBrush, _startPosX, _startPosY + 30, 320, 30);
			// отрисуем сперва передние пушки авианосца (чтобы потом отрисовка авианосца на него "легла")
			base.DrawTransport(g);
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
				dopBrush = new SolidBrush(DopColor);
				g.FillPolygon(dopBrush, gunSpritePoints);
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
				g.FillPolygon(dopBrush, gunSpritePoints);
			}
			if (HelicopterStand)
			{
				dopBrush = new SolidBrush(Color.Black);
				g.FillEllipse(dopBrush, _startPosX + 30, _startPosY, 45, 45);
				pen = new Pen(Color.Black);
				g.DrawEllipse(pen, _startPosX + 30, _startPosY, 45, 45);
				g.DrawString("H", new Font("Arial", 24, FontStyle.Bold), Brushes.Yellow, _startPosX + 36, _startPosY + 5);
			}
			if (SatelliteLocator)
			{
				dopBrush = new SolidBrush(Color.White);
				g.FillEllipse(dopBrush, _startPosX + 30, _startPosY + 50, 45, 45);
				pen = new Pen(Color.Black);
				g.DrawEllipse(pen, _startPosX + 30, _startPosY + 50, 45, 45);
				g.DrawLine(pen, _startPosX + 37, _startPosY + 57, _startPosX + 68, _startPosY + 88);
				g.DrawLine(pen, _startPosX + 37, _startPosY + 88, _startPosX + 68, _startPosY + 57);
			}
		}
	}
}
