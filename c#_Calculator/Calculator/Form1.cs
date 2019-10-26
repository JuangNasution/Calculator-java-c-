using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        string ope;
        int temp=0;
        int temp2;
        int hasil;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void btnclick(string angka)
        {
            ope += angka;
            textBox1.Text = ope;
        }
        public void btnclear()
        {
            ope = "";
            textBox1.Text = "";
        }
        public void btndel()
        {
            ope=ope.Remove(ope.Length - 1, 1);
            textBox1.Text = ope;
        }
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        public void btnequal()
        {
            double result = Evaluate(ope);
            textBox1.Text = result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnclick("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnclick("2");

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            btnclick("3");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            btnclick("+");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnequal();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            btnclick("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnclick("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnclick("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnclick("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnclick("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btnclick("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btnclick("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btnclick("-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btnclick("*");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btnclick("/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            btnclear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            btnclick(".");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            btndel();
        }
    }
}
