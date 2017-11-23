using System;
using System.Windows.Forms;
using Scoring_System;

public class Trainee : IComparable
{
    static public bool IsContestRunning = false;
    static public int RemainingMinutes = 0;
    static public int RemainingSeconds = 0;
    static public int ActiveScore = 0;
    public string Name;
    public int Score;
    private Label ScoreLabel;
    private Label NameLabel;
    private Button AddButton;
    private Button SubtractButton;
    private Button BonusButton;
    private Button DeleteButton;
    private MainForm ParentForm;
    public Trainee()
    {
        Name = "";
        Score = 0;
    }
    public void Draw(ref int offset, Panel Parent, MainForm ParentF)
    {
        ParentForm = ParentF;
        ScoreLabel = new Label()
        {
            Text = Score.ToString(),
            Location = new System.Drawing.Point(250, 5 + offset),
        };
        Parent.Controls.Add(ScoreLabel);
        NameLabel = new Label()
        {
            Text = Name,
            Location = new System.Drawing.Point(53, 5 + offset),
            Size = new System.Drawing.Size(200, 20)
        };
        Parent.Controls.Add(NameLabel);
        AddButton = new Button()
        {
            Text = "Add",
            Location = new System.Drawing.Point(350, 2 + offset),
            FlatStyle = FlatStyle.System
        };
        AddButton.Click += AddButtonClick;
        Parent.Controls.Add(AddButton);
        SubtractButton = new Button()
        {
            Text = "Subtract",
            Location = new System.Drawing.Point(430, 2 + offset),
            FlatStyle = FlatStyle.System
        };
        SubtractButton.Click += SubtractButtonClick;
        Parent.Controls.Add(SubtractButton);
        BonusButton = new Button()
        {
            Text = "Bonus",
            Location = new System.Drawing.Point(510, 2 + offset),
            FlatStyle = FlatStyle.System
        };
        BonusButton.Click += BonusButton_Click;
        Parent.Controls.Add(BonusButton);
        DeleteButton = new Button()
        {
            Text = "Delete",
            Location = new System.Drawing.Point(590, 2 + offset),
            FlatStyle = FlatStyle.System
        };
        DeleteButton.Click += DeleteButton_Click;
        Parent.Controls.Add(DeleteButton);
        offset += 25;
    }
    public void ResetLocation(int offset)
    {
        NameLabel.Location = new System.Drawing.Point(53, 5 + offset);
        ScoreLabel.Location = new System.Drawing.Point(250, 5 + offset);
        AddButton.Location = new System.Drawing.Point(350, 2 + offset);
        SubtractButton.Location = new System.Drawing.Point(430, 2 + offset);
        BonusButton.Location = new System.Drawing.Point(510, 2 + offset);
        DeleteButton.Location = new System.Drawing.Point(590, 2 + offset);
    }
    private void BonusButton_Click(object sender, EventArgs e)
    {
        Score += 7;
        ScoreLabel.Text = Score.ToString();
        if (IsContestRunning)
        {
            AddButton.Enabled = false;
        }
        ParentForm.SortTrainees();
    }
    public void Clear(Panel Parent)
    {
        Parent.Controls.Remove(NameLabel);
        Parent.Controls.Remove(ScoreLabel);
        Parent.Controls.Remove(AddButton);
        Parent.Controls.Remove(SubtractButton);
        Parent.Controls.Remove(BonusButton);
        Parent.Controls.Remove(DeleteButton);
    }
    public void SetAddButtonActive()
    {
        AddButton.Enabled = true;
    }
    private void SubtractButtonClick(object sender, EventArgs e)
    {
        Score--;
        ScoreLabel.Text = Score.ToString();
        ParentForm.SortTrainees();
    }
    private void AddButtonClick(object sender, EventArgs e)
    {
        if (IsContestRunning)
        {
            if (ActiveScore > 0)
            {
                Score += ActiveScore;
                ActiveScore--;
                ScoreLabel.Text = Score.ToString();
                ParentForm.SortTrainees();
                AddButton.Enabled = false;
            }
        }
        else
        {
            Score++;
            ScoreLabel.Text = Score.ToString();
            ParentForm.SortTrainees();
        }
    }
    private void DeleteButton_Click(object sender, EventArgs e)
    {
        ParentForm.ClearTrainee(this);
    }
    public int CompareTo(object obj)
    {
        if(obj.GetType() == typeof(Trainee))
        {
            Trainee t = obj as Trainee;
            if (t.Score > Score) return 1;
            else if (Score > t.Score) return -1;
            else return 0;
        }
        else
        {
            return 0;
        }
    }
}