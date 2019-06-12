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
            int stackZ = stack.ContainerCollection.Count;

            if (Electricity && stack.Electricity == false)//Elektriciteit check
                return false;
            
            if (Valuable && checkIfValuableCanBePlaced(stack, stacksOnXAxis, stackY, stackZ) == false) //als de container valuable is moet er gekeken worden of ie uberhaupt geplaatst kan worden zonder dat de ingangen/ingangen van andere containers geblokkeerd zijn
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

            return $"Gewicht {Weight} {props}";
        }

        private int checkNumberOffFreeEntrances(IStack stack, List<IStack> stacksOnXAxis, int stackY, int stackZ)
        {
            int unblockedEntrances = 0;
            if (stacksOnXAxis[stackY - 1].ContainerCollection[stackZ] == null) //check of achter vrij is
                unblockedEntrances++;

            if (stacksOnXAxis[stackY + 1].ContainerCollection[stackZ] == null) //check of voor vrij is
                unblockedEntrances++;

            return unblockedEntrances;
        }

        private bool checkIfValuableCanBePlaced(IStack stack, List<IStack> stacksOnXAxis, int stackY, int stackZ)
        {
            int unblockedEntrances = checkNumberOffFreeEntrances(stack, stacksOnXAxis, stackY, stackZ); //aantal vrije ingangen ophalen
            if (unblockedEntrances == 0)
            {
                return false;
            }

            if (unblockedEntrances == 1)
            {
                if (stacksOnXAxis[stackY - 1].ContainerCollection[stackZ].Valuable)
                {
                    //checken of de enige ingang van een waardevolle container achter niet geblokkeerd word
                    if (checkNumberOffFreeEntrances(stack, stacksOnXAxis, stackY - 1, stackZ) != 2)
                        return false;
                }
                else if (stacksOnXAxis[stackY + 1].ContainerCollection[stackZ].Valuable)
                {
                    //checken of de enige ingang van een waardevolle container achter niet geblokkeerd word
                    if (checkNumberOffFreeEntrances(stack, stacksOnXAxis, stackY + 1, stackZ) != 2)
                        return false;
                }

            }
            return true;
        }
    }
}
