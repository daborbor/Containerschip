using System.Collections.Generic;
using Objects.Interfaces.ObjectInterfaces;

namespace Objects.Objects.Ship.ShipLogica
{
    internal static class GetStackLogic
    {
        public static List<IStack> GetStack(List<List<IStack>> stackMatrix)
        {
            List<IStack> returnList = new List<IStack>();
            foreach (List<IStack> stacks in stackMatrix)
            {
                foreach (IStack stack in stacks)
                {
                    returnList.Add(stack);
                }
            }

            return returnList;
        }

        public static List<IStack> GetStackOnXAxisByStack(List<List<IStack>> stackMatrix,IStack stack)
        {
            for (int i = 0; i <= stackMatrix.Count; i++)
            {
                if (stackMatrix[i].IndexOf(stack) != -1)
                {
                    return stackMatrix[i];
                }
            }

            return null;
        }
    }
}
