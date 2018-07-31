﻿namespace CoreAPIDemo
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.sampleTree = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.runSample = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.prevPage = new System.Windows.Forms.ToolStripButton();
			this.currentPage = new System.Windows.Forms.ToolStripTextBox();
			this.pagesCount = new System.Windows.Forms.ToolStripLabel();
			this.nextPage = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnOpen = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.previewImage = new System.Windows.Forms.PictureBox();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.codeSource = new FastColoredTextBoxNS.FastColoredTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.toolStrip3 = new System.Windows.Forms.ToolStrip();
			this.filterEdit = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.expandAll = new System.Windows.Forms.ToolStripButton();
			this.collapseAll = new System.Windows.Forms.ToolStripButton();
			this.viewControl = new System.Windows.Forms.TabControl();
			this.bookmarksTab = new System.Windows.Forms.TabPage();
			this.bookmarkProgress = new System.Windows.Forms.ProgressBar();
			this.bookmarksTree = new System.Windows.Forms.TreeView();
			this.toolStrip4 = new System.Windows.Forms.ToolStrip();
			this.addBookmark = new System.Windows.Forms.ToolStripButton();
			this.removeBookmark = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.moveBookmarkUp = new System.Windows.Forms.ToolStripButton();
			this.moveBookmarkDown = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.expandBookmarks = new System.Windows.Forms.ToolStripButton();
			this.collapseBookmarks = new System.Windows.Forms.ToolStripButton();
			this.namedDests = new System.Windows.Forms.TabPage();
			this.namedDestsList = new System.Windows.Forms.ListView();
			this.destName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.destPage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.namedDestsProgress = new System.Windows.Forms.ProgressBar();
			this.toolStrip5 = new System.Windows.Forms.ToolStrip();
			this.addDest = new System.Windows.Forms.ToolStripButton();
			this.removeDest = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.toolStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.previewImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.codeSource)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.toolStrip3.SuspendLayout();
			this.viewControl.SuspendLayout();
			this.bookmarksTab.SuspendLayout();
			this.toolStrip4.SuspendLayout();
			this.namedDests.SuspendLayout();
			this.toolStrip5.SuspendLayout();
			this.SuspendLayout();
			// 
			// sampleTree
			// 
			this.sampleTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sampleTree.FullRowSelect = true;
			this.sampleTree.HideSelection = false;
			this.sampleTree.HotTracking = true;
			this.sampleTree.ItemHeight = 26;
			this.sampleTree.Location = new System.Drawing.Point(0, 31);
			this.sampleTree.Margin = new System.Windows.Forms.Padding(2);
			this.sampleTree.Name = "sampleTree";
			this.sampleTree.ShowLines = false;
			this.sampleTree.Size = new System.Drawing.Size(505, 662);
			this.sampleTree.TabIndex = 0;
			this.sampleTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.sampleTree_NodeMouseClick);
			this.sampleTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.sampleTree_NodeMouseDoubleClick);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(505, 0);
			this.splitter1.Margin = new System.Windows.Forms.Padding(2);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(7, 693);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runSample,
            this.toolStripSeparator2,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(551, 31);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// runSample
			// 
			this.runSample.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.runSample.Image = ((System.Drawing.Image)(resources.GetObject("runSample.Image")));
			this.runSample.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.runSample.Name = "runSample";
			this.runSample.Size = new System.Drawing.Size(109, 28);
			this.runSample.Text = "Run Sample";
			this.runSample.Click += new System.EventHandler(this.runSample_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(103, 28);
			this.toolStripButton2.Text = "Go to Source";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStrip2
			// 
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prevPage,
            this.currentPage,
            this.pagesCount,
            this.nextPage,
            this.toolStripSeparator3,
            this.btnOpen,
            this.btnSave,
            this.btnClose});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(551, 31);
			this.toolStrip2.TabIndex = 0;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// prevPage
			// 
			this.prevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.prevPage.Image = ((System.Drawing.Image)(resources.GetObject("prevPage.Image")));
			this.prevPage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.prevPage.Name = "prevPage";
			this.prevPage.Size = new System.Drawing.Size(28, 28);
			this.prevPage.Text = "Previuos Page";
			this.prevPage.Click += new System.EventHandler(this.prevPage_Click);
			// 
			// currentPage
			// 
			this.currentPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.currentPage.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.currentPage.Name = "currentPage";
			this.currentPage.Size = new System.Drawing.Size(34, 27);
			this.currentPage.Text = "1";
			this.currentPage.TextChanged += new System.EventHandler(this.currentPage_TextChanged);
			// 
			// pagesCount
			// 
			this.pagesCount.Name = "pagesCount";
			this.pagesCount.Size = new System.Drawing.Size(18, 28);
			this.pagesCount.Text = "/0";
			// 
			// nextPage
			// 
			this.nextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nextPage.Image = ((System.Drawing.Image)(resources.GetObject("nextPage.Image")));
			this.nextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nextPage.Name = "nextPage";
			this.nextPage.Size = new System.Drawing.Size(28, 28);
			this.nextPage.Text = "Next Page";
			this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
			// 
			// btnOpen
			// 
			this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
			this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(169, 28);
			this.btnOpen.Text = "Open with Default Viewer";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(59, 28);
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(64, 28);
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// previewImage
			// 
			this.previewImage.BackColor = System.Drawing.SystemColors.Control;
			this.previewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewImage.Location = new System.Drawing.Point(0, 31);
			this.previewImage.Margin = new System.Windows.Forms.Padding(2);
			this.previewImage.Name = "previewImage";
			this.previewImage.Size = new System.Drawing.Size(551, 415);
			this.previewImage.TabIndex = 0;
			this.previewImage.TabStop = false;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter2.Location = new System.Drawing.Point(512, 446);
			this.splitter2.Margin = new System.Windows.Forms.Padding(2);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(551, 6);
			this.splitter2.TabIndex = 0;
			this.splitter2.TabStop = false;
			this.splitter2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter2_SplitterMoved);
			// 
			// codeSource
			// 
			this.codeSource.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.codeSource.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
			this.codeSource.AutoScrollMinSize = new System.Drawing.Size(27, 14);
			this.codeSource.BackBrush = null;
			this.codeSource.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.codeSource.CharHeight = 14;
			this.codeSource.CharWidth = 8;
			this.codeSource.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.codeSource.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.codeSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codeSource.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.codeSource.IsReplaceMode = false;
			this.codeSource.Language = FastColoredTextBoxNS.Language.CSharp;
			this.codeSource.LeftBracket = '(';
			this.codeSource.LeftBracket2 = '{';
			this.codeSource.Location = new System.Drawing.Point(0, 31);
			this.codeSource.Margin = new System.Windows.Forms.Padding(2);
			this.codeSource.Name = "codeSource";
			this.codeSource.Paddings = new System.Windows.Forms.Padding(0);
			this.codeSource.ReadOnly = true;
			this.codeSource.RightBracket = ')';
			this.codeSource.RightBracket2 = '}';
			this.codeSource.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.codeSource.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeSource.ServiceColors")));
			this.codeSource.Size = new System.Drawing.Size(551, 210);
			this.codeSource.TabIndex = 2;
			this.codeSource.Zoom = 100;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.codeSource);
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(512, 452);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(551, 241);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.previewImage);
			this.panel2.Controls.Add(this.toolStrip2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(512, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(551, 446);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.sampleTree);
			this.panel3.Controls.Add(this.toolStrip3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(505, 693);
			this.panel3.TabIndex = 5;
			// 
			// toolStrip3
			// 
			this.toolStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterEdit,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.expandAll,
            this.collapseAll});
			this.toolStrip3.Location = new System.Drawing.Point(0, 0);
			this.toolStrip3.Name = "toolStrip3";
			this.toolStrip3.Size = new System.Drawing.Size(505, 31);
			this.toolStrip3.TabIndex = 1;
			this.toolStrip3.Text = "toolStrip3";
			// 
			// filterEdit
			// 
			this.filterEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.filterEdit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.filterEdit.Name = "filterEdit";
			this.filterEdit.Size = new System.Drawing.Size(334, 27);
			this.filterEdit.TextChanged += new System.EventHandler(this.filterEdit_TextChanged);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton1.Text = "Clear Filter";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// expandAll
			// 
			this.expandAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.expandAll.Image = ((System.Drawing.Image)(resources.GetObject("expandAll.Image")));
			this.expandAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.expandAll.Name = "expandAll";
			this.expandAll.Size = new System.Drawing.Size(28, 28);
			this.expandAll.Text = "Expand All";
			this.expandAll.Click += new System.EventHandler(this.expandAll_Click);
			// 
			// collapseAll
			// 
			this.collapseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.collapseAll.Image = ((System.Drawing.Image)(resources.GetObject("collapseAll.Image")));
			this.collapseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.collapseAll.Name = "collapseAll";
			this.collapseAll.Size = new System.Drawing.Size(28, 28);
			this.collapseAll.Text = "Collapse All";
			this.collapseAll.Click += new System.EventHandler(this.collapseAll_Click);
			// 
			// viewControl
			// 
			this.viewControl.Controls.Add(this.bookmarksTab);
			this.viewControl.Controls.Add(this.namedDests);
			this.viewControl.Dock = System.Windows.Forms.DockStyle.Right;
			this.viewControl.Location = new System.Drawing.Point(1065, 0);
			this.viewControl.Margin = new System.Windows.Forms.Padding(2);
			this.viewControl.Name = "viewControl";
			this.viewControl.SelectedIndex = 0;
			this.viewControl.Size = new System.Drawing.Size(244, 693);
			this.viewControl.TabIndex = 2;
			// 
			// bookmarksTab
			// 
			this.bookmarksTab.Controls.Add(this.bookmarkProgress);
			this.bookmarksTab.Controls.Add(this.bookmarksTree);
			this.bookmarksTab.Controls.Add(this.toolStrip4);
			this.bookmarksTab.Location = new System.Drawing.Point(4, 22);
			this.bookmarksTab.Name = "bookmarksTab";
			this.bookmarksTab.Padding = new System.Windows.Forms.Padding(2);
			this.bookmarksTab.Size = new System.Drawing.Size(236, 667);
			this.bookmarksTab.TabIndex = 0;
			this.bookmarksTab.Text = "Bookmarks";
			this.bookmarksTab.UseVisualStyleBackColor = true;
			// 
			// bookmarkProgress
			// 
			this.bookmarkProgress.Dock = System.Windows.Forms.DockStyle.Top;
			this.bookmarkProgress.Location = new System.Drawing.Point(2, 33);
			this.bookmarkProgress.Name = "bookmarkProgress";
			this.bookmarkProgress.Size = new System.Drawing.Size(232, 10);
			this.bookmarkProgress.Step = 1;
			this.bookmarkProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.bookmarkProgress.TabIndex = 1;
			this.bookmarkProgress.Visible = false;
			// 
			// bookmarksTree
			// 
			this.bookmarksTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bookmarksTree.FullRowSelect = true;
			this.bookmarksTree.HideSelection = false;
			this.bookmarksTree.HotTracking = true;
			this.bookmarksTree.Location = new System.Drawing.Point(2, 33);
			this.bookmarksTree.Name = "bookmarksTree";
			this.bookmarksTree.ShowLines = false;
			this.bookmarksTree.Size = new System.Drawing.Size(232, 632);
			this.bookmarksTree.TabIndex = 0;
			this.bookmarksTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.bookmarksTree_NodeMouseClick);
			// 
			// toolStrip4
			// 
			this.toolStrip4.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookmark,
            this.removeBookmark,
            this.toolStripSeparator4,
            this.moveBookmarkUp,
            this.moveBookmarkDown,
            this.toolStripSeparator5,
            this.expandBookmarks,
            this.collapseBookmarks});
			this.toolStrip4.Location = new System.Drawing.Point(2, 2);
			this.toolStrip4.Name = "toolStrip4";
			this.toolStrip4.Size = new System.Drawing.Size(232, 31);
			this.toolStrip4.TabIndex = 2;
			this.toolStrip4.Text = "toolStrip4";
			// 
			// addBookmark
			// 
			this.addBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addBookmark.Image = ((System.Drawing.Image)(resources.GetObject("addBookmark.Image")));
			this.addBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addBookmark.Name = "addBookmark";
			this.addBookmark.Size = new System.Drawing.Size(28, 28);
			this.addBookmark.Text = "Add Bookmark";
			this.addBookmark.Click += new System.EventHandler(this.addBookmark_Click);
			// 
			// removeBookmark
			// 
			this.removeBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.removeBookmark.Image = ((System.Drawing.Image)(resources.GetObject("removeBookmark.Image")));
			this.removeBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.removeBookmark.Name = "removeBookmark";
			this.removeBookmark.Size = new System.Drawing.Size(28, 28);
			this.removeBookmark.Text = "Remove Bookmark";
			this.removeBookmark.Click += new System.EventHandler(this.removeBookmark_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
			// 
			// moveBookmarkUp
			// 
			this.moveBookmarkUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.moveBookmarkUp.Image = ((System.Drawing.Image)(resources.GetObject("moveBookmarkUp.Image")));
			this.moveBookmarkUp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.moveBookmarkUp.Name = "moveBookmarkUp";
			this.moveBookmarkUp.Size = new System.Drawing.Size(28, 28);
			this.moveBookmarkUp.Text = "Move Up";
			this.moveBookmarkUp.Click += new System.EventHandler(this.moveBookmarkUp_Click);
			// 
			// moveBookmarkDown
			// 
			this.moveBookmarkDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.moveBookmarkDown.Image = ((System.Drawing.Image)(resources.GetObject("moveBookmarkDown.Image")));
			this.moveBookmarkDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.moveBookmarkDown.Name = "moveBookmarkDown";
			this.moveBookmarkDown.Size = new System.Drawing.Size(28, 28);
			this.moveBookmarkDown.Text = "Move Down";
			this.moveBookmarkDown.Click += new System.EventHandler(this.moveBookmarkDown_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
			// 
			// expandBookmarks
			// 
			this.expandBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.expandBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("expandBookmarks.Image")));
			this.expandBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.expandBookmarks.Name = "expandBookmarks";
			this.expandBookmarks.Size = new System.Drawing.Size(28, 28);
			this.expandBookmarks.Text = "Expand All Bookmarks";
			this.expandBookmarks.Click += new System.EventHandler(this.expandBookmarks_Click);
			// 
			// collapseBookmarks
			// 
			this.collapseBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.collapseBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("collapseBookmarks.Image")));
			this.collapseBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.collapseBookmarks.Name = "collapseBookmarks";
			this.collapseBookmarks.Size = new System.Drawing.Size(28, 28);
			this.collapseBookmarks.Text = "Collapse All Bookmarks";
			this.collapseBookmarks.Click += new System.EventHandler(this.collapseBookmarks_Click);
			// 
			// namedDests
			// 
			this.namedDests.Controls.Add(this.namedDestsList);
			this.namedDests.Controls.Add(this.namedDestsProgress);
			this.namedDests.Controls.Add(this.toolStrip5);
			this.namedDests.Location = new System.Drawing.Point(4, 22);
			this.namedDests.Margin = new System.Windows.Forms.Padding(2);
			this.namedDests.Name = "namedDests";
			this.namedDests.Size = new System.Drawing.Size(236, 667);
			this.namedDests.TabIndex = 1;
			this.namedDests.Text = "Named Destinations";
			this.namedDests.UseVisualStyleBackColor = true;
			// 
			// namedDestsList
			// 
			this.namedDestsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.destName,
            this.destPage});
			this.namedDestsList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.namedDestsList.HideSelection = false;
			this.namedDestsList.Location = new System.Drawing.Point(0, 41);
			this.namedDestsList.Margin = new System.Windows.Forms.Padding(2);
			this.namedDestsList.Name = "namedDestsList";
			this.namedDestsList.Size = new System.Drawing.Size(236, 626);
			this.namedDestsList.TabIndex = 1;
			this.namedDestsList.UseCompatibleStateImageBehavior = false;
			this.namedDestsList.View = System.Windows.Forms.View.Details;
			this.namedDestsList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.namedDestsList_ColumnClick);
			this.namedDestsList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.namedDestsList_ItemSelectionChanged);
			// 
			// destName
			// 
			this.destName.Text = "Name";
			this.destName.Width = 118;
			// 
			// destPage
			// 
			this.destPage.Text = "Page";
			this.destPage.Width = 111;
			// 
			// namedDestsProgress
			// 
			this.namedDestsProgress.Dock = System.Windows.Forms.DockStyle.Top;
			this.namedDestsProgress.Location = new System.Drawing.Point(0, 31);
			this.namedDestsProgress.Margin = new System.Windows.Forms.Padding(2);
			this.namedDestsProgress.Name = "namedDestsProgress";
			this.namedDestsProgress.Size = new System.Drawing.Size(236, 10);
			this.namedDestsProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.namedDestsProgress.TabIndex = 0;
			this.namedDestsProgress.Visible = false;
			// 
			// toolStrip5
			// 
			this.toolStrip5.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDest,
            this.removeDest,
            this.toolStripSeparator6});
			this.toolStrip5.Location = new System.Drawing.Point(0, 0);
			this.toolStrip5.Name = "toolStrip5";
			this.toolStrip5.Size = new System.Drawing.Size(236, 31);
			this.toolStrip5.TabIndex = 2;
			this.toolStrip5.Text = "toolStrip5";
			// 
			// addDest
			// 
			this.addDest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addDest.Image = ((System.Drawing.Image)(resources.GetObject("addDest.Image")));
			this.addDest.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addDest.Name = "addDest";
			this.addDest.Size = new System.Drawing.Size(28, 28);
			this.addDest.Text = "Add Named Destination";
			this.addDest.Click += new System.EventHandler(this.addDest_Click);
			// 
			// removeDest
			// 
			this.removeDest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.removeDest.Image = ((System.Drawing.Image)(resources.GetObject("removeDest.Image")));
			this.removeDest.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.removeDest.Name = "removeDest";
			this.removeDest.Size = new System.Drawing.Size(28, 28);
			this.removeDest.Text = "Remove Named Destination";
			this.removeDest.Click += new System.EventHandler(this.removeDest_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
			// 
			// splitter3
			// 
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter3.Location = new System.Drawing.Point(1063, 0);
			this.splitter3.Margin = new System.Windows.Forms.Padding(2);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(2, 693);
			this.splitter3.TabIndex = 0;
			this.splitter3.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1309, 693);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.splitter2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitter3);
			this.Controls.Add(this.viewControl);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(855, 626);
			this.Name = "Form1";
			this.Text = "CoreAPIDemo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.previewImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.codeSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.toolStrip3.ResumeLayout(false);
			this.toolStrip3.PerformLayout();
			this.viewControl.ResumeLayout(false);
			this.bookmarksTab.ResumeLayout(false);
			this.bookmarksTab.PerformLayout();
			this.toolStrip4.ResumeLayout(false);
			this.toolStrip4.PerformLayout();
			this.namedDests.ResumeLayout(false);
			this.namedDests.PerformLayout();
			this.toolStrip5.ResumeLayout(false);
			this.toolStrip5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView sampleTree;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton runSample;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton prevPage;
		private System.Windows.Forms.ToolStripTextBox currentPage;
		private System.Windows.Forms.ToolStripButton nextPage;
		private System.Windows.Forms.PictureBox previewImage;
		private System.Windows.Forms.ToolStripLabel pagesCount;
		private System.Windows.Forms.Splitter splitter2;
		private FastColoredTextBoxNS.FastColoredTextBox codeSource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ToolStrip toolStrip3;
		private System.Windows.Forms.ToolStripTextBox filterEdit;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton expandAll;
		private System.Windows.Forms.ToolStripButton collapseAll;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnOpen;
		private System.Windows.Forms.TabControl viewControl;
		private System.Windows.Forms.TabPage bookmarksTab;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.TreeView bookmarksTree;
		private System.Windows.Forms.ProgressBar bookmarkProgress;
		private System.Windows.Forms.ToolStrip toolStrip4;
		private System.Windows.Forms.ToolStripButton addBookmark;
		private System.Windows.Forms.ToolStripButton removeBookmark;
		private System.Windows.Forms.ToolStripButton moveBookmarkUp;
		private System.Windows.Forms.ToolStripButton moveBookmarkDown;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton expandBookmarks;
		private System.Windows.Forms.ToolStripButton collapseBookmarks;
		private System.Windows.Forms.TabPage namedDests;
		private System.Windows.Forms.ListView namedDestsList;
		private System.Windows.Forms.ColumnHeader destName;
		private System.Windows.Forms.ColumnHeader destPage;
		private System.Windows.Forms.ProgressBar namedDestsProgress;
		private System.Windows.Forms.ToolStrip toolStrip5;
		private System.Windows.Forms.ToolStripButton addDest;
		private System.Windows.Forms.ToolStripButton removeDest;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
	}
}

