using System.Windows.Forms;
using System.Collections.Generic;

namespace Scoring_System
{
    public partial class MainForm : Form
    {
        private List<Trainee> Trainees;
        public MainForm()
        {
            Trainees = new List<Trainee>();
            InitializeComponent();
        }
        private void AddTraineeButton_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text))
            {
                Trainees.Add(new Trainee()
                {
                    Name = NameTextBox.Text
                });
                NameTextBox.Text = "";
                NameTextBox.Focus();
            }
        }
        private void FinishButton_Click(object sender, System.EventArgs e)
        {
            ActionPanelHelper.Visible = true;
            ActionPanel.Visible = true;
            RegisterationPanel.Visible = false;
        }
        private void ActionPanel_VisibleChanged(object sender, System.EventArgs e)
        {
            if (ActionPanel.Visible)
            {
                int offset = 0;
                foreach (Trainee s in Trainees)
                {
                    s.Draw(ref offset, ActionPanel, this);
                }
            }
            else
            {
                foreach (Trainee s in Trainees)
                {
                    s.Clear(ActionPanel);
                }
            }
        }
        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTraineeButton.PerformClick();
            }
        }
        public void SortTrainees()
        {
            SuspendLayout();
            Trainees.Sort();
            int offset = 0;
            foreach(Trainee t in Trainees)
            {
                t.ResetLocation(offset);
                offset += 25;
            }
            ResumeLayout();
        }
        private void StartContestButton_Click(object sender, System.EventArgs e)
        {
            if (!Trainee.IsContestRunning)
            {
                StartContestButton.Text = "Stop Contest";
                MinutesCounter.Enabled = false;
                SecondsCounter.Enabled = false;
                Trainee.IsContestRunning = true;
                Trainee.ActiveScore = 5;
                Trainee.RemainingMinutes = (int)MinutesCounter.Value;
                Trainee.RemainingSeconds = (int)SecondsCounter.Value;
                CounterTimer.Interval = 1000;
                CounterTimer.Start();
            }
            else
            {
                CounterTimer.Stop();
                Trainee.IsContestRunning = false;
                StartContestButton.Text = "Start Contest";
                MinutesCounter.Enabled = true;
                SecondsCounter.Enabled = true;
                MinutesCounter.Value = 0;
                SecondsCounter.Value = 0;
                foreach(Trainee t in Trainees)
                {
                    t.SetAddButtonActive();
                }
            }
        }
        private void CounterTimer_Tick(object sender, System.EventArgs e)
        {
            if(Trainee.RemainingSeconds != 0)
            {
                Trainee.RemainingSeconds--;
                SecondsCounter.Value = Trainee.RemainingSeconds;
            }
            else if (Trainee.RemainingMinutes != 0)
            {
                Trainee.RemainingMinutes--;
                Trainee.RemainingSeconds = 59;
                MinutesCounter.Value = Trainee.RemainingMinutes;
                SecondsCounter.Value = Trainee.RemainingSeconds;
            }
            else
            {
                MinutesCounter.Enabled = true;
                SecondsCounter.Enabled = true;
                StartContestButton.Text = "Start Contest";
                Trainee.IsContestRunning = false;
                foreach (Trainee t in Trainees)
                {
                    t.SetAddButtonActive();
                }
                CounterTimer.Stop();
            }
        }
        private void MinutesCounter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartContestButton.PerformClick();
            }
        }
        private void SecondsCounter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartContestButton.PerformClick();
            }
        }
    }
}