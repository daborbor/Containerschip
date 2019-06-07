using Algoritme.Interfaces.ObjectInterfaces;
using System.Collections.Generic;

namespace Algoritme.Objects
{
    public class Stack : IStack
    {
        public List<IContainer> ContainerCollection { get; }
        public bool Electricity { get; }
        public int Weight { get; }

        public int TotalWeightOnLowestContainer
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

        public int Height => ContainerCollection.Count;
    }
}
