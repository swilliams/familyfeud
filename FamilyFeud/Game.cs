using System;
using FamilyFeud.Objects;

namespace FamilyFeud
{
	/// <summary>
	/// Summary description for Game.
	/// </summary>
	public class Game : GameBase
	{
		private LaunchForm controlForm;
		private FeudForm gameDisplay;
		private int errorCount;
		private bool soundEffects;

		public Game(string filename, LaunchForm controlForm, FeudForm gameDisplay) : base(filename) {
			this.controlForm = controlForm;
			this.gameDisplay = gameDisplay;
			this.errorCount = 0;
			this.soundEffects = true;
		}

		public bool SoundEffects {
			get { return this.soundEffects; }
			set { this.soundEffects = value; }
		}

		public int Score {
			get { return this.gameDisplay.Score; }
		}

		public void SetLeftScore(int score) {
			this.gameDisplay.LeftTeamScore = score;
		}

		public void SetRightScore(int score) {
			this.gameDisplay.RightTeamScore = score;
		}

		public int ScoreLeftTeam() {
			int score = this.gameDisplay.LeftTeamScore;
			score += this.Score;
			this.gameDisplay.LeftTeamScore = score;
			return score;
		}

		public int ScoreRightTeam() {
			int score = this.gameDisplay.RightTeamScore;
			score += this.Score;
			this.gameDisplay.RightTeamScore = score;
			return score;
		}

		public override void DisplayQuestion() {
			this.errorCount = 0;
			this.controlForm.Question = this.CurrentQuestion.Text;
			this.gameDisplay.Question = this.CurrentQuestion.Text;
			foreach(Answer answer in this.CurrentQuestion.Answers) {
				this.DisplayAnswer(answer);
			}
		}

		public override void DisplayAnswer(Answer answer) {
			this.controlForm.AddAnswer(answer.Text);
			this.gameDisplay.AddAnswer(answer.Text, answer.Votes);
		}

		public override void ShowAnswer(int index) {
			this.gameDisplay.ShowAnswer(index, this.soundEffects);
		}

		public void ResetErrorCount() {
			this.errorCount = 0;
		}

		public override void ShowError() {
			this.errorCount++;
			string error = "";
			for (int i = 0; i < this.errorCount; i++) {
				error += "X";
			}
			this.gameDisplay.ErrorText = error;
			this.gameDisplay.ShowError(this.soundEffects);
		}
	}
}
