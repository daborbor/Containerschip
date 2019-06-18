using System.Collections.Generic;
using Objects.Interfaces.ObjectInterfaces;

namespace Objects.Objects.Container.ContainerLogica
{
    internal static class CheckEntrances
    {
        public static int CheckNumberOfFreeEntrances(IStack stack, List<IStack> stacksOnXAxis, int stackY)
        {
            int unblockedEntrances = 2;

            if (stackY > 0) //checken of het niet de eerste rij is
            {
                if (stacksOnXAxis[stackY - 1].Height > stack.Height)
                    unblockedEntrances--;
            }
            if (stackY != stacksOnXAxis.Count - 1)//checken of het niet de laatste rij is
            {
                if (stacksOnXAxis[stackY + 1].Height > stack.Height)
                    unblockedEntrances--;
            }

            return unblockedEntrances;
        }
    }
}
