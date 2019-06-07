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
        List<IContainer> ContainerCollection { get; }
    }
}
