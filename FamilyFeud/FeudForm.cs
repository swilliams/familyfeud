using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FamilyFeud
{
	/// <summary>
	/// Summary description for FeudForm.
	/// </summary>
	public class FeudForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Panel pnlAnswers;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Panel pnlBackground;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblLeftTeam;
		private System.Windows.Forms.Label lblRightTeam;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FeudForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FeudForm));
			this.lblError = new System.Windows.Forms.Label();
			this.pnlAnswers = new System.Windows.Forms.Panel();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.pnlBackground = new System.Windows.Forms.Panel();
			this.lblScore = new System.Windows.Forms.Label();
			this.lblLeftTeam = new System.Windows.Forms.Label();
			this.lblRightTeam = new System.Windows.Forms.Label();
			this.pnlBackground.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblError
			// 
			this.lblError.BackColor = System.Drawing.Color.Transparent;
			this.lblError.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Crimson;
			this.lblError.Location = new System.Drawing.Point(12, 492);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(260, 100);
			this.lblError.TabIndex = 0;
			this.lblError.Text = "XXX";
			this.lblError.Visible = false;
			// 
			// pnlAnswers
			// 
			this.pnlAnswers.BackColor = System.Drawing.Color.Transparent;
			this.pnlAnswers.Location = new System.Drawing.Point(192, 176);
			this.pnlAnswers.Name = "pnlAnswers";
			this.pnlAnswers.Size = new System.Drawing.Size(420, 212);
			this.pnlAnswers.TabIndex = 1;
			// 
			// lblQuestion
			// 
			this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
			this.lblQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblQuestion.Location = new System.Drawing.Point(192, 136);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(416, 40);
			this.lblQuestion.TabIndex = 2;
			this.lblQuestion.Text = "Question Text";
			// 
			// pnlBackground
			// 
			this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
			this.pnlBackground.Controls.Add(this.lblRightTeam);
			this.pnlBackground.Controls.Add(this.lblLeftTeam);
			this.pnlBackground.Controls.Add(this.lblScore);
			this.pnlBackground.Controls.Add(this.pnlAnswers);
			this.pnlBackground.Controls.Add(this.lblQuestion);
			this.pnlBackground.Controls.Add(this.lblError);
			this.pnlBackground.Font = new System.Drawing.Font("Edwardian Script ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnlBackground.Location = new System.Drawing.Point(0, 0);
			this.pnlBackground.Name = "pnlBackground";
			this.pnlBackground.Size = new System.Drawing.Size(792, 610);
			this.pnlBackground.TabIndex = 3;
			// 
			// lblScore
			// 
			this.lblScore.BackColor = System.Drawing.Color.Transparent;
			this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblScore.ForeColor = System.Drawing.Color.Gold;
			this.lblScore.Location = new System.Drawing.Point(360, 52);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(80, 28);
			this.lblScore.TabIndex = 3;
			this.lblScore.Text = "000";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLeftTeam
			// 
			this.lblLeftTeam.BackColor = System.Drawing.Color.Transparent;
			this.lblLeftTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblLeftTeam.ForeColor = System.Drawing.Color.Gold;
			this.lblLeftTeam.Location = new System.Drawing.Point(48, 284);
			this.lblLeftTeam.Name = "lblLeftTeam";
			this.lblLeftTeam.Size = new System.Drawing.Size(80, 32);
			this.lblLeftTeam.TabIndex = 4;
			this.lblLeftTeam.Text = "000";
			this.lblLeftTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRightTeam
			// 
			this.lblRightTeam.BackColor = System.Drawing.Color.Transparent;
			this.lblRightTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblRightTeam.ForeColor = System.Drawing.Color.Gold;
			this.lblRightTeam.Location = new System.Drawing.Point(672, 284);
			this.lblRightTeam.Name = "lblRightTeam";
			this.lblRightTeam.Size = new System.Drawing.Size(80, 32);
			this.lblRightTeam.TabIndex = 5;
			this.lblRightTeam.Text = "000";
			this.lblRightTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FeudForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(792, 610);
			this.Controls.Add(this.pnlBackground);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FeudForm";
			this.Text = "FeudForm";
			this.Resize += new System.EventHandler(this.FeudForm_Resize);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FeudForm_Closing);
			this.Load += new System.EventHandler(this.FeudForm_Load);
			this.pnlBackground.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public int Score {
			get { return Convert.ToInt32(this.lblScore.Text); }
		}

		public int LeftTeamScore {
			get { return Convert.ToInt32(this.lblLeftTeam.Text); }
			set { this.lblLeftTeam.Text = value.ToString(); } 
		}

		public int RightTeamScore {
			get { return Convert.ToInt32(this.lblRightTeam.Text); }
			set { this.lblRightTeam.Text = value.ToString(); } 
		}

		public string ErrorText {
			get { return this.lblError.Text; }
			set { this.lblError.Text = value; }
		}

		public string Question {
			get { return this.lblQuestion.Text; }
			set { 
				this.pnlAnswers.Controls.Clear();
				this.lblError.Text = "";
				this.lblQuestion.Text = value; 
				this.lblScore.Text = "0";
			}
		}

		private void FeudForm_Resize(object sender, System.EventArgs e) {
			this.FormBorderStyle = this.WindowState == FormWindowState.Maximized ? FormBorderStyle.None : FormBorderStyle.Sizable;
			this.ResizeForm();
		}

		private void FeudForm_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			this.Visible = false;
			e.Cancel = true;
		}

		public void AddAnswer(string answerText, int votes) {
			QuestionControl ctl = new QuestionControl();
			ctl.AnswerCount = votes.ToString();
			ctl.AnswerText = answerText;
			int yDelta = 4;
			if (this.pnlAnswers.Controls.Count > 0) {
				Control LastAnswer = this.pnlAnswers.Controls[this.pnlAnswers.Controls.Count - 1];
				yDelta = LastAnswer.Bounds.Bottom + 1;
			}
			ctl.Size = new Size(201, 24);
			ctl.Index = (this.pnlAnswers.Controls.Count + 1).ToString();
			ctl.Location = new Point(0, yDelta);
			ctl.ResizeControl();
			ctl.Visible = true;
			this.pnlAnswers.Controls.Add(ctl);
		}

		public void ShowAnswer(int index, bool soundeffects) {
			QuestionControl ctl = this.pnlAnswers.Controls[index] as QuestionControl;
			ctl.ToggleCoverup();
			if (soundeffects && !ctl.IsCovered)
				AudioPlayer.PlaySound("FamilyFeud.Resource.bell.wav");
			int score = Int32.Parse(this.lblScore.Text);
			score += Int32.Parse(ctl.AnswerCount);
			this.lblScore.Text = score.ToString();
		}

		public void ShowError(bool soundeffects) {
			Timer timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += new EventHandler(timer_Tick);
			timer.Start();
			this.lblError.Visible = true;
			this.lblError.BringToFront();
			if (soundeffects)
				AudioPlayer.PlaySound("FamilyFeud.Resource.buzzer.wav");
		}

		private void timer_Tick(object sender, EventArgs e) {
			this.lblError.Visible = false;
			Timer timer = sender as Timer;
			if (timer != null) {
				timer.Stop();
				timer.Dispose();
			}
		}

		public void ResizeForm() {
			this.pnlBackground.Location = new Point((this.Width / 2) - (this.pnlBackground.Width / 2), (this.Height / 2) - (this.pnlBackground.Height / 2));
		}

		private void FeudForm_Load(object sender, System.EventArgs e) {
			this.ResizeForm();
			this.lblLeftTeam.Font = this.lblRightTeam.Font = this.lblScore.Font = new Font("Digital dream", 16, FontStyle.Bold);
		}
	}
}
