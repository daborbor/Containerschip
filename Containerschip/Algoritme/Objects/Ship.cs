using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritme.Interfaces.ObjectInterfaces;

namespace Algoritme.Objects
{
    public class Ship : IShip
    {
        public List<List<IStack>> StackMatrix { get; }
        public int Width { get; }
        public int Length { get; }

        public Ship(int width, int length)
        {
            Width = width;
            Length = length;
            for (int i = 0; i < Width; i++)
            {
                StackMatrix.Add(new List<IStack>(Length));
            }

            foreach (List<IStack> stackColletion in StackMatrix)
            {
                for (int i = 0; i < Length; i++)
                {
                    stackColletion.Add(new Stack());
                }
            }
        }

        public void AddContainer(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
