using System;
using System.Windows.Forms;
using Scoring_System;

class Trainee : IComparable
{
    static public bool IsContestRunning = false;
    static public int RemainingMinutes = 0;
    static public int RemainingSeconds = 0;
    static public int ActiveScore = 0;
    public string Name;
    public int Score;
    private bool LastButtonState;
    private Label ScoreLabel;
    private Label NameLabel;
    private Button AddButton;
    private Button SubtractButton;
    private Button BonusButton;
    private MainForm ParentForm;
    public Trainee()
    {
        Name = "";
        Score = 0;
        LastButtonState = true;
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
            Location = new System.Drawing.Point(419, 5 + offset),
            Enabled = LastButtonState
        };
        AddButton.Click += AddButtonClick;
        Parent.Controls.Add(AddButton);
        SubtractButton = new Button()
        {
            Text = "Subtract",
            Location = new System.Drawing.Point(500, 5 + offset),
        };
        SubtractButton.Click += SubtractButtonClick;
        Parent.Controls.Add(SubtractButton);
        BonusButton = new Button()
        {
            Text = "Bonus",
            Location = new System.Drawing.Point(580, 5 + offset)
        };
        BonusButton.Click += BonusButton_Click;
        Parent.Controls.Add(BonusButton);
        offset += 25;
    }
    private void BonusButton_Click(object sender, EventArgs e)
    {
        Score += 7;
        if(IsContestRunning)
        {
            LastButtonState = false;
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
    }
    public void SetAddButtonActive()
    {
        AddButton.Enabled = true;
        LastButtonState = true;
    }
    private void SubtractButtonClick(object sender, EventArgs e)
    {
        Score--;
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
                ParentForm.SortTrainees();
                AddButton.Enabled = false;
                LastButtonState = false;
            }
        }
        else
        {
            Score++;
            ParentForm.SortTrainees();
        }
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