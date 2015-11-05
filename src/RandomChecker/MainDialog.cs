using System;
using System.Windows.Forms;

namespace RandomChecker
{
    public partial class MainDialog : Form
    {
        private const int CustomRandSeqLength = 1000;
        // Machine-randomized numbers
        private RandomSequence sdRand, ddRand, tdRand;
        // Numbers from textfile
        private RandomSequence sdFile, ddFile, tdFile;
        private RandomSequence userSeq = RandomSequence.CreateEmpty(2);
        private readonly IRandomSequenceTest rndTest = new ApproximateEntropyTest();
        private byte prevBitLength;
        
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
                if (!ParseUserSeqCell(i))
                    return;
            }
            PerformTest(lUserSeq, userSeq);
        }

        private bool ParseUserSeqCell(int index)
        {
            try
            {
                userSeq[index] = Convert.ToInt32(dgvUserSeq[0, index].Value);
                return true;
            }
            catch (FormatException)
            {
                lUserSeq.Text = "Error: row "+(index+1)+"!";
                return false;
            }
        }

        public MainDialog()
        {
            InitializeComponent();
            prevBitLength = Convert.ToByte(numBitLength.Value);
        }

        private void numBitLength_ValueChanged(object sender, EventArgs e)
        {
            var currentValue = Convert.ToByte(numBitLength.Value);
            userSeq.SignificantBits = currentValue;
            if (currentValue>=prevBitLength)
            {
                prevBitLength = currentValue;
                return;
            }
            int rowCount = dgvUserSeq.RowCount-1;
            for (int i = 0; i<rowCount; i++)
                VerifyBitLength(i, currentValue);
        }

        private void VerifyBitLength(int index, int keepBits)
        {
            var x = Convert.ToInt32(dgvUserSeq[0, index].Value);
            x &= ~(~0<<keepBits);
            dgvUserSeq[0, index].Value = x;
            userSeq[index] = x;
        }

        private void MainDialog_Shown(object sender, EventArgs e)
        {
            Random rand = new Random();
            sdRand = RandomSequence.Generate(CustomRandSeqLength, 1, sb => rand.Next(0, 2));
            ddRand = RandomSequence.Generate(CustomRandSeqLength, 2, sb => rand.Next(0, 4));
            tdRand = RandomSequence.Generate(CustomRandSeqLength, 3, sb => rand.Next(0, 8));
            sdFile = RandomSequence.Load("single_digits.txt", 1);
            ddFile = RandomSequence.Load("double_digits.txt", 2);
            tdFile = RandomSequence.Load("triple_digits.txt", 3);
            for (int i = 0; i<sdRand.Data.Count; i++)
                dgvAlgSeq.Rows.Add(sdRand[i], ddRand[i], tdRand[i]);
            for (int i = 0; i<sdFile.Data.Count; i++)
                dgvTabSeq.Rows.Add(sdFile[i], ddFile[i], tdFile[i]);
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
            var result = rndTest.Test(src.Data, int.MaxValue, src.SignificantBits)[0];
            string format = result<0.0001 ? "E" : "0.0000";
            l.Text = string.Format("PRB = {0}", result.ToString(format));
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int keepBits = (int)numBitLength.Value;
            userSeq.EnsureLength(e.RowIndex+1);
            if (!ParseUserSeqCell(e.RowIndex))
                return;
            VerifyBitLength(e.RowIndex, keepBits);
            CalculateGrid();
        }

        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        { CalculateGrid(); }
    }
}
