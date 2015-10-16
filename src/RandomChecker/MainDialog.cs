using System;
using System.Windows.Forms;

namespace RandomChecker
{
    public partial class MainDialog : Form
    {
        private const int ACount = 1000; // Array size
        private const int NCount = 15; // Shown number of arrays
        private const int Lim = 100; // Sequence limit
        // Machine-randomized numbers
        private RandomSequence sdRand, ddRand, tdRand;
        // Numbers from textfile
        private RandomSequence sdFile, ddFile, tdFile;
        private RandomSequence userSeq = RandomSequence.CreateEmpty(2);
        private readonly IRandomSequenceTest rndTest = new ApproximateEntropyTest();
        
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
            userSeq.SetLength(rowCount);
            for (int i = 0; i<rowCount; i++)
            {
                try
                {
                    userSeq[i] = Convert.ToInt32(dgvUserSeq[0, i].Value);
                }
                catch (FormatException)
                {
                    lUserSeq.Text = "Error: row "+(i+1)+"!";
                    return;
                }
            }
            PerformTest(lUserSeq, userSeq);
        }

        public MainDialog()
        {
            InitializeComponent();
        }
        
        private void MainDialog_Shown(object sender, EventArgs e)
        {
            Random rand = new Random();
            sdRand = RandomSequence.Generate(ACount, 1, sb => rand.Next(0, 2));
            ddRand = RandomSequence.Generate(ACount, 2, sb => rand.Next(0, 4));
            tdRand = RandomSequence.Generate(ACount, 3, sb => rand.Next(0, 8));
            sdFile = RandomSequence.Load("single_digits.txt", 1);
            ddFile = RandomSequence.Load("double_digits.txt", 2);
            tdFile = RandomSequence.Load("triple_digits.txt", 3);
            for (int i = 0; i<NCount; i++)
            {
                dgvAlgSeq.Rows.Add(sdRand[i], ddRand[i], tdRand[i]);
                dgvTabSeq.Rows.Add(sdFile[i], ddFile[i], tdFile[i]);
            }
            PerformTest(lAlgSeq1, sdRand);
            PerformTest(lAlgSeq2, ddRand);
            PerformTest(lAlgSeq3, tdRand);
            PerformTest(lTabSeq1, sdFile);
            PerformTest(lTabSeq2, ddFile);
            PerformTest(lTabSeq3, tdFile);
            CalculateGrid();
        }

        void PerformTest(Label l, RandomSequence src)
        {
            var result = rndTest.Test(src.Data, Lim, src.SignificantBits)[0];
            string format = result<0.0001 ? "E" : "0.0000";
            l.Text = string.Format("PRB = {0}", result.ToString(format));
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { CalculateGrid(); }

        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        { CalculateGrid(); }
    }
}
