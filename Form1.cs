using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2782_Project_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            string filePath = "animals.txt";
            SummaryResult result = SummaryService.Calculate(filePath);

            // Fill in the labels
            lblTotalValue.Text = result.Total.ToString();
            lblAverageAgeValue.Text = result.AvgAge;
            lblAverageScoreValue.Text = result.AvgScore;
            lblCriticalValue.Text = result.Critical.ToString();
            lblSeriousValue.Text = result.Serious.ToString();
            lblStableValue.Text = result.Stable.ToString();
            lblRecoveringValue.Text = result.Recovering.ToString();
            lblReleaseReadyValue.Text = result.ReleaseReady.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
