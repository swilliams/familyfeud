/*
 * Showing images on XP-styled buttons.
 * 
 * Author: Andrew Ma (ajma@microsoft.com)
 * http://blogs.msdn.com/ajma/archive/2005/01/21/358356.aspx
 * 
 * Redistribution and use in source and binary forms, with or without 
 * modification, are permitted.
 * 
 * This posting is provided "AS IS" with no warranties, and confers no rights. 
 * Use of included code samples are subject to the terms specified at http://www.microsoft.com/info/cpyright.htm
 */ 

using System;
using System.Drawing;
using System.Windows.Forms; 

namespace FamilyFeud {
	/// <summary>
	/// Represents a Windows button control that will use Visual Styles by default. This button will also draw images if specified.
	/// </summary>
	public class Button : System.Windows.Forms.Button {
		/// <summary>
		/// WM_PAINT message
		/// </summary>
		const int WM_PAINT = 0xF; 

		/// <summary>
		/// Initializes a new instance of the Button class.
		/// </summary>
		public Button() {
			FlatStyle = FlatStyle.System;
		} 

		/// <summary>
		/// Overridden. See <see cref="Control.WndProc"/>.
		/// </summary>
		/// <param name="m">The Windows <see cref="Message"/> to process. </param>
		protected override void WndProc(ref Message m) {
			// let base.WndProc go first
			base.WndProc (ref m); 

			// if paiting (and there is a message), draw image on top of button
			if(m.Msg == WM_PAINT && this.Image != null) {
				Graphics g = Graphics.FromHwnd(this.Handle);
				switch(this.ImageAlign) {
					case ContentAlignment.BottomCenter:
						g.DrawImage(this.Image, centerX(), bottom());
						break;
					case ContentAlignment.BottomLeft:
						g.DrawImage(this.Image, left(), bottom());
						break;
					case ContentAlignment.BottomRight:
						g.DrawImage(this.Image, right(), bottom());
						break;
					case ContentAlignment.MiddleCenter:
						g.DrawImage(this.Image, centerX(), centerY());
						break;
					case ContentAlignment.MiddleLeft:
						g.DrawImage(this.Image, left(), centerY());
						break;
					case ContentAlignment.MiddleRight:
						g.DrawImage(this.Image, right(), centerY());
						break;
					case ContentAlignment.TopCenter:
						g.DrawImage(this.Image, centerX(), top());
						break;
					case ContentAlignment.TopLeft:
						g.DrawImage(this.Image, left(), top());
						break;
					case ContentAlignment.TopRight:
						g.DrawImage(this.Image, right(), top());
						break;
				}
				g.Dispose();
			}
		} 

		#region Returns the X/Y points for the image to be drawn
		private int centerX() {
			return (this.Width - this.Image.Width) / 2;
		} 

		private int centerY() {
			return (this.Height - this.Image.Height) / 2;
		} 

		private int top() {
			return 4;
		} 

		private int left() {
			return 4;
		} 

		private int right() {
			return this.Width - this.Image.Width - left();
		} 

		private int bottom() {
			return this.Height - this.Image.Width - top();
		}
		#endregion
	}
}


