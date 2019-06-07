using System.Collections.Generic;

namespace Algoritme.Interfaces.ObjectInterfaces
{
    public interface IShip
    {
        List<List<IStack>> StackMatrix { get; }
        int Width { get; }
        int Length { get; }

        void AddContainer(int x, int y);
    }
}
