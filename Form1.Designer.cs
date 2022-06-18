namespace SyntheticDivisionCalculator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Factor = new System.Windows.Forms.TextBox();
            this.dtGridView_Poly = new System.Windows.Forms.DataGridView();
            this.btn_MakeGrid = new System.Windows.Forms.Button();
            this.txtBox_Orde = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.dtGridView_Ans = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txtBox_IsFactor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Poly)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Ans)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Calc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_Orde);
            this.groupBox1.Controls.Add(this.btn_MakeGrid);
            this.groupBox1.Controls.Add(this.dtGridView_Poly);
            this.groupBox1.Controls.Add(this.txtBox_Factor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polynomial Degree";
            // 
            // txtBox_Factor
            // 
            this.txtBox_Factor.Location = new System.Drawing.Point(112, 169);
            this.txtBox_Factor.Name = "txtBox_Factor";
            this.txtBox_Factor.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Factor.TabIndex = 1;
            // 
            // dtGridView_Poly
            // 
            this.dtGridView_Poly.AllowUserToAddRows = false;
            this.dtGridView_Poly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Poly.Location = new System.Drawing.Point(6, 74);
            this.dtGridView_Poly.Name = "dtGridView_Poly";
            this.dtGridView_Poly.Size = new System.Drawing.Size(451, 65);
            this.dtGridView_Poly.TabIndex = 2;
            // 
            // btn_MakeGrid
            // 
            this.btn_MakeGrid.Location = new System.Drawing.Point(356, 32);
            this.btn_MakeGrid.Name = "btn_MakeGrid";
            this.btn_MakeGrid.Size = new System.Drawing.Size(102, 23);
            this.btn_MakeGrid.TabIndex = 3;
            this.btn_MakeGrid.Text = "Make Input Grid";
            this.btn_MakeGrid.UseVisualStyleBackColor = true;
            this.btn_MakeGrid.Click += new System.EventHandler(this.btn_MakeGrid_Click);
            // 
            // txtBox_Orde
            // 
            this.txtBox_Orde.Location = new System.Drawing.Point(112, 34);
            this.txtBox_Orde.Name = "txtBox_Orde";
            this.txtBox_Orde.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Orde.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBox_IsFactor);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.dtGridView_Ans);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 209);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factor ( x = ... )";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(355, 166);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(102, 23);
            this.btn_Calc.TabIndex = 5;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // dtGridView_Ans
            // 
            this.dtGridView_Ans.AllowUserToAddRows = false;
            this.dtGridView_Ans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Ans.Location = new System.Drawing.Point(6, 32);
            this.dtGridView_Ans.Name = "dtGridView_Ans";
            this.dtGridView_Ans.Size = new System.Drawing.Size(451, 65);
            this.dtGridView_Ans.TabIndex = 6;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(355, 174);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(102, 23);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txtBox_IsFactor
            // 
            this.txtBox_IsFactor.Location = new System.Drawing.Point(6, 103);
            this.txtBox_IsFactor.Multiline = true;
            this.txtBox_IsFactor.Name = "txtBox_IsFactor";
            this.txtBox_IsFactor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_IsFactor.Size = new System.Drawing.Size(451, 60);
            this.txtBox_IsFactor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Polynomial Synthetic Division Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Poly)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Ans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Orde;
        private System.Windows.Forms.Button btn_MakeGrid;
        private System.Windows.Forms.DataGridView dtGridView_Poly;
        private System.Windows.Forms.TextBox txtBox_Factor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBox_IsFactor;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dtGridView_Ans;
    }
}

