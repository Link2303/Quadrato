using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLQUADRATO;

namespace WFQUADRATO
{
    public partial class Form_Menu : Form
    {
        QUADRATO Q1;
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void B_Q_Click(object sender, EventArgs e)
        {
            double X, Y, L;
            try
            {
                X = Convert.ToDouble(TB_X.Text);
                try
                {
                    Y = Convert.ToDouble(TB_Y.Text);
                    try
                    {
                        L = Convert.ToDouble(TB_L.Text);
                        Q1 = new QUADRATO(L, X, Y);
                        BT_A.Enabled = true;
                        BT_P.Enabled = true;
                        B_Q.Enabled = false;
                        B_X.Enabled = true;
                        B_Y.Enabled = true;
                        B_L.Enabled = true;
                    }
                    catch (Exception ERRORE)
                    {
                        MessageBox.Show("Problema LATO: " + ERRORE.Message);
                        TB_L.Focus();
                        TB_L.SelectAll();
                    }
                }
                catch (Exception ERRORE)
                {
                    MessageBox.Show("Problema Y: " + ERRORE.Message);
                    TB_Y.Focus();
                    TB_Y.SelectAll();
                }
            }
            catch (Exception ERRORE)
            {
                MessageBox.Show("Problema X: " + ERRORE.Message);
                TB_X.Focus();
                TB_X.SelectAll();
            }
        }

        private void BT_A_Click(object sender, EventArgs e)
        {
            TB_A.Text = Q1.AREA().ToString();
        }

        private void BT_P_Click(object sender, EventArgs e)
        {
            TB_P.Text = Q1.PERIMETRO().ToString();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void B_X_Click(object sender, EventArgs e)
        {
            Q1.XP = Convert.ToDouble(TB_X.Text);
        }

        private void B_Y_Click(object sender, EventArgs e)
        {
            Q1.YP = Convert.ToDouble(TB_Y.Text);
        }

        private void B_L_Click(object sender, EventArgs e)
        {
            Q1.LP = Convert.ToDouble(TB_L.Text);
        }

        private void P_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics Pen;
            Pen Penna1;
            Pen Penna2;

            Graphics Foglio;
            Penna1 = new Pen(Color.Indigo, 2);

            Foglio = P.CreateGraphics();
            Foglio.TranslateTransform(P.Width / 2, P.Height / 2);
            Foglio.ScaleTransform(1, -1);
            Foglio.DrawLine(Penna1, (float)(Q1.XP - (Q1.LP / 2)), (float)(Q1.YP - (Q1.LP / 2)), (float)(2 * Q1.LP), (float)(2 * Q1.LP));
        }
    }
}
