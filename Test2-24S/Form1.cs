using System.Security.Cryptography;

namespace Test2_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f1 = Convert.ToDouble(textBox1.Text);
            double f2 = Convert.ToDouble(textBox2.Text);
            double f3 = Convert.ToDouble(textBox3.Text);
            //textBox1.Clear();
            //textBox2.Clear();   
            //textBox3.Clear();
            if (f1 > f2)
            {
                if (f1 > f3)
                {
                    if (f2 > f3)
                    {
                        string s1 = textBox1.Text;
                        string s2 = textBox2.Text;
                        string s3 = textBox3.Text;
                        textBox1.Text = ($"{f3}");
                        textBox2.Text = ($"{f2}");
                        textBox3.Text = ($"{f1}");
                    }
                    else
                    {
                        string s1 = textBox1.Text;
                        string s2 = textBox2.Text;
                        string s3 = textBox3.Text;
                        textBox1.Text = ($"{f2}");
                        textBox2.Text = ($"{f3}");
                        textBox3.Text = ($"{f1}");
                    }
                }
                else
                {
                    textBox1.Text = ($"{f2}");
                    textBox2.Text = ($"{f1}");
                    textBox3.Text = ($"{f3}");
                }


            }
            else
            {
                if (f2 > f3)
                {
                    if (f3 > f1)
                    {
                        textBox1.Text = ($"{f1}");
                        textBox2.Text = ($"{f3}");
                        textBox3.Text = ($"{f2}");
                    }
                    else
                        textBox1.Text = ($"{f3}");
                    textBox2.Text = ($"{f1}");
                    textBox3.Text = ($"{f2}");
                }
                else
                {
                    textBox1.Text = ($"{f1}");
                    textBox2.Text = ($"{f2}");
                    textBox3.Text = ($"{f3}");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double f1 = Convert.ToDouble(textBox1.Text);
            double f2 = Convert.ToDouble(textBox2.Text);
            double f3 = Convert.ToDouble(textBox3.Text);
            //textBox1.Clear();
            //textBox2.Clear();   
            //textBox3.Clear();
            if (f1 > f2)
            {
                if (f1 > f3)
                {
                    if (f2 > f3)
                    {
                        string s1 = textBox1.Text;
                        string s2 = textBox2.Text;
                        string s3 = textBox3.Text;
                        textBox1.Text = ($"{f1}");
                        textBox2.Text = ($"{f2}");
                        textBox3.Text = ($"{f3}");
                    }
                    else
                    {
                        string s1 = textBox1.Text;
                        string s2 = textBox2.Text;
                        string s3 = textBox3.Text;
                        textBox1.Text = ($"{f1}");
                        textBox2.Text = ($"{f3}");
                        textBox3.Text = ($"{f2}");
                    }
                }
                else
                {
                    textBox1.Text = ($"{f3}");
                    textBox2.Text = ($"{f1}");
                    textBox3.Text = ($"{f2}");
                }


            }
            else
            {
                if (f2 > f3)
                {
                    if (f3 > f1)
                    {
                        textBox1.Text = ($"{f2}");
                        textBox2.Text = ($"{f3}");
                        textBox3.Text = ($"{f1}");
                    }
                    else
                        textBox1.Text = ($"{f2}");
                    textBox2.Text = ($"{f1}");
                    textBox3.Text = ($"{f3}");
                }
                else
                {
                    textBox1.Text = ($"{f3}");
                    textBox2.Text = ($"{f2}");
                    textBox3.Text = ($"{f1}");
                }
            }
        }
    }
}
