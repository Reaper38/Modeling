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

namespace RandomChecker
{
    public partial class Form1 : Form
    {
        // Array size
        const int ACount = 1000;

        // Shown number of arrays
        const int NCount = 15;

        // Sequence limit
        const int Lim = 100;

        // Machine-randomized numbers
        int[] SDRand;
        int[] DDRand;
        int[] TDRand;

        // Numbers from textfile
        int[] SDFile;
        int[] DDFile;
        int[] TDFile;

        // Get all numbers from textfile to int array
        static int[] ParseIntFile(string FName)
        {
            string FText = File.ReadAllText(FName);

            string[] IStr = FText.Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int[] Result = new int[IStr.Length];

            for (int I = 0; I < IStr.Length; ++I)
                Result[I] = int.Parse(IStr[I]);

            return Result;
        }

        // Get evaluation of randomized sequence
        public double RandomCheck(ref int[] Sequence)
        {
            // If sequence is too big
            if (Sequence.Count() > Lim)
            {
                double Step = (double)Sequence.Count() / (double)Lim;

                int[] Seq = new int[Lim];
                for (int I = 0; I < Lim; ++I)
                    Seq[I] = Sequence[(int)(Step * I)];

                return RandomCheck(ref Seq);
            }

            // Calculating pyramid size
            int Count = 1;
            for (int I = Sequence.Count() - 1; I > 1; --I)
                Count += I;

            // Pyramid of subsequent substractions

            int[] Pyramid = new int[Count];

            for (int I = 1; I < Sequence.Count(); ++I)
                Pyramid[I - 1] = Sequence[I] - Sequence[I - 1];

            int J = 0;
            for (int I = Sequence.Count() - 1; I > 0; --I)
            {
                for (int K = 1; K < I; ++K)
                {
                    Pyramid[J + I + K - 1] = Pyramid[J + K] - Pyramid[J + K - 1];
                }

                J += I;
            }

            // Get all distinct numbers (bar 0) from pyramid
            int[] Diff = Pyramid.Distinct().Where(X => X != 0).ToArray();

            return (double)(Diff.Count()) / (double)(Pyramid.Count());
        }

        // Evaluation of user input
        private void CalculateGrid()
        {
            // We can evaluate sequence of three and more numbers
            int RCount = dataGridView2.RowCount - 1;
            if (RCount < 3)
            {
                label10.Text = "More numbers!";
                return;
            }

            // Convert user input to number array
            int[] Nums = new int[RCount];
            for (int I = 0; I < RCount; ++I)
            {
                try
                {
                    Nums[I] = Convert.ToInt32(dataGridView2[0, I].Value);
                }
                catch (FormatException)
                {
                    label10.Text = "Error: row " + (I + 1).ToString() + "!";
                    return;
                }
            }

            // Array evaluation
            double Res = RandomCheck(ref Nums);
            label10.Text = "PRB = " + Res.ToString("0.0000%");
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Evaluation of machine-randomized and textfile numbers
        private void Form1_Shown(object sender, EventArgs e)
        {
            Random Rand = new Random();

            // Generating machine-randomized numbers

            SDRand = new int[ACount];
            DDRand = new int[ACount];
            TDRand = new int[ACount];

            for (int I = 0; I < ACount; ++I)
            {
                SDRand[I] = Rand.Next(0, 10);
                DDRand[I] = Rand.Next(0, 100);
                TDRand[I] = Rand.Next(0, 1000);
            }

            // Loading numbers from textfile

            SDFile = ParseIntFile("single_digits.txt");
            DDFile = ParseIntFile("double_digits.txt");
            TDFile = ParseIntFile("triple_digits.txt");

            for (int I = 0; I < NCount; ++I)
            {
                dataGridView1.Rows.Add(SDRand[I], DDRand[I], TDRand[I]);
                dataGridView3.Rows.Add(SDFile[I], DDFile[I], TDFile[I]);
            }

            // Evaluating machine-randomized and textfile numbers

            double Res = RandomCheck(ref SDRand);
            label4.Text = "PRB = " + Res.ToString("0.0000%");

            Res = RandomCheck(ref DDRand);
            label5.Text = "PRB = " + Res.ToString("0.0000%");

            Res = RandomCheck(ref TDRand);
            label6.Text = "PRB = " + Res.ToString("0.0000%");

            Res = RandomCheck(ref SDFile);
            label7.Text = "PRB = " + Res.ToString("0.0000%");

            Res = RandomCheck(ref DDFile);
            label8.Text = "PRB = " + Res.ToString("0.0000%");

            Res = RandomCheck(ref TDFile);
            label9.Text = "PRB = " + Res.ToString("0.0000%");

            CalculateGrid();
        }

        // On cell edit
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateGrid();
        }

        // On row deletion
        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalculateGrid();
        }
    }
}
