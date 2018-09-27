namespace Explorer_Stats
{
	partial class ExplorerStats
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerStats));
			this.tlpFolderBrowser = new System.Windows.Forms.TableLayoutPanel();
			this.labelFolderPath = new System.Windows.Forms.Label();
			this.txtFolderPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.panelFolderStatistics = new System.Windows.Forms.Panel();
			this.splitContainerFolderStats = new System.Windows.Forms.SplitContainer();
			this.treeViewFolderExplorer = new System.Windows.Forms.TreeView();
			this.groupBoxFolderStatistics = new System.Windows.Forms.GroupBox();
			this.dataGridViewFileDetails = new System.Windows.Forms.DataGridView();
			this.labelFileDetails = new System.Windows.Forms.Label();
			this.tableLayoutPanelStatistics = new System.Windows.Forms.TableLayoutPanel();
			this.labelFolderName = new System.Windows.Forms.Label();
			this.labelTotalSize = new System.Windows.Forms.Label();
			this.labelSelectedFolderName = new System.Windows.Forms.Label();
			this.labelSelectedFolderSize = new System.Windows.Forms.Label();
			this.labelModifiedDate = new System.Windows.Forms.Label();
			this.labelAccessedDate = new System.Windows.Forms.Label();
			this.labelCreationDate = new System.Windows.Forms.Label();
			this.labelSubdirectories = new System.Windows.Forms.Label();
			this.labelSelectedFolderLastModifiedDate = new System.Windows.Forms.Label();
			this.labelSelectedFolderLastAccessedDate = new System.Windows.Forms.Label();
			this.labelSelectedFolderCreationDate = new System.Windows.Forms.Label();
			this.labelSelectedFolderSubDirectories = new System.Windows.Forms.Label();
			this.labelNumberOfFiles = new System.Windows.Forms.Label();
			this.labelSelectedFolderNumberFiles = new System.Windows.Forms.Label();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.tlpFolderBrowser.SuspendLayout();
			this.panelFolderStatistics.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerFolderStats)).BeginInit();
			this.splitContainerFolderStats.Panel1.SuspendLayout();
			this.splitContainerFolderStats.Panel2.SuspendLayout();
			this.splitContainerFolderStats.SuspendLayout();
			this.groupBoxFolderStatistics.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileDetails)).BeginInit();
			this.tableLayoutPanelStatistics.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpFolderBrowser
			// 
			this.tlpFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpFolderBrowser.ColumnCount = 3;
			this.tlpFolderBrowser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpFolderBrowser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpFolderBrowser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpFolderBrowser.Controls.Add(this.labelFolderPath, 0, 0);
			this.tlpFolderBrowser.Controls.Add(this.txtFolderPath, 1, 0);
			this.tlpFolderBrowser.Controls.Add(this.btnBrowse, 2, 0);
			this.tlpFolderBrowser.Location = new System.Drawing.Point(12, 12);
			this.tlpFolderBrowser.Name = "tlpFolderBrowser";
			this.tlpFolderBrowser.RowCount = 1;
			this.tlpFolderBrowser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpFolderBrowser.Size = new System.Drawing.Size(610, 26);
			this.tlpFolderBrowser.TabIndex = 0;
			// 
			// labelFolderPath
			// 
			this.labelFolderPath.AutoSize = true;
			this.labelFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFolderPath.Location = new System.Drawing.Point(3, 0);
			this.labelFolderPath.Name = "labelFolderPath";
			this.labelFolderPath.Size = new System.Drawing.Size(61, 26);
			this.labelFolderPath.TabIndex = 0;
			this.labelFolderPath.Text = "Folder Path";
			this.labelFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFolderPath
			// 
			this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFolderPath.Location = new System.Drawing.Point(70, 3);
			this.txtFolderPath.Name = "txtFolderPath";
			this.txtFolderPath.ReadOnly = true;
			this.txtFolderPath.Size = new System.Drawing.Size(456, 20);
			this.txtFolderPath.TabIndex = 1;
			this.txtFolderPath.TextChanged += new System.EventHandler(this.TxtFolderPath_TextChanged);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBrowse.Location = new System.Drawing.Point(532, 3);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 20);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// panelFolderStatistics
			// 
			this.panelFolderStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelFolderStatistics.Controls.Add(this.splitContainerFolderStats);
			this.panelFolderStatistics.Location = new System.Drawing.Point(12, 45);
			this.panelFolderStatistics.Name = "panelFolderStatistics";
			this.panelFolderStatistics.Size = new System.Drawing.Size(610, 654);
			this.panelFolderStatistics.TabIndex = 1;
			// 
			// splitContainerFolderStats
			// 
			this.splitContainerFolderStats.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerFolderStats.Location = new System.Drawing.Point(0, 0);
			this.splitContainerFolderStats.Name = "splitContainerFolderStats";
			// 
			// splitContainerFolderStats.Panel1
			// 
			this.splitContainerFolderStats.Panel1.Controls.Add(this.treeViewFolderExplorer);
			this.splitContainerFolderStats.Panel1MinSize = 200;
			// 
			// splitContainerFolderStats.Panel2
			// 
			this.splitContainerFolderStats.Panel2.Controls.Add(this.groupBoxFolderStatistics);
			this.splitContainerFolderStats.Panel2MinSize = 200;
			this.splitContainerFolderStats.Size = new System.Drawing.Size(610, 654);
			this.splitContainerFolderStats.SplitterDistance = 282;
			this.splitContainerFolderStats.TabIndex = 0;
			// 
			// treeViewFolderExplorer
			// 
			this.treeViewFolderExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewFolderExplorer.Location = new System.Drawing.Point(0, 0);
			this.treeViewFolderExplorer.Name = "treeViewFolderExplorer";
			this.treeViewFolderExplorer.Size = new System.Drawing.Size(282, 654);
			this.treeViewFolderExplorer.TabIndex = 0;
			this.treeViewFolderExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewFolderExplorer_AfterSelect);
			// 
			// groupBoxFolderStatistics
			// 
			this.groupBoxFolderStatistics.Controls.Add(this.dataGridViewFileDetails);
			this.groupBoxFolderStatistics.Controls.Add(this.labelFileDetails);
			this.groupBoxFolderStatistics.Controls.Add(this.tableLayoutPanelStatistics);
			this.groupBoxFolderStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxFolderStatistics.Location = new System.Drawing.Point(0, 0);
			this.groupBoxFolderStatistics.Name = "groupBoxFolderStatistics";
			this.groupBoxFolderStatistics.Size = new System.Drawing.Size(324, 654);
			this.groupBoxFolderStatistics.TabIndex = 0;
			this.groupBoxFolderStatistics.TabStop = false;
			this.groupBoxFolderStatistics.Text = "Selected Folder Statistics";
			// 
			// dataGridViewFileDetails
			// 
			this.dataGridViewFileDetails.AllowUserToAddRows = false;
			this.dataGridViewFileDetails.AllowUserToDeleteRows = false;
			this.dataGridViewFileDetails.AllowUserToOrderColumns = true;
			this.dataGridViewFileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewFileDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFileDetails.Location = new System.Drawing.Point(7, 195);
			this.dataGridViewFileDetails.Name = "dataGridViewFileDetails";
			this.dataGridViewFileDetails.ReadOnly = true;
			this.dataGridViewFileDetails.RowHeadersVisible = false;
			this.dataGridViewFileDetails.Size = new System.Drawing.Size(311, 453);
			this.dataGridViewFileDetails.TabIndex = 3;
			// 
			// labelFileDetails
			// 
			this.labelFileDetails.AutoSize = true;
			this.labelFileDetails.Location = new System.Drawing.Point(6, 176);
			this.labelFileDetails.Name = "labelFileDetails";
			this.labelFileDetails.Size = new System.Drawing.Size(112, 13);
			this.labelFileDetails.TabIndex = 2;
			this.labelFileDetails.Text = "Contained File Details:";
			// 
			// tableLayoutPanelStatistics
			// 
			this.tableLayoutPanelStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanelStatistics.ColumnCount = 2;
			this.tableLayoutPanelStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelStatistics.Controls.Add(this.labelFolderName, 0, 0);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelTotalSize, 0, 1);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelSelectedFolderName, 1, 0);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelSelectedFolderSize, 1, 1);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelModifiedDate, 0, 6);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelAccessedDate, 0, 5);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelCreationDate, 0, 4);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelSubdirectories, 0, 3);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelSelectedFolderLastModifiedDate, 1, 6);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelSelectedFolderLastAccessedDate, 1, 5);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelSelectedFolderCreationDate, 1, 4);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelSelectedFolderSubDirectories, 1, 3);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelNumberOfFiles, 0, 2);
			this.tableLayoutPanelStatistics.Controls.Add(this.labelSelectedFolderNumberFiles, 1, 2);
			this.tableLayoutPanelStatistics.Location = new System.Drawing.Point(7, 19);
			this.tableLayoutPanelStatistics.Name = "tableLayoutPanelStatistics";
			this.tableLayoutPanelStatistics.RowCount = 7;
			this.tableLayoutPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelStatistics.Size = new System.Drawing.Size(311, 142);
			this.tableLayoutPanelStatistics.TabIndex = 0;
			// 
			// labelFolderName
			// 
			this.labelFolderName.AutoSize = true;
			this.labelFolderName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFolderName.Location = new System.Drawing.Point(3, 0);
			this.labelFolderName.Name = "labelFolderName";
			this.labelFolderName.Size = new System.Drawing.Size(131, 20);
			this.labelFolderName.TabIndex = 0;
			this.labelFolderName.Text = "Folder Name:";
			this.labelFolderName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelTotalSize
			// 
			this.labelTotalSize.AutoSize = true;
			this.labelTotalSize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTotalSize.Location = new System.Drawing.Point(3, 20);
			this.labelTotalSize.Name = "labelTotalSize";
			this.labelTotalSize.Size = new System.Drawing.Size(131, 20);
			this.labelTotalSize.TabIndex = 1;
			this.labelTotalSize.Text = "Total Size:";
			this.labelTotalSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSelectedFolderName
			// 
			this.labelSelectedFolderName.AutoSize = true;
			this.labelSelectedFolderName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectedFolderName.Location = new System.Drawing.Point(140, 0);
			this.labelSelectedFolderName.Name = "labelSelectedFolderName";
			this.labelSelectedFolderName.Size = new System.Drawing.Size(168, 20);
			this.labelSelectedFolderName.TabIndex = 2;
			this.labelSelectedFolderName.Text = "Name";
			this.labelSelectedFolderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSelectedFolderSize
			// 
			this.labelSelectedFolderSize.AutoSize = true;
			this.labelSelectedFolderSize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectedFolderSize.Location = new System.Drawing.Point(140, 20);
			this.labelSelectedFolderSize.Name = "labelSelectedFolderSize";
			this.labelSelectedFolderSize.Size = new System.Drawing.Size(168, 20);
			this.labelSelectedFolderSize.TabIndex = 3;
			this.labelSelectedFolderSize.Text = "Size Bytes";
			this.labelSelectedFolderSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelModifiedDate
			// 
			this.labelModifiedDate.AutoSize = true;
			this.labelModifiedDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModifiedDate.Location = new System.Drawing.Point(3, 120);
			this.labelModifiedDate.Name = "labelModifiedDate";
			this.labelModifiedDate.Size = new System.Drawing.Size(131, 22);
			this.labelModifiedDate.TabIndex = 9;
			this.labelModifiedDate.Text = "Date Last Modified:";
			this.labelModifiedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelAccessedDate
			// 
			this.labelAccessedDate.AutoSize = true;
			this.labelAccessedDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAccessedDate.Location = new System.Drawing.Point(3, 100);
			this.labelAccessedDate.Name = "labelAccessedDate";
			this.labelAccessedDate.Size = new System.Drawing.Size(131, 20);
			this.labelAccessedDate.TabIndex = 8;
			this.labelAccessedDate.Text = "Date Last Accessed:";
			this.labelAccessedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelCreationDate
			// 
			this.labelCreationDate.AutoSize = true;
			this.labelCreationDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCreationDate.Location = new System.Drawing.Point(3, 80);
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Size = new System.Drawing.Size(131, 20);
			this.labelCreationDate.TabIndex = 6;
			this.labelCreationDate.Text = "Created Date:";
			this.labelCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSubdirectories
			// 
			this.labelSubdirectories.AutoSize = true;
			this.labelSubdirectories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSubdirectories.Location = new System.Drawing.Point(3, 60);
			this.labelSubdirectories.Name = "labelSubdirectories";
			this.labelSubdirectories.Size = new System.Drawing.Size(131, 20);
			this.labelSubdirectories.TabIndex = 4;
			this.labelSubdirectories.Text = "Number ofSub-Directories:";
			this.labelSubdirectories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSelectedFolderLastModifiedDate
			// 
			this.labelSelectedFolderLastModifiedDate.AutoSize = true;
			this.labelSelectedFolderLastModifiedDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectedFolderLastModifiedDate.Location = new System.Drawing.Point(140, 120);
			this.labelSelectedFolderLastModifiedDate.Name = "labelSelectedFolderLastModifiedDate";
			this.labelSelectedFolderLastModifiedDate.Size = new System.Drawing.Size(168, 22);
			this.labelSelectedFolderLastModifiedDate.TabIndex = 11;
			this.labelSelectedFolderLastModifiedDate.Text = "DateTime";
			this.labelSelectedFolderLastModifiedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSelectedFolderLastAccessedDate
			// 
			this.labelSelectedFolderLastAccessedDate.AutoSize = true;
			this.labelSelectedFolderLastAccessedDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectedFolderLastAccessedDate.Location = new System.Drawing.Point(140, 100);
			this.labelSelectedFolderLastAccessedDate.Name = "labelSelectedFolderLastAccessedDate";
			this.labelSelectedFolderLastAccessedDate.Size = new System.Drawing.Size(168, 20);
			this.labelSelectedFolderLastAccessedDate.TabIndex = 10;
			this.labelSelectedFolderLastAccessedDate.Text = "DateTime";
			this.labelSelectedFolderLastAccessedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSelectedFolderCreationDate
			// 
			this.labelSelectedFolderCreationDate.AutoSize = true;
			this.labelSelectedFolderCreationDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectedFolderCreationDate.Location = new System.Drawing.Point(140, 80);
			this.labelSelectedFolderCreationDate.Name = "labelSelectedFolderCreationDate";
			this.labelSelectedFolderCreationDate.Size = new System.Drawing.Size(168, 20);
			this.labelSelectedFolderCreationDate.TabIndex = 7;
			this.labelSelectedFolderCreationDate.Text = "DateTime";
			this.labelSelectedFolderCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSelectedFolderSubDirectories
			// 
			this.labelSelectedFolderSubDirectories.AutoSize = true;
			this.labelSelectedFolderSubDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectedFolderSubDirectories.Location = new System.Drawing.Point(140, 60);
			this.labelSelectedFolderSubDirectories.Name = "labelSelectedFolderSubDirectories";
			this.labelSelectedFolderSubDirectories.Size = new System.Drawing.Size(168, 20);
			this.labelSelectedFolderSubDirectories.TabIndex = 5;
			this.labelSelectedFolderSubDirectories.Text = "Number";
			this.labelSelectedFolderSubDirectories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelNumberOfFiles
			// 
			this.labelNumberOfFiles.AutoSize = true;
			this.labelNumberOfFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumberOfFiles.Location = new System.Drawing.Point(3, 40);
			this.labelNumberOfFiles.Name = "labelNumberOfFiles";
			this.labelNumberOfFiles.Size = new System.Drawing.Size(131, 20);
			this.labelNumberOfFiles.TabIndex = 12;
			this.labelNumberOfFiles.Text = "Number of Files:";
			this.labelNumberOfFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSelectedFolderNumberFiles
			// 
			this.labelSelectedFolderNumberFiles.AutoSize = true;
			this.labelSelectedFolderNumberFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectedFolderNumberFiles.Location = new System.Drawing.Point(140, 40);
			this.labelSelectedFolderNumberFiles.Name = "labelSelectedFolderNumberFiles";
			this.labelSelectedFolderNumberFiles.Size = new System.Drawing.Size(168, 20);
			this.labelSelectedFolderNumberFiles.TabIndex = 13;
			this.labelSelectedFolderNumberFiles.Text = "Number";
			this.labelSelectedFolderNumberFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// ExplorerStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 711);
			this.Controls.Add(this.panelFolderStatistics);
			this.Controls.Add(this.tlpFolderBrowser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "ExplorerStats";
			this.Text = "Explorer Stats";
			this.tlpFolderBrowser.ResumeLayout(false);
			this.tlpFolderBrowser.PerformLayout();
			this.panelFolderStatistics.ResumeLayout(false);
			this.splitContainerFolderStats.Panel1.ResumeLayout(false);
			this.splitContainerFolderStats.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerFolderStats)).EndInit();
			this.splitContainerFolderStats.ResumeLayout(false);
			this.groupBoxFolderStatistics.ResumeLayout(false);
			this.groupBoxFolderStatistics.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileDetails)).EndInit();
			this.tableLayoutPanelStatistics.ResumeLayout(false);
			this.tableLayoutPanelStatistics.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpFolderBrowser;
		private System.Windows.Forms.Label labelFolderPath;
		private System.Windows.Forms.TextBox txtFolderPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Panel panelFolderStatistics;
		private System.Windows.Forms.SplitContainer splitContainerFolderStats;
		private System.Windows.Forms.TreeView treeViewFolderExplorer;
		private System.Windows.Forms.GroupBox groupBoxFolderStatistics;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStatistics;
		private System.Windows.Forms.Label labelFolderName;
		private System.Windows.Forms.Label labelTotalSize;
		private System.Windows.Forms.Label labelSelectedFolderName;
		private System.Windows.Forms.Label labelSelectedFolderSize;
		private System.Windows.Forms.Label labelSubdirectories;
		private System.Windows.Forms.Label labelSelectedFolderSubDirectories;
		private System.Windows.Forms.Label labelFileDetails;
		private System.Windows.Forms.Label labelSelectedFolderLastModifiedDate;
		private System.Windows.Forms.Label labelSelectedFolderLastAccessedDate;
		private System.Windows.Forms.Label labelAccessedDate;
		private System.Windows.Forms.Label labelCreationDate;
		private System.Windows.Forms.Label labelSelectedFolderCreationDate;
		private System.Windows.Forms.Label labelModifiedDate;
		private System.Windows.Forms.DataGridView dataGridViewFileDetails;
		private System.Windows.Forms.Label labelNumberOfFiles;
		private System.Windows.Forms.Label labelSelectedFolderNumberFiles;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
	}
}

