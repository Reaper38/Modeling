using System;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        private MatrixSolver solver;
        private int gridSize;

        // Установка таблицы определённого размера
        private void SetGrid()
        {
            dataGridView1.ColumnCount = gridSize;
            dataGridView1.RowCount = gridSize;

            for (int i = 0; i<gridSize; i++)
            {
                dataGridView1.Columns[i].Width = 55;
                for (int j = 0; j<gridSize; j++)
                {
                    if (dataGridView1[i, j].Value==null)
                        dataGridView1[i, j].Value = "0";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            gridSize = 4;
            SetGrid();
            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].Width = 80;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double[,] a = new double[gridSize, gridSize];
            double[] b = new double[gridSize];
            b[0] = 1;
            for (int i = 1; i<gridSize; i++)
                b[i] = 0;
            try
            {
                for (int i = 0; i<gridSize; i++)
                {
                    for (int j = 0; j<gridSize; j++)
                    {
                        a[i, j] = -Convert.ToDouble(dataGridView1[i, j].Value);
                        if (j==i)
                        {
                            for (int k = 0; k<gridSize; k++)
                                a[i, j] += Convert.ToDouble(dataGridView1[k, i].Value);
                        }
                    }
                }
                for (int j = 0; j<gridSize; j++)
                    a[0, j]++;
            }
            catch
            {
                MessageBox.Show("Матрица содержит неверные значения!", 
                    ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            solver = new MatrixSolver(a, b);
            dataGridView2.RowCount = gridSize;
            for (int i = 0; i<gridSize; i++)
                dataGridView2[0, i].Value = "";
            if (solver.Calculate())
            {
                for (int i = 0; i<gridSize; i++)
                    dataGridView2[0, i].Value =  String.Format("{0:0.000000}", solver.X(i));
            }
        }

        // Увеличение размера матрицы
        private void button3_Click(object sender, EventArgs e)
        {
            if (gridSize==15)
            {
                MessageBox.Show("Чрезвычайно большой размер матрицы!",
                    ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gridSize++;
            SetGrid();
        }

        // Уменьшение размера матрицы
        private void button2_Click(object sender, EventArgs e)
        {
            if (gridSize==2)
            {
                MessageBox.Show("Матрица чересчур мала!",
                    ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gridSize--;
            SetGrid();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<gridSize; i++)
            {
                for (int j = 0; j<gridSize; j++)
                    dataGridView1[i, j].Value = "0";
            }
        }
        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==e.RowIndex)
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = "0";
        }
    }
}
