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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddTraineeButton = new System.Windows.Forms.Button();
            this.RegisterationPanel = new System.Windows.Forms.Panel();
            this.FinishButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Spacer = new System.Windows.Forms.Label();
            this.DummyLabel = new System.Windows.Forms.Label();
            this.MinutesCounter = new System.Windows.Forms.NumericUpDown();
            this.StartContestButton = new System.Windows.Forms.Button();
            this.CounterTimer = new System.Windows.Forms.Timer(this.components);
            this.ActionPanelHelper = new System.Windows.Forms.Panel();
            this.SecondsCounter = new System.Windows.Forms.NumericUpDown();
            this.DummySeprator = new System.Windows.Forms.Label();
            this.RegisterationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesCounter)).BeginInit();
            this.ActionPanelHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(204, 162);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(271, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            // 
            // AddTraineeButton
            // 
            this.AddTraineeButton.Location = new System.Drawing.Point(481, 160);
            this.AddTraineeButton.Name = "AddTraineeButton";
            this.AddTraineeButton.Size = new System.Drawing.Size(75, 23);
            this.AddTraineeButton.TabIndex = 1;
            this.AddTraineeButton.Text = "Add Trainee";
            this.AddTraineeButton.UseVisualStyleBackColor = true;
            this.AddTraineeButton.Click += new System.EventHandler(this.AddTraineeButton_Click);
            // 
            // RegisterationPanel
            // 
            this.RegisterationPanel.Controls.Add(this.FinishButton);
            this.RegisterationPanel.Controls.Add(this.NameLabel);
            this.RegisterationPanel.Controls.Add(this.HeaderLabel);
            this.RegisterationPanel.Controls.Add(this.NameTextBox);
            this.RegisterationPanel.Controls.Add(this.AddTraineeButton);
            this.RegisterationPanel.Location = new System.Drawing.Point(-1, -1);
            this.RegisterationPanel.Name = "RegisterationPanel";
            this.RegisterationPanel.Size = new System.Drawing.Size(681, 380);
            this.RegisterationPanel.TabIndex = 2;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(262, 237);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(190, 48);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Done";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(163, 165);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(239, 47);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(236, 49);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Registeration";
            // 
            // ActionPanel
            // 
            this.ActionPanel.AutoScroll = true;
            this.ActionPanel.Location = new System.Drawing.Point(0, 95);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(683, 284);
            this.ActionPanel.TabIndex = 3;
            this.ActionPanel.Visible = false;
            this.ActionPanel.VisibleChanged += new System.EventHandler(this.ActionPanel_VisibleChanged);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(195, 14);
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
            this.DummyLabel.Size = new System.Drawing.Size(515, 13);
            this.DummyLabel.TabIndex = 3;
            this.DummyLabel.Text = "   Name                                                    Score                 " +
    "                                                                  Controls";
            // 
            // MinutesCounter
            // 
            this.MinutesCounter.Location = new System.Drawing.Point(270, 12);
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
            this.StartContestButton.Location = new System.Drawing.Point(415, 12);
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
            this.ActionPanelHelper.Visible = false;
            // 
            // SecondsCounter
            // 
            this.SecondsCounter.Location = new System.Drawing.Point(350, 12);
            this.SecondsCounter.Name = "SecondsCounter";
            this.SecondsCounter.Size = new System.Drawing.Size(54, 20);
            this.SecondsCounter.TabIndex = 6;
            this.SecondsCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondsCounter_KeyDown);
            // 
            // DummySeprator
            // 
            this.DummySeprator.AutoSize = true;
            this.DummySeprator.Font = new System.Drawing.Font("Neo Tech Alt Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DummySeprator.Location = new System.Drawing.Point(330, 9);
            this.DummySeprator.Name = "DummySeprator";
            this.DummySeprator.Size = new System.Drawing.Size(14, 19);
            this.DummySeprator.TabIndex = 7;
            this.DummySeprator.Text = ":";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 379);
            this.Controls.Add(this.RegisterationPanel);
            this.Controls.Add(this.ActionPanelHelper);
            this.Controls.Add(this.ActionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Scoring System";
            this.RegisterationPanel.ResumeLayout(false);
            this.RegisterationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesCounter)).EndInit();
            this.ActionPanelHelper.ResumeLayout(false);
            this.ActionPanelHelper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddTraineeButton;
        private System.Windows.Forms.Panel RegisterationPanel;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label HeaderLabel;
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
    }
}

