using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Relative_Path
{
	public partial class Form1 : Form
	{
		readonly static char[] separator = { '\\', '/' };

		public Form1()
		{
			InitializeComponent();
		}

		private void openPath(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				if ((sender as Button).Name == "buttonPath1")
					textBoxPath1.Text = folderBrowserDialog.SelectedPath;
				if ((sender as Button).Name == "buttonPath2")
					textBoxPath2.Text = folderBrowserDialog.SelectedPath;

				if (textBoxPath1.Text != string.Empty && textBoxPath2.Text != string.Empty)
					textBoxRelativePath.Text = calcRelativePath(textBoxPath1.Text, textBoxPath2.Text);
			}
		}

		private void textBox_textChanged(object sender, EventArgs e)
		{
			if (textBoxPath1.Text != string.Empty && textBoxPath2.Text != string.Empty)
				textBoxRelativePath.Text = calcRelativePath(textBoxPath1.Text, textBoxPath2.Text);
		}

		/*
		 * Given 2 paths, returns the relative path for the second one
		 */
		private string calcRelativePath(string path1, string path2)
		{
			textBoxRelativePath.Text = "Calcolo";

			string[] absPathSplitted1 = path1.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			string[] absPathSplitted2 = path2.Split(separator, StringSplitOptions.RemoveEmptyEntries);

			if (absPathSplitted1[0] != absPathSplitted2[0])
				return "Paths are on two different drive letters or roots and cannot have a relative path.";

			List<string> relativePath = new List<string>();

			int common = 0;
			while (common < absPathSplitted1.Length && common < absPathSplitted2.Length)
				if (absPathSplitted1[common] == absPathSplitted2[common])
					common++;
				else
					break;

			if (absPathSplitted1.Length - common > 0)
				relativePath.AddRange(Enumerable.Repeat("..", absPathSplitted1.Length - common));

			for (int i = common; i < absPathSplitted2.Length; i++)
				relativePath.Add(absPathSplitted2[i]);

			return string.Join("\\", relativePath);
		}
	}
}
