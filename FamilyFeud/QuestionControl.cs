using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FamilyFeud
{
	/// <summary>
	/// Summary description for Question.
	/// </summary>
	public class QuestionControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel pnlNumber;
		private System.Windows.Forms.Panel pnlWhiteLine;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Label lblAnswer;
		private System.Windows.Forms.Panel pnlCoverUp;
		private System.Windows.Forms.Label lblIndex;
		private System.Windows.Forms.Panel pnlBoxRight;
		private System.Windows.Forms.Panel pnlBoxLeft;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public QuestionControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlNumber = new System.Windows.Forms.Panel();
			this.lblNumber = new System.Windows.Forms.Label();
			this.pnlWhiteLine = new System.Windows.Forms.Panel();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.pnlCoverUp = new System.Windows.Forms.Panel();
			this.pnlBoxLeft = new System.Windows.Forms.Panel();
			this.pnlBoxRight = new System.Windows.Forms.Panel();
			this.lblIndex = new System.Windows.Forms.Label();
			this.pnlNumber.SuspendLayout();
			this.pnlCoverUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlNumber
			// 
			this.pnlNumber.Controls.Add(this.lblNumber);
			this.pnlNumber.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlNumber.Location = new System.Drawing.Point(220, 0);
			this.pnlNumber.Name = "pnlNumber";
			this.pnlNumber.Size = new System.Drawing.Size(32, 28);
			this.pnlNumber.TabIndex = 0;
			// 
			// lblNumber
			// 
			this.lblNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblNumber.ForeColor = System.Drawing.Color.White;
			this.lblNumber.Location = new System.Drawing.Point(-7, 4);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(36, 20);
			this.lblNumber.TabIndex = 0;
			this.lblNumber.Text = "100";
			this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnlWhiteLine
			// 
			this.pnlWhiteLine.BackColor = System.Drawing.Color.White;
			this.pnlWhiteLine.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlWhiteLine.Location = new System.Drawing.Point(219, 0);
			this.pnlWhiteLine.Name = "pnlWhiteLine";
			this.pnlWhiteLine.Size = new System.Drawing.Size(1, 28);
			this.pnlWhiteLine.TabIndex = 1;
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblAnswer.ForeColor = System.Drawing.Color.White;
			this.lblAnswer.Location = new System.Drawing.Point(8, 4);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(84, 18);
			this.lblAnswer.TabIndex = 2;
			this.lblAnswer.Text = "Answer Text";
			// 
			// pnlCoverUp
			// 
			this.pnlCoverUp.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(249)), ((System.Byte)(224)), ((System.Byte)(131)));
			this.pnlCoverUp.Controls.Add(this.pnlBoxLeft);
			this.pnlCoverUp.Controls.Add(this.pnlBoxRight);
			this.pnlCoverUp.Controls.Add(this.lblIndex);
			this.pnlCoverUp.Location = new System.Drawing.Point(4, 4);
			this.pnlCoverUp.Name = "pnlCoverUp";
			this.pnlCoverUp.Size = new System.Drawing.Size(208, 20);
			this.pnlCoverUp.TabIndex = 3;
			// 
			// pnlBoxLeft
			// 
			this.pnlBoxLeft.Location = new System.Drawing.Point(4, 4);
			this.pnlBoxLeft.Name = "pnlBoxLeft";
			this.pnlBoxLeft.Size = new System.Drawing.Size(84, 12);
			this.pnlBoxLeft.TabIndex = 2;
			this.pnlBoxLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoxRight_Paint);
			// 
			// pnlBoxRight
			// 
			this.pnlBoxRight.Location = new System.Drawing.Point(120, 4);
			this.pnlBoxRight.Name = "pnlBoxRight";
			this.pnlBoxRight.Size = new System.Drawing.Size(84, 12);
			this.pnlBoxRight.TabIndex = 1;
			this.pnlBoxRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoxRight_Paint);
			// 
			// lblIndex
			// 
			this.lblIndex.AutoSize = true;
			this.lblIndex.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblIndex.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(157)), ((System.Byte)(84)), ((System.Byte)(5)));
			this.lblIndex.Location = new System.Drawing.Point(100, 0);
			this.lblIndex.Name = "lblIndex";
			this.lblIndex.Size = new System.Drawing.Size(12, 18);
			this.lblIndex.TabIndex = 0;
			this.lblIndex.Text = "1";
			// 
			// QuestionControl
			// 
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.pnlCoverUp);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.pnlWhiteLine);
			this.Controls.Add(this.pnlNumber);
			this.Name = "QuestionControl";
			this.Size = new System.Drawing.Size(252, 28);
			this.Resize += new System.EventHandler(this.QuestionControl_Resize);
			this.pnlNumber.ResumeLayout(false);
			this.pnlCoverUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void pnlBoxRight_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			Panel pnl = sender as Panel;
			Rectangle rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
			Pen p = new Pen(this.lblIndex.ForeColor, 1);
			e.Graphics.DrawRectangle(p, rect);
		}

		public string Index {
			get { return this.lblIndex.Text; }
			set { this.lblIndex.Text = value; }
		}

		public string AnswerCount {
			get { return this.lblNumber.Text; }
			set { this.lblNumber.Text = value; }
		}

		public string AnswerText {
			get { return this.lblAnswer.Text; } 
			set { this.lblAnswer.Text = value; }
		}

		private void Initialize() {
			this.ResizeControl();
			this.pnlCoverUp.BringToFront();
		}

		public bool IsCovered {
			get { return this.pnlCoverUp.Visible; }
		}

		public void ToggleCoverup() {
			this.pnlCoverUp.Visible = !this.pnlCoverUp.Visible;
		}

		public void ResizeControl() {
			this.pnlCoverUp.Location = new Point(0, 0);
			this.pnlCoverUp.Width = this.Width;
			this.pnlCoverUp.Height = this.Height;
			this.pnlBoxLeft.Location = new Point(4, 4);
			this.pnlBoxLeft.Width = this.pnlBoxRight.Width = (this.Width / 2) - 14;
			this.pnlBoxLeft.Height = this.pnlBoxRight.Height = this.Height - 8;
			this.lblIndex.Location = new Point(this.pnlBoxLeft.Bounds.Right + 4, 4);
			this.pnlBoxRight.Location = new Point(this.lblIndex.Bounds.Right + 4, 4);
		}

		private void QuestionControl_Resize(object sender, System.EventArgs e) {
			this.ResizeControl();
		}
	}
}
