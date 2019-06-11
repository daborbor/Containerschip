using Algoritme.Interfaces.ObjectInterfaces;
using System.Collections.Generic;

namespace Algoritme.Objects
{
    public class Stack : IStack
    {
        public readonly List<IContainer> ContainerCollection { get; }

        public bool Electricity { get; }

        public Stack(bool electricity)
        {
            Electricity = electricity;
        }

        public int Weight
        {
            get
            {
                int returnWeight = 0;
                foreach (IContainer container in ContainerCollection)
                {
                    returnWeight += container.Weight;
                }

                return returnWeight;
            }
        }

        public int TotalWeightOnLowestContainer
        {
            get
            {
                int returnWeight = 0;
                List<IContainer> containerCollection = ContainerCollection;
                containerCollection.RemoveAt(0);
                foreach (IContainer container in containerCollection)
                {
                    returnWeight += container.Weight;
                }

                return returnWeight;
            }
        }

        public void AddContainer(IContainer container)
        {
            ContainerCollection.Add(container);
        }

        public int Height => ContainerCollection.Count;
    }
}
