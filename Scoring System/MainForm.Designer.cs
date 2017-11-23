namespace Scoring_System
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Spacer = new System.Windows.Forms.Label();
            this.DummyLabel = new System.Windows.Forms.Label();
            this.MinutesCounter = new System.Windows.Forms.NumericUpDown();
            this.StartContestButton = new System.Windows.Forms.Button();
            this.CounterTimer = new System.Windows.Forms.Timer(this.components);
            this.ActionPanelHelper = new System.Windows.Forms.Panel();
            this.DynamicTraineeText = new System.Windows.Forms.TextBox();
            this.DynamicAddTraineeButton = new System.Windows.Forms.Button();
            this.DummySeprator = new System.Windows.Forms.Label();
            this.SecondsCounter = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesCounter)).BeginInit();
            this.ActionPanelHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionPanel
            // 
            this.ActionPanel.AutoScroll = true;
            this.ActionPanel.Location = new System.Drawing.Point(0, 95);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(683, 284);
            this.ActionPanel.TabIndex = 3;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(3, 19);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(69, 13);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "Contest Time";
            // 
            // Spacer
            // 
            this.Spacer.AutoSize = true;
            this.Spacer.Location = new System.Drawing.Point(23, 79);
            this.Spacer.Name = "Spacer";
            this.Spacer.Size = new System.Drawing.Size(637, 13);
            this.Spacer.TabIndex = 4;
            this.Spacer.Text = "_________________________________________________________________________________" +
    "________________________";
            // 
            // DummyLabel
            // 
            this.DummyLabel.AutoSize = true;
            this.DummyLabel.Location = new System.Drawing.Point(46, 63);
            this.DummyLabel.Name = "DummyLabel";
            this.DummyLabel.Size = new System.Drawing.Size(485, 13);
            this.DummyLabel.TabIndex = 3;
            this.DummyLabel.Text = "   Name                                                    Score                 " +
    "                                                        Controls";
            // 
            // MinutesCounter
            // 
            this.MinutesCounter.Location = new System.Drawing.Point(78, 17);
            this.MinutesCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MinutesCounter.Name = "MinutesCounter";
            this.MinutesCounter.Size = new System.Drawing.Size(54, 20);
            this.MinutesCounter.TabIndex = 2;
            this.MinutesCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MinutesCounter_KeyDown);
            // 
            // StartContestButton
            // 
            this.StartContestButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartContestButton.Location = new System.Drawing.Point(223, 17);
            this.StartContestButton.Name = "StartContestButton";
            this.StartContestButton.Size = new System.Drawing.Size(100, 20);
            this.StartContestButton.TabIndex = 0;
            this.StartContestButton.Text = "Start Contest";
            this.StartContestButton.UseVisualStyleBackColor = true;
            this.StartContestButton.Click += new System.EventHandler(this.StartContestButton_Click);
            // 
            // CounterTimer
            // 
            this.CounterTimer.Tick += new System.EventHandler(this.CounterTimer_Tick);
            // 
            // ActionPanelHelper
            // 
            this.ActionPanelHelper.Controls.Add(this.DynamicTraineeText);
            this.ActionPanelHelper.Controls.Add(this.DynamicAddTraineeButton);
            this.ActionPanelHelper.Controls.Add(this.DummySeprator);
            this.ActionPanelHelper.Controls.Add(this.SecondsCounter);
            this.ActionPanelHelper.Controls.Add(this.TimeLabel);
            this.ActionPanelHelper.Controls.Add(this.Spacer);
            this.ActionPanelHelper.Controls.Add(this.DummyLabel);
            this.ActionPanelHelper.Controls.Add(this.MinutesCounter);
            this.ActionPanelHelper.Controls.Add(this.StartContestButton);
            this.ActionPanelHelper.Location = new System.Drawing.Point(0, 0);
            this.ActionPanelHelper.Name = "ActionPanelHelper";
            this.ActionPanelHelper.Size = new System.Drawing.Size(683, 95);
            this.ActionPanelHelper.TabIndex = 6;
            // 
            // DynamicTraineeText
            // 
            this.DynamicTraineeText.Location = new System.Drawing.Point(496, 16);
            this.DynamicTraineeText.Name = "DynamicTraineeText";
            this.DynamicTraineeText.Size = new System.Drawing.Size(100, 20);
            this.DynamicTraineeText.TabIndex = 9;
            this.DynamicTraineeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DynamicTraineeText_KeyDown);
            // 
            // DynamicAddTraineeButton
            // 
            this.DynamicAddTraineeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DynamicAddTraineeButton.Location = new System.Drawing.Point(602, 14);
            this.DynamicAddTraineeButton.Name = "DynamicAddTraineeButton";
            this.DynamicAddTraineeButton.Size = new System.Drawing.Size(75, 23);
            this.DynamicAddTraineeButton.TabIndex = 8;
            this.DynamicAddTraineeButton.Text = "Add Trainee";
            this.DynamicAddTraineeButton.UseVisualStyleBackColor = true;
            this.DynamicAddTraineeButton.Click += new System.EventHandler(this.DynamicAddTraineeButton_Click);
            // 
            // DummySeprator
            // 
            this.DummySeprator.AutoSize = true;
            this.DummySeprator.Font = new System.Drawing.Font("Neo Tech Alt Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DummySeprator.Location = new System.Drawing.Point(138, 14);
            this.DummySeprator.Name = "DummySeprator";
            this.DummySeprator.Size = new System.Drawing.Size(14, 19);
            this.DummySeprator.TabIndex = 7;
            this.DummySeprator.Text = ":";
            // 
            // SecondsCounter
            // 
            this.SecondsCounter.Location = new System.Drawing.Point(158, 17);
            this.SecondsCounter.Name = "SecondsCounter";
            this.SecondsCounter.Size = new System.Drawing.Size(54, 20);
            this.SecondsCounter.TabIndex = 6;
            this.SecondsCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondsCounter_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 379);
            this.Controls.Add(this.ActionPanelHelper);
            this.Controls.Add(this.ActionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Scoring System";
            ((System.ComponentModel.ISupportInitialize)(this.MinutesCounter)).EndInit();
            this.ActionPanelHelper.ResumeLayout(false);
            this.ActionPanelHelper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.NumericUpDown MinutesCounter;
        private System.Windows.Forms.Button StartContestButton;
        private System.Windows.Forms.Timer CounterTimer;
        private System.Windows.Forms.Label Spacer;
        private System.Windows.Forms.Label DummyLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Panel ActionPanelHelper;
        private System.Windows.Forms.Label DummySeprator;
        private System.Windows.Forms.NumericUpDown SecondsCounter;
        private System.Windows.Forms.TextBox DynamicTraineeText;
        private System.Windows.Forms.Button DynamicAddTraineeButton;
    }
}

