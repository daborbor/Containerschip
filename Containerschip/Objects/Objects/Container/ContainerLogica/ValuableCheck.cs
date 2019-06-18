using System.Collections.Generic;
using Objects.Interfaces.ObjectInterfaces;

namespace Objects.Objects.Container.ContainerLogica
{
    internal static class ValuableCheck
    {
        public static bool CheckIfValuableCanBePlaced(IStack stack, List<IStack> stacksOnXAxis, int stackY)
        {
            int containerZAxis = stack.Height + 1;
            int unblockedEntrances = CheckEntrances.CheckNumberOfFreeEntrances(stack, stacksOnXAxis, stackY); //aantal vrije ingangen ophalen
            if (unblockedEntrances == 0)
            {
                return false;
            }
            else if (unblockedEntrances == 1)
            {
                if (stackY > 0) //checken of dit niet de eerste rij is en of de rij ervoor wel zo'n hoge containers heeft
                {
                    IStack stackOnXAxisBehind = stacksOnXAxis[stackY - 1];
                    if (stackOnXAxisBehind.Height > stack.Height && containerZAxis <= stackOnXAxisBehind.Height)
                    {
                        if (stackOnXAxisBehind.ContainerCollection[containerZAxis - 1].Valuable)//checken of de enige ingang van een waardevolle container achter niet geblokkeerd word
                        {
                            if (CheckEntrances.CheckNumberOfFreeEntrances(stack, stacksOnXAxis, stackY - 1) != 2)
                                return false;
                        }
                    }
                }

                if (stackY < stacksOnXAxis.Count - 1) //checken of het niet de laatste rij is en of de rij erna wel zo'n hoge containers heeft
                {
                    IStack stackOnXAxisInFront = stacksOnXAxis[stackY + 1];
                    if (stackOnXAxisInFront.Height >= stack.Height && containerZAxis <= stackOnXAxisInFront.Height)
                    {
                        if (stackOnXAxisInFront.ContainerCollection[containerZAxis - 1].Valuable) //checken of de enige ingang van een waardevolle container achter niet geblokkeerd word
                        {
                            if (CheckEntrances.CheckNumberOfFreeEntrances(stack, stacksOnXAxis, stackY + 1) != 2)
                                return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
