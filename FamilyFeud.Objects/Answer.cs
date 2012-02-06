using System;

namespace FamilyFeud.Objects
{
	/// <summary>
	/// Summary description for Answer.
	/// </summary>
	[Serializable]
	public class Answer
	{
		private string text;
		private int votes;

		public Answer() : this("", 0) { }
		public Answer(string text, int votes) {
			this.text = text;
			this.votes = votes;
		}

		public string Text {
			get { return this.text; }
			set { this.text = value; }
		}

		public int Votes {
			get { return this.votes; }
			set { this.votes = value; }
		}
	}
}
