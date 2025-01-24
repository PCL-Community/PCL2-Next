
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace PCLNext.Desktop.Modules.Base;

public static class ModBase
{
#pragma warning disable CA2211
    #region 声明
    //下列版本信息由更新器自动修改
    public const string VersionBaseName = "3.0.0."; //不含分支前缀的显示用版本名
    public const string VersionStandardCode = "3.0.0." + VersionBranchCode; //标准格式的四段式版本号
    public const string CommitHash = "native"; //Commit Hash，由 GitHub Workflow 自动替换
    public static string CommitHashShort = (CommitHash == "native") ? "native" : CommitHash.Substring(0, 7); //Commit Hash, 取前 7 位
    public const string UpstreamVersion = "2.8.12"; //上游版本
#if RELEASE
    public const int VersionCode = 400; //Release
#else
    public const int VersionCode = 400; //Snapshot
#endif
    //自动生成的版本信息
    public const string VersionDisplayName = VersionBranchName + " " + VersionBaseName;
#if RELEASE
    public const string VersionBranchName = "Next";
    public const string VersionBranchCode = "0";
#elif BETA
    public const string VersionBranchName = "Next Preview";
    public const string VersionBranchCode = "50";
#else
    public const string VersionBranchName = "Next Debug";
    public const string VersionBranchCode = "100";
#endif
    /// <summary>
    /// 主窗口句柄。
    /// </summary>
    public static IntPtr Handle;
    /// <summary>
    /// 程序的启动路径，以"\"结尾。
    /// </summary>
    public static string Path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase ?? "";
    /// <summary>
    /// 程序内嵌图片文件夹路径，以"/"结尾。
    /// </summary>
    public static string PathImage = "pack://application:,,,/Plain Craft Launcher 2;component/Images/";
    /// <summary>
    /// 当前程序的语言。
    /// </summary>
    public static string Lang = "zh_CN";
    /// <summary> 
    /// 设置对象。
    /// </summary>
    // public static ModSetup Setup = new ModSetup(); // To be finished
    #endregion
#pragma warning restore CA2211
}

