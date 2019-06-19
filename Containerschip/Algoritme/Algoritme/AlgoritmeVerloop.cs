using Objects.Interfaces.ObjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Algoritme.AlgoritmeLogica;

namespace Algoritme.Algoritme
{
    public class AlgoritmeVerloop
    {
        private int minX;
        private int maxX;

        public List<IContainer> PlaatsContainers(IShip ship, List<IContainer> containerCollection)
        {
            if (ship == null) throw new ArgumentNullException(nameof(ship));
            if (containerCollection == null) throw new ArgumentNullException(nameof(containerCollection));

            containerCollection = containerCollection.OrderBy(o => o.Valuable).ThenByDescending(o => o.Electricity).ToList();
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

                Tuple<int, int, bool> tuple = DetermineXRangePlacment.XRange(ship, containerGeplaatsts, minX, maxX);
                minX = tuple.Item1;
                maxX = tuple.Item2;
                containerGeplaatsts = tuple.Item3;
            }

            return containerCollection;
        }
    }
}
