using Algoritme.Interfaces.ObjectInterfaces;
using System.Collections.Generic;

namespace Algoritme.Objects
{
    internal class Stack : IStack
    {
        public bool Electricity { get; }
        public List<IContainer> ContainerCollection { get; }
    }
}
