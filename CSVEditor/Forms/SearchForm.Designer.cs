﻿partial class SearchForm
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
			System.Windows.Forms.Label searchLabel;
			System.Windows.Forms.Label replaceLabel;
			this.m_SearchTextBox = new System.Windows.Forms.TextBox();
			this.m_ReplaceTextBox = new System.Windows.Forms.TextBox();
			this.m_SearchNextButton = new System.Windows.Forms.Button();
			this.m_ReplaceButton = new System.Windows.Forms.Button();
			this.m_ReplaceAllButton = new System.Windows.Forms.Button();
			this.m_WildcardCheckBox = new System.Windows.Forms.CheckBox();
			this.m_CaseCheckBox = new System.Windows.Forms.CheckBox();
			this.m_HintRichTextBox = new System.Windows.Forms.RichTextBox();
			searchLabel = new System.Windows.Forms.Label();
			replaceLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// searchLabel
			// 
			searchLabel.AutoSize = true;
			searchLabel.Location = new System.Drawing.Point(9, 18);
			searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			searchLabel.Name = "searchLabel";
			searchLabel.Size = new System.Drawing.Size(65, 12);
			searchLabel.TabIndex = 1;
			searchLabel.Text = "查找内容：";
			// 
			// replaceLabel
			// 
			replaceLabel.AutoSize = true;
			replaceLabel.Location = new System.Drawing.Point(20, 94);
			replaceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			replaceLabel.Name = "replaceLabel";
			replaceLabel.Size = new System.Drawing.Size(53, 12);
			replaceLabel.TabIndex = 2;
			replaceLabel.Text = "替换为：";
			// 
			// m_SearchTextBox
			// 
			this.m_SearchTextBox.Location = new System.Drawing.Point(75, 18);
			this.m_SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.m_SearchTextBox.Multiline = true;
			this.m_SearchTextBox.Name = "m_SearchTextBox";
			this.m_SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.m_SearchTextBox.Size = new System.Drawing.Size(188, 61);
			this.m_SearchTextBox.TabIndex = 0;
			this.m_SearchTextBox.TextChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// m_ReplaceTextBox
			// 
			this.m_ReplaceTextBox.Location = new System.Drawing.Point(75, 94);
			this.m_ReplaceTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.m_ReplaceTextBox.Multiline = true;
			this.m_ReplaceTextBox.Name = "m_ReplaceTextBox";
			this.m_ReplaceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.m_ReplaceTextBox.Size = new System.Drawing.Size(188, 61);
			this.m_ReplaceTextBox.TabIndex = 3;
			this.m_ReplaceTextBox.TextChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// m_SearchNextButton
			// 
			this.m_SearchNextButton.Location = new System.Drawing.Point(282, 18);
			this.m_SearchNextButton.Margin = new System.Windows.Forms.Padding(2);
			this.m_SearchNextButton.Name = "m_SearchNextButton";
			this.m_SearchNextButton.Size = new System.Drawing.Size(83, 25);
			this.m_SearchNextButton.TabIndex = 4;
			this.m_SearchNextButton.TabStop = false;
			this.m_SearchNextButton.Text = "查找下一个";
			this.m_SearchNextButton.UseVisualStyleBackColor = true;
			this.m_SearchNextButton.Click += new System.EventHandler(this.OnSearchNextButton_Click);
			// 
			// m_ReplaceButton
			// 
			this.m_ReplaceButton.Location = new System.Drawing.Point(282, 94);
			this.m_ReplaceButton.Margin = new System.Windows.Forms.Padding(2);
			this.m_ReplaceButton.Name = "m_ReplaceButton";
			this.m_ReplaceButton.Size = new System.Drawing.Size(83, 25);
			this.m_ReplaceButton.TabIndex = 5;
			this.m_ReplaceButton.TabStop = false;
			this.m_ReplaceButton.Text = "替换";
			this.m_ReplaceButton.UseVisualStyleBackColor = true;
			this.m_ReplaceButton.Click += new System.EventHandler(this.OnReplaceButton_Click);
			// 
			// m_ReplaceAllButton
			// 
			this.m_ReplaceAllButton.Location = new System.Drawing.Point(282, 129);
			this.m_ReplaceAllButton.Margin = new System.Windows.Forms.Padding(2);
			this.m_ReplaceAllButton.Name = "m_ReplaceAllButton";
			this.m_ReplaceAllButton.Size = new System.Drawing.Size(83, 25);
			this.m_ReplaceAllButton.TabIndex = 6;
			this.m_ReplaceAllButton.TabStop = false;
			this.m_ReplaceAllButton.Text = "全部替换";
			this.m_ReplaceAllButton.UseVisualStyleBackColor = true;
			this.m_ReplaceAllButton.Click += new System.EventHandler(this.OnReplaceAllButton_Click);
			// 
			// m_WildcardCheckBox
			// 
			this.m_WildcardCheckBox.AutoSize = true;
			this.m_WildcardCheckBox.Location = new System.Drawing.Point(11, 171);
			this.m_WildcardCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.m_WildcardCheckBox.Name = "m_WildcardCheckBox";
			this.m_WildcardCheckBox.Size = new System.Drawing.Size(84, 16);
			this.m_WildcardCheckBox.TabIndex = 7;
			this.m_WildcardCheckBox.TabStop = false;
			this.m_WildcardCheckBox.Text = "使用通配符";
			this.m_WildcardCheckBox.UseVisualStyleBackColor = true;
			this.m_WildcardCheckBox.CheckedChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// m_CaseCheckBox
			// 
			this.m_CaseCheckBox.AutoSize = true;
			this.m_CaseCheckBox.Location = new System.Drawing.Point(121, 171);
			this.m_CaseCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.m_CaseCheckBox.Name = "m_CaseCheckBox";
			this.m_CaseCheckBox.Size = new System.Drawing.Size(84, 16);
			this.m_CaseCheckBox.TabIndex = 8;
			this.m_CaseCheckBox.TabStop = false;
			this.m_CaseCheckBox.Text = "区分大小写";
			this.m_CaseCheckBox.UseVisualStyleBackColor = true;
			this.m_CaseCheckBox.CheckedChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// m_HintRichTextBox
			// 
			this.m_HintRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.m_HintRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_HintRichTextBox.Location = new System.Drawing.Point(0, 192);
			this.m_HintRichTextBox.Multiline = false;
			this.m_HintRichTextBox.Name = "m_HintRichTextBox";
			this.m_HintRichTextBox.ReadOnly = true;
			this.m_HintRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.m_HintRichTextBox.Size = new System.Drawing.Size(380, 20);
			this.m_HintRichTextBox.TabIndex = 10;
			this.m_HintRichTextBox.Text = "test";
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 212);
			this.Controls.Add(this.m_HintRichTextBox);
			this.Controls.Add(this.m_CaseCheckBox);
			this.Controls.Add(this.m_WildcardCheckBox);
			this.Controls.Add(this.m_ReplaceAllButton);
			this.Controls.Add(this.m_ReplaceButton);
			this.Controls.Add(this.m_SearchNextButton);
			this.Controls.Add(this.m_ReplaceTextBox);
			this.Controls.Add(replaceLabel);
			this.Controls.Add(searchLabel);
			this.Controls.Add(this.m_SearchTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "查找和替换";
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OnSearchForm_HelpButtonClicked);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox m_SearchTextBox;
    private System.Windows.Forms.TextBox m_ReplaceTextBox;
    private System.Windows.Forms.Button m_SearchNextButton;
    private System.Windows.Forms.Button m_ReplaceButton;
    private System.Windows.Forms.Button m_ReplaceAllButton;
    private System.Windows.Forms.CheckBox m_WildcardCheckBox;
    private System.Windows.Forms.CheckBox m_CaseCheckBox;
	private System.Windows.Forms.RichTextBox m_HintRichTextBox;
}