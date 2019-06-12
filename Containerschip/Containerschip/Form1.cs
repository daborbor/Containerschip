using System;
using System.Collections.Generic;
using Algoritme.Objects;
using System.Windows.Forms;
using Algoritme.Interfaces.ObjectInterfaces;
using Algoritme.Objects.Ship;

namespace Containerschip
{
    public partial class Form1 : Form
    {
        private Random r = new Random();
        private Ship ship;
        private List<Button> buttonList = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            int weight = Convert.ToInt32(nudContainerWeight.Value);
            try
            {
                lbContainer.Items.Add(new StandardContainer(weight));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void butMakeShip_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttonList)
            {
                Controls.Remove(button);
            }
            buttonList.Clear();
            Ship ship = new Ship((int) nudX.Value, (int) nudY.Value);
            List<List<IStack>> shipList = ship.GetList();
            foreach (List<IStack> stackList in shipList)
            {
                foreach (IStack stack in stackList)
                {
                    int x = shipList.IndexOf(stackList);
                    int y = stackList.IndexOf(stack);
                    Button newButton = new Button();
                    newButton.Text = $"{x}, {y}";
                    newButton.Left = 150 + x * 80;
                    newButton.Top = y * 30;
                    newButton.Name = $"{x},{y}";
                    buttonList.Add(newButton);
                }
            }

            foreach (Button Button in buttonList)
            {
                Controls.Add(Button);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudRandom.Value; i++)
            {
                int weight = r.Next(4000, 30000);
                bool electricity = 0.5 < r.NextDouble();
                bool valuable = 0.5 < r.NextDouble();
                lbContainer.Items.Add(new StandardContainer(weight, electricity, valuable));
            }
        }
    }
}
