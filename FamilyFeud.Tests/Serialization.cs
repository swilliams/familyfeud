using System;
using System.IO;
using NUnit.Framework;
using FamilyFeud.Objects;

namespace FamilyFeud.Tests
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	[TestFixture]
	public class Serialization
	{
		private QuestionCollection questions;
		private Question simpleQuestion;
		private string filename;

		public Serialization() {
		}

		private void DeleteFile(string filename) {
			if (File.Exists(filename)) {
				File.Delete(filename);
			}
		}

		[SetUp]
		public void Setup() {
			this.questions = new QuestionCollection();
			this.simpleQuestion = new Question();
			this.simpleQuestion.Text = "Sample Question";
			this.simpleQuestion.Responses = 100;
			this.simpleQuestion.Answers.Add(new Answer("answer 1", 25));
			this.simpleQuestion.Answers.Add(new Answer("answer 2", 50));
			this.simpleQuestion.Answers.Add(new Answer("answer 3", 25));
			this.filename = @"c:\questions.game";
			this.DeleteFile(this.filename);
		}

		[Test]
		public void SaveAndLoad() {
			Assert.IsTrue(questions.Count == 0);
			questions.Add(this.simpleQuestion);
			Assert.IsTrue(questions.Count == 1);
			questions.Save(filename);
			questions = null;
			questions = new QuestionCollection();
			Assert.IsTrue(questions.Count == 0);
			questions.Load(filename, false);
			Assert.IsTrue(questions.Count > 0);
		}

		[Test]
		public void Append() {
			this.questions.Add(this.simpleQuestion);
			this.questions.Save(this.filename);
			this.questions.Load(this.filename, true);
			Assert.AreEqual(2, this.questions.Count);
		}

		[TearDown]
		public void TearDown() {
			this.questions.Clear();
			this.DeleteFile(this.filename);
		}
	}
}
