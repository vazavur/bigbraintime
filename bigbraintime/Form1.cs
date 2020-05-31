using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigbraintime
{
    public partial class BIGBRAINTIME : Form
    {
        public BIGBRAINTIME()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = arr.Length;
        }

        public int[] arr = new int[32]; //в задании указано, что массив фиксированной длинны (32)

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BIGBRAINTIME_Load(object sender, EventArgs e)
        {

        }

        private void randomizer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++) //заполнение массива случайными числами
            {
                arr[i] = rnd.Next(-100, 100);
                dataGridView1.Rows[0].Cells[i].Value = arr[i];
            }
        }

        private void button_fromfile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader str = new StreamReader(@"D:\file.txt"); //возьмем массив из файла, считывает первые 32 элемента
                string[] a = str.ReadToEnd().Split(';');
                for (int i = 0; i < arr.Length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = Convert.ToInt32(a[i]);
                    arr[i] = Convert.ToInt32(a[i]);
                }
                str.Close();
            } catch
            {
                MessageBox.Show(
                    "Вероятно, файл имеет неверный формат данных.",
                    "Внимание");
            }
        }

        private void button_tofile_Click(object sender, EventArgs e)
        {
            StreamWriter str = new StreamWriter(@"D:\outputfile.txt"); //отправим массив, содержащийся в ячейках, в файл
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
                str.Write(Convert.ToString(arr[i]) + ";");
            }
            str.Close();
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void button_creategyst_Click(object sender, EventArgs e) //строим диаграмму
        {
            int[] x = arr;
            int[] y = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                y[i] = arr[i];
                x[i] = i;
            }
            chart.Series[0].Points.DataBindXY(x, y);
        }

        private void button_changeform_Click(object sender, EventArgs e) //переход на вторую форму
        {
            Form2 secondform = new Form2();
            secondform.Show();
        }
    }
}
