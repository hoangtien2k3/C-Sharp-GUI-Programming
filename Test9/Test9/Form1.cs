using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxDS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            comboBoxDS.Items.Add("OBAMA");
            comboBoxDS.Items.Add("UKARA");
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            comboBoxDS.Items.Insert(1, 123);
        }
    }
}
