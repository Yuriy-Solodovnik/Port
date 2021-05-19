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
    public partial class Form1 : Form
    {
        private readonly BindingSource _bPorts;
        public Form1()
        {
            InitializeComponent();
            AddButton.Click += AddButton_Click;
            _bPorts = new BindingSource();
            _bPorts.DataSource = Store.ports;
            var s = new System.Media.SoundPlayer(@"D:\VS_Programs\SPZ2\SPZ2\Resources\port.wav");
            s.PlayLooping();
            TablePorts.DataSource = _bPorts;
            
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Form form = new PortForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                        _bPorts.ResetBindings(false);
                TablePorts.Rows.RemoveAt(TablePorts.Rows.Count - 1);
                TablePorts.Refresh();
            }
        }
        private void TablePorts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
