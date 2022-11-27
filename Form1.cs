using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace teorVer_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double distributionParametr;
        private int count;
        private void btn_modelling_Click(object sender, EventArgs e)
        {
            this.ChartDistribution.Series[0].Points.Clear();
            this.ChartDistribution.Series[1].Points.Clear();
            try
            {
                distributionParametr = Convert.ToDouble(DistributionParametr.Text.Replace(".", ","));
                count = Convert.ToInt32(Count.Text);
            }
            catch
            {
                MessageBox.Show("Введите все поля!");
            }

            Random r = new Random();
            List<double> PointsY = new List<double>();

            for (int i = 0; i < count; i++)
            {
                double r1 = r.NextDouble();
                PointsY.Add(-(Math.Log(1 - r1) / distributionParametr));
            }

            double interval = PointsY.Max() / 20;
            double inInterval = interval;
            int[] countInterval = new int[20];
            for (int i = 0; i < PointsY.Count; i++)
            {
                inInterval = interval;
                for (int j = 0; j < countInterval.Length; j++)
                {
                    if (PointsY[i] < inInterval)
                    {
                        countInterval[j]++;
                        break;
                    }
                    else
                    {
                        inInterval += interval;
                    }
                }
            }

            double x = interval / 2;
            for (int k = 0; k < 20; k++)
            {
                this.ChartDistribution.Series[0].Points.AddXY(x, countInterval[k] / (count * interval));
                x += interval;
            }

            x = interval / 2;
            double g = 0;
            for (int i = 0; i < 21; i++)
            {
                if (i == 0)
                {
                    g = distributionParametr * Math.Exp(-distributionParametr * 0);
                    this.ChartDistribution.Series[1].Points.AddXY(0, g);
                }
                g = distributionParametr * Math.Exp(-distributionParametr * x);
                this.ChartDistribution.Series[1].Points.AddXY(x, g);
                x += interval;
            }
        }

        private void DistributionParametr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // цифры, клавиша BackSpace и запятая с точкой
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // цифры, клавиша BackSpace
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
