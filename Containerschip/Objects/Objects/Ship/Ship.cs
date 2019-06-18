using System.Collections.Generic;
using Objects.Interfaces.ObjectInterfaces;
using Objects.Objects.Ship.ShipLogica;

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

        public Ship(int widthX, int lengthY)
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
                    if (i == 0)
                    {
                        stackCollection.Add(new Stack(true));
                    }
                    else
                    {
                        stackCollection.Add(new Stack(false));
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
