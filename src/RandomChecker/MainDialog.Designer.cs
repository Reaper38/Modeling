namespace RandomChecker
{
    partial class MainDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlgSeq = new System.Windows.Forms.DataGridView();
            this.dgvUserSeq = new System.Windows.Forms.DataGridView();
            this.UserBased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTabSeq = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lAlgSeq1 = new System.Windows.Forms.Label();
            this.lAlgSeq2 = new System.Windows.Forms.Label();
            this.lAlgSeq3 = new System.Windows.Forms.Label();
            this.lTabSeq1 = new System.Windows.Forms.Label();
            this.lTabSeq2 = new System.Windows.Forms.Label();
            this.lTabSeq3 = new System.Windows.Forms.Label();
            this.lUserSeq = new System.Windows.Forms.Label();
            this.SingleDigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoubleDigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripleDigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numBitLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBitLength)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlgSeq
            // 
            this.dgvAlgSeq.AllowUserToAddRows = false;
            this.dgvAlgSeq.AllowUserToDeleteRows = false;
            this.dgvAlgSeq.AllowUserToResizeColumns = false;
            this.dgvAlgSeq.AllowUserToResizeRows = false;
            this.dgvAlgSeq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlgSeq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAlgSeq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlgSeq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingleDigit,
            this.DoubleDigit,
            this.TripleDigit});
            this.dgvAlgSeq.Location = new System.Drawing.Point(9, 26);
            this.dgvAlgSeq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAlgSeq.Name = "dgvAlgSeq";
            this.dgvAlgSeq.ReadOnly = true;
            this.dgvAlgSeq.RowHeadersVisible = false;
            this.dgvAlgSeq.RowHeadersWidth = 80;
            this.dgvAlgSeq.RowTemplate.Height = 24;
            this.dgvAlgSeq.Size = new System.Drawing.Size(352, 323);
            this.dgvAlgSeq.TabIndex = 0;
            // 
            // dgvUserSeq
            // 
            this.dgvUserSeq.AllowUserToResizeColumns = false;
            this.dgvUserSeq.AllowUserToResizeRows = false;
            this.dgvUserSeq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserSeq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUserSeq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserSeq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserBased});
            this.dgvUserSeq.Location = new System.Drawing.Point(734, 26);
            this.dgvUserSeq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUserSeq.Name = "dgvUserSeq";
            this.dgvUserSeq.RowHeadersVisible = false;
            this.dgvUserSeq.RowTemplate.Height = 24;
            this.dgvUserSeq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserSeq.Size = new System.Drawing.Size(93, 323);
            this.dgvUserSeq.TabIndex = 1;
            this.dgvUserSeq.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dgvUserSeq.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserDeletedRow);
            // 
            // UserBased
            // 
            this.UserBased.HeaderText = "Any X";
            this.UserBased.Name = "UserBased";
            // 
            // dgvTabSeq
            // 
            this.dgvTabSeq.AllowUserToAddRows = false;
            this.dgvTabSeq.AllowUserToDeleteRows = false;
            this.dgvTabSeq.AllowUserToResizeColumns = false;
            this.dgvTabSeq.AllowUserToResizeRows = false;
            this.dgvTabSeq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabSeq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTabSeq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabSeq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvTabSeq.Location = new System.Drawing.Point(370, 26);
            this.dgvTabSeq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTabSeq.Name = "dgvTabSeq";
            this.dgvTabSeq.ReadOnly = true;
            this.dgvTabSeq.RowHeadersVisible = false;
            this.dgvTabSeq.RowHeadersWidth = 80;
            this.dgvTabSeq.RowTemplate.Height = 24;
            this.dgvTabSeq.Size = new System.Drawing.Size(352, 323);
            this.dgvTabSeq.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Generated sequence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table sequence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input";
            // 
            // lAlgSeq1
            // 
            this.lAlgSeq1.AutoSize = true;
            this.lAlgSeq1.Location = new System.Drawing.Point(16, 356);
            this.lAlgSeq1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAlgSeq1.Name = "lAlgSeq1";
            this.lAlgSeq1.Size = new System.Drawing.Size(0, 13);
            this.lAlgSeq1.TabIndex = 6;
            // 
            // lAlgSeq2
            // 
            this.lAlgSeq2.AutoSize = true;
            this.lAlgSeq2.Location = new System.Drawing.Point(134, 356);
            this.lAlgSeq2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAlgSeq2.Name = "lAlgSeq2";
            this.lAlgSeq2.Size = new System.Drawing.Size(0, 13);
            this.lAlgSeq2.TabIndex = 7;
            // 
            // lAlgSeq3
            // 
            this.lAlgSeq3.AutoSize = true;
            this.lAlgSeq3.Location = new System.Drawing.Point(250, 356);
            this.lAlgSeq3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAlgSeq3.Name = "lAlgSeq3";
            this.lAlgSeq3.Size = new System.Drawing.Size(0, 13);
            this.lAlgSeq3.TabIndex = 8;
            // 
            // lTabSeq1
            // 
            this.lTabSeq1.AutoSize = true;
            this.lTabSeq1.Location = new System.Drawing.Point(378, 356);
            this.lTabSeq1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTabSeq1.Name = "lTabSeq1";
            this.lTabSeq1.Size = new System.Drawing.Size(0, 13);
            this.lTabSeq1.TabIndex = 9;
            // 
            // lTabSeq2
            // 
            this.lTabSeq2.AutoSize = true;
            this.lTabSeq2.Location = new System.Drawing.Point(495, 356);
            this.lTabSeq2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTabSeq2.Name = "lTabSeq2";
            this.lTabSeq2.Size = new System.Drawing.Size(0, 13);
            this.lTabSeq2.TabIndex = 10;
            // 
            // lTabSeq3
            // 
            this.lTabSeq3.AutoSize = true;
            this.lTabSeq3.Location = new System.Drawing.Point(612, 356);
            this.lTabSeq3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTabSeq3.Name = "lTabSeq3";
            this.lTabSeq3.Size = new System.Drawing.Size(0, 13);
            this.lTabSeq3.TabIndex = 11;
            // 
            // lUserSeq
            // 
            this.lUserSeq.AutoSize = true;
            this.lUserSeq.Location = new System.Drawing.Point(741, 356);
            this.lUserSeq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUserSeq.Name = "lUserSeq";
            this.lUserSeq.Size = new System.Drawing.Size(0, 13);
            this.lUserSeq.TabIndex = 12;
            // 
            // SingleDigit
            // 
            this.SingleDigit.HeaderText = "1 bit";
            this.SingleDigit.MaxInputLength = 1;
            this.SingleDigit.Name = "SingleDigit";
            this.SingleDigit.ReadOnly = true;
            // 
            // DoubleDigit
            // 
            this.DoubleDigit.HeaderText = "2 bit";
            this.DoubleDigit.MaxInputLength = 2;
            this.DoubleDigit.Name = "DoubleDigit";
            this.DoubleDigit.ReadOnly = true;
            // 
            // TripleDigit
            // 
            this.TripleDigit.HeaderText = "3 bit";
            this.TripleDigit.MaxInputLength = 3;
            this.TripleDigit.Name = "TripleDigit";
            this.TripleDigit.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "1 bit";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "2 bit";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 2;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "3 bit";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // numBitLength
            // 
            this.numBitLength.Location = new System.Drawing.Point(770, 5);
            this.numBitLength.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numBitLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBitLength.Name = "numBitLength";
            this.numBitLength.Size = new System.Drawing.Size(57, 20);
            this.numBitLength.TabIndex = 13;
            this.numBitLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBitLength.ValueChanged += new System.EventHandler(this.numBitLength_ValueChanged);
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 376);
            this.Controls.Add(this.numBitLength);
            this.Controls.Add(this.lUserSeq);
            this.Controls.Add(this.lTabSeq3);
            this.Controls.Add(this.lTabSeq2);
            this.Controls.Add(this.lTabSeq1);
            this.Controls.Add(this.lAlgSeq3);
            this.Controls.Add(this.lAlgSeq2);
            this.Controls.Add(this.lAlgSeq1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTabSeq);
            this.Controls.Add(this.dgvUserSeq);
            this.Controls.Add(this.dgvAlgSeq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainDialog";
            this.Text = "Random checker";
            this.Shown += new System.EventHandler(this.MainDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBitLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlgSeq;
        private System.Windows.Forms.DataGridView dgvUserSeq;
        private System.Windows.Forms.DataGridView dgvTabSeq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lAlgSeq1;
        private System.Windows.Forms.Label lAlgSeq2;
        private System.Windows.Forms.Label lAlgSeq3;
        private System.Windows.Forms.Label lTabSeq1;
        private System.Windows.Forms.Label lTabSeq2;
        private System.Windows.Forms.Label lTabSeq3;
        private System.Windows.Forms.Label lUserSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserBased;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingleDigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoubleDigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripleDigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.NumericUpDown numBitLength;
    }
}

