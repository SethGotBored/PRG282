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

            // Set default "0" text for value labels
            this.lblTotalValue.Text = "0";
            this.lblAverageAgeValue.Text = "0";
            this.lblAverageScoreValue.Text = "0";
            this.lblCriticalValue.Text = "0";
            this.lblSeriousValue.Text = "0";
            this.lblStableValue.Text = "0";
            this.lblRecoveringValue.Text = "0";
            this.lblReleaseReadyValue.Text = "0";

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