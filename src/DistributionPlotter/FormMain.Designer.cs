namespace DistributionPlotter
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.rbtnUni = new System.Windows.Forms.RadioButton();
            this.rbtnExp = new System.Windows.Forms.RadioButton();
            this.panelChDist = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInp = new System.Windows.Forms.Panel();
            this.numIn2 = new System.Windows.Forms.NumericUpDown();
            this.numIn1 = new System.Windows.Forms.NumericUpDown();
            this.lblPoi = new System.Windows.Forms.Label();
            this.numPoint = new System.Windows.Forms.NumericUpDown();
            this.panelRes = new System.Windows.Forms.Panel();
            this.txbxMo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxDisp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.panelChDist.SuspendLayout();
            this.panelInp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint)).BeginInit();
            this.panelRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnUni
            // 
            this.rbtnUni.AutoSize = true;
            this.rbtnUni.Location = new System.Drawing.Point(14, 37);
            this.rbtnUni.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnUni.Name = "rbtnUni";
            this.rbtnUni.Size = new System.Drawing.Size(61, 17);
            this.rbtnUni.TabIndex = 0;
            this.rbtnUni.Text = "Uniform";
            this.rbtnUni.UseVisualStyleBackColor = true;
            this.rbtnUni.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnExp
            // 
            this.rbtnExp.AutoSize = true;
            this.rbtnExp.Location = new System.Drawing.Point(14, 59);
            this.rbtnExp.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnExp.Name = "rbtnExp";
            this.rbtnExp.Size = new System.Drawing.Size(83, 17);
            this.rbtnExp.TabIndex = 1;
            this.rbtnExp.Text = "Exponential ";
            this.rbtnExp.UseVisualStyleBackColor = true;
            this.rbtnExp.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panelChDist
            // 
            this.panelChDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChDist.Controls.Add(this.label1);
            this.panelChDist.Controls.Add(this.rbtnUni);
            this.panelChDist.Controls.Add(this.rbtnExp);
            this.panelChDist.Location = new System.Drawing.Point(9, 10);
            this.panelChDist.Margin = new System.Windows.Forms.Padding(2);
            this.panelChDist.Name = "panelChDist";
            this.panelChDist.Size = new System.Drawing.Size(155, 109);
            this.panelChDist.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distribution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // panelInp
            // 
            this.panelInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInp.Controls.Add(this.numIn2);
            this.panelInp.Controls.Add(this.numIn1);
            this.panelInp.Controls.Add(this.lblPoi);
            this.panelInp.Controls.Add(this.numPoint);
            this.panelInp.Controls.Add(this.label3);
            this.panelInp.Controls.Add(this.label2);
            this.panelInp.Location = new System.Drawing.Point(9, 135);
            this.panelInp.Margin = new System.Windows.Forms.Padding(2);
            this.panelInp.Name = "panelInp";
            this.panelInp.Size = new System.Drawing.Size(155, 106);
            this.panelInp.TabIndex = 7;
            // 
            // numIn2
            // 
            this.numIn2.DecimalPlaces = 3;
            this.numIn2.Location = new System.Drawing.Point(73, 57);
            this.numIn2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIn2.Name = "numIn2";
            this.numIn2.Size = new System.Drawing.Size(77, 20);
            this.numIn2.TabIndex = 10;
            this.numIn2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numIn1
            // 
            this.numIn1.DecimalPlaces = 3;
            this.numIn1.Location = new System.Drawing.Point(73, 31);
            this.numIn1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIn1.Name = "numIn1";
            this.numIn1.Size = new System.Drawing.Size(77, 20);
            this.numIn1.TabIndex = 9;
            this.numIn1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPoi
            // 
            this.lblPoi.AutoSize = true;
            this.lblPoi.Location = new System.Drawing.Point(10, 7);
            this.lblPoi.Name = "lblPoi";
            this.lblPoi.Size = new System.Drawing.Size(39, 13);
            this.lblPoi.TabIndex = 8;
            this.lblPoi.Text = "Points:";
            // 
            // numPoint
            // 
            this.numPoint.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPoint.Location = new System.Drawing.Point(73, 5);
            this.numPoint.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPoint.Name = "numPoint";
            this.numPoint.Size = new System.Drawing.Size(77, 20);
            this.numPoint.TabIndex = 7;
            this.numPoint.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // panelRes
            // 
            this.panelRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRes.Controls.Add(this.txbxMo);
            this.panelRes.Controls.Add(this.label4);
            this.panelRes.Controls.Add(this.txbxDisp);
            this.panelRes.Controls.Add(this.label5);
            this.panelRes.Location = new System.Drawing.Point(9, 256);
            this.panelRes.Margin = new System.Windows.Forms.Padding(2);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(155, 108);
            this.panelRes.TabIndex = 8;
            // 
            // txbxMo
            // 
            this.txbxMo.Location = new System.Drawing.Point(14, 21);
            this.txbxMo.Margin = new System.Windows.Forms.Padding(2);
            this.txbxMo.Name = "txbxMo";
            this.txbxMo.ReadOnly = true;
            this.txbxMo.Size = new System.Drawing.Size(123, 20);
            this.txbxMo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Variance";
            // 
            // txbxDisp
            // 
            this.txbxDisp.Location = new System.Drawing.Point(14, 73);
            this.txbxDisp.Margin = new System.Windows.Forms.Padding(2);
            this.txbxDisp.Name = "txbxDisp";
            this.txbxDisp.ReadOnly = true;
            this.txbxDisp.Size = new System.Drawing.Size(123, 20);
            this.txbxDisp.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Expected value";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(9, 376);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(154, 46);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(176, 9);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(592, 392);
            this.zedGraph.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 431);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.panelInp);
            this.Controls.Add(this.panelChDist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Distribution plotter";
            this.panelChDist.ResumeLayout(false);
            this.panelChDist.PerformLayout();
            this.panelInp.ResumeLayout(false);
            this.panelInp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint)).EndInit();
            this.panelRes.ResumeLayout(false);
            this.panelRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnUni;
        private System.Windows.Forms.RadioButton rbtnExp;
        private System.Windows.Forms.Panel panelChDist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInp;
        private System.Windows.Forms.Panel panelRes;
        private System.Windows.Forms.TextBox txbxMo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxDisp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRun;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Label lblPoi;
        private System.Windows.Forms.NumericUpDown numPoint;
        private System.Windows.Forms.NumericUpDown numIn1;
        private System.Windows.Forms.NumericUpDown numIn2;
    }
}

