using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigbraintime
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            menuStrip1.Dock = DockStyle.Top;
        }

        private void wdwToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void outputtext_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void посланиеРазработчикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtext_textBox.Text = "Данное приложение, созданное в целях обучения, распространяется по свободной лицензии. " +
                "Любая попытка продажи запрещена.";
        }

        private void изФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtext_textBox.Text = "Считывает из файла с именем  'file.txt', расположенном в корне диска D, данные, " +
                "которые помещает в ячейки первой строки таблицы. Данные должны быть целочисленными и разделяться точкой с запятой. " +
                "Считывает только первые 32 элемента.";
        }

        private void рандомайзерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtext_textBox.Text = "Рандомизирует (получает случайные) числа от -100 до 100, которые помещает в ячейки " +
                "первой строки таблицы. Генерирует 32 целочисленных значения.";
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtext_textBox.Text = "Согласно заданию, находит минимальное и максимальное значение массива, расположенного " +
                "в строке 1. Помещает минимальное значение в ячейку 1, а максимально в ячейку 2. В ячейке 3 находится " +
                "результат целочисленного нахождения среднего арифметического этих двух значений. В третьей строке располагается " +
                "массив из первой строки, отрицательные элементы которого заполнены средним арифметическим минимального и максимального " +
                "значения основного массива (значение, расположенное в ячейке 3 второй строки)";
        }

        private void гистограммаtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtext_textBox.Text = "Строит зависимую от массива, расположенного в первой строке таблицы, гистограмму.";
        }

        private void вФайлtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtext_textBox.Text = "Отправляет массив, находящийся в третьей строке таблицы, в файл 'outputfile.txt'. В случае, " +
                "если строка пустая, отправляет в файл 32 нуля, разделенных точкой с запятой. В случае, если строка не полная, заполняет " +
                "пробелы нулями.";
        }
    }
}
