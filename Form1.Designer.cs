namespace PRG2782_Project_2026
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateSummary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btnGenerateSummary.Location = new System.Drawing.Point(55, 50);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(146, 23);
            this.btnGenerateSummary.TabIndex = 0;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = true;
            this.btnGenerateSummary.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total animals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Average age (years)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average recovery score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Critical";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Serious";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Recovering";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Release-Ready";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(299, 140);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(13, 13);
            this.lblTotalValue.TabIndex = 9;
            this.lblTotalValue.Text = "0";
            // 
            // lblAverageAgeValue
            // 
            this.lblAverageAgeValue.AutoSize = true;
            this.lblAverageAgeValue.Location = new System.Drawing.Point(292, 169);
            this.lblAverageAgeValue.Name = "lblAverageAgeValue";
            this.lblAverageAgeValue.Size = new System.Drawing.Size(13, 13);
            this.lblAverageAgeValue.TabIndex = 10;
            this.lblAverageAgeValue.Text = "0";
            // 
            // lblAverageScoreValue
            // 
            this.lblAverageScoreValue.AutoSize = true;
            this.lblAverageScoreValue.Location = new System.Drawing.Point(302, 213);
            this.lblAverageScoreValue.Name = "lblAverageScoreValue";
            this.lblAverageScoreValue.Size = new System.Drawing.Size(13, 13);
            this.lblAverageScoreValue.TabIndex = 11;
            this.lblAverageScoreValue.Text = "0";
            // 
            // lblCriticalValue
            // 
            this.lblCriticalValue.AutoSize = true;
            this.lblCriticalValue.Location = new System.Drawing.Point(305, 242);
            this.lblCriticalValue.Name = "lblCriticalValue";
            this.lblCriticalValue.Size = new System.Drawing.Size(13, 13);
            this.lblCriticalValue.TabIndex = 12;
            this.lblCriticalValue.Text = "0";
            // 
            // lblSeriousValue
            // 
            this.lblSeriousValue.AutoSize = true;
            this.lblSeriousValue.Location = new System.Drawing.Point(308, 276);
            this.lblSeriousValue.Name = "lblSeriousValue";
            this.lblSeriousValue.Size = new System.Drawing.Size(13, 13);
            this.lblSeriousValue.TabIndex = 13;
            this.lblSeriousValue.Text = "0";
            // 
            // lblStableValue
            // 
            this.lblStableValue.AutoSize = true;
            this.lblStableValue.Location = new System.Drawing.Point(302, 310);
            this.lblStableValue.Name = "lblStableValue";
            this.lblStableValue.Size = new System.Drawing.Size(13, 13);
            this.lblStableValue.TabIndex = 14;
            this.lblStableValue.Text = "0";
            // 
            // lblRecoveringValue
            // 
            this.lblRecoveringValue.AutoSize = true;
            this.lblRecoveringValue.Location = new System.Drawing.Point(295, 340);
            this.lblRecoveringValue.Name = "lblRecoveringValue";
            this.lblRecoveringValue.Size = new System.Drawing.Size(13, 13);
            this.lblRecoveringValue.TabIndex = 15;
            this.lblRecoveringValue.Text = "0";
            // 
            // lblReleaseReadyValue
            // 
            this.lblReleaseReadyValue.AutoSize = true;
            this.lblReleaseReadyValue.Location = new System.Drawing.Point(302, 376);
            this.lblReleaseReadyValue.Name = "lblReleaseReadyValue";
            this.lblReleaseReadyValue.Size = new System.Drawing.Size(13, 13);
            this.lblReleaseReadyValue.TabIndex = 16;
            this.lblReleaseReadyValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReleaseReadyValue);
            this.Controls.Add(this.lblRecoveringValue);
            this.Controls.Add(this.lblStableValue);
            this.Controls.Add(this.lblSeriousValue);
            this.Controls.Add(this.lblCriticalValue);
            this.Controls.Add(this.lblAverageScoreValue);
            this.Controls.Add(this.lblAverageAgeValue);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateSummary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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

