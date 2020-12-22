using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattopGame
{
	class ShipComparer : IComparer<Vehicle>
	{
		public int Compare(Vehicle x, Vehicle y)
		{
            if (x is Flattop && y is Flattop)
            {
                return ComparerFlattop((Flattop)x, (Flattop)y);
            }
            if (x is Flattop && y is ArmyShip)
            {
                return -1;
            }
            if (x is ArmyShip && y is Flattop)
            {
                return 1;
            }
            if (x is ArmyShip && y is ArmyShip)
            {
                return ComparerArmyShip((ArmyShip)x, (ArmyShip)y);
            }
            return 0;
        }

        private int ComparerArmyShip(ArmyShip x, ArmyShip y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerFlattop(Flattop x, Flattop y)
        {
            var res = ComparerArmyShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.HelicopterStand != y.HelicopterStand)
            {
                return x.HelicopterStand.CompareTo(y.HelicopterStand);
            }
            if (x.FrontGun != y.FrontGun)
            {
                return x.FrontGun.CompareTo(y.FrontGun);
            }
            if (x.SatelliteLocator != y.SatelliteLocator)
            {
                return x.SatelliteLocator.CompareTo(y.SatelliteLocator);
            }
            if (x.LandingStrip != y.LandingStrip)
            {
                return x.LandingStrip.CompareTo(y.LandingStrip);
            }
            if (x.Plane != y.Plane)
            {
                return x.Plane.CompareTo(y.Plane);
            }
            return 0;
        }
    }
}
