using System.Collections.Generic;

namespace Algoritme.Interfaces.ObjectInterfaces
{
    public interface IShip
    {
        int WidthX { get; }
        int LengthY { get; }

        void AddContainer(int x, int y, IContainer container);
    }
}
