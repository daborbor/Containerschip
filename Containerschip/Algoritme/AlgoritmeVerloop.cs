using Algoritme.Interfaces.ObjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritme
{
    public class AlgoritmeVerloop
    {
        private int minX;
        private int maxX;

        public List<IContainer> PlaatsContainers(IShip ship, List<IContainer> containerCollection)
        {
            if (ship == null) throw new ArgumentNullException(nameof(ship));
            if (containerCollection == null) throw new ArgumentNullException(nameof(containerCollection));

            //containerCollection = containerCollection.OrderByDescending(o => o.Weight).ThenByDescending(o => o.Valuable).ToList();
            containerCollection = containerCollection.OrderBy(o => o.Valuable).ThenByDescending(o=>o.Electricity).ToList();
            bool containerGeplaatsts = true;
            minX = 0;
            maxX = ship.WidthX;
            while (containerGeplaatsts && containerCollection.Count != 0)
            {
                foreach (IContainer container in containerCollection)
                {
                    containerGeplaatsts = false;
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

                    if (containerGeplaatsts)
                        break;
                }

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
            }

            return containerCollection;
        }
    }
}
