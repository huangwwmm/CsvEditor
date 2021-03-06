﻿partial class DataGridViewConsoleForm
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
			System.Windows.Forms.ColumnHeader levelHeader;
			System.Windows.Forms.ColumnHeader positionHeader;
			System.Windows.Forms.ColumnHeader captionHeader;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
			System.Windows.Forms.ColumnHeader collapseHeader;
			this.m_InfoCheckBox = new System.Windows.Forms.CheckBox();
			this.m_WarningCheckBox = new System.Windows.Forms.CheckBox();
			this.m_ErrorCheckBox = new System.Windows.Forms.CheckBox();
			this.m_CollapseCheckBox = new System.Windows.Forms.CheckBox();
			this.m_SplitContainer = new System.Windows.Forms.SplitContainer();
			this.m_MessageListView = new System.Windows.Forms.ListView();
			this.m_DetailTextBox = new System.Windows.Forms.TextBox();
			levelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			positionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			captionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			collapseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			flowLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_SplitContainer)).BeginInit();
			this.m_SplitContainer.Panel1.SuspendLayout();
			this.m_SplitContainer.Panel2.SuspendLayout();
			this.m_SplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// levelHeader
			// 
			levelHeader.Text = "等级";
			levelHeader.Width = 68;
			// 
			// positionHeader
			// 
			positionHeader.Text = "位置（行,列）";
			positionHeader.Width = 121;
			// 
			// captionHeader
			// 
			captionHeader.Text = "说明";
			captionHeader.Width = 628;
			// 
			// flowLayoutPanel
			// 
			flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			flowLayoutPanel.AutoSize = true;
			flowLayoutPanel.Controls.Add(this.m_InfoCheckBox);
			flowLayoutPanel.Controls.Add(this.m_WarningCheckBox);
			flowLayoutPanel.Controls.Add(this.m_ErrorCheckBox);
			flowLayoutPanel.Location = new System.Drawing.Point(688, 4);
			flowLayoutPanel.Name = "flowLayoutPanel";
			flowLayoutPanel.Size = new System.Drawing.Size(207, 26);
			flowLayoutPanel.TabIndex = 6;
			// 
			// m_InfoCheckBox
			// 
			this.m_InfoCheckBox.AutoSize = true;
			this.m_InfoCheckBox.Location = new System.Drawing.Point(3, 3);
			this.m_InfoCheckBox.Name = "m_InfoCheckBox";
			this.m_InfoCheckBox.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.m_InfoCheckBox.Size = new System.Drawing.Size(63, 16);
			this.m_InfoCheckBox.TabIndex = 2;
			this.m_InfoCheckBox.Text = "信息";
			this.m_InfoCheckBox.UseVisualStyleBackColor = true;
			this.m_InfoCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBox_CheckedChanged);
			// 
			// m_WarningCheckBox
			// 
			this.m_WarningCheckBox.AutoSize = true;
			this.m_WarningCheckBox.Checked = true;
			this.m_WarningCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_WarningCheckBox.Location = new System.Drawing.Point(72, 3);
			this.m_WarningCheckBox.Name = "m_WarningCheckBox";
			this.m_WarningCheckBox.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.m_WarningCheckBox.Size = new System.Drawing.Size(63, 16);
			this.m_WarningCheckBox.TabIndex = 1;
			this.m_WarningCheckBox.Text = "警告";
			this.m_WarningCheckBox.UseVisualStyleBackColor = true;
			this.m_WarningCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBox_CheckedChanged);
			// 
			// m_ErrorCheckBox
			// 
			this.m_ErrorCheckBox.AutoSize = true;
			this.m_ErrorCheckBox.Checked = true;
			this.m_ErrorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_ErrorCheckBox.Location = new System.Drawing.Point(141, 3);
			this.m_ErrorCheckBox.Name = "m_ErrorCheckBox";
			this.m_ErrorCheckBox.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.m_ErrorCheckBox.Size = new System.Drawing.Size(63, 16);
			this.m_ErrorCheckBox.TabIndex = 0;
			this.m_ErrorCheckBox.Text = "错误";
			this.m_ErrorCheckBox.UseVisualStyleBackColor = true;
			this.m_ErrorCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBox_CheckedChanged);
			// 
			// collapseHeader
			// 
			collapseHeader.Text = "折叠";
			// 
			// m_CollapseCheckBox
			// 
			this.m_CollapseCheckBox.AutoSize = true;
			this.m_CollapseCheckBox.Location = new System.Drawing.Point(12, 8);
			this.m_CollapseCheckBox.Name = "m_CollapseCheckBox";
			this.m_CollapseCheckBox.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.m_CollapseCheckBox.Size = new System.Drawing.Size(81, 16);
			this.m_CollapseCheckBox.TabIndex = 4;
			this.m_CollapseCheckBox.Text = "折叠(?)";
			this.m_CollapseCheckBox.UseVisualStyleBackColor = true;
			this.m_CollapseCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBox_CheckedChanged);
			// 
			// m_SplitContainer
			// 
			this.m_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_SplitContainer.Location = new System.Drawing.Point(0, 0);
			this.m_SplitContainer.Name = "m_SplitContainer";
			this.m_SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// m_SplitContainer.Panel1
			// 
			this.m_SplitContainer.Panel1.Controls.Add(this.m_CollapseCheckBox);
			this.m_SplitContainer.Panel1.Controls.Add(flowLayoutPanel);
			this.m_SplitContainer.Panel1.Controls.Add(this.m_MessageListView);
			// 
			// m_SplitContainer.Panel2
			// 
			this.m_SplitContainer.Panel2.Controls.Add(this.m_DetailTextBox);
			this.m_SplitContainer.Size = new System.Drawing.Size(898, 469);
			this.m_SplitContainer.SplitterDistance = 310;
			this.m_SplitContainer.TabIndex = 0;
			// 
			// m_MessageListView
			// 
			this.m_MessageListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.m_MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            levelHeader,
            positionHeader,
            captionHeader,
            collapseHeader});
			this.m_MessageListView.FullRowSelect = true;
			this.m_MessageListView.GridLines = true;
			this.m_MessageListView.Location = new System.Drawing.Point(0, 34);
			this.m_MessageListView.MultiSelect = false;
			this.m_MessageListView.Name = "m_MessageListView";
			this.m_MessageListView.Size = new System.Drawing.Size(898, 276);
			this.m_MessageListView.TabIndex = 5;
			this.m_MessageListView.UseCompatibleStateImageBehavior = false;
			this.m_MessageListView.View = System.Windows.Forms.View.Details;
			this.m_MessageListView.SelectedIndexChanged += new System.EventHandler(this.OnMessageListView_SelectedIndexChanged);
			this.m_MessageListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMessageListView_MouseDoubleClick);
			// 
			// m_DetailTextBox
			// 
			this.m_DetailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_DetailTextBox.Location = new System.Drawing.Point(0, 0);
			this.m_DetailTextBox.Multiline = true;
			this.m_DetailTextBox.Name = "m_DetailTextBox";
			this.m_DetailTextBox.ReadOnly = true;
			this.m_DetailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.m_DetailTextBox.Size = new System.Drawing.Size(898, 155);
			this.m_DetailTextBox.TabIndex = 0;
			// 
			// DataGridViewConsoleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 469);
			this.Controls.Add(this.m_SplitContainer);
			this.Name = "DataGridViewConsoleForm";
			this.Text = "控制台";
			this.Load += new System.EventHandler(this.OnDataGridViewConsoleForm_Load);
			flowLayoutPanel.ResumeLayout(false);
			flowLayoutPanel.PerformLayout();
			this.m_SplitContainer.Panel1.ResumeLayout(false);
			this.m_SplitContainer.Panel1.PerformLayout();
			this.m_SplitContainer.Panel2.ResumeLayout(false);
			this.m_SplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_SplitContainer)).EndInit();
			this.m_SplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.TextBox m_DetailTextBox;
	private System.Windows.Forms.CheckBox m_InfoCheckBox;
	private System.Windows.Forms.CheckBox m_WarningCheckBox;
	private System.Windows.Forms.CheckBox m_ErrorCheckBox;
	private System.Windows.Forms.SplitContainer m_SplitContainer;
	private System.Windows.Forms.CheckBox m_CollapseCheckBox;
	private System.Windows.Forms.ListView m_MessageListView;
}