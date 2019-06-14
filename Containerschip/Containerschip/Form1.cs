using Algoritme;
using Algoritme.Interfaces.ObjectInterfaces;
using Algoritme.Objects;
using Algoritme.Objects.Ship;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Containerschip
{
    public partial class Form1 : Form
    {
        private readonly Random r = new Random();
        private Ship ship;
        private readonly List<ListBox> listboxList = new List<ListBox>();
        private readonly List<Label> stackInfoLabelList = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            int weight = Convert.ToInt32(nudContainerWeight.Value);
            try
            {
                lbContainer.Items.Add(new StandardContainer(weight, false, cbWaardevol.Checked));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void butMakeShip_Click(object sender, EventArgs e)
        {
            foreach (ListBox listBox in listboxList)
            {
                Controls.Remove(listBox);
            }

            foreach (Label label in stackInfoLabelList)
            {
                Controls.Remove(label);
            }
            listboxList.Clear();
            ship = new Ship((int)nudX.Value, (int)nudY.Value);
            List<List<IStack>> shipList = ship.GetList();
            foreach (List<IStack> stackList in shipList)
            {
                foreach (IStack stack in stackList)
                {
                    int x = shipList.IndexOf(stackList);
                    int y = stackList.IndexOf(stack);
                    ListBox listBox = new ListBox
                    {
                        Width = 70,
                        Height = 40,
                        Left = 150 + (x * 80),
                        Top = y * 45,
                        Name = $"{x},{y}"
                    };
                    listboxList.Add(listBox);
                }
            }

            foreach (ListBox listBox in listboxList)
            {
                Controls.Add(listBox);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudRandom.Value; i++)
            {
                int weight = r.Next(4000, 30000);
                bool electricity = 0.1 > r.NextDouble();
                bool valuable = 0.1 > r.NextDouble();
                lbContainer.Items.Add(new StandardContainer(weight, electricity, valuable));
            }
        }

        private void btnSorteer_Click(object sender, EventArgs e)
        {
            foreach (ListBox listBox in listboxList)
            {
                Controls.Remove(listBox);
            }

            foreach (Label label in stackInfoLabelList)
            {
                Controls.Remove(label);
            }
            listboxList.Clear();
            AlgoritmeVerloop algoritmeVerloop = new AlgoritmeVerloop();
            List<IContainer> containerList = new List<IContainer>();
            foreach (IContainer containerItem in lbContainer.Items)
            {
                containerList.Add(containerItem);
            }
            lbContainer.Items.Clear();
            List<IContainer> restContainers = algoritmeVerloop.PlaatsContainers(ship, containerList);
            foreach (IContainer container in restContainers)
            {
                lbContainer.Items.Add(container);
            }
            List<List<IStack>> stackList = ship.GetList();
            for (int x = 0; x < stackList.Count; x++)
            {
                for (int y = 0; y < stackList[x].Count; y++)
                {
                    ListBox listBox = new ListBox
                    {
                        Width = 120,
                        Height = 60,
                        Left = 150 + (x * 120),
                        Top = 20 + (y * 75),
                        Name = $"{x},{y}"
                    };

                    Label label = new Label
                    {
                        Text = stackList[x][y].Weight.ToString(), Top = 20 + (y * 75) - 15, Left = 150 + (x * 120)
                    };

                    foreach (IContainer container in stackList[x][y])
                    {
                        listBox.Items.Add(container);
                    }
                    listboxList.Add(listBox);
                    stackInfoLabelList.Add(label);
                }
            }
            foreach (ListBox listBox in listboxList)
            {
                Controls.Add(listBox);
            }

            foreach (Label label in stackInfoLabelList)
            {
                Controls.Add(label);
            }

            float totaalGewicht = ship.GewichtLinks() + ship.GewichtRechts();
            lbBalans.Text = "Balans" + (ship.GewichtLinks()/totaalGewicht) + "/" + (ship.GewichtRechts()/totaalGewicht);
        }
    }
}
