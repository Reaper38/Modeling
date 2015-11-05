using System;
using System.Drawing;
using System.Windows.Forms;

namespace DistributionPlotter
{
    using ZedGraph;

    public partial class FormMain : Form
    {
             
        public FormMain()
        {
            InitializeComponent();

            zedGraph.GraphPane.Title.Text = "Графики распределения";
            zedGraph.GraphPane.XAxis.Title.Text = "X";
            zedGraph.GraphPane.YAxis.Title.Text = "Y";

            rbtnUni.Checked = true;
        }       

        // Вычисление
        private void button1_Click(object sender, EventArgs e)
        {
            // Число значений
            int Points = (int)numPoint.Value;           
            
            GraphPane Pane = zedGraph.GraphPane;
            Pane.CurveList.Clear();

            // Равномерное распределение
            if (rbtnUni.Checked)
            {              
                try
                {
                    var A = (double)numIn1.Value;
                    var B = (double)numIn2.Value;
                    var p = Util.PlotUni(A, B, Points);
                    Pane.AddCurve("Распределение", p[0], Color.Red, SymbolType.None);
                    Pane.AddCurve("Плотность", p[1], Color.Blue, SymbolType.None);

                    txbxMo.Text = Convert.ToString((A + B) / 2);
                    txbxDisp.Text = Convert.ToString((A - B) * (A - B) / 12);
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Экспоненциальное распределение
            if (rbtnExp.Checked)
            {             
                try
                {
                    var L = (double)numIn1.Value;
                    var p = Util.PlotExp(L, Points);
                    Pane.AddCurve("Распределение", p[0], Color.Red, SymbolType.None);
                    Pane.AddCurve("Плотность", p[1], Color.Blue, SymbolType.None);

                    txbxMo.Text = Convert.ToString(1/L);
                    txbxDisp.Text = Convert.ToString(1/L/L);
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Обновить график
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

       // Выбор распределения

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUni.Checked)
            {
                label2.Text = "A:";
                label3.Text = "B:";

                label3.Visible = true;
                numIn2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnExp.Checked)
            {
                label2.Text = "Lambda:";

                label3.Visible = false;
                numIn2.Enabled = false;
            }
        }
    }
}
