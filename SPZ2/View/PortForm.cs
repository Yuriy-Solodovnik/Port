using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ2
{
    public partial class PortForm : Form
    {
        public PortForm()
        {
            InitializeComponent();
            AddPort.Click += AddPort_Click;
            CancelButton.Click += CancelButton_Click;
            ProfitButton.Click += ProfitButton_Click;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDownDocks_ValueChanged(object sender, EventArgs e)
        {

        }
        private void AddPort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Port port = new Port();
            port.Name = textBoxName.Text;
            port.Adress = textBoxAdress.Text;
            port.Workers = (int)numericUpDownWorkers.Value;
            port.TechPrice = (double)numericUpDownTechPrice.Value;
            port.Technique = (int)numericUpDownTechCount.Value;
            port.ServiceCost = (double)numericUpDownCostServicing.Value;
            port.Hours = (int)numericUpDownHours.Value;
            port.Docks = (int)numericUpDownDocks.Value;
            port.Ships = (int)numericUpDownShips.Value;
            port.Time=default;
            port.Profit = default;
            Store.AddPort(port);
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ProfitButton_Click(object sender, EventArgs e)
        {
            ProfitLabel2.Text = Convert.ToString(numericUpDownShips.Value * numericUpDownCostServicing.Value -numericUpDownTechPrice.Value*numericUpDownTechCount.Value);
        }
    }
}
