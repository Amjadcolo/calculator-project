using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_project
{
    public partial class Form1 : Form
    {
       

        private void calculations_Click(object sender, EventArgs e)
        {
            float a, b;
            float r;
          char optr;
            a = Convert.ToInt32(n1.Text);
            b = Convert.ToInt32(n2.Text);
            optr = Convert.ToChar(opt.Text);

            switch (optr)
            {
                case '+':
                    {
                    r = a + b;
                    result.Text = r.ToString();
                        break;
                    }
                case '-':
                    {
                        r = a - b;
                        result.Text = r.ToString();
                        break;
                    }
                case '*':
                    {
                        r = a * b;
                        result.Text = r.ToString();
                        break;
                    }
                case '/':
                    {
                        r = a / b;
                        result.Text = r.ToString();
                        break;
                    }
            }
        }

       
    }
}
