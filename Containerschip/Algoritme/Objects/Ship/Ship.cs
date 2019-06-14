using System;
using System.Collections.Generic;
using Algoritme.Interfaces.ObjectInterfaces;

namespace Algoritme.Objects.Ship
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

        public float GewichtLinks()
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

            returnWeight += gewichtMidden() / 2;
            return returnWeight;
        }

        private float gewichtMidden()
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

        public float GewichtRechts()
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

            returnWeight += gewichtMidden() / 2;
            return returnWeight;
        }

        public void AddContainer(int width, int length, IContainer container)
        {
            StackMatrix[width][length].AddContainer(container, StackMatrix[width]);
        }

        public List<IStack> GetStack()
        {
            List<IStack> returnList = new List<IStack>();
            foreach (List<IStack> stacks in StackMatrix)
            {
                foreach (IStack stack in stacks)
                {
                    returnList.Add(stack);
                }
            }

            return returnList;
        }

        public List<IStack> GetStackOnXAxisByStack(IStack stack)
        {
            for (int i = 0; i <= StackMatrix.Count; i++)
            {
                if (StackMatrix[i].IndexOf(stack) != -1)
                {
                    return StackMatrix[i];
                }
            }

            return null;
        }

        public List<List<IStack>> GetList()
        {
            return StackMatrix;
        }
    }
}
