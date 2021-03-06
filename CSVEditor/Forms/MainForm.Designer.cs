﻿using System.Drawing;

partial class MainForm
{
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
			System.Windows.Forms.MenuStrip menuStrip;
			this.m_FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_OpenFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_SaveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_GotoEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_SearchEditStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_UndoEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_RedoEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.m_CutEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_CopyEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_PasteEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_DebugToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_MergeLocalizationToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_VerifierToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_CSVFileAssociationToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_LayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_SaveLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ApplyLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ManagerLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ApplyVerifierLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_SplitContainer = new System.Windows.Forms.SplitContainer();
			this.m_CellEditPanel = new System.Windows.Forms.Panel();
			this.m_CellEditTextBox = new System.Windows.Forms.TextBox();
			this.m_CellEditTipPanel = new System.Windows.Forms.Panel();
			this.m_CellEditTipLabel = new System.Windows.Forms.Label();
			this.m_OpenCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.m_SaveCSVFileDialog = new System.Windows.Forms.SaveFileDialog();
			menuStrip = new System.Windows.Forms.MenuStrip();
			menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_SplitContainer)).BeginInit();
			this.m_SplitContainer.Panel2.SuspendLayout();
			this.m_SplitContainer.SuspendLayout();
			this.m_CellEditPanel.SuspendLayout();
			this.m_CellEditTipPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_FileToolStripMenuItem,
            this.m_EditToolStripMenuItem,
            this.m_ToolsToolStripMenuItem,
            this.m_LayoutToolStripMenuItem});
			menuStrip.Location = new System.Drawing.Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
			menuStrip.Size = new System.Drawing.Size(1588, 46);
			menuStrip.TabIndex = 1;
			menuStrip.Text = "MenuStrip";
			// 
			// m_FileToolStripMenuItem
			// 
			this.m_FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_OpenFIleToolStripMenuItem,
            this.toolStripSeparator1,
            this.m_SaveFileToolStripMenuItem,
            this.m_SaveToFileToolStripMenuItem});
			this.m_FileToolStripMenuItem.Name = "m_FileToolStripMenuItem";
			this.m_FileToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
			this.m_FileToolStripMenuItem.Text = "文件";
			this.m_FileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.OnTopToolStripMenuItem_DropDownClosed);
			this.m_FileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnTopToolStripMenuItem_DropDownOpening);
			// 
			// m_OpenFIleToolStripMenuItem
			// 
			this.m_OpenFIleToolStripMenuItem.Name = "m_OpenFIleToolStripMenuItem";
			this.m_OpenFIleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.m_OpenFIleToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
			this.m_OpenFIleToolStripMenuItem.Text = "打开";
			this.m_OpenFIleToolStripMenuItem.Click += new System.EventHandler(this.OnOpenFileToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
			// 
			// m_SaveFileToolStripMenuItem
			// 
			this.m_SaveFileToolStripMenuItem.Name = "m_SaveFileToolStripMenuItem";
			this.m_SaveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.m_SaveFileToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
			this.m_SaveFileToolStripMenuItem.Text = "保存";
			this.m_SaveFileToolStripMenuItem.Click += new System.EventHandler(this.OnSaveFileToolStripMenuItem_Click);
			// 
			// m_SaveToFileToolStripMenuItem
			// 
			this.m_SaveToFileToolStripMenuItem.Name = "m_SaveToFileToolStripMenuItem";
			this.m_SaveToFileToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
			this.m_SaveToFileToolStripMenuItem.Text = "保存为";
			this.m_SaveToFileToolStripMenuItem.Click += new System.EventHandler(this.OnSaveFileToolStripMenuItem_Click);
			// 
			// m_EditToolStripMenuItem
			// 
			this.m_EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_GotoEditToolStripMenuItem,
            this.m_SearchEditStripMenuItem,
            this.toolStripSeparator2,
            this.m_UndoEditToolStripMenuItem,
            this.m_RedoEditToolStripMenuItem,
            this.toolStripSeparator4,
            this.m_CutEditToolStripMenuItem,
            this.m_CopyEditToolStripMenuItem,
            this.m_PasteEditToolStripMenuItem});
			this.m_EditToolStripMenuItem.Name = "m_EditToolStripMenuItem";
			this.m_EditToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
			this.m_EditToolStripMenuItem.Text = "编辑";
			this.m_EditToolStripMenuItem.DropDownClosed += new System.EventHandler(this.OnTopToolStripMenuItem_DropDownClosed);
			this.m_EditToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnTopToolStripMenuItem_DropDownOpening);
			// 
			// m_GotoEditToolStripMenuItem
			// 
			this.m_GotoEditToolStripMenuItem.Name = "m_GotoEditToolStripMenuItem";
			this.m_GotoEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.m_GotoEditToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
			this.m_GotoEditToolStripMenuItem.Text = "转到";
			this.m_GotoEditToolStripMenuItem.Click += new System.EventHandler(this.OnGotoEditToolStripMenuItem_Click);
			// 
			// m_SearchEditStripMenuItem
			// 
			this.m_SearchEditStripMenuItem.Name = "m_SearchEditStripMenuItem";
			this.m_SearchEditStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.m_SearchEditStripMenuItem.Size = new System.Drawing.Size(317, 38);
			this.m_SearchEditStripMenuItem.Text = "查找和替换";
			this.m_SearchEditStripMenuItem.Click += new System.EventHandler(this.OnSearchEditStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(314, 6);
			// 
			// m_UndoEditToolStripMenuItem
			// 
			this.m_UndoEditToolStripMenuItem.Name = "m_UndoEditToolStripMenuItem";
			this.m_UndoEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.m_UndoEditToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
			this.m_UndoEditToolStripMenuItem.Text = "撤销";
			this.m_UndoEditToolStripMenuItem.Click += new System.EventHandler(this.OnEditToolStripMenuItem_Click);
			// 
			// m_RedoEditToolStripMenuItem
			// 
			this.m_RedoEditToolStripMenuItem.Name = "m_RedoEditToolStripMenuItem";
			this.m_RedoEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.m_RedoEditToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
			this.m_RedoEditToolStripMenuItem.Text = "重做";
			this.m_RedoEditToolStripMenuItem.Click += new System.EventHandler(this.OnEditToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(314, 6);
			// 
			// m_CutEditToolStripMenuItem
			// 
			this.m_CutEditToolStripMenuItem.Name = "m_CutEditToolStripMenuItem";
			this.m_CutEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.m_CutEditToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
			this.m_CutEditToolStripMenuItem.Text = "剪切";
			this.m_CutEditToolStripMenuItem.Visible = false;
			this.m_CutEditToolStripMenuItem.Click += new System.EventHandler(this.OnEditToolStripMenuItem_Click);
			// 
			// m_CopyEditToolStripMenuItem
			// 
			this.m_CopyEditToolStripMenuItem.Name = "m_CopyEditToolStripMenuItem";
			this.m_CopyEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.m_CopyEditToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
			this.m_CopyEditToolStripMenuItem.Text = "复制";
			this.m_CopyEditToolStripMenuItem.Click += new System.EventHandler(this.OnEditToolStripMenuItem_Click);
			// 
			// m_PasteEditToolStripMenuItem
			// 
			this.m_PasteEditToolStripMenuItem.Name = "m_PasteEditToolStripMenuItem";
			this.m_PasteEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.m_PasteEditToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
			this.m_PasteEditToolStripMenuItem.Text = "粘贴";
			this.m_PasteEditToolStripMenuItem.Click += new System.EventHandler(this.OnEditToolStripMenuItem_Click);
			// 
			// m_ToolsToolStripMenuItem
			// 
			this.m_ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_DebugToolsToolStripMenuItem,
            this.m_MergeLocalizationToolsToolStripMenuItem,
            this.m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem,
            this.m_VerifierToolsToolStripMenuItem,
            this.m_CSVFileAssociationToolsToolStripMenuItem});
			this.m_ToolsToolStripMenuItem.Name = "m_ToolsToolStripMenuItem";
			this.m_ToolsToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
			this.m_ToolsToolStripMenuItem.Text = "工具";
			this.m_ToolsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnTopToolStripMenuItem_DropDownOpening);
			// 
			// m_DebugToolsToolStripMenuItem
			// 
			this.m_DebugToolsToolStripMenuItem.Name = "m_DebugToolsToolStripMenuItem";
			this.m_DebugToolsToolStripMenuItem.Size = new System.Drawing.Size(500, 38);
			this.m_DebugToolsToolStripMenuItem.Text = "测试(仅DEBUG可见)";
			this.m_DebugToolsToolStripMenuItem.Click += new System.EventHandler(this.OnDebugToolsToolStripMenuItem_Click);
			// 
			// m_MergeLocalizationToolsToolStripMenuItem
			// 
			this.m_MergeLocalizationToolsToolStripMenuItem.Name = "m_MergeLocalizationToolsToolStripMenuItem";
			this.m_MergeLocalizationToolsToolStripMenuItem.Size = new System.Drawing.Size(500, 38);
			this.m_MergeLocalizationToolsToolStripMenuItem.Text = "本地化合并(?)";
			this.m_MergeLocalizationToolsToolStripMenuItem.Click += new System.EventHandler(this.OnMergeLocalizationToolsToolStripMenuItem_Click);
			// 
			// m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem
			// 
			this.m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem.Name = "m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem";
			this.m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem.Size = new System.Drawing.Size(500, 38);
			this.m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem.Text = "移除所有制表符并转换所有换行符(?)";
			this.m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem.Click += new System.EventHandler(this.OnRemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem_Click);
			// 
			// m_VerifierToolsToolStripMenuItem
			// 
			this.m_VerifierToolsToolStripMenuItem.Name = "m_VerifierToolsToolStripMenuItem";
			this.m_VerifierToolsToolStripMenuItem.Size = new System.Drawing.Size(500, 38);
			this.m_VerifierToolsToolStripMenuItem.Text = "校验当前打开的表";
			this.m_VerifierToolsToolStripMenuItem.Click += new System.EventHandler(this.OnVerifierToolsToolStripMenuItem_Click);
			// 
			// m_CSVFileAssociationToolsToolStripMenuItem
			// 
			this.m_CSVFileAssociationToolsToolStripMenuItem.Name = "m_CSVFileAssociationToolsToolStripMenuItem";
			this.m_CSVFileAssociationToolsToolStripMenuItem.Size = new System.Drawing.Size(500, 38);
			this.m_CSVFileAssociationToolsToolStripMenuItem.Text = "关联csv文件(?)";
			this.m_CSVFileAssociationToolsToolStripMenuItem.Click += new System.EventHandler(this.OnCSVFileAssociationToolsToolStripMenuItem_Click);
			// 
			// m_LayoutToolStripMenuItem
			// 
			this.m_LayoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_SaveLayoutToolStripMenuItem,
            this.m_ApplyLayoutToolStripMenuItem,
            this.m_ManagerLayoutToolStripMenuItem,
            this.toolStripSeparator3,
            this.m_ApplyVerifierLayoutToolStripMenuItem});
			this.m_LayoutToolStripMenuItem.Name = "m_LayoutToolStripMenuItem";
			this.m_LayoutToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
			this.m_LayoutToolStripMenuItem.Text = "布局";
			this.m_LayoutToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnTopToolStripMenuItem_DropDownOpening);
			// 
			// m_SaveLayoutToolStripMenuItem
			// 
			this.m_SaveLayoutToolStripMenuItem.Name = "m_SaveLayoutToolStripMenuItem";
			this.m_SaveLayoutToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
			this.m_SaveLayoutToolStripMenuItem.Text = "保存布局";
			this.m_SaveLayoutToolStripMenuItem.Click += new System.EventHandler(this.OnLayoutToolStripMenuItem_Click);
			// 
			// m_ApplyLayoutToolStripMenuItem
			// 
			this.m_ApplyLayoutToolStripMenuItem.Name = "m_ApplyLayoutToolStripMenuItem";
			this.m_ApplyLayoutToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
			this.m_ApplyLayoutToolStripMenuItem.Text = "应用布局";
			// 
			// m_ManagerLayoutToolStripMenuItem
			// 
			this.m_ManagerLayoutToolStripMenuItem.Name = "m_ManagerLayoutToolStripMenuItem";
			this.m_ManagerLayoutToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
			this.m_ManagerLayoutToolStripMenuItem.Text = "管理布局";
			this.m_ManagerLayoutToolStripMenuItem.Click += new System.EventHandler(this.OnLayoutToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(253, 6);
			// 
			// m_ApplyVerifierLayoutToolStripMenuItem
			// 
			this.m_ApplyVerifierLayoutToolStripMenuItem.Name = "m_ApplyVerifierLayoutToolStripMenuItem";
			this.m_ApplyVerifierLayoutToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
			this.m_ApplyVerifierLayoutToolStripMenuItem.Text = "应用校验规则";
			// 
			// m_SplitContainer
			// 
			this.m_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.m_SplitContainer.Location = new System.Drawing.Point(0, 46);
			this.m_SplitContainer.Margin = new System.Windows.Forms.Padding(6);
			this.m_SplitContainer.Name = "m_SplitContainer";
			this.m_SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// m_SplitContainer.Panel2
			// 
			this.m_SplitContainer.Panel2.Controls.Add(this.m_CellEditPanel);
			this.m_SplitContainer.Panel2.Controls.Add(this.m_CellEditTipPanel);
			this.m_SplitContainer.Size = new System.Drawing.Size(1588, 912);
			this.m_SplitContainer.SplitterDistance = 809;
			this.m_SplitContainer.SplitterWidth = 8;
			this.m_SplitContainer.TabIndex = 2;
			// 
			// m_CellEditPanel
			// 
			this.m_CellEditPanel.Controls.Add(this.m_CellEditTextBox);
			this.m_CellEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_CellEditPanel.Location = new System.Drawing.Point(0, 0);
			this.m_CellEditPanel.Margin = new System.Windows.Forms.Padding(6);
			this.m_CellEditPanel.Name = "m_CellEditPanel";
			this.m_CellEditPanel.Size = new System.Drawing.Size(1588, 95);
			this.m_CellEditPanel.TabIndex = 1;
			// 
			// m_CellEditTextBox
			// 
			this.m_CellEditTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_CellEditTextBox.Location = new System.Drawing.Point(0, 0);
			this.m_CellEditTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.m_CellEditTextBox.Multiline = true;
			this.m_CellEditTextBox.Name = "m_CellEditTextBox";
			this.m_CellEditTextBox.Size = new System.Drawing.Size(1588, 95);
			this.m_CellEditTextBox.TabIndex = 0;
			// 
			// m_CellEditTipPanel
			// 
			this.m_CellEditTipPanel.Controls.Add(this.m_CellEditTipLabel);
			this.m_CellEditTipPanel.Location = new System.Drawing.Point(1522, 116);
			this.m_CellEditTipPanel.Margin = new System.Windows.Forms.Padding(6);
			this.m_CellEditTipPanel.Name = "m_CellEditTipPanel";
			this.m_CellEditTipPanel.Size = new System.Drawing.Size(200, 200);
			this.m_CellEditTipPanel.TabIndex = 0;
			// 
			// m_CellEditTipLabel
			// 
			this.m_CellEditTipLabel.AutoSize = true;
			this.m_CellEditTipLabel.Location = new System.Drawing.Point(24, 28);
			this.m_CellEditTipLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.m_CellEditTipLabel.Name = "m_CellEditTipLabel";
			this.m_CellEditTipLabel.Size = new System.Drawing.Size(46, 24);
			this.m_CellEditTipLabel.TabIndex = 0;
			this.m_CellEditTipLabel.Text = "Tip";
			// 
			// m_OpenCSVFileDialog
			// 
			this.m_OpenCSVFileDialog.FileName = "OpenCSVFileDialog";
			this.m_OpenCSVFileDialog.Filter = "*.csv|*.csv";
			this.m_OpenCSVFileDialog.FilterIndex = 0;
			this.m_OpenCSVFileDialog.Multiselect = true;
			this.m_OpenCSVFileDialog.Title = "打开文件";
			// 
			// m_SaveCSVFileDialog
			// 
			this.m_SaveCSVFileDialog.DefaultExt = "csv";
			this.m_SaveCSVFileDialog.FileName = "NewCSVFile";
			this.m_SaveCSVFileDialog.Filter = "*.csv|*.csv";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1588, 958);
			this.Controls.Add(this.m_SplitContainer);
			this.Controls.Add(menuStrip);
			this.MainMenuStrip = menuStrip;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.Text = "CSV编辑器";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnForm_FormClosing);
			this.Load += new System.EventHandler(this.OnMainForm_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnMainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnMainForm_DragEnter);
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			this.m_SplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_SplitContainer)).EndInit();
			this.m_SplitContainer.ResumeLayout(false);
			this.m_CellEditPanel.ResumeLayout(false);
			this.m_CellEditPanel.PerformLayout();
			this.m_CellEditTipPanel.ResumeLayout(false);
			this.m_CellEditTipPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.OpenFileDialog m_OpenCSVFileDialog;
    private System.Windows.Forms.SaveFileDialog m_SaveCSVFileDialog;
	private System.Windows.Forms.SplitContainer m_SplitContainer;
	private System.Windows.Forms.Panel m_CellEditTipPanel;
	private System.Windows.Forms.Label m_CellEditTipLabel;
	private System.Windows.Forms.Panel m_CellEditPanel;
	private System.Windows.Forms.TextBox m_CellEditTextBox;
	private System.Windows.Forms.ToolStripMenuItem m_FileToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_OpenFIleToolStripMenuItem;
	private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	private System.Windows.Forms.ToolStripMenuItem m_SaveFileToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_SaveToFileToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_EditToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_GotoEditToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_SearchEditStripMenuItem;
	private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	private System.Windows.Forms.ToolStripMenuItem m_UndoEditToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_RedoEditToolStripMenuItem;
	private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	private System.Windows.Forms.ToolStripMenuItem m_CutEditToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_CopyEditToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_PasteEditToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_ToolsToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_DebugToolsToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_MergeLocalizationToolsToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_RemoveAllTabAndConvertAllCRLFToLFToolsToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_VerifierToolsToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_CSVFileAssociationToolsToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_LayoutToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_SaveLayoutToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_ApplyLayoutToolStripMenuItem;
	private System.Windows.Forms.ToolStripMenuItem m_ManagerLayoutToolStripMenuItem;
	private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	private System.Windows.Forms.ToolStripMenuItem m_ApplyVerifierLayoutToolStripMenuItem;
}