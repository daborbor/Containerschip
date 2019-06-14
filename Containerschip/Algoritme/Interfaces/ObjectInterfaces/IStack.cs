using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme.Interfaces.ObjectInterfaces
{
    public interface IStack : IEnumerable<IContainer>
    {
        bool Electricity { get; }
        bool HasValuable { get; }
        bool Check(IContainer container, List<IStack> stacksOnXAxis);
        int Weight { get; }
        int TotalWeightOnLowestContainer { get; }
        int MaxWeightOnLowestContainer { get;  }
        int Height { get; }
        List<IContainer> ContainerCollection { get; }

        bool AddContainer(IContainer container, List<IStack> stacksOnXAxis);
    }
}
