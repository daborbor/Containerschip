using Algoritme.Interfaces.ObjectInterfaces;
using System;
using System.Collections.Generic;

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
                if (i == 0)
                {
                    StackMatrix.Add(new List<IStack>(Length));
                }
                StackMatrix.Add(new List<IStack>(Length));
            }

            foreach (List<IStack> stackColletion in StackMatrix)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (i == 0)
                    {
                        stackColletion.Add(new Stack(true));
                    }
                    else
                    {
                        stackColletion.Add(new Stack(false));
                    }
                }
            }
        }

        public float _gewichtLinks()
        {
            float returnWeight = 0;
            int leftHalf = (int)Math.Floor((decimal)Width / 2);
            for (int i = 0; i != leftHalf; i++)
            {
                foreach (IStack stack in StackMatrix[i])
                {
                    returnWeight += stack.Weight;
                }
            }

            returnWeight += _gewichtMidden() / 2;
            return returnWeight;
        }

        private float _gewichtMidden()
        {
            int returnWeight = 0;
            if (Width % 2 != 0)
            {
                int middle = (int)Math.Round((decimal)Width / 2);
                foreach (IStack stack in StackMatrix[middle])
                {
                    returnWeight += stack.Weight;
                }
            }
            return returnWeight;
        }

        public float _gewichtRechts()
        {
            float returnWeight = 0;
            int rightHalf = (int)Math.Floor((decimal)Width / 2);
            for (int i = 0; i != rightHalf; i++)
            {
                foreach (IStack stack in StackMatrix[i+rightHalf])
                {
                    returnWeight += stack.Weight;
                }
            }

            returnWeight += _gewichtMidden() / 2;
            return returnWeight;
        }

        public void AddContainer(int width, int length, IContainer container)
        {
            StackMatrix[width][length].AddContainer(container);
        }
    }
}
