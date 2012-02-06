using System;

namespace FamilyFeud.Objects
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	[Serializable]
	public class Question
	{
		private string text;
		private int responses;
		private AnswerCollection answers;

		public Question() {
			this.text = "";
			this.responses = 0;
			this.answers = new AnswerCollection();
		}

		public string Text {
			get { return this.text; }
			set { this.text = value; }
		}

		public int Responses {
			get { return this.responses; }
			set { this.responses = value; }
		}

		public AnswerCollection Answers {
			get { return this.answers; }
			set { this.answers = value; }
		}
	}
}
