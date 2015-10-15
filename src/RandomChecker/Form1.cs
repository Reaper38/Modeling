using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RandomChecker
{
    public partial class Form1 : Form
    {
        private const int ACount = 1000; // Array size
        private const int NCount = 15; // Shown number of arrays
        private const int Lim = 100; // Sequence limit
        // Machine-randomized numbers
        private int[] sdRand, ddRand, tdRand;
        // Numbers from textfile
        private int[] sdFile, ddFile, tdFile;

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
        private double RandomCheck(ref int[] sequence)
        {
            // If sequence is too big
            if (sequence.Length>Lim)
            {
                double step = (double)sequence.Length/Lim;
                int[] seq = new int[Lim];
                for (int i = 0; i<Lim; i++)
                    seq[i] = sequence[(int)(step*i)];
                return RandomCheck(ref seq);
            }
            // Calculating pyramid size
            int count = 1;
            for (int i = sequence.Length-1; i>1; i--)
                count += i;
            // Pyramid of subsequent substractions
            int[] pyramid = new int[count];
            for (int i = 1; i<sequence.Length; i++)
                pyramid[i-1] = sequence[i]-sequence[i-1];
            int j = 0;
            for (int i = sequence.Length-1; i>0; i--)
            {
                for (int k = 1; k<i; k++)
                    pyramid[j+i+k-1] = pyramid[j+k] - pyramid[j+k-1];
                j += i;
            }
            // Get all distinct numbers (bar 0) from pyramid
            int[] diff = pyramid.Distinct().Where(x => x!=0).ToArray();
            return diff.Length/(double)pyramid.Length;
        }
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
            // Array evaluation
            double res = RandomCheck(ref nums);
            label10.Text = "PRB = "+res.ToString("0.0000%");
        }

        public Form1()
        {
            InitializeComponent();
        }
        // Evaluation of machine-randomized and textfile numbers
        private void Form1_Shown(object sender, EventArgs e)
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
            double res = RandomCheck(ref sdRand);
            label4.Text = "PRB = "+res.ToString("0.0000%");
            res = RandomCheck(ref ddRand);
            label5.Text = "PRB = "+res.ToString("0.0000%");
            res = RandomCheck(ref tdRand);
            label6.Text = "PRB = "+res.ToString("0.0000%");
            res = RandomCheck(ref sdFile);
            label7.Text = "PRB = "+res.ToString("0.0000%");
            res = RandomCheck(ref ddFile);
            label8.Text = "PRB = "+res.ToString("0.0000%");
            res = RandomCheck(ref tdFile);
            label9.Text = "PRB = "+res.ToString("0.0000%");
            CalculateGrid();
        }
        // On cell edit
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { CalculateGrid(); }
        // On row deletion
        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        { CalculateGrid(); }
    }
}
