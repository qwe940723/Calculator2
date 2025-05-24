using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        Calculate2 calculate = new Calculate2(); // 建立計算機物件
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定

        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        
        
        
        
        
        
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            calculate.Reset();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Add_Number("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            Add_Number("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Add_Number("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Add_Number("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; 
            calculate.secondNumber = Convert.ToSingle(txtNumber.Text); 

            
            switch (operators)
            {
                case 0:
                    finalResults = calculate.Add(); 
                    break;
                case 1:
                    finalResults = calculate.Subtract(); 
                    break;
                case 2:
                    finalResults = calculate.Multiply(); 
                    break;
                case 3:
                    finalResults = calculate.Divide();  
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); 

            
            calculate.Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Select_Operator(0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Select_Operator(1);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Select_Operator(2);
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            Select_Operator(3);
        }
        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + _number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber.Text = txtNumber.Text.Substring(0, txtNumber.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out double value))
            {
                value = value / 100;
                txtNumber.Text = value.ToString();
            }
        }

        private void Select_Operator(int _operator)
        {
            calculate.firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，再將數字存到計算機物件的firstNumber屬性裡面
            operators = _operator;
            txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
        }
    }
}
