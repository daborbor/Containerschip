using System;
using System.Collections.Generic;
using Objects.Interfaces.ObjectInterfaces;

namespace Objects.Objects.Ship.ShipLogica
{
    internal static class WeightDistributionLogic
    {
        public static float GewichtLinks(List<List<IStack>> StackMatrix)
        {
            float returnWeight = 0;
            int leftHalf = (int)Math.Floor((decimal)StackMatrix.Count / 2);
            for (int i = 0; i != leftHalf; i++)
            {
                foreach (IStack stack in StackMatrix[i])
                {
                    returnWeight += stack.Weight;
                }
            }

            returnWeight += gewichtMidden(StackMatrix) / 2;
            return returnWeight;
        }

        private static float gewichtMidden(List<List<IStack>> StackMatrix)
        {
            int returnWeight = 0;
            if (StackMatrix.Count % 2 != 0)
            {
                int middle = (int)Math.Round((decimal)StackMatrix.Count / 2);
                foreach (IStack stack in StackMatrix[middle])
                {
                    returnWeight += stack.Weight;
                }
            }
            return returnWeight;
        }

        public static float GewichtRechts(List<List<IStack>> StackMatrix)
        {
            float returnWeight = 0;
            int rightHalf = (int)Math.Floor((decimal)StackMatrix.Count / 2);
            for (int i = 0; i != rightHalf; i++)
            {
                foreach (IStack stack in StackMatrix[i + rightHalf])
                {
                    returnWeight += stack.Weight;
                }
            }

            returnWeight += gewichtMidden(StackMatrix) / 2;
            return returnWeight;
        }
    }
}
