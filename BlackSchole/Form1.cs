using Accord.Statistics.Distributions.Univariate;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BlackSchole
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxUnit.SelectedItem = "year";

            #region Unit tests (for tests purpose only /!\ do not commit this commented block in production)

            //textBoxStockPrice.Text = "50";
            //textBoxStrikePrice.Text = "55";
            //textBoxTime.Text = "1";
            //textBoxVolatility.Text = "0,2";
            //textBoxRisk.Text = "0,09";

            //textBoxStockPrice.Text = "64";
            //textBoxStrikePrice.Text = "60";
            //textBoxTime.Text = "0,49315068";
            //textBoxVolatility.Text = "0,27";
            //textBoxRisk.Text = "0,045";

            #endregion
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double call = 0;
            double put = 0;

            labelResult.Text = string.Empty;

            string error = string.Empty;

            #region test if the fields are correctly filled

            if (!int.TryParse(textBoxStockPrice.Text, out int num2)) error += "stock empty or incorrect" + Environment.NewLine;
            if (!int.TryParse(textBoxStrikePrice.Text, out num2)) error += "strike empty or incorrect" + Environment.NewLine;
            if (!double.TryParse(textBoxTime.Text, out double num)) error += "time empty or incorrect" + Environment.NewLine;
            if (!double.TryParse(textBoxVolatility.Text, out num)) error += "volatility empty or incorrect" + Environment.NewLine;
            if (!double.TryParse(textBoxRisk.Text, out num)) error += "risk empty or incorrect";

            #endregion

            if (error == string.Empty) // if there is no error
            {
                int S = Convert.ToInt32(textBoxStockPrice.Text);
                int K = Convert.ToInt32(textBoxStrikePrice.Text);
                double t = Convert.ToDouble(textBoxTime.Text);
                double o = Convert.ToDouble(textBoxVolatility.Text);
                double r = Convert.ToDouble(textBoxRisk.Text);

                switch (comboBoxUnit.SelectedItem) //convert from the correct unit
                {
                    case "month":
                        t = t / 12;
                        break;
                    case "day":
                        t = t / 365;
                        break;
                }

                double d1 = CalculateD1(S, K, t, o, r);
                double d2 = CalculateD2(d1, o, t);

                var checkedButton = groupBoxRadioButton.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(v => v.Checked);

                labelResult.Text = "d1 = " + Math.Round(d1, 4) + Environment.NewLine;
                labelResult.Text += "d2 = " + Math.Round(d2, 4) + Environment.NewLine;

                switch (checkedButton.Tag)
                {
                    case "call":
                        call = CalculateCall(S, K, r, t, d1, d2);
                        labelResult.Text += "Call : " + Math.Round(call, 4);
                        break;
                    case "put":
                        put = CalculatePut(r, K, t, S, -d1, -d2);
                        labelResult.Text += "Put : " + Math.Round(put, 4);
                        break;
                    case "all":
                        call = CalculateCall(S, K, r, t, d1, d2);
                        put = CalculatePut(r, K, t, S, -d1, -d2);
                        labelResult.Text += "Call : " + Math.Round(call, 4) + Environment.NewLine;
                        labelResult.Text += "Put : " + Math.Round(put, 4);
                        break;
                }
            }
            else // Display error message
            {
                labelResult.Text = error;
            }
        }

        private double CalculateD2(double d1, double o, double t)
        {
            return d1 - (o * Math.Sqrt(t));
        }

        private double CalculateD1(int s, int k, double t, double o, double r)
        {
            double supp = (Math.Log(Convert.ToDouble(s) / Convert.ToDouble(k))) + ((r + (Math.Pow(o, 2) / 2)) * t);

            double inf = o * Math.Sqrt(t);

            return supp / inf;

        }

        private double CalculateCall(int S, int K, double r, double t, double d1, double d2)
        {
            NormalDistribution Normal = new NormalDistribution();

            double NormalDistributionLawD1 = Normal.DistributionFunction(Math.Abs(d1));

            double NormalDistributionLawD2 = Normal.DistributionFunction(Math.Abs(d2));

            if (d1 < 0) NormalDistributionLawD1 = 1 - NormalDistributionLawD1;
            if (d2 < 0) NormalDistributionLawD2 = 1 - NormalDistributionLawD2;

            return (S * NormalDistributionLawD1) - (K * (Math.Exp(-r * t))) * (NormalDistributionLawD2);
        }

        private double CalculatePut(double r, int K, double t, int S, double d1, double d2)
        {
            NormalDistribution Normal = new NormalDistribution();

            double NormalDistributionLawD1 = Normal.DistributionFunction(Math.Abs(d1));

            double NormalDistributionLawD2 = Normal.DistributionFunction(Math.Abs(d2));

            if (d1 < 0) NormalDistributionLawD1 = 1 - NormalDistributionLawD1;
            if (d2 < 0) NormalDistributionLawD2 = 1 - NormalDistributionLawD2;

            return (K * Math.Exp(-r * t) * NormalDistributionLawD2) - (S * NormalDistributionLawD1);
        }
    }
}
