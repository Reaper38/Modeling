using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RandomChecker
{
    public partial class MainDialog : Form
    {
        private const int ACount = 1000; // Array size
        private const int NCount = 15; // Shown number of arrays
        private const int Lim = 100; // Sequence limit
        // Machine-randomized numbers
        private int[] sdRand, ddRand, tdRand;
        // Numbers from textfile
        private int[] sdFile, ddFile, tdFile;
        private readonly IRandomSequenceTest rndTest = new ApproximateEntropyTest();
        
        private static int[] LoadData(string filePath)
        {
            string text = File.ReadAllText(filePath);
            string[] splitText = text.Split(new[] {'\t', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            int[] result = new int[splitText.Length];
            for (int i = 0; i<splitText.Length; i++)
                result[i] = int.Parse(splitText[i]);
            return result;
        }
        
        private void CalculateGrid()
        {
            // We can evaluate sequence of three and more numbers
            int rowCount = dgvUserSeq.RowCount-1;
            if (rowCount<3)
            {
                lUserSeq.Text = "More numbers!";
                return;
            }
            // Convert user input to number array
            int[] nums = new int[rowCount];
            for (int i = 0; i<rowCount; i++)
            {
                try
                {
                    nums[i] = Convert.ToInt32(dgvUserSeq[0, i].Value);
                }
                catch (FormatException)
                {
                    lUserSeq.Text = "Error: row "+(i+1)+"!";
                    return;
                }
            }
            PerformTest(lUserSeq, nums, 1);
        }

        public MainDialog()
        {
            InitializeComponent();
        }
        
        private void MainDialog_Shown(object sender, EventArgs e)
        {
            Random rand = new Random();
            sdRand = new int[ACount];
            ddRand = new int[ACount];
            tdRand = new int[ACount];
            for (int i = 0; i<ACount; i++)
            {
                sdRand[i] = rand.Next(0, 10);
                ddRand[i] = rand.Next(0, 100);
                tdRand[i] = rand.Next(0, 1000);
            }
            sdFile = LoadData("single_digits.txt");
            ddFile = LoadData("double_digits.txt");
            tdFile = LoadData("triple_digits.txt");
            for (int i = 0; i<NCount; i++)
            {
                dgvAlgSeq.Rows.Add(sdRand[i], ddRand[i], tdRand[i]);
                dgvTabSeq.Rows.Add(sdFile[i], ddFile[i], tdFile[i]);
            }
            PerformTest(lAlgSeq1, sdRand, 1);
            PerformTest(lAlgSeq2, ddRand, 2);
            PerformTest(lAlgSeq3, tdRand, 3);
            PerformTest(lTabSeq1, sdFile, 1);
            PerformTest(lTabSeq2, ddFile, 2);
            PerformTest(lTabSeq3, tdFile, 3);
            CalculateGrid();
        }

        void PerformTest(Label l, IList<int> src, byte sbCount)
        {
            var result = rndTest.Test(src, Lim, sbCount)[0];
            string format = result<0.0001 ? "E" : "0.0000";
            l.Text = string.Format("PRB = {0}", result.ToString(format));
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { CalculateGrid(); }

        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        { CalculateGrid(); }
    }
}
