using Algoritme.Interfaces.ObjectInterfaces;
using System.Collections.Generic;

namespace Algoritme.Objects
{
    public class Stack : IStack
    {
        public List<IContainer> ContainerCollection { get; } = new List<IContainer>();

        public bool Electricity { get; }
        public bool HasValuable { get; private set; }

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

        public bool AddContainer(IContainer container, List<IStack> stacksOnXAxis)
        {
            if (HasValuable)
                return false;

            if (TotalWeightOnLowestContainer + container.Weight > 120)
                return false;

            bool containerCheck = container.Check(this, stacksOnXAxis);
            if (containerCheck)
            {
                ContainerCollection.Add(container);
                if (container.Valuable)
                {
                    HasValuable = true;
                }
                return true;
            }

            return false;
        }

        public int Height => ContainerCollection.Count;
    }
}
