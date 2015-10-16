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
            this.SingleDigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoubleDigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripleDigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserSeq = new System.Windows.Forms.DataGridView();
            this.UserBased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTabSeq = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabSeq)).BeginInit();
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
            this.dgvAlgSeq.Location = new System.Drawing.Point(12, 32);
            this.dgvAlgSeq.Name = "dgvAlgSeq";
            this.dgvAlgSeq.ReadOnly = true;
            this.dgvAlgSeq.RowHeadersVisible = false;
            this.dgvAlgSeq.RowHeadersWidth = 80;
            this.dgvAlgSeq.RowTemplate.Height = 24;
            this.dgvAlgSeq.Size = new System.Drawing.Size(470, 398);
            this.dgvAlgSeq.TabIndex = 0;
            // 
            // SingleDigit
            // 
            this.SingleDigit.HeaderText = "0 <= X < 10";
            this.SingleDigit.MaxInputLength = 1;
            this.SingleDigit.Name = "SingleDigit";
            this.SingleDigit.ReadOnly = true;
            // 
            // DoubleDigit
            // 
            this.DoubleDigit.HeaderText = "0 <= X < 100";
            this.DoubleDigit.MaxInputLength = 2;
            this.DoubleDigit.Name = "DoubleDigit";
            this.DoubleDigit.ReadOnly = true;
            // 
            // TripleDigit
            // 
            this.TripleDigit.HeaderText = "0 <= X < 1000";
            this.TripleDigit.MaxInputLength = 3;
            this.TripleDigit.Name = "TripleDigit";
            this.TripleDigit.ReadOnly = true;
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
            this.dgvUserSeq.Location = new System.Drawing.Point(978, 32);
            this.dgvUserSeq.Name = "dgvUserSeq";
            this.dgvUserSeq.RowHeadersVisible = false;
            this.dgvUserSeq.RowTemplate.Height = 24;
            this.dgvUserSeq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserSeq.Size = new System.Drawing.Size(124, 398);
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
            this.dgvTabSeq.Location = new System.Drawing.Point(494, 32);
            this.dgvTabSeq.Name = "dgvTabSeq";
            this.dgvTabSeq.ReadOnly = true;
            this.dgvTabSeq.RowHeadersVisible = false;
            this.dgvTabSeq.RowHeadersWidth = 80;
            this.dgvTabSeq.RowTemplate.Height = 24;
            this.dgvTabSeq.Size = new System.Drawing.Size(470, 398);
            this.dgvTabSeq.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "0 <= X < 10";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "0 <= X < 100";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 2;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "0 <= X < 1000";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Generated sequence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table sequence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(978, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input";
            // 
            // lAlgSeq1
            // 
            this.lAlgSeq1.AutoSize = true;
            this.lAlgSeq1.Location = new System.Drawing.Point(22, 438);
            this.lAlgSeq1.Name = "lAlgSeq1";
            this.lAlgSeq1.Size = new System.Drawing.Size(0, 17);
            this.lAlgSeq1.TabIndex = 6;
            // 
            // lAlgSeq2
            // 
            this.lAlgSeq2.AutoSize = true;
            this.lAlgSeq2.Location = new System.Drawing.Point(178, 438);
            this.lAlgSeq2.Name = "lAlgSeq2";
            this.lAlgSeq2.Size = new System.Drawing.Size(0, 17);
            this.lAlgSeq2.TabIndex = 7;
            // 
            // lAlgSeq3
            // 
            this.lAlgSeq3.AutoSize = true;
            this.lAlgSeq3.Location = new System.Drawing.Point(334, 438);
            this.lAlgSeq3.Name = "lAlgSeq3";
            this.lAlgSeq3.Size = new System.Drawing.Size(0, 17);
            this.lAlgSeq3.TabIndex = 8;
            // 
            // lTabSeq1
            // 
            this.lTabSeq1.AutoSize = true;
            this.lTabSeq1.Location = new System.Drawing.Point(504, 438);
            this.lTabSeq1.Name = "lTabSeq1";
            this.lTabSeq1.Size = new System.Drawing.Size(0, 17);
            this.lTabSeq1.TabIndex = 9;
            // 
            // lTabSeq2
            // 
            this.lTabSeq2.AutoSize = true;
            this.lTabSeq2.Location = new System.Drawing.Point(660, 438);
            this.lTabSeq2.Name = "lTabSeq2";
            this.lTabSeq2.Size = new System.Drawing.Size(0, 17);
            this.lTabSeq2.TabIndex = 10;
            // 
            // lTabSeq3
            // 
            this.lTabSeq3.AutoSize = true;
            this.lTabSeq3.Location = new System.Drawing.Point(816, 438);
            this.lTabSeq3.Name = "lTabSeq3";
            this.lTabSeq3.Size = new System.Drawing.Size(0, 17);
            this.lTabSeq3.TabIndex = 11;
            // 
            // lUserSeq
            // 
            this.lUserSeq.AutoSize = true;
            this.lUserSeq.Location = new System.Drawing.Point(988, 438);
            this.lUserSeq.Name = "lUserSeq";
            this.lUserSeq.Size = new System.Drawing.Size(0, 17);
            this.lUserSeq.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 463);
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
            this.Name = "Form1";
            this.Text = "Random checker";
            this.Shown += new System.EventHandler(this.MainDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabSeq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlgSeq;
        private System.Windows.Forms.DataGridView dgvUserSeq;
        private System.Windows.Forms.DataGridView dgvTabSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingleDigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoubleDigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripleDigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
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
    }
}

