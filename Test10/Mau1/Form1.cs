using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chlbBang1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chlbBang1.CheckedItems;
            foreach(var item in items)
            {
                // Console.WriteLine(item);
                chlbBang2.Items.Add(item);

            }

            // duyet xoa phan tu ben bang1
            foreach (string s in chlbBang2.Items)
            {
                chlbBang1.Items.Remove(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chlbBang1.CheckedItems;
            // addRange nó sẽ bê toàn bộ bảng bên trái và ném sang bảng bên phải.
            chlbBang2.Items.AddRange(chlbBang1.Items);
            // xoa toan bo ben bang 1
            chlbBang1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chlbBang2.CheckedItems;
            foreach (var item in items)
            {
                // Console.WriteLine(item);
                chlbBang1.Items.Add(item);

            }

            // duyet xoa phan tu ben bang1
            foreach (string s in chlbBang1.Items)
            {
                chlbBang2.Items.Remove(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chlbBang2.CheckedItems;
            // addRange nó sẽ bê toàn bộ bảng bên trái và ném sang bảng bên phải.
            chlbBang1.Items.AddRange(chlbBang2.Items);
            // xoa toan bo ben bang 1
            chlbBang2.Items.Clear();
        }
    }
}
