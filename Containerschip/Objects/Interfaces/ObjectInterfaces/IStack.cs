using System.Collections.Generic;

namespace Objects.Interfaces.ObjectInterfaces
{
    public interface IStack : IEnumerable<IContainer>
    {
        bool Electricity { get; }
        bool HasValuable { get; }
        bool Check(IContainer container, List<IStack> stacksOnXAxis);
        int Weight { get; }
        int MaxWeight { get; }
        int TotalWeightOnLowestContainer { get; }
        int MaxWeightOnLowestContainer { get;  }
        int Height { get; }
        List<IContainer> ContainerCollection { get; }

        bool AddContainer(IContainer container, List<IStack> stacksOnXAxis);
    }
}
