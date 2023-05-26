using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        //Вызов класса Function и создание ссылки operation из файла Class1.cs
        Function operation = new Function();

        //Форма
        public Form1() => InitializeComponent();

        //Кнопка "0" 1
        private void Button0_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button0.Text);

        //Кнопка "1" 2
        private void Button1_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button1.Text);

        //Кнопка "2" 3
        private void Button2_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button2.Text);

        //Кнопка "3" 4
        private void Button3_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button3.Text);

        //Кнопка "4" 5
        private void Button4_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button4.Text);

        //Кнопка "5" 6
        private void Button5_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button5.Text);

        //Кнопка "6" 7
        private void Button6_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button6.Text);

        //Кнопка "7" 8
        private void Button7_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button7.Text);

        //Кнопка "8" 9
        private void Button8_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button8.Text);

        //Кнопка "9" 10
        private void Button9_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, Button9.Text);

        //Кнопка "e" 11
        private void ButtonE_Click(object sender, EventArgs e) => operation.E(TextBox1);

        //Кнопка "π" 12
        private void ButtonPi_Click(object sender, EventArgs e) => operation.Pi(TextBox1);

        //Кнопка "." 13
        private void ButtonDot_Click(object sender, EventArgs e) => operation.Dot(TextBox1, ButtonDot.Text);

        //Кнопка "(" 14
        private void ButtonLb_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, ButtonLb.Text);

        //Кнопка ")" 15
        private void ButtonRb_Click(object sender, EventArgs e) => operation.ButtonToTextBox(TextBox1, ButtonRb.Text);

        //Кнопка "+" 16
        private void ButtonPlus_Click(object sender, EventArgs e) => operation.ButtonOperator(TextBox1, LabelZnak, LabelNumber, ButtonPlus.Text);

        //Кнопка "-" 17
        private void ButtonMinus_Click(object sender, EventArgs e) => operation.ButtonOperator(TextBox1, LabelZnak, LabelNumber, ButtonMinus.Text);

        //Кнопка "*" 18
        private void ButtonMult_Click(object sender, EventArgs e) => operation.ButtonOperator(TextBox1, LabelZnak, LabelNumber, ButtonMult.Text);

        //Кнопка "/" 19
        private void ButtonDiv_Click(object sender, EventArgs e) => operation.ButtonOperator(TextBox1, LabelZnak, LabelNumber, ButtonDiv.Text);

        //Кнопка "Дробь с числителем 1" 20
        private void Button1x_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "1/");

        //Кнопка "%" 21
        private void ButtonPer_Click(object sender, EventArgs e) => operation.ButtonOperator(TextBox1, LabelZnak, LabelNumber, ButtonPer.Text);

        //Кнопка "Степень" 22
        private void ButtonPow_Click(object sender, EventArgs e) => operation.ButtonOperator(TextBox1, LabelZnak, LabelNumber, "^");

        //Кнопка "Корень" 23
        private void ButtonSqrt_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, ButtonSqrt.Text);

        //Кнопка "Квадрат" 24
        private void ButtonX2_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "^2");

        //Кнопка "Куб" 25
        private void ButtonX3_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "^3");

        //Кнопка "Синус" 26
        private void ButtonSin_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "Sin");

        //Кнопка "Арксинус" 27
        private void ButtonAsin_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "Asin");

        //Кнопка "Косинус" 28
        private void ButtonCos_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "Cos");

        //Кнопка "Арккосинус" 29
        private void ButtonAcos_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "Acos");

        //Кнопка "Тангенс" 30
        private void ButtonTan_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "Tan");

        //Кнопка "Арктангенс" 31
        private void ButtonAtan_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "Atan");

        //Кнопка "Факториал" 32
        private void ButtonFact_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "!");

        //Кнопка "Логарифм" 33
        private void ButtonLg_Click(object sender, EventArgs e) => operation.ButtonOperator(TextBox1, LabelZnak, LabelNumber, "Log");

        //Кнопка "Натуральный логарифм" 34
        private void ButtonLn_Click(object sender, EventArgs e) => operation.ButtonHardOperator(LabelZnak, "Ln");

        //Кнопка "=" 35
        private void ButtonEqual_Click(object sender, EventArgs e) => operation.Operators(TextBox1, LabelZnak, LabelNumber);

        //Кнопка удаления знака 36
        private void ButtonBs_Click(object sender, EventArgs e) => operation.Backspace(TextBox1);

        //Кнопка "Очистить всё" 37
        private void ButtonCe_Click(object sender, EventArgs e) => operation.ClearAll(TextBox1, LabelNumber, LabelZnak);
    }
}