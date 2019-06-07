using System;
using Algoritme.Interfaces.ObjectInterfaces;

namespace Algoritme.Objects
{
    public class Container : IContainer
    {
        public int Weight { get; }
        public bool Check(IStack stack)
        {
            throw new System.NotImplementedException();
        }

        public Container(int weight)
        {
            if (weight < 1)
            {
                throw new ArgumentOutOfRangeException(string.Format("Gewicht ({0}) mag niet kleiner dan 1 zijn", "ARG0"));
            }

            Weight = weight;
        }
    }
}
