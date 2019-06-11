using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme.Interfaces.ObjectInterfaces
{
    public interface IStack
    {
        bool Electricity { get; }
        int Weight { get; }
        int TotalWeightOnLowestContainer { get; }
        int Height { get; }
        List<IContainer> ContainerCollection { get; }

        void AddContainer(IContainer container);
    }
}
