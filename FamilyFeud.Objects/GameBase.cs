using System;

namespace FamilyFeud.Objects {
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public abstract class GameBase {
		private QuestionCollection questions;
		protected int index;

		public GameBase(string filename) {
			this.questions = new QuestionCollection();
			this.questions.Load(filename, false);
			index = 0;
		}

		public GameBase(QuestionCollection questions) {
			this.questions = questions;
			this.index = 0;
		}

		public QuestionCollection Questions {
			get { return this.questions; }
		}

		public Question CurrentQuestion {
			get { return this.questions[this.index]; }
		}

		public abstract void DisplayQuestion();

		public abstract void DisplayAnswer(Answer answer);

		public abstract void ShowAnswer(int index);

		public abstract void ShowError();

		public virtual Question FinalQuestiong() {
			this.index = this.questions.Count - 1;
			return this.CurrentQuestion;
		}

		public virtual Question FirstQuestion() {
			this.index = 0;
			return this.CurrentQuestion;
		}

		public virtual Question NextQuestion() {
			if (this.index + 1 < this.questions.Count)
				this.index++;
			return this.CurrentQuestion;
		}

		public virtual Question PreviousQuestion() {
			if (this.index - 1 > -1)
				this.index--;
			return this.CurrentQuestion;
		}
	}
}
