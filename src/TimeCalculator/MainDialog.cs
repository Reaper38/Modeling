using System;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class MainDialog : Form
    {
        private MatrixSolver solver;
        private int gridSize;

        // Установка таблицы определённого размера
        private void SetGrid()
        {
            dgvCrossTable.ColumnCount = gridSize;
            dgvCrossTable.RowCount = gridSize;

            for (int i = 0; i<gridSize; i++)
            {
                dgvCrossTable.Columns[i].Width = 55;
                for (int j = 0; j<gridSize; j++)
                {
                    if (dgvCrossTable[i, j].Value==null)
                        dgvCrossTable[i, j].Value = "0";
                }
            }
        }

        public MainDialog()
        {
            InitializeComponent();
            gridSize = 4;
            SetGrid();
            dgvResult.ColumnCount = 1;
            dgvResult.Columns[0].Width = 80;
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
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
                        a[i, j] = -Convert.ToDouble(dgvCrossTable[i, j].Value);
                        if (j==i)
                        {
                            for (int k = 0; k<gridSize; k++)
                                a[i, j] += Convert.ToDouble(dgvCrossTable[k, i].Value);
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
            dgvResult.RowCount = gridSize;
            for (int i = 0; i<gridSize; i++)
                dgvResult[0, i].Value = "";
            if (solver.Calculate())
            {
                for (int i = 0; i<gridSize; i++)
                    dgvResult[0, i].Value =  String.Format("{0:0.000000}", solver.X(i));
            }
        }
        
        private void btnExpand_Click(object sender, EventArgs e)
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
        
        private void btnShrink_Click(object sender, EventArgs e)
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
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<gridSize; i++)
            {
                for (int j = 0; j<gridSize; j++)
                    dgvCrossTable[i, j].Value = "0";
            }
        }
        
        private void dgvCrossTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==e.RowIndex)
                dgvCrossTable[e.ColumnIndex, e.RowIndex].Value = "0";
        }
    }
}
