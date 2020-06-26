using System;
using System.IO;
using System.Windows.Forms;

namespace bigbraintime
{
    public partial class BIGBRAINTIME : Form
    {
        public BIGBRAINTIME()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = arr.Length;
            dataGridView1.RowCount = 3;
            form2status = 0;
        }

        public int[] arr = new int[32]; //в задании указано, что массив фиксированной длинны (32)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
  
        private void BIGBRAINTIME_Load(object sender, EventArgs e)
        {

        }

        private int min = 101;
        private int max = -101;
        private void randomizer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++) //заполнение массива случайными числами
            {
                arr[i] = rnd.Next(-100, 100);
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
                dataGridView1.Rows[0].Cells[i].Value = arr[i];
            }
        }

        private void button_fromfile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader str = new StreamReader(@"D:\file.txt"); //возьмем массив из файла, считывает первые 32 элемента
                string[] a = str.ReadToEnd().Split(';');
                max = Convert.ToInt32(a[0]);
                min = Convert.ToInt32(a[0]);
                for (int i = 0; i < arr.Length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = Convert.ToInt32(a[i]);
                    arr[i] = Convert.ToInt32(a[i]);
                    if (arr[i] > max) max = arr[i];
                    if (arr[i] < min) min = arr[i];
                }
                str.Close();
            }
            catch
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
                arr[i] = Convert.ToInt32(dataGridView1.Rows[2].Cells[i].Value);
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
        private byte form2status; //переключатель, будет нужен, если билд программы не будет выгружаться из памяти

        public byte Form2status { get => form2status; set => form2status = value; }

        private void button_changeform_Click(object sender, EventArgs e) //переход на вторую форму
        {
            Hide();
            Form2 secondform = new Form2();
            secondform.Show();
            form2status = 1;
        }

        private void button_objective_Click(object sender, EventArgs e) //выполнение задания, R2
        {
            dataGridView1.Rows[1].Cells[0].Value = min; //2
            dataGridView1.Rows[1].Cells[1].Value = max; //2
            int arithmean = (min + max) / 2; //3
            dataGridView1.Rows[1].Cells[2].Value = arithmean; //4
            for (int i = 0; i < arr.Length; i++) //5
            {
                if (arr[i] < 0) arr[i] = arithmean; //6
                dataGridView1.Rows[2].Cells[i].Value = arr[i]; //7
            }
        }

        private void button_sortie_Click(object sender, EventArgs e)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        dataGridView1.Rows[0].Cells[i].Value = Convert.ToInt32(arr[i]);
                    }
                }
            }
        }

        private void button_cleaner_Click(object sender, EventArgs e)
        {
            min = 101;
            max = -101;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = 0;
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }
        }
    }
}
