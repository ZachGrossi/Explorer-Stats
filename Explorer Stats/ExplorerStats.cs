using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_Stats
{
	public partial class ExplorerStats : Form
	{
		public ExplorerStats()
		{
			InitializeComponent();

			// Reset the view
			treeViewFolderExplorer.Nodes.Clear();
			this.labelSelectedFolderName.Text = string.Empty;
			this.labelSelectedFolderSize.Text = string.Empty;
			this.labelSelectedFolderNumberFiles.Text = string.Empty;
			this.labelSelectedFolderSubDirectories.Text = string.Empty;
			this.labelSelectedFolderCreationDate.Text = string.Empty;
			this.labelSelectedFolderLastAccessedDate.Text = string.Empty;
			this.labelSelectedFolderLastModifiedDate.Text = string.Empty;
		}

		#region GUI Methods
		/// <summary>
		/// When the Browse button is clicked, display the FolderBrowserDialog
		/// </summary>
		private void BtnBrowse_Click(object sender, EventArgs e)
		{
			string path = ShowFolderBrowser();
			if (!string.IsNullOrWhiteSpace(path))
			{
				txtFolderPath.Text = path;
			}
		}

		/// <summary>
		/// Populates the FolderTreeView with the information from the root folder and all subdirectories
		/// </summary>
		private void TxtFolderPath_TextChanged(object sender, EventArgs e)
		{
			var path = txtFolderPath.Text;
			if (!string.IsNullOrWhiteSpace(path))
			{
				// Reset the view
				treeViewFolderExplorer.Nodes.Clear();
				this.labelSelectedFolderName.Text = string.Empty;
				this.labelSelectedFolderSize.Text = string.Empty;
				this.labelSelectedFolderNumberFiles.Text = string.Empty;
				this.labelSelectedFolderSubDirectories.Text = string.Empty;
				this.labelSelectedFolderCreationDate.Text = string.Empty;
				this.labelSelectedFolderLastAccessedDate.Text = string.Empty;
				this.labelSelectedFolderLastModifiedDate.Text = string.Empty;

				// Start creating the directory tree
				var dirInfo = new DirectoryInfo(path);

				this.UseWaitCursor = true;
				tlpFolderBrowser.Enabled = false;
				splitContainerFolderStats.Enabled = false;

				backgroundWorker.RunWorkerAsync(dirInfo);
			}
		}

		/// <summary>
		/// After a node has been selected, update the directory and file stats
		/// </summary>
		private void TreeViewFolderExplorer_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node != null)
			{
				PopulateStatisticsView(e.Node);
			}
		}
		#endregion

		#region BakgroundWorker Methods
		/// <summary>
		/// Start the background work thread to build the directory tree
		/// </summary>
		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var dirInfo = (DirectoryInfo)e.Argument;
			e.Result = CreateDirectoryTree(dirInfo);
		}

		/// <summary>
		/// Once the background work has completed, verify the output and populate the TreeView with the directory tree contents
		/// </summary>
		private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.UseWaitCursor = false;
			tlpFolderBrowser.Enabled = true;
			splitContainerFolderStats.Enabled = true;

			if (e.Error != null)
			{
				Console.WriteLine(e.Error.Message + "\n" + e.Error.StackTrace);
			}
			else
			{
				var currentDirectory = (Directory)e.Result;
				PopulateDirectoryTreeView(currentDirectory, treeViewFolderExplorer.Nodes);
			}
		}
		#endregion

		#region Main Methods
		/// <summary>
		/// Create the directory tree from the root directory's DirectoryInfo object
		/// </summary>
		/// <param name="rootDirectory">The DirectoryInfo reoresenting the location of the root directory</param>
		/// <returns>The Directory object containing all analyzed statistics of the directory tree</returns>
		public Directory CreateDirectoryTree(DirectoryInfo rootDirectory)
		{
			if (rootDirectory.Exists)
			{
				return new Directory(rootDirectory);
			}

			return null;
		}
		
		/// <summary>
		/// Displays a FolderBrowserDialog to select a root directory
		/// </summary>
		/// <returns>The full string path to the selected directory</returns>
		public string ShowFolderBrowser()
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();

			try
			{
				folder.ShowNewFolderButton = false;
				folder.Description = "Please select a root directory to analyze";

				var result = folder.ShowDialog(this);
				if ((result == DialogResult.OK) && (!string.IsNullOrWhiteSpace(folder.SelectedPath)))
				{
					return folder.SelectedPath;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}
			finally
			{
				folder.Dispose();
			}

			return string.Empty;
		}

		/// <summary>
		/// Breaks down the directory tree into statistics and tree nodes for the TreeView
		/// </summary>
		/// <param name="directoryinfo">The DirectoryInfo object representing the current directory to add to the TreeView</param>
		/// <param name="nodes">The parent node's collection of TreeNodes that will be appended to</param>
		public void PopulateDirectoryTreeView(Directory directory, TreeNodeCollection nodes)
		{
			try
			{
				TreeNode currentNode = nodes.Add(directory.Name);
				currentNode.Tag = directory;

				// Draw the subdirectories from the subdirectory collection of the current directory node
				foreach (var subDir in directory.Subdirectories)
				{
					PopulateDirectoryTreeView(subDir, currentNode.Nodes);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}
		}

		/// <summary>
		/// Populate the statistics right panel with the currently-selcted directory's file statistics
		/// </summary>
		/// <param name="node">The currently-selected TreeNode</param>
		public void PopulateStatisticsView(TreeNode node)
		{
			try
			{
				if ((node != null) && (node.Tag != null))
				{
					var dInfo = (Directory)node.Tag;

					// Populate top statistics view
					this.labelSelectedFolderName.Text = dInfo.Name;
					this.labelSelectedFolderSize.Text = dInfo.TotalFileSize() + " Bytes";
					this.labelSelectedFolderNumberFiles.Text = dInfo.TotalNumberOfFiles().ToString();
					this.labelSelectedFolderSubDirectories.Text = dInfo.TotalNumberOfSubdirectories().ToString();
					this.labelSelectedFolderCreationDate.Text = dInfo.DirectoryInfo.CreationTime.ToString("yyyy/MM/dd HH:mm:ss");
					this.labelSelectedFolderLastAccessedDate.Text = dInfo.DirectoryInfo.LastAccessTime.ToString("yyyy/MM/dd HH:mm:ss");
					this.labelSelectedFolderLastModifiedDate.Text = dInfo.DirectoryInfo.LastWriteTime.ToString("yyyy/MM/dd HH:mm:ss");

					// Populate the extension collection
					dataGridViewFileDetails.DataSource = dInfo.TotalFileExtensions().Values.ToList();
					dataGridViewFileDetails.Update();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}
		}
		#endregion
	}
}
