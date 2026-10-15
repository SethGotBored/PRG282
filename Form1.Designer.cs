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
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.Location = new System.Drawing.Point(20, 20);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(160, 30);
            this.btnGenerateSummary.TabIndex = 0;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = true;
            this.btnGenerateSummary.Click += new System.EventHandler(this.btnGenerateSummary_Click);
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Location = new System.Drawing.Point(0, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(100, 23);
            this.lblTotalValue.TabIndex = 0;
            this.lblTotalValue.Text = "0";
            // 
            // lblAverageAgeValue
            // 
            this.lblAverageAgeValue.Location = new System.Drawing.Point(0, 0);
            this.lblAverageAgeValue.Name = "lblAverageAgeValue";
            this.lblAverageAgeValue.Size = new System.Drawing.Size(100, 23);
            this.lblAverageAgeValue.TabIndex = 0;
            this.lblAverageAgeValue.Text = "0";
            // 
            // lblAverageScoreValue
            // 
            this.lblAverageScoreValue.Location = new System.Drawing.Point(0, 0);
            this.lblAverageScoreValue.Name = "lblAverageScoreValue";
            this.lblAverageScoreValue.Size = new System.Drawing.Size(100, 23);
            this.lblAverageScoreValue.TabIndex = 0;
            this.lblAverageScoreValue.Text = "0";
            // 
            // lblCriticalValue
            // 
            this.lblCriticalValue.Location = new System.Drawing.Point(0, 0);
            this.lblCriticalValue.Name = "lblCriticalValue";
            this.lblCriticalValue.Size = new System.Drawing.Size(100, 23);
            this.lblCriticalValue.TabIndex = 0;
            this.lblCriticalValue.Text = "0";
            // 
            // lblSeriousValue
            // 
            this.lblSeriousValue.Location = new System.Drawing.Point(0, 0);
            this.lblSeriousValue.Name = "lblSeriousValue";
            this.lblSeriousValue.Size = new System.Drawing.Size(100, 23);
            this.lblSeriousValue.TabIndex = 0;
            this.lblSeriousValue.Text = "0";
            // 
            // lblStableValue
            // 
            this.lblStableValue.Location = new System.Drawing.Point(0, 0);
            this.lblStableValue.Name = "lblStableValue";
            this.lblStableValue.Size = new System.Drawing.Size(100, 23);
            this.lblStableValue.TabIndex = 0;
            this.lblStableValue.Text = "0";
            // 
            // lblRecoveringValue
            // 
            this.lblRecoveringValue.Location = new System.Drawing.Point(0, 0);
            this.lblRecoveringValue.Name = "lblRecoveringValue";
            this.lblRecoveringValue.Size = new System.Drawing.Size(100, 23);
            this.lblRecoveringValue.TabIndex = 0;
            this.lblRecoveringValue.Text = "0";
            // 
            // lblReleaseReadyValue
            // 
            this.lblReleaseReadyValue.Location = new System.Drawing.Point(0, 0);
            this.lblReleaseReadyValue.Name = "lblReleaseReadyValue";
            this.lblReleaseReadyValue.Size = new System.Drawing.Size(100, 23);
            this.lblReleaseReadyValue.TabIndex = 0;
            this.lblReleaseReadyValue.Text = "0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(722, 620);
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