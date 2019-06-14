using Algoritme.Interfaces.ObjectInterfaces;
using System;
using System.Collections.Generic;

namespace Algoritme.Objects
{
    public class StandardContainer : IContainer
    {
        public int Weight { get; }
        public bool Electricity { get; }
        public bool Valuable { get; }

        public StandardContainer(int weight)
        {
            if (weight < 1)
            {
                throw new ArgumentOutOfRangeException($"Gewicht ({weight}) mag niet kleiner dan 1 zijn");
            }

            Weight = weight;
            Electricity = false;
            Valuable = false;
        }

        public StandardContainer(int weight, bool electricity, bool valuable)
        {
            if (weight < 1)
            {
                throw new ArgumentOutOfRangeException($"Gewicht ({weight}) mag niet kleiner dan 1 zijn");
            }

            Weight = weight;
            Electricity = electricity;
            Valuable = valuable;
        }

        public bool Check(IStack stack, List<IStack> stacksOnXAxis)
        {
            int stackY = stacksOnXAxis.IndexOf(stack);
            int stackZ = stack.ContainerCollection.Count - 1;

            if (Electricity && !stack.Electricity)//Elektriciteit check
                return false;

            if (Valuable && !checkIfValuableCanBePlaced(stack, stacksOnXAxis, stackY)) //als de container valuable is moet er gekeken worden of ie uberhaupt geplaatst kan worden zonder dat de ingangen/ingangen van andere containers geblokkeerd zijn
                return false;

            //als nergens een bezwaar is mag de container erop
            return true;
        }

        public override string ToString()
        {
            string props = "";
            if (Valuable)
                props += "waardevol, ";

            if (Electricity)
                props += "elektrisch, ";

            return $"{Weight}, {props}";
        }

        private int checkNumberOfFreeEntrances(IStack stack, List<IStack> stacksOnXAxis, int stackY)
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

        private bool checkIfValuableCanBePlaced(IStack stack, List<IStack> stacksOnXAxis, int stackY)
        {
            int containerZAxis = stack.Height + 1;
            int unblockedEntrances = checkNumberOfFreeEntrances(stack, stacksOnXAxis, stackY); //aantal vrije ingangen ophalen
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
                            if (checkNumberOfFreeEntrances(stack, stacksOnXAxis, stackY - 1) != 2)
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
                            if (checkNumberOfFreeEntrances(stack, stacksOnXAxis, stackY + 1) != 2)
                                return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
