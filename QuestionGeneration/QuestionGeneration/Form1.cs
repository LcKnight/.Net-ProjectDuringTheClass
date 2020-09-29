using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuestionGeneration
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        static int count = 1;
        int RightCount = 0;
        static int MaxCount = 5;
        //count 为题号,MaxCount 为总题量
        static int MaxTime = 8;
        public static int time= MaxTime;
        //time 为右上角的显示当前题目剩余时间


        //enum Char {Plus,Minus,Mul,Division};
        char al;
        //0 1 2 3 对应 + - * /

        public int num1, num2;
        public double ans;
 
        public void Quest()
        {
            time = MaxTime;
            if (count>MaxCount)
            {
                MessageBox.Show("答题结束");
                timer1.Stop();
            }
            else
            {
                num1 = rnd.Next(-10, 20);
                num2 = rnd.Next(-10, 20);
                int c = rnd.Next(0, 3);
                switch (c)
                {
                    case 0:
                        this.al = '+';
                        ans = num1 + num2;
                        break;
                    case 1:
                        this.al = '-';
                        ans = num1 - num2;
                        break;

                    case 2:
                        this.al = '*';
                        ans = num1 * num2;
                        break;

                    case 3:
                        this.al = '/';
                        if (num2 == 0)
                        {
                            num2 = rnd.Next(1, 10);//避免除数为0
                        }
                        ans = num1 / num2;
                        break;

                    default:
                        break;

                }
                Question.Text = num1.ToString() + "   " + al.ToString() + "   " + num2.ToString() + "   " + "=";
                this.Index.Text = count.ToString();
                count++;
            }
            
        }

        public bool TimeOut()
        {
            if (time <= 0)
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(Answer.Text) == ans)
            //✔❌
            {
                RightCount++;
                Mark.Text = "✔";
                Score.Text = ( Math.Floor((100.0*RightCount / MaxCount))).ToString();
            }

            else
                Mark.Text = "❌";
            timer1.Stop();
            Thread.Sleep(500);
            Quest();
            timer1.Start();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Time.Text = time.ToString();
            time--;
            if(TimeOut())
            {
                timer1.Stop();
                MessageBox.Show("超时，进入下一题","超时", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Start();
                Quest();
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            MaxCount = Convert.ToInt32(textBoxacount.Text);
            MaxTime = Convert.ToInt32(textBoxTime.Text);
            textBoxacount.Hide();
            textBoxTime.Hide();
            timer1.Start();
            Total.Text = MaxCount.ToString();
            Quest();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
