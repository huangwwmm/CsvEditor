﻿using System;
using System.IO;
using System.Windows.Forms;

[Serializable]
public class Setting
{
	private static Setting ms_Instance = null;
	public static Setting Instance
	{
		get
		{
			if (ms_Instance == null)
			{
				Load();
			}
			return ms_Instance;
		}
	}

	private static string ms_SavePath = FileUtility.GetApplicationDirectory() + GlobalData.SETTING_FILE_NAME;

	public bool FirstRun = false;

	#region DiffCompare
	public bool TortoiseCompareEnable = true;
	public string TortoiseCompareExePath;

	public bool BeyondCompareEnable = true;
	public bool BeyondCompareAutoExePath = true;
	public string BeyondCompareExePath;

	public bool CodeCompareEnable = true;
	public bool CodeCompareAutoExePath = true;
	public string CodeCompareExePath;
	#endregion

	/// <summary>
	/// 初始化数据
	/// </summary>
	public Setting()
	{
		FirstRun = true;

		TortoiseCompareEnable = true;
		BeyondCompareEnable = true;
		BeyondCompareAutoExePath = true;
		BeyondCompareExePath = "";
		CodeCompareEnable = true;
		CodeCompareAutoExePath = true;
		CodeCompareExePath = "";
	}

	/// <summary>
	/// 保存到文件
	/// </summary>
	public static void Save()
	{
		try
		{
			SerializeUtility.WriteFile(ms_SavePath, Instance);
		}
		catch (Exception ex)
		{
			DebugUtility.ShowExceptionMessageBox("保存设置失败\n" + ms_SavePath, ex);
		}
	}

	/// <summary>
	/// 读取设置到ms_Instance
	/// </summary>
	public static void Load()
	{
		// 配置文件不存在
		if (!File.Exists(ms_SavePath))
		{
			ms_Instance = new Setting();
			return;
		}

		try
		{
			ms_Instance = (Setting)SerializeUtility.ReadFile(ms_SavePath);
			ms_Instance.FirstRun = false;
		}
		catch (Exception ex)
		{
			if (DebugUtility.ShowExceptionMessageBox("读取设置失败\n是否删除设置文件重新读取?\n" + ms_SavePath, ex, MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				ms_Instance = DeleteAndLoad();
			}
		}
	}

	private static Setting DeleteAndLoad()
	{
		try
		{
			if (File.Exists(ms_SavePath))
			{
				File.Delete(ms_SavePath);
			}
		}
		catch (Exception ex)
		{
			DebugUtility.ShowExceptionMessageBox("删除设置文件失败,使用默认设置.", ex);
		}

		if (ms_Instance == null)
		{
			ms_Instance = new Setting();
		}
		return ms_Instance;
	}
}