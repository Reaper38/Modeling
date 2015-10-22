using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        MatrixSolver Solver;
        int GridSize;

        // Установка таблицы определённого размера
        private void SetGrid()
        {
            dataGridView1.ColumnCount = GridSize;
            dataGridView1.RowCount = GridSize;

            for (int I = 0; I < GridSize; ++I)
            {
                dataGridView1.Columns[I].Width = 55;

                for (int J = 0; J < GridSize; ++J)
                    if (dataGridView1[I, J].Value == null)
                        dataGridView1[I, J].Value = "0";
            }
        }

        public Form1()
        {
            InitializeComponent();

            GridSize = 4;
            SetGrid();

            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].Width = 80;
        }

        // Решение матрицы
        private void button1_Click(object sender, EventArgs e)
        {
            // Формирование матрицы

            double[,] A = new double[GridSize, GridSize];
            double[] B = new double[GridSize];

            B[0] = 1;
            for (int I = 1; I < GridSize; ++I)
                B[I] = 0;

            try
            {
                for (int I = 0; I < GridSize; ++I)
                {
                    for (int J = 0; J < GridSize; ++J)
                    {
                        A[I, J] = -Convert.ToDouble(dataGridView1[I, J].Value);

                        if (J == I)
                            for (int K = 0; K < GridSize; ++K)
                                A[I, J] += Convert.ToDouble(dataGridView1[K, I].Value);
                    }
                }

                for (int J = 0; J < GridSize; ++J)
                    A[0, J]++;
            }
            catch
            {
                MessageBox.Show("Матрица содержит неверные значения!", Form1.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Решение системы

            Solver = new MatrixSolver(A, B);

            dataGridView2.RowCount = GridSize;
            for (int I = 0; I < GridSize; ++I)
                dataGridView2[0, I].Value = "";
            
            if (Solver.Calculate())
                for (int I = 0; I < GridSize; ++I)
                    dataGridView2[0, I].Value =  String.Format("{0:0.000000}", Solver.X(I));
        }

        // Увеличение размера матрицы
        private void button3_Click(object sender, EventArgs e)
        {
            if (GridSize == 15)
                MessageBox.Show("Чрезвычайно большой размер матрицы!", Form1.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GridSize++;
                SetGrid();
            }
        }

        // Уменьшение размера матрицы
        private void button2_Click(object sender, EventArgs e)
        {
            if (GridSize == 2)
                MessageBox.Show("Матрица чересчур мала!", Form1.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GridSize--;
                SetGrid();
            }
        }

        // Обнуление таблицы
        private void button4_Click(object sender, EventArgs e)
        {
            for (int I = 0; I < GridSize; ++I)
                for (int J = 0; J < GridSize; ++J)
                    dataGridView1[I, J].Value = "0";
        }

        // Изменение значения в клетке таблицы
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == e.RowIndex)
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = "0";
        }
    }
}
