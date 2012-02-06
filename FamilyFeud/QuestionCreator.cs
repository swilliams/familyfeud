using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using FamilyFeud.Objects;

namespace FamilyFeud
{
	/// <summary>
	/// Summary description for QuestionCreator.
	/// </summary>
	public class QuestionCreator : System.Windows.Forms.Form
	{
		private QuestionCollection questions;

		private System.Windows.Forms.ListBox listQuestions;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.TextBox txtQuestion;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblAnswers;
		private System.Windows.Forms.TextBox txtAnswers;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public QuestionCreator()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.questions = new QuestionCollection();
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
			this.listQuestions = new System.Windows.Forms.ListBox();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.txtQuestion = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblAnswers = new System.Windows.Forms.Label();
			this.txtAnswers = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// listQuestions
			// 
			this.listQuestions.Location = new System.Drawing.Point(280, 8);
			this.listQuestions.Name = "listQuestions";
			this.listQuestions.Size = new System.Drawing.Size(144, 238);
			this.listQuestions.TabIndex = 0;
			// 
			// lblQuestion
			// 
			this.lblQuestion.Location = new System.Drawing.Point(8, 8);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(160, 16);
			this.lblQuestion.TabIndex = 1;
			this.lblQuestion.Text = "Question:";
			// 
			// txtQuestion
			// 
			this.txtQuestion.Location = new System.Drawing.Point(8, 24);
			this.txtQuestion.Name = "txtQuestion";
			this.txtQuestion.Size = new System.Drawing.Size(264, 20);
			this.txtQuestion.TabIndex = 0;
			this.txtQuestion.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSave.Location = new System.Drawing.Point(280, 256);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(144, 32);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAdd.Location = new System.Drawing.Point(168, 208);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(104, 32);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add >>";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblAnswers
			// 
			this.lblAnswers.Location = new System.Drawing.Point(8, 48);
			this.lblAnswers.Name = "lblAnswers";
			this.lblAnswers.Size = new System.Drawing.Size(264, 16);
			this.lblAnswers.TabIndex = 5;
			this.lblAnswers.Text = "Answers (one per line):";
			// 
			// txtAnswers
			// 
			this.txtAnswers.Location = new System.Drawing.Point(8, 64);
			this.txtAnswers.Multiline = true;
			this.txtAnswers.Name = "txtAnswers";
			this.txtAnswers.Size = new System.Drawing.Size(264, 136);
			this.txtAnswers.TabIndex = 1;
			this.txtAnswers.Text = "";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Feud Files (*.feud)|*.feud|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
			this.saveFileDialog1.Title = "Save Questions";
			// 
			// QuestionCreator
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 294);
			this.Controls.Add(this.txtAnswers);
			this.Controls.Add(this.lblAnswers);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtQuestion);
			this.Controls.Add(this.lblQuestion);
			this.Controls.Add(this.listQuestions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "QuestionCreator";
			this.Text = "QuestionCreator";
			this.Load += new System.EventHandler(this.QuestionCreator_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void QuestionCreator_Load(object sender, System.EventArgs e) {
		
		}

		private void btnAdd_Click(object sender, System.EventArgs e) {
			Question q = new Question();
			q.Text = this.txtQuestion.Text;
			for (int i = 0; i < this.txtAnswers.Lines.Length; i++) {
				if (this.txtAnswers.Lines[i] != "") {
					string[] line = this.txtAnswers.Lines[i].Split('|');
					Answer a = new Answer(line[0], Int32.Parse(line[1]));
					q.Answers.Add(a);
				}
			}
			this.questions.Add(q);
			this.listQuestions.Items.Add(q.Text);
			this.txtAnswers.Clear();
			this.txtQuestion.Clear();
			this.txtQuestion.Focus();
		}

		private void btnSave_Click(object sender, System.EventArgs e) {
			this.saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK) {
				this.questions.Save(this.saveFileDialog1.FileName);
				this.Close();
			}
		}
	}
}
