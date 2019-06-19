using Objects.Interfaces.ObjectInterfaces;
using Objects.Objects.Ship.ShipLogica;
using System.Collections.Generic;

namespace Objects.Objects.Ship
{
    public class Ship : IShip
    {
        private List<List<IStack>> StackMatrix { get; }
        public int WidthX { get; }
        public int LengthY { get; }
        public float GewichtLinks() => WeightDistributionLogic.GewichtLinks(StackMatrix);
        public float GewichtRechts() => WeightDistributionLogic.GewichtRechts(StackMatrix);
        public List<IStack> GetStack() => GetStackLogic.GetStack(StackMatrix);
        public List<IStack> GetStackOnXAxisByStack(IStack stack) => GetStackLogic.GetStackOnXAxisByStack(StackMatrix, stack);
        public List<List<IStack>> GetList() => StackMatrix;

        public int Weight
        {
            get
            {
                int returnWeight = 0;
                foreach (List<IStack> list in StackMatrix)
                {
                    foreach (IStack stack in list)
                    {
                        returnWeight += stack.Weight;
                    }
                }
                return returnWeight;
            }
        }

        public int MaxWeight
        {
            get
            {
                int maxWeight = 0;
                foreach (List<IStack> list in StackMatrix)
                {
                    foreach (IStack stack in list)
                    {
                        maxWeight += stack.MaxWeight;
                    }
                }

                return maxWeight;
            }
        }

        public Ship(int widthX, int lengthY, int maxWeightOnStack, int maxWeightOnLowestContainer, List<int> electricityList)
        {
            StackMatrix = new List<List<IStack>>();
            WidthX = widthX;
            LengthY = lengthY;
            for (int i = 0; i < WidthX; i++)
            {
                StackMatrix.Add(new List<IStack>(LengthY));
            }

            foreach (List<IStack> stackCollection in StackMatrix)
            {
                for (int i = 0; i < LengthY; i++)
                {
                    if (electricityList.Contains(i))
                    {
                        stackCollection.Add(new Stack(maxWeightOnStack, maxWeightOnLowestContainer,true));
                    }
                    else
                    {
                        stackCollection.Add(new Stack(maxWeightOnStack, maxWeightOnLowestContainer, false));
                    }
                }
            }
        }

        public void AddContainer(int x, int y, IContainer container)
        {
            StackMatrix[x][y].AddContainer(container, StackMatrix[x]);
        }
    }
}
