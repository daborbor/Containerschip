using Algoritme.Interfaces.ObjectInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algoritme.Objects
{
    public class Ship : IShip
    {
        private List<List<IStack>> StackMatrix { get; }
        public int WidthX { get; }
        public int LengthY { get; }

        public Ship(int widthX, int lengthY)
        {
            StackMatrix = new List<List<IStack>>();
            WidthX = widthX;
            LengthY = lengthY;
            for (int i = 0; i < WidthX; i++)
            {
                StackMatrix.Add(new List<IStack>(LengthY));
            }

            foreach (List<IStack> stackColletion in StackMatrix)
            {
                for (int i = 0; i < LengthY; i++)
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
            int leftHalf = (int)Math.Floor((decimal)WidthX / 2);
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
            if (WidthX % 2 != 0)
            {
                int middle = (int)Math.Round((decimal)WidthX / 2);
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
            int rightHalf = (int)Math.Floor((decimal)WidthX / 2);
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
            StackMatrix[width][length].AddContainer(container, StackMatrix[width]);
        }

        public List<List<IStack>> GetList()
        {
            return StackMatrix;
        }
    }
}
