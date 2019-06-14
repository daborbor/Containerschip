using System.Collections.Generic;
using Algoritme.Objects;

namespace Algoritme.Interfaces.ObjectInterfaces
{
    public interface IShip
    {
        int WidthX { get; }
        int LengthY { get; }
        float GewichtLinks();
        float GewichtRechts();
        void AddContainer(int x, int y, IContainer container);
        List<IStack> GetStack();
        List<IStack> GetStackOnXAxisByStack(IStack stack);
        List<List<IStack>> GetList();
    }
}
