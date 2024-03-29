﻿using Objects.Interfaces.ObjectInterfaces;
using System.Collections;
using System.Collections.Generic;

namespace Objects.Objects
{
    public class Stack : IStack
    {
        public List<IContainer> ContainerCollection { get; } = new List<IContainer>();

        public bool Electricity { get; }
        public bool HasValuable { get; private set; }
        public int MaxWeight { get; }
        public int MaxWeightOnLowestContainer { get; }

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
                if (ContainerCollection.Count > 1)
                {
                    for (int i = 1; i < ContainerCollection.Count; i++)
                    {
                        returnWeight += ContainerCollection[i].Weight;
                    }
                }

                return returnWeight;
            }
        }

        public Stack(int maxWeight, int maxWeightOnLowestContainer, bool electricity)
        {
            Electricity = electricity;
            MaxWeight = maxWeight;
            MaxWeightOnLowestContainer = maxWeightOnLowestContainer;
        }

        public bool AddContainer(IContainer container, List<IStack> stacksOnXAxis)
        {
            if (Check(container, stacksOnXAxis))
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

        public bool Check(IContainer container, List<IStack> stacksOnXAxis)
        {
            if (HasValuable)
                return false;

            if (TotalWeightOnLowestContainer + container.Weight > MaxWeightOnLowestContainer)
                return false;

            if (Weight + container.Weight > MaxWeight)
                return false;

            return container.Check(this, stacksOnXAxis);
        }

        public int Height => ContainerCollection.Count;

        IEnumerator<IContainer> IEnumerable<IContainer>.GetEnumerator()
        {
            return ContainerCollection.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return ContainerCollection.GetEnumerator();
        }
    }
}
