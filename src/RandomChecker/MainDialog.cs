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
        private readonly IRandomSequenceTest rndTest = new PyramidTest();

        // Get all numbers from textfile to int array
        private static int[] ParseIntFile(string fName)
        {
            string fText = File.ReadAllText(fName);
            string[] str = fText.Split(new[] {'\t', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            int[] result = new int[str.Length];
            for (int i = 0; i<str.Length; i++)
                result[i] = int.Parse(str[i]);
            return result;
        }
        // Get evaluation of randomized sequence
        
        // Evaluation of user input
        private void CalculateGrid()
        {
            // We can evaluate sequence of three and more numbers
            int rCount = dataGridView2.RowCount-1;
            if (rCount<3)
            {
                label10.Text = "More numbers!";
                return;
            }
            // Convert user input to number array
            int[] nums = new int[rCount];
            for (int i = 0; i<rCount; i++)
            {
                try
                {
                    nums[i] = Convert.ToInt32(dataGridView2[0, i].Value);
                }
                catch (FormatException)
                {
                    label10.Text = "Error: row "+(i+1)+"!";
                    return;
                }
            }
            PerformTest(label10, nums);
        }

        public MainDialog()
        {
            InitializeComponent();
        }
        // Evaluation of machine-randomized and textfile numbers
        private void MainDialog_Shown(object sender, EventArgs e)
        {
            Random rand = new Random();
            // Generating machine-randomized numbers
            sdRand = new int[ACount];
            ddRand = new int[ACount];
            tdRand = new int[ACount];
            for (int i = 0; i<ACount; i++)
            {
                sdRand[i] = rand.Next(0, 10);
                ddRand[i] = rand.Next(0, 100);
                tdRand[i] = rand.Next(0, 1000);
            }
            // Loading numbers from textfile
            sdFile = ParseIntFile("single_digits.txt");
            ddFile = ParseIntFile("double_digits.txt");
            tdFile = ParseIntFile("triple_digits.txt");
            for (int i = 0; i<NCount; i++)
            {
                dataGridView1.Rows.Add(sdRand[i], ddRand[i], tdRand[i]);
                dataGridView3.Rows.Add(sdFile[i], ddFile[i], tdFile[i]);
            }
            // Evaluating machine-randomized and textfile numbers
            PerformTest(label4, sdRand);
            PerformTest(label5, ddRand);
            PerformTest(label6, tdRand);
            PerformTest(label7, sdFile);
            PerformTest(label8, ddFile);
            PerformTest(label9, tdFile);
            CalculateGrid();
        }

        void PerformTest(Label l, IList<int> src)
        {
            var result = rndTest.Test(src, Lim)[0];
            l.Text = string.Format("PRB = {0}%", result.ToString("0.0000"));
        }
        // On cell edit
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { CalculateGrid(); }
        // On row deletion
        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        { CalculateGrid(); }
    }
}
