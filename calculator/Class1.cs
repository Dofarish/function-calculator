using System;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace calculator
{
    class Function
    {
        private int i = 0;
        public void ButtonToTextBox(TextBox obj1, string str1)
        {
            if (i == 0)
                obj1.Text += str1;
            else
            {
                obj1.Text = str1;
                i = 0;
            }
        }
        public void Dot(TextBox obj1, string str1)
        {
            if (!obj1.Text.Contains(","))
            {
                obj1.Text += str1;
            }
        }
        public void ButtonOperator(TextBox obj1, Label obj2, Label obj3, string str1)
        {
            obj3.Text = obj1.Text;
            obj1.Text = string.Empty;
            obj2.Text = str1;
        }
        public void ButtonHardOperator(Label obj2, string str1) => obj2.Text = str1;
        public void Backspace(TextBox obj1)
        {
            if (obj1.Text.Length > 0)
            {
                if (obj1.Text != "3,14159265358979" & obj1.Text != "2,71828182845905")
                    obj1.Text = obj1.Text.Substring(0, obj1.Text.Length - 1);
                if (obj1.Text == "не число")
                {
                    obj1.Text = string.Empty;
                    i = 0;
                }
                else
                {
                    obj1.Text = string.Empty;
                    i = 0;
                }
            }
        }
        public void ClearAll(TextBox obj1, Label obj2, Label obj3)
        {
            obj1.Text = string.Empty;
            Clear(obj2, obj3);
            i = 0;
        }
        void Clear(Label obj1, Label obj2) => obj1.Text = obj2.Text = string.Empty;
        public void Operators(TextBox obj1, Label obj2, Label obj3)
        {
            switch (obj2.Text)
            {
                case "+":
                    obj1.Text = (double.Parse(obj3.Text) + double.Parse(obj1.Text)).ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "-":
                    obj1.Text = (double.Parse(obj3.Text) - double.Parse(obj1.Text)).ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "*":
                    obj1.Text = (double.Parse(obj3.Text) * double.Parse(obj1.Text)).ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "/":
                    obj1.Text = (double.Parse(obj3.Text) / double.Parse(obj1.Text)).ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "%":
                    obj1.Text = (double.Parse(obj3.Text) / 100 * double.Parse(obj1.Text)).ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "^":
                    obj1.Text = Convert.ToString(Math.Pow(double.Parse(obj3.Text), double.Parse(obj1.Text)));
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "^2":
                    double result = double.Parse(obj1.Text);
                    result = Math.Pow(result, 2);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "^3":
                    result = double.Parse(obj1.Text);
                    result = Math.Pow(result, 3);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "√":
                    result = double.Parse(obj1.Text);
                    result = Math.Sqrt(result);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "1/":
                    obj1.Text = (double.Parse("1") / double.Parse(obj1.Text)).ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "Log":
                    result = double.Parse(obj1.Text);
                    result = Math.Log(result, double.Parse(obj1.Text));
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "Ln":
                    result = double.Parse(obj1.Text);
                    result = Math.Log(result);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "!":
                    int Factorial(int number)
                    {
                        if (number == 1)
                            return 1;
                        return number * Factorial(number - 1);
                    }
                    obj1.Text = Convert.ToString(Factorial(int.Parse(obj1.Text)));
                    break;
                case "Sin":
                    result = double.Parse(obj1.Text);
                    result = Math.Sin(result);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                default:
                    break;
                case "Asin":
                    result = double.Parse(obj1.Text);
                    result = Math.Asin(result);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "Cos":
                    result = double.Parse(obj1.Text);
                    result = Math.Cos(result);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "Acos":
                    result = double.Parse(obj1.Text);
                    result = Math.Acos(result);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "Tan":
                    result = double.Parse(obj1.Text);
                    result = Math.Tan(result);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
                case "Atan":
                    result = double.Parse(obj1.Text);
                    result = Math.Atan(result);
                    obj1.Text = result.ToString();
                    Clear(obj2, obj3);
                    i = 1;
                    break;
            }
        }
        public void Pi(TextBox obj1)
        {
            obj1.Text = Convert.ToString(Math.PI);
            i = 1;
        }
        public void E(TextBox obj1)
        {
            obj1.Text = Convert.ToString(Math.E);
            i = 1;
        }
    }
}