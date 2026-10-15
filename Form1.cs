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
            BuildSummaryControls();
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

        private void BuildSummaryControls()
        {
            string[] captions = { "Total animals", "Average age (years)", "Average recovery score", "Critical", "Serious", "Stable", "Recovering", "Release-Ready" };
            Label[] valueLabels = { lblTotalValue, lblAverageAgeValue, lblAverageScoreValue, lblCriticalValue, lblSeriousValue, lblStableValue, lblRecoveringValue, lblReleaseReadyValue };

            for (int i = 0; i < 8; i++)
            {
                // Caption Label
                Label caption = new Label();
                caption.Location = new Point(20, 70 + (i * 30));
                caption.Size = new Size(160, 20);
                caption.Text = captions[i];
                this.Controls.Add(caption);

                // Value Label
                valueLabels[i].Location = new Point(190, 70 + (i * 30));
                valueLabels[i].Size = new Size(100, 20);
                this.Controls.Add(valueLabels[i]);
            }
        }
    }
}
