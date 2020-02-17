using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ESolutions.ImageResizer
{
	public partial class MainForm : Form
	{
		//Fields
		#region resizer
		private Resizer resizer = new Resizer();
		#endregion

		//Constructors
		#region MainForm
		public MainForm()
		{
			InitializeComponent();

			this.resizer.FileProcessed += new EventHandler(Resizer_FileProcessed);
			this.resizer.Finished += new EventHandler(Resizer_Finished);
		}
		#endregion

		//Methods
		#region SelectSourceButton_Click
		private void SelectSourceButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog browser = new FolderBrowserDialog();
			browser.SelectedPath = this.sourceTextBox.Text;
			browser.ShowNewFolderButton = false;

			if (browser.ShowDialog() == DialogResult.OK)
			{
				this.sourceTextBox.Text = browser.SelectedPath;
				this.resizer.SourceDirectory = new DirectoryInfo(browser.SelectedPath);
			}
		}
		#endregion

		#region SelectTargetButton_Click
		private void SelectTargetButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog browser = new FolderBrowserDialog();
			browser.SelectedPath = this.targetTextBox.Text;
			browser.ShowNewFolderButton = true;

			if (browser.ShowDialog() == DialogResult.OK)
			{
				this.targetTextBox.Text = browser.SelectedPath;
				this.resizer.TargetDirectory = new DirectoryInfo(browser.SelectedPath);
			}
		}
		#endregion

		#region GoButton_Click
		private void GoButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.resizer.LongestImageSide = Convert.ToInt32(this.longestSideImageTextBox.Text);
				this.resizer.LongestThumbSide = Convert.ToInt32(this.longestSizeThumbTextBox.Text);

				this.progressBar.Minimum = 0;
				this.progressBar.Maximum = this.resizer.NumberOfFiles - 1;
				this.progressBar.Value = 0;

				this.finishedLabel.Visible = false;

				this.resizer.BeginResizing();
			}
			catch
			{

			}
		}
		#endregion

		#region Resizer_Finished
		void Resizer_Finished(object sender, EventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new EventHandler(this.Resizer_Finished), sender, e);
			}
			else
			{
				this.progressBar.Value = 0;
				this.finishedLabel.Visible = true;
			}
		}
		#endregion

		#region Resizer_FileProcessed
		void Resizer_FileProcessed(object sender, EventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new EventHandler(this.Resizer_FileProcessed), sender, e);
			}
			else
			{
				this.progressBar.Increment(1);
			}
		}
		#endregion

		#region DigitsOnlyTextBox_KeyPress
		private void DigitsOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}
		#endregion
	}
}