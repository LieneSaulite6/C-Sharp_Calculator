using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 
Calculator tutorial
https://www.youtube.com/watch?v=Xp4S4KMxYJA

Backspace button
https://www.c-sharpcorner.com/article/simple-scientific-calculator-using-c-sharp-in-visual-studio/

C, CE, Square root buttons
https://www.youtube.com/watch?v=8OphyxOdQ-w

Keyboard events
https://www.youtube.com/watch?v=ogVAU54EQFg

 */

namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";

        public Calculator()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst - valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "+":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst + valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "*":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst * valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "/":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst / valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "%":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst % valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TxtBox.Text = "0";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            int index = TxtBox.Text.Length;
            index--;
            TxtBox.Text = TxtBox.Text.Remove(index);
            if (TxtBox.Text == "")
            {
                TxtBox.Text = "0";
            }


        }

        private void OneXBtn_Click(object sender, EventArgs e)
        {
            Result = decimal.Parse(TxtBox.Text);
            Result = 1 / Result;
            TxtBox.Text = Result.ToString();
        }

        private void SqRootBtn_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(TxtBox.Text);
            sq = Math.Sqrt(sq);
            TxtBox.Text = Convert.ToString(sq);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
        }

        private void clearEnBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
            String f, s;
            f = Convert.ToString(valueFirst);
            s = Convert.ToString(valueSecond);
            f = "";
            s = "";
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                ZeroBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D0)
            {
                ZeroBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad1) 
            { 
                OneBtn.PerformClick();
            }
            
            if(e.KeyCode == Keys. D1)
            {
                OneBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad2)
            {
                TwoBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D2)
            {
                TwoBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad3)
            {
                ThreeBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D3)
            {
                ThreeBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad4)
            {
                FourBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D4)
            {
                FourBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad5)
            {
                FiveBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D5)
            {
                FiveBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad6)
            {
                SixBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D6)
            {
                SixBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad7)
            {
                SevenBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D7)
            {
                SevenBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad8)
            {
                EightBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D8)
            {
                EightBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad9)
            {
                NineBtn.PerformClick();
            }

            if (e.KeyCode == Keys.D9)
            {
                NineBtn.PerformClick();
            }

        }

        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EqualBtn.PerformClick();
            }

            if(e.KeyCode == Keys.Back)
            {
                BackBtn.PerformClick();
            }

            if(e.KeyCode == Keys.Delete)
            {
                cBtn.PerformClick();
            }

            if (e.KeyCode == Keys.Divide)
            {
                DivideBtn.PerformClick();
            }

            if (e.KeyCode == Keys.Multiply)
            {
                MultiplyBtn.PerformClick();
            }

            if (e.KeyCode == Keys.Oemcomma)
            {
                DotBtn.PerformClick();
            }
        }
    }
}
