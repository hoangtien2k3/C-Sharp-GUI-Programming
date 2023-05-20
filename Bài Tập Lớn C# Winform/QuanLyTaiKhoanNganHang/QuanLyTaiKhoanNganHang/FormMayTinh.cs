using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormMayTinh : Form
    {
        private double currentValue = 0;
        private string currentOperator = "";
        public FormMayTinh()
        {
            InitializeComponent();
        }

        private void FormMayTinh_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operatorText = button.Text;

            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                double operand = double.Parse(txtDisplay.Text);

                switch (currentOperator)
                {
                    case "+":
                        currentValue += operand;
                        break;
                    case "-":
                        currentValue -= operand;
                        break;
                    case "*":
                        currentValue *= operand;
                        break;
                    case "/":
                        if (operand != 0)
                            currentValue /= operand;
                        else
                            MessageBox.Show("Error: Cannot divide by zero.");
                        break;
                    default:
                        currentValue = operand;
                        break;
                }
            }

            currentOperator = operatorText; 
            txtPhepTinh.Text = currentOperator;
            txtDisplay.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                double operand = double.Parse(txtDisplay.Text);

                switch (currentOperator)
                {
                    case "+":
                        currentValue += operand;
                        break;
                    case "-":
                        currentValue -= operand;
                        break;
                    case "*":
                        currentValue *= operand;
                        break;
                    case "/":
                        if (operand != 0)
                            currentValue /= operand;
                        else
                            MessageBox.Show("Error: Cannot divide by zero.");
                        break;
                }
            }

            txtDisplay.Text = currentValue.ToString();
            currentOperator = "";
            currentValue = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            currentOperator = "";
            currentValue = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            btnOperator_Click(sender, e);
        }

        private void btnBangKetQua_Click(object sender, EventArgs e)
        {
            btnEquals_Click(sender, e);
        }

        private void btnDE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                // Lớp StringBuilder trong Java được sử dụng để tạo chuỗi có thể thay đổi (chuỗi dạng mutable). 
                StringBuilder sb = new StringBuilder(txtDisplay.Text);
                sb.Remove(sb.Length - 1, 1);
                txtDisplay.Text = sb.ToString();
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }
    }
}
