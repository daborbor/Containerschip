using Objects.Interfaces.ObjectInterfaces;
using System;

namespace Algoritme.AlgoritmeLogica
{
    internal static class DetermineXRangePlacment
    {
        public static Tuple<int, int, bool> XRange(IShip ship, bool containerGeplaatsts, int minX, int maxX)
        {
            if ((!containerGeplaatsts && minX != 0) || maxX != ship.WidthX)
            {
                minX = 0;
                maxX = ship.WidthX;
                containerGeplaatsts = true;
            }
            else if (ship.GewichtLinks() <= ship.GewichtRechts())
            {
                minX = 0;
                maxX = (int)Math.Floor((decimal)(ship.WidthX / 2));
            }
            else
            {
                minX = (int)Math.Floor((decimal)(ship.WidthX / 2));
                maxX = ship.WidthX;
            }
            return new Tuple<int, int, bool>(minX, maxX, containerGeplaatsts);
        }
    }
}
