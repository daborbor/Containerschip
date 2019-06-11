using System;
using Algoritme.Interfaces.ObjectInterfaces;

namespace Algoritme.Objects
{
    public class StandardContainer : IContainer
    {
        public int Weight { get; }
        public bool Electricity { get; }

        public StandardContainer(int weight)
        {
            if (weight < 1)
            {
                throw new ArgumentOutOfRangeException($"Gewicht ({weight}) mag niet kleiner dan 1 zijn");
            }
            
            Weight = weight;
        }

        public bool Check(IStack stack)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Gewicht " + Weight.ToString();
        }
    }
}
