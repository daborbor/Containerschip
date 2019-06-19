using Objects.Interfaces.ObjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Algoritme.AlgoritmeLogica;

namespace Algoritme.Algoritme
{
    public class AlgoritmeVerloop
    {
        private int _minX;
        private int _maxX;

        public List<IContainer> PlaatsContainers(IShip ship, List<IContainer> containerCollection)
        {
            if (ship == null) throw new ArgumentNullException(nameof(ship));
            if (containerCollection == null) throw new ArgumentNullException(nameof(containerCollection));

            containerCollection = containerCollection.OrderBy(o => o.Valuable).ThenByDescending(o => o.Electricity).ToList();
            bool containerGeplaatst = true;
            _minX = 0;
            _maxX = ship.WidthX;
            while (containerGeplaatst && containerCollection.Count != 0)
            {
                foreach (IContainer container in containerCollection)
                {
                    List<IStack> stackList = ship.GetStack().OrderBy(o => o.Height).ToList(); //de stacks van laag naar hoog sorteren, zo plaatsen we altijd containers op de laagste plek
                    containerGeplaatst = false;
                    foreach (IStack stack in stackList)
                    {
                        if (stack.AddContainer(container, ship.GetStackOnXAxisByStack(stack)))
                        {
                            containerCollection.Remove(container);
                            containerGeplaatst = true;
                            break;
                        }
                    }

                    if (containerGeplaatst)
                        break;
                }

                Tuple<int, int, bool> tuple = DetermineXRangePlacment.XRange(ship, containerGeplaatst, _minX, _maxX);
                _minX = tuple.Item1;
                _maxX = tuple.Item2;
                containerGeplaatst = tuple.Item3;
            }

            return containerCollection;
        }
    }
}
