using System;
using NUnit.Framework;
using FamilyFeud.Objects;

namespace FamilyFeud.Tests
{
	/// <summary>
	/// Summary description for GameTest.
	/// </summary>
	[TestFixture]
	public class GameTest
	{
		private SimpleGame game;
		public GameTest()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		[SetUp]
		public void Setup() {
			Question q1 = new Question();
			q1.Text = "Question One";
			q1.Responses = 100;
			q1.Answers.Add(new Answer("answer 1-1", 50));
			q1.Answers.Add(new Answer("answer 1-2", 25));
			q1.Answers.Add(new Answer("answer 1-3", 25));
			Question q2 = new Question();
			q2.Text = "Question The second";
			q2.Responses = 95;
			q2.Answers.Add(new Answer("answer 2-1", 50));
			q2.Answers.Add(new Answer("answer 2-2", 25));
			q2.Answers.Add(new Answer("answer 2-3", 20));
			Question q3 = new Question();
			q3.Text = "Question Three";
			q3.Responses = 86;
			q3.Answers.Add(new Answer("answer 3-1", 20));
			q3.Answers.Add(new Answer("answer 3-2", 26));
			q3.Answers.Add(new Answer("answer 3-3", 40));

			QuestionCollection questions = new QuestionCollection();
			questions.Add(q1);
			questions.Add(q2);
			questions.Add(q3);
			this.game = new SimpleGame(questions);
		}

		[Test]
		public void GenerateTest() {
			this.game.Questions.Save(@"c:\game.feud");
		}

		[Test]
		public void RunGame() {
			for (int i = 0; i < this.game.Questions.Count; i++) {
				this.game.DisplayQuestion();
				Assert.IsTrue(this.game.State == GameState.Display);
				this.game.ShowAnswer(0);
				Assert.AreEqual(GameState.CorrectAnswer, this.game.State, "Correct answer states were not equal.");
				this.game.ShowError();
				Assert.AreEqual(GameState.WrongAnswer, this.game.State, "Error was not equal");
			}

		}
	}
}
