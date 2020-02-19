using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leadersoftware
{
    public partial class tableDisplay : UserControl
    {
        public tableDisplay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                   }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
