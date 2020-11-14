using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Можно настроить в свойствах формы
            button4.Text = "Начать игру";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label1.Text = "---";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool b = button1.Visible;
            button1.Visible = !b;
            button2.Visible = !b;
            button3.Visible = !b;
            label1.Visible = checkBox1.Checked;// Подсказка
            if (b) button4.Text = "Начать игру"; else button4.Text = "Завершить игру"; // If можно писать по разному
            if (b)
            {
                label1.Text = "---";
            }
            else
            {
                //Создание объекта для генерации чисел
                Random rnd = new Random();
                int rd = rnd.Next(1, 4);
                switch (rd)
                {
                    case 1:
                        label1.Text = "Камень";
                        break;
                    case 2:
                        label1.Text = "Ножницы";
                        break;
                    case 3:
                        label1.Text = "Бумага";
                        break;
                    default:
                        label1.Text = "---";
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myResult("Камень"));
            button4.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myResult("Ножницы"));
            button4.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myResult("Бумага"));
            button4.PerformClick();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = checkBox1.Checked;// Подсказка
        }
 
        private string myResult(string sUser)
        {
            string sComp = label1.Text;
            string s = string.Empty;
            s = "\r\n";// Перевод каретки
            if (sUser == sComp)
            {
                return "Ничья" + s + s + "Игрок: " + sUser + s + "Компьютер: " + sComp;
            }
            else
            {
                if ((sUser == "Камень" && sComp == "Ножницы") ||
                    (sUser == "Ножницы" && sComp == "Бумага") ||
                    (sUser == "Бумага" && sComp == "Камень"))
                {
                    return "Победа!!!" + s + s + "Игрок: " + sUser + s + "Компьютер: " + sComp;
                }
                else
                {
                    return "Проиграл :(" + s + s + "Игрок: " + sUser + s + "Компьютер: " + sComp;
                }
            }
        }
    }
}
