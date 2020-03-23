using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public enum op  {Add, Sub, Mul, Div};

    public partial class Form1 : Form
    {
        public int val = 0;
        public bool newNum = true;
        public op operate = op.Add;

        public Form1()
        {
            InitializeComponent();
        }

        public int add(int a,int b)
        {
            int sum = a + b;
            return sum;
        }
        public float addf(int a,int b)
        {
            float sum = a + b;
            return sum;
        }
        public int sub(int a,int b)
        {
            int sum = a - b;
            return sum;
        }

        public void setNum(string a)
        {
           
            if (newNum)
            {
                label1.Text = a;
                newNum = false;
            }
            else if (label1.Text == "0") label1.Text = a;
            else label1.Text = label1.Text + a;
        }

        private void numbutton1_Click(object sender, EventArgs e)
        {
            Button bu = (Button)sender; // object 타입인 sender를 Button타입으로 형변환
            setNum(bu.Text);
        }
        
        private void numPlus_Click(object sender, EventArgs e)
        {

            if (newNum == false)
            {
                int num = Convert.ToInt32(label1.Text);
                if (operate == op.Add) val = val + num;
                else if (operate == op.Sub) val = val - num;
                else if (operate == op.Mul) val = val * num;
                else if (operate == op.Div) val = val / num;
                label1.Text = val.ToString();
                newNum = true;
                //이전에 가지고 있던 연산자를 가지고 연산하는 작업
            }// 예외처리 - 연산자를 계속 누르고 숫자를 안눌렀을 경우


            //이후엔 마지막에 누른 연산자를 저장
            Button bu = (Button)sender; // 여기서 다음 연산해야할 연산자를 저장
            if (bu.Text == "+") operate = op.Add;
            else if (bu.Text == "-") operate = op.Sub;
            else if (bu.Text == "*") operate = op.Mul;
            else if (bu.Text == "/") operate = op.Div;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            val = 0;
            newNum = true;
            operate = op.Add;
            label1.Text = "0";
        }
    }
}
