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

            zedGraph.GraphPane.Title.Text = "Distribution Graph";
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
            PointPairList[] p = new PointPairList[0];
            try
            {
                // Равномерное распределение
                if (rbtnUni.Checked)
                {
                    var A = (double)numIn1.Value;
                    var B = (double)numIn2.Value;
                    p = Util.PlotUni(A, B, Points);

                    txbxMo.Text = Convert.ToString((A + B) / 2);
                    txbxDisp.Text = Convert.ToString((A - B) * (A - B) / 12);
                }
                // Экспоненциальное распределение
                if (rbtnExp.Checked)
                {
                    var L = (double)numIn1.Value;
                    p = Util.PlotExp(L, Points);

                    txbxMo.Text = Convert.ToString(1 / L);
                    txbxDisp.Text = Convert.ToString(1 / L / L);

                }
            }           
            catch (Exception)
            {
                MessageBox.Show("Wrong parameters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Pane.AddCurve("Distribution", p[0], Color.Red, SymbolType.None);
            Pane.AddCurve("Density", p[1], Color.Blue, SymbolType.None);
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
