using System;
using FamilyFeud.Objects;

namespace FamilyFeud.Tests
{
	/// <summary>
	/// Summary description for SimpleGame.
	/// </summary>
	public class SimpleGame : GameBase
	{
		private GameState state;
		private string output;

		public SimpleGame(string filename) : base(filename) {
			this.Initialize();
		}

		public SimpleGame(QuestionCollection questions) : base(questions) {
			this.Initialize();
		}

		private void Initialize() {
			this.state = GameState.Start;
			this.output = "";
		}

		public GameState State {
			get { return this.state; }
		}

		public string Output {
			get { return this.output; }
		}

		public override void DisplayAnswer(Answer answer) {
			this.state = GameState.Display;
			this.output = answer.Text + " (" + answer.Votes + ")";
		}

		public override void DisplayQuestion() {
			this.state = GameState.Display;
			this.output = this.CurrentQuestion.Text;
		}

		public override void ShowAnswer(int index) {
			this.state = GameState.CorrectAnswer;
			this.output = this.CurrentQuestion.Answers[index].Text;
		}

		public override void ShowError() {
			this.state = GameState.WrongAnswer;
			this.output = "wrong answer";
		}

	}

	public enum GameState {
		Start,
		End,
		Display,
		WrongAnswer,
		CorrectAnswer
	}
}
