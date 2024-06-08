using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ИМ_Лаб2
{
    public partial class Form_Сurrency : Form
    {
        public Form_Сurrency()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            curr_dollar = (double)el_Dollar.Value;
            curr_euro = (double)el_Euro.Value;
            chart1.Series[0].Points.AddXY(0, curr_dollar);
            chart1.Series[1].Points.AddXY(0, curr_euro);
        }

        const double k = 0.02;
        Random rnd = new Random();
        double curr_dollar = 0;
        double curr_euro = 0;
        bool f = false;

        private void bt_Start_Click(object sender, EventArgs e)
        {
            if (f) {
                timer1.Stop();
                f = false;
                bt_Start.Text = "Старт";
            }
            else
            {
                timer1.Start();
                f = true;
                bt_Start.Text = "Стоп";
            }
        }

        private double N(double e, double q)
        {
            double sum = 0;

            double num_summand = 100;

            for (int i = 0; i < num_summand; i++)
            {
                sum += rnd.NextDouble();
            }

            sum -= num_summand / 2;
            sum *= Math.Sqrt(num_summand);

            return sum * Math.Sqrt(q) + e;
        }
        double drift = 0.05, volatility = 0.2;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            curr_dollar = curr_dollar * (1 + drift + volatility * N(0, 1));
            chart1.Series[0].Points.AddXY(0, curr_dollar);

            curr_euro = curr_euro * (1 + drift + volatility * N(0, 1));
            chart1.Series[1].Points.AddXY(0, curr_euro);
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.AddXY(0, curr_dollar);
            chart1.Series[1].Points.AddXY(0, curr_euro);
        }
    }
}
