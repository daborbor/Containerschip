using System;
using System.Collections.Generic;
using Objects.Interfaces.ObjectInterfaces;
using Objects.Objects.Container.ContainerLogica;

namespace Objects.Objects.Container
{
    public class Container : IContainer
    {
        public int Weight { get; }
        public bool Electricity { get; }
        public bool Valuable { get; }

        public Container(int weight, bool electricity, bool valuable)
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

            if (Electricity && !stack.Electricity)//Elektriciteit check
                return false;

            if (Valuable && !ValuableCheck.CheckIfValuableCanBePlaced(stack, stacksOnXAxis, stackY)) //als de container valuable is moet er gekeken worden of ie uberhaupt geplaatst kan worden zonder dat de ingangen/ingangen van andere containers geblokkeerd zijn
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
    }
}
