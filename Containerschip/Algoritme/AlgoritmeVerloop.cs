using Algoritme.Interfaces.ObjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritme
{
    public class AlgoritmeVerloop
    {
        private readonly bool _isOdd = false;
        private int minX;
        private int maxX;
        public List<IContainer> PlaatsContainers(IShip ship, List<IContainer> containerCollection)
        {
            containerCollection = containerCollection.OrderByDescending(o => o.Weight).ThenBy(o=>o.Valuable).ToList();
            if (ship.GewichtLinks() <= ship.GewichtRechts())
            {
                minX = 0;
                maxX = (int)Math.Floor((decimal)(ship.WidthX / 2));
            }
            else
            {
                minX = (int)Math.Floor((decimal)(ship.WidthX / 2));
                maxX = ship.WidthX;
            }

            bool containerGeplaatsts = false;

            foreach (IContainer container in containerCollection)
            {
                containerGeplaatsts = true;
                List<IStack> stackList = ship.GetStack().OrderBy(o => o.Height).ToList();
                foreach (IStack stack in stackList)
                {
                    if (stack.AddContainer(container, ship.GetStackOnXAxisByStack(stack)))
                    {
                        containerCollection.Remove(container);
                        containerGeplaatsts = true;
                        break;
                    }
                }

                if (!containerGeplaatsts)
                    break;
            }

            return containerCollection;
        }
    }
}
