using System.Collections.Generic;

namespace Algoritme.Interfaces.ObjectInterfaces
{
    public interface IContainer
    {
        int Weight { get; }
        bool Check(IStack stack, List<IStack> stacksOnYAxis);
        bool Electricity { get; }
        bool Valuable { get; }
        string ToString();

    }
}
