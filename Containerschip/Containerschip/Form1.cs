using System;
using Algoritme.Objects;
using System.Windows.Forms;

namespace Containerschip
{
    public partial class Form1 : Form
    {
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
            for (int i = 0; nudY.Value != i; i++)
            {

            }
        }
    }
}
