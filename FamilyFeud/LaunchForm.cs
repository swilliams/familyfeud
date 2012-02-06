using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FamilyFeud
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class LaunchForm : System.Windows.Forms.Form
	{
		private Game feudGame;
		private FeudForm feudForm;
		private System.Windows.Forms.GroupBox grpQuestion;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Panel pnlQuestionTop;
		private System.Windows.Forms.Panel pnlAnswers;
		private System.Windows.Forms.Label lblLine;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.TextBox txtFile;
		private FamilyFeud.Button btnBrowse;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnMax;
		private FamilyFeud.Button btnError;
		private System.Windows.Forms.CheckBox chkSound;
		private System.Windows.Forms.Button btnQuestionControl;
		private System.Windows.Forms.Button btnResetError;
		private System.Windows.Forms.Button btnScoreLeft;
		private System.Windows.Forms.Button btnScoreRight;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLeftScore;
		private System.Windows.Forms.TextBox txtRightScore;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LaunchForm()
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(LaunchForm));
			this.grpQuestion = new System.Windows.Forms.GroupBox();
			this.pnlAnswers = new System.Windows.Forms.Panel();
			this.pnlQuestionTop = new System.Windows.Forms.Panel();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.lblLine = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnShow = new System.Windows.Forms.Button();
			this.lblFile = new System.Windows.Forms.Label();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.btnBrowse = new FamilyFeud.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnMax = new System.Windows.Forms.Button();
			this.btnError = new FamilyFeud.Button();
			this.chkSound = new System.Windows.Forms.CheckBox();
			this.btnQuestionControl = new System.Windows.Forms.Button();
			this.btnResetError = new System.Windows.Forms.Button();
			this.btnScoreLeft = new System.Windows.Forms.Button();
			this.btnScoreRight = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLeftScore = new System.Windows.Forms.TextBox();
			this.txtRightScore = new System.Windows.Forms.TextBox();
			this.grpQuestion.SuspendLayout();
			this.pnlQuestionTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpQuestion
			// 
			this.grpQuestion.Controls.Add(this.pnlAnswers);
			this.grpQuestion.Controls.Add(this.pnlQuestionTop);
			this.grpQuestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpQuestion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grpQuestion.Location = new System.Drawing.Point(84, 48);
			this.grpQuestion.Name = "grpQuestion";
			this.grpQuestion.Size = new System.Drawing.Size(496, 296);
			this.grpQuestion.TabIndex = 0;
			this.grpQuestion.TabStop = false;
			this.grpQuestion.Text = "Current Question";
			// 
			// pnlAnswers
			// 
			this.pnlAnswers.AutoScroll = true;
			this.pnlAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAnswers.Location = new System.Drawing.Point(3, 88);
			this.pnlAnswers.Name = "pnlAnswers";
			this.pnlAnswers.Size = new System.Drawing.Size(490, 205);
			this.pnlAnswers.TabIndex = 2;
			// 
			// pnlQuestionTop
			// 
			this.pnlQuestionTop.Controls.Add(this.lblQuestion);
			this.pnlQuestionTop.Controls.Add(this.lblLine);
			this.pnlQuestionTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlQuestionTop.Location = new System.Drawing.Point(3, 17);
			this.pnlQuestionTop.Name = "pnlQuestionTop";
			this.pnlQuestionTop.Size = new System.Drawing.Size(490, 71);
			this.pnlQuestionTop.TabIndex = 1;
			// 
			// lblQuestion
			// 
			this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblQuestion.Location = new System.Drawing.Point(0, 0);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(490, 70);
			this.lblQuestion.TabIndex = 0;
			this.lblQuestion.Text = "Question Text:";
			// 
			// lblLine
			// 
			this.lblLine.BackColor = System.Drawing.Color.Black;
			this.lblLine.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblLine.Location = new System.Drawing.Point(0, 70);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new System.Drawing.Size(490, 1);
			this.lblLine.TabIndex = 0;
			// 
			// btnNext
			// 
			this.btnNext.Enabled = false;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnNext.Location = new System.Drawing.Point(452, 348);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(124, 28);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next Question >>";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrev
			// 
			this.btnPrev.Enabled = false;
			this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPrev.Location = new System.Drawing.Point(88, 348);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(124, 28);
			this.btnPrev.TabIndex = 2;
			this.btnPrev.Text = "<< Prior Question";
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnShow
			// 
			this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShow.Location = new System.Drawing.Point(596, 4);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(112, 24);
			this.btnShow.TabIndex = 3;
			this.btnShow.Text = "Show Game Form";
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// lblFile
			// 
			this.lblFile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFile.Location = new System.Drawing.Point(8, 8);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(92, 16);
			this.lblFile.TabIndex = 4;
			this.lblFile.Text = "Questions File:";
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(100, 4);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(360, 20);
			this.txtFile.TabIndex = 5;
			this.txtFile.Text = "";
			// 
			// btnBrowse
			// 
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
			this.btnBrowse.Location = new System.Drawing.Point(464, 4);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(24, 24);
			this.btnBrowse.TabIndex = 6;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOpen.Location = new System.Drawing.Point(496, 4);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(44, 24);
			this.btnOpen.TabIndex = 7;
			this.btnOpen.Text = "Load";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Feud Files (*.feud)|*.feud|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
			this.openFileDialog1.Title = "Open a Game File";
			// 
			// btnMax
			// 
			this.btnMax.Enabled = false;
			this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnMax.Location = new System.Drawing.Point(596, 32);
			this.btnMax.Name = "btnMax";
			this.btnMax.Size = new System.Drawing.Size(112, 28);
			this.btnMax.TabIndex = 8;
			this.btnMax.Text = "Maximize Game Form";
			this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
			// 
			// btnError
			// 
			this.btnError.Enabled = false;
			this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnError.Image = ((System.Drawing.Image)(resources.GetObject("btnError.Image")));
			this.btnError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnError.Location = new System.Drawing.Point(288, 348);
			this.btnError.Name = "btnError";
			this.btnError.Size = new System.Drawing.Size(112, 28);
			this.btnError.TabIndex = 9;
			this.btnError.Text = "  Wrong Answer";
			this.btnError.Click += new System.EventHandler(this.btnError_Click);
			// 
			// chkSound
			// 
			this.chkSound.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkSound.Location = new System.Drawing.Point(596, 64);
			this.chkSound.Name = "chkSound";
			this.chkSound.Size = new System.Drawing.Size(112, 20);
			this.chkSound.TabIndex = 10;
			this.chkSound.Text = "Play Sound Effects";
			// 
			// btnQuestionControl
			// 
			this.btnQuestionControl.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnQuestionControl.Location = new System.Drawing.Point(596, 88);
			this.btnQuestionControl.Name = "btnQuestionControl";
			this.btnQuestionControl.Size = new System.Drawing.Size(112, 28);
			this.btnQuestionControl.TabIndex = 11;
			this.btnQuestionControl.Text = "Create Questions";
			this.btnQuestionControl.Click += new System.EventHandler(this.btnQuestionControl_Click);
			// 
			// btnResetError
			// 
			this.btnResetError.Enabled = false;
			this.btnResetError.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnResetError.Location = new System.Drawing.Point(288, 380);
			this.btnResetError.Name = "btnResetError";
			this.btnResetError.Size = new System.Drawing.Size(112, 28);
			this.btnResetError.TabIndex = 12;
			this.btnResetError.Text = "Reset Error Count";
			this.btnResetError.Click += new System.EventHandler(this.btnResetError_Click);
			// 
			// btnScoreLeft
			// 
			this.btnScoreLeft.Enabled = false;
			this.btnScoreLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnScoreLeft.Location = new System.Drawing.Point(88, 380);
			this.btnScoreLeft.Name = "btnScoreLeft";
			this.btnScoreLeft.Size = new System.Drawing.Size(124, 28);
			this.btnScoreLeft.TabIndex = 13;
			this.btnScoreLeft.Text = "Give Points To Left";
			this.btnScoreLeft.Click += new System.EventHandler(this.btnScoreLeft_Click);
			// 
			// btnScoreRight
			// 
			this.btnScoreRight.Enabled = false;
			this.btnScoreRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnScoreRight.Location = new System.Drawing.Point(452, 380);
			this.btnScoreRight.Name = "btnScoreRight";
			this.btnScoreRight.Size = new System.Drawing.Size(124, 28);
			this.btnScoreRight.TabIndex = 14;
			this.btnScoreRight.Text = "Give Points To Right";
			this.btnScoreRight.Click += new System.EventHandler(this.btnScoreRight_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(88, 412);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Left Team Score:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(452, 412);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Right Team Score:";
			// 
			// txtLeftScore
			// 
			this.txtLeftScore.Enabled = false;
			this.txtLeftScore.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtLeftScore.Location = new System.Drawing.Point(88, 432);
			this.txtLeftScore.Name = "txtLeftScore";
			this.txtLeftScore.Size = new System.Drawing.Size(128, 23);
			this.txtLeftScore.TabIndex = 17;
			this.txtLeftScore.Text = "0";
			this.txtLeftScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtLeftScore.TextChanged += new System.EventHandler(this.txtLeftScore_TextChanged);
			// 
			// txtRightScore
			// 
			this.txtRightScore.Enabled = false;
			this.txtRightScore.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtRightScore.Location = new System.Drawing.Point(452, 432);
			this.txtRightScore.Name = "txtRightScore";
			this.txtRightScore.Size = new System.Drawing.Size(128, 23);
			this.txtRightScore.TabIndex = 18;
			this.txtRightScore.Text = "0";
			this.txtRightScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRightScore.TextChanged += new System.EventHandler(this.txtRightScore_TextChanged);
			// 
			// LaunchForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(712, 466);
			this.Controls.Add(this.txtRightScore);
			this.Controls.Add(this.txtLeftScore);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnScoreRight);
			this.Controls.Add(this.btnScoreLeft);
			this.Controls.Add(this.btnResetError);
			this.Controls.Add(this.btnQuestionControl);
			this.Controls.Add(this.chkSound);
			this.Controls.Add(this.btnError);
			this.Controls.Add(this.btnMax);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.grpQuestion);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LaunchForm";
			this.Text = "Launch Form";
			this.Load += new System.EventHandler(this.LaunchForm_Load);
			this.grpQuestion.ResumeLayout(false);
			this.pnlQuestionTop.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new LaunchForm());
		}

		public string Question {
			get { return this.lblQuestion.Text; }
			set { 
				this.lblQuestion.Text = value; 
				this.ClearAnswers();
			}
		}

		public void AddAnswer(string answer) {
			LinkLabel link = new LinkLabel();
			int index = 0;
			int yDelta = 4;
			if (this.pnlAnswers.Controls.Count > 0) {
				Control LastLink = this.pnlAnswers.Controls[this.pnlAnswers.Controls.Count - 1];
				yDelta = LastLink.Bounds.Bottom + 1;
				index = this.pnlAnswers.Controls.Count;
			} 
			link.Text = (index + 1).ToString() + ". " + answer;
			link.Tag = index;
			link.Width = this.pnlAnswers.Width - 16;
			link.Location = new Point(8, yDelta);
			link.Visible = true;
			link.LinkClicked += new LinkLabelLinkClickedEventHandler(link_LinkClicked);
			this.pnlAnswers.Controls.Add(link);
		}

		public void ClearAnswers() {
			this.pnlAnswers.Controls.Clear();
		}

		private void Open(string filename) {
			this.feudGame = new Game(filename, this, this.feudForm);
			this.txtRightScore.Text = this.txtLeftScore.Text = "0";
			this.chkSound.DataBindings.Clear();
			this.chkSound.DataBindings.Add("Checked", this.feudGame, "SoundEffects");
			this.feudGame.DisplayQuestion();
			this.btnResetError.Enabled = this.btnScoreLeft.Enabled = this.btnScoreRight.Enabled = this.txtLeftScore.Enabled = this.txtRightScore.Enabled = this.btnError.Enabled = this.btnPrev.Enabled = this.btnNext.Enabled = this.btnShow.Enabled = true;
			this.btnError.Refresh();
		}

		private void btnBrowse_Click(object sender, System.EventArgs e) {
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK) {
				this.txtFile.Text = this.openFileDialog1.FileName;
			}
		}

		private void LaunchForm_Load(object sender, System.EventArgs e) {
			this.feudForm = new FeudForm();
			this.openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
			this.btnMax.DataBindings.Add("Enabled", this.feudForm, "Visible");
			this.btnShow_Click(sender, e);
		}

		private void btnShow_Click(object sender, System.EventArgs e) {
			this.feudForm.Visible = !this.feudForm.Visible;
			this.btnShow.Text = this.feudForm.Visible ? "Hide Game Form" : "Show Game Form";
		}

		private void btnOpen_Click(object sender, System.EventArgs e) {
			this.Open(this.txtFile.Text);
		}

		private void btnNext_Click(object sender, System.EventArgs e) {
			this.feudGame.NextQuestion();
			this.feudGame.DisplayQuestion();
		}

		private void btnPrev_Click(object sender, System.EventArgs e) {
			this.feudGame.PreviousQuestion();
			this.feudGame.DisplayQuestion();
		}

		private void btnMax_Click(object sender, System.EventArgs e) {
			this.feudForm.WindowState = this.feudForm.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
			this.btnMax.Text = this.feudForm.WindowState == FormWindowState.Maximized ? "Restore Game Form" : "Maximize Game Form";
		}

		private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			LinkLabel link = sender as LinkLabel;
			this.feudGame.ShowAnswer(Convert.ToInt32(link.Tag));
		}

		private void btnError_Click(object sender, System.EventArgs e) {
			this.feudGame.ShowError();
		}

		private void btnQuestionControl_Click(object sender, System.EventArgs e) {
			QuestionCreator frm = new QuestionCreator();
			frm.Show();
		}

		private void btnResetError_Click(object sender, System.EventArgs e) {
			this.feudGame.ResetErrorCount();
		}

		private void btnScoreLeft_Click(object sender, System.EventArgs e) {
			this.txtLeftScore.Text = this.feudGame.ScoreLeftTeam().ToString();
		}

		private void txtLeftScore_TextChanged(object sender, System.EventArgs e) {
			try {
				int i = Convert.ToInt32(this.txtLeftScore.Text);
				this.feudGame.SetLeftScore(i);
			} catch { }
			
		}

		private void btnScoreRight_Click(object sender, System.EventArgs e) {
			this.txtRightScore.Text = this.feudGame.ScoreRightTeam().ToString();
		}

		private void txtRightScore_TextChanged(object sender, System.EventArgs e) {
			try {
				int i = Convert.ToInt32(this.txtRightScore.Text);
				this.feudGame.SetRightScore(i);
			} catch { }
		}
	}
}
