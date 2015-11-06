namespace TimeCalculator
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.dgvCrossTable = new System.Windows.Forms.DataGridView();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnShrink = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lCrossTable = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrossTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(365, 307);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 41);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // dgvCrossTable
            // 
            this.dgvCrossTable.AllowUserToAddRows = false;
            this.dgvCrossTable.AllowUserToDeleteRows = false;
            this.dgvCrossTable.AllowUserToResizeColumns = false;
            this.dgvCrossTable.AllowUserToResizeRows = false;
            this.dgvCrossTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrossTable.ColumnHeadersVisible = false;
            this.dgvCrossTable.Location = new System.Drawing.Point(9, 37);
            this.dgvCrossTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCrossTable.Name = "dgvCrossTable";
            this.dgvCrossTable.RowHeadersVisible = false;
            this.dgvCrossTable.RowTemplate.Height = 24;
            this.dgvCrossTable.Size = new System.Drawing.Size(338, 255);
            this.dgvCrossTable.TabIndex = 1;
            this.dgvCrossTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCrossTable_CellValueChanged);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.ColumnHeadersVisible = false;
            this.dgvResult.Location = new System.Drawing.Point(365, 37);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(94, 255);
            this.dgvResult.TabIndex = 2;
            // 
            // btnShrink
            // 
            this.btnShrink.Location = new System.Drawing.Point(9, 307);
            this.btnShrink.Margin = new System.Windows.Forms.Padding(2);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(56, 41);
            this.btnShrink.TabIndex = 3;
            this.btnShrink.Text = "-";
            this.btnShrink.UseVisualStyleBackColor = true;
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(86, 307);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(2);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(56, 41);
            this.btnExpand.TabIndex = 4;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(253, 307);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 41);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Очистить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lCrossTable
            // 
            this.lCrossTable.AutoSize = true;
            this.lCrossTable.Location = new System.Drawing.Point(10, 19);
            this.lCrossTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCrossTable.Name = "lCrossTable";
            this.lCrossTable.Size = new System.Drawing.Size(107, 13);
            this.lCrossTable.TabIndex = 6;
            this.lCrossTable.Text = "Матрица переходов";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(365, 19);
            this.lResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(59, 13);
            this.lResult.TabIndex = 7;
            this.lResult.Text = "Результат";
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 358);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lCrossTable);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnShrink);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.dgvCrossTable);
            this.Controls.Add(this.btnCalc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDialog";
            this.Text = "Решение системы состояний";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrossTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DataGridView dgvCrossTable;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lCrossTable;
        private System.Windows.Forms.Label lResult;
    }
}

