namespace PRG2782_Project_2026
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnGenerateSummary = new System.Windows.Forms.Button();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblAverageAgeValue = new System.Windows.Forms.Label();
            this.lblAverageScoreValue = new System.Windows.Forms.Label();
            this.lblCriticalValue = new System.Windows.Forms.Label();
            this.lblSeriousValue = new System.Windows.Forms.Label();
            this.lblStableValue = new System.Windows.Forms.Label();
            this.lblRecoveringValue = new System.Windows.Forms.Label();
            this.lblReleaseReadyValue = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Button
            this.btnGenerateSummary.Location = new System.Drawing.Point(20, 20);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(160, 30);
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = true;
            this.btnGenerateSummary.Click += new System.EventHandler(this.btnGenerateSummary_Click);

            // Caption and Value Labels
            string[] captions = { "Total animals", "Average age (years)", "Average recovery score", "Critical", "Serious", "Stable", "Recovering", "Release-Ready" };
            System.Windows.Forms.Label[] valueLabels = { this.lblTotalValue, this.lblAverageAgeValue, this.lblAverageScoreValue, this.lblCriticalValue, this.lblSeriousValue, this.lblStableValue, this.lblRecoveringValue, this.lblReleaseReadyValue };

            for (int i = 0; i < 8; i++)
            {
                // Caption Label
                System.Windows.Forms.Label caption = new System.Windows.Forms.Label();
                caption.Location = new System.Drawing.Point(20, 70 + (i * 30));
                caption.Size = new System.Drawing.Size(160, 20);
                caption.Text = captions[i];
                this.Controls.Add(caption);

                // Value Label
                valueLabels[i].Location = new System.Drawing.Point(190, 70 + (i * 30));
                valueLabels[i].Size = new System.Drawing.Size(100, 20);
                valueLabels[i].Text = "0";
                this.Controls.Add(valueLabels[i]);
            }

            // Form1 Setup
            this.ClientSize = new System.Drawing.Size(340, 350);
            this.Controls.Add(this.btnGenerateSummary);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        // Field Declarations
        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblAverageAgeValue;
        private System.Windows.Forms.Label lblAverageScoreValue;
        private System.Windows.Forms.Label lblCriticalValue;
        private System.Windows.Forms.Label lblSeriousValue;
        private System.Windows.Forms.Label lblStableValue;
        private System.Windows.Forms.Label lblRecoveringValue;
        private System.Windows.Forms.Label lblReleaseReadyValue;
    }
}