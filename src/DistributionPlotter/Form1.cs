using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistributionPlotter
{
    using ZedGraph;

    public partial class Form1 : Form
    {
        // Число значений
        const int Points = 5000;

        public Form1()
        {
            InitializeComponent();

            zedGraphControl1.GraphPane.Title.Text = "Графики распределения";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "X";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Y";

            radioButton1.Checked = true;
        }

        // Получение набора значений X между двумя значениями
        private double[] GetRange(double Start, double Finish)
        {
            double[] Output = new double[Points];

            double Step = (Finish - Start) / Points;
            double Current = Start;

            for (int I = 0; I < Points; ++I)
            {
                Output[I] = Current;
                Current += Step;
            }

            return Output;
        }



        // Вычисление
        private void button1_Click(object sender, EventArgs e)
        {
            double[] X;
            double[] Y, y;
            
            GraphPane Pane = zedGraphControl1.GraphPane;
            Pane.CurveList.Clear();

            PointPairList P1, P2;
            
            if (radioButton1.Checked)
            {
                // Равномерное распределение
                try
                {
                    var d = new Distribution();
                    double A = Convert.ToDouble(textBox1.Text);
                    double B = Convert.ToDouble(textBox2.Text);
                    if (A > B)
                    {
                        A += B;
                        B = A - B;
                        A -= B;
                    }

                    X = GetRange(2 * A - B - 2, 2 * B - A + 2);

                    Y = d.UniformDistribution(X, A, B);
                    y = d.UniformDensity(X, A, B);

                    P1 = new PointPairList(X, Y);
                    P2 = new PointPairList(X, y);

                    Pane.AddCurve("Распределение", P1, Color.Red, SymbolType.None);
                    Pane.AddCurve("Плотность", P2, Color.Blue, SymbolType.None);

                    textBox3.Text = Convert.ToString((A + B) / 2);
                    textBox4.Text = Convert.ToString((A - B) * (A - B) / 12);
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Экспоненциальное распределение
                try
                {
                    var d = new Distribution();
                    double L = Convert.ToDouble(textBox1.Text);
                    if (L <= 0)
                        throw new Exception("Invalid lambda input");

                    X = GetRange(-5.0 / L, 10.0 / L);

                    Y = d.ExponentialDistribution(X, L);
                    y = d.ExponentialDensity(X, L);

                    P1 = new PointPairList(X, Y);
                    P2 = new PointPairList(X, y);

                    Pane.AddCurve("Распределение", P1, Color.Red, SymbolType.None);
                    Pane.AddCurve("Плотность", P2, Color.Blue, SymbolType.None);

                    textBox3.Text = Convert.ToString(1/L);
                    textBox4.Text = Convert.ToString(1/L/L);
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Обновить график
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

       // Выбор распределения

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "A";
                label3.Text = "B";

                label3.Visible = true;
                textBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Text = "lambda";

                label3.Visible = false;
                textBox2.Enabled = false;
            }
        }
    }
}
