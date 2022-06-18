using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntheticDivisionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MakeGrid_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtBox_Orde.Text);

            dtGridView_Poly.Rows.Clear();
            dtGridView_Poly.Columns.Clear();
            dtGridView_Ans.Rows.Clear();
            dtGridView_Ans.Columns.Clear();

            for (int i = N; i >= 0; i--)
            {
                var colPoly = new DataGridViewColumn();
                colPoly.HeaderText = ("x^" + i.ToString());
                colPoly.CellTemplate = new DataGridViewTextBoxCell();
                colPoly.Width = 40;
                dtGridView_Poly.Columns.Add(colPoly);
                var colAns = new DataGridViewColumn();
                colAns.HeaderText = ("x^" + i.ToString());
                colAns.CellTemplate = new DataGridViewTextBoxCell();
                colAns.Width = 40;
                dtGridView_Ans.Columns.Add(colAns);
            }
            var colR = new DataGridViewColumn();
            colR.HeaderText = ("Reminder");
            colR.CellTemplate = new DataGridViewTextBoxCell();
            colR.Width = 70;
            dtGridView_Ans.Columns.Add(colR);
            dtGridView_Poly.Rows.Add();
            dtGridView_Ans.Rows.Add();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            double[] PolyN;
            double[] Ans;
            int F = int.Parse(txtBox_Factor.Text);
            int N = int.Parse(txtBox_Orde.Text) + 1;

            PolyN = new double[N];
            Ans = new double[N];

            for (int i = 0; i < N; i++)
            {
                PolyN[N-1-i] = Convert.ToDouble(dtGridView_Poly[i, 0].Value);
            }
            Ans = Pol_Synth_Div(PolyN, Ans, F);
            for (int i = 0; i < Ans.Length; i++)
            {
                dtGridView_Ans[i, 0].Value = Ans[Ans.Length-1-i];
            }
        }

        private double[] Pol_Synth_Div(double[] A, double[] B, int f)
        {
            int n = A.Length;
            double r = A[n-1];
            A[n-1] = 0;
            for (int i = n - 2; i >= 0; i--)
            {
                double s = A[i];
                A[i] = r;
                r = s + r * f;
            }
            dtGridView_Ans[n, 0].Value = r;
            if (r == 0)
            {
                txtBox_IsFactor.Text += ("x = " + Convert.ToString(f) + " Merupakan Akar Dari Persamaan Polynomial di Atas");
            }
            else
            {
                txtBox_IsFactor.Text += ("x = " + Convert.ToString(f) + " Bukan Merupakan Akar Dari Persamaan Polynomial di Atas");
            }
            txtBox_IsFactor.Text += (Environment.NewLine);
            return A;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_IsFactor.Text = "";
            dtGridView_Poly.Rows.Clear();
            dtGridView_Poly.Columns.Clear();
            dtGridView_Ans.Rows.Clear();
            dtGridView_Ans.Columns.Clear();
        }
    }
}
