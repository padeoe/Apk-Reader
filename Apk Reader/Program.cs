using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace Apk_Reader
{
	static class Program
	{
	public static ApkInfo apkInfo;
		public static string NokiaN1DeviceCode= "L15220FNN1K2";
		public static string Nexus6DeviceCode = "ZX1G42B46X";
		public static string staticArgs0;
		static String[] aapt_Argument = { "dump", "badging", "" };
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(String[] args)
		{


			///for debug
			String[] a = new String[1];
			a[0] = @"C:\Users\padeoe\Desktop\aaa.apk";
			args = a;


			if (args.Length == 1)
			{
				staticArgs0 = args[0];
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
			else
			{
				MessageBox.Show("请在apk程序上右键-打开方式-用本程序打开","Apk Reader");
			}
		}

		/// <summary>
		/// 根据文件大小不同返回不同单位的大小，便于直观阅读
		/// </summary>
		/// <param name="filePath">文件路径</param>
		/// <returns></returns>
		public static String showFileSize(String filePath)
		{
			long filesize=new FileInfo(filePath).Length;
			if (filesize<=1024) { return filesize + "B"; }
			double filesize_KB = filesize / 1024.0;
            if (filesize_KB <= 1024) { return filesize_KB.ToString("#.##") + "KB"; }
			return (filesize_KB / 1024).ToString("#.##")+"MB("+ filesize_KB.ToString("#") + "KB)"; 

		}
		/// <summary>
		/// 执行aapt命令获取输出
		/// </summary>
		/// <param name="commandPath">bat的路径</param>
		/// <returns></returns>
		public static String executeCommand(String fileName,String[] args)
		{
			Process myProcess = new Process();
			ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(fileName);
			String argument = null;
			for (int i = 0; i < args.Length; i++)
			{
				argument += " " + args[i];
			}
			myProcessStartInfo.Arguments = argument;
			myProcessStartInfo.UseShellExecute = false;
			myProcessStartInfo.CreateNoWindow = true;
			myProcessStartInfo.RedirectStandardOutput = true;
			myProcessStartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8; // this is the most important part, to get correct myString, see below
			myProcess.StartInfo = myProcessStartInfo;
			myProcess.Start();
			StreamReader myStreamReader = myProcess.StandardOutput;
			string myString = myStreamReader.ReadToEnd();
			myProcess.WaitForExit();
			myProcess.Close();
			return myString;
		}

		public static String ReadApk(String apkPath)
		{
			aapt_Argument[2] = apkPath;
			return executeCommand("aapt.exe",aapt_Argument);
		}
	}
	/// <summary>
	/// 存储Apk信息
	/// </summary>
	public class ApkInfo
	{
		public String allManifest { get; }
		public String apkName { get; }
		public String versionName { get; }
		public String packageName { get; }
		public String sdkVersion { get; }
		public String targetSdkVersion { get; }
		public String versionCode { get; }

		/// <summary>
		/// 根据Mainifest.xml文件读取ApkInfo类属性所需的apk信息
		/// </summary>
		/// <param name="Mainifest">Mainifest.xml文件的内容</param>
		public ApkInfo(String Mainifest)
		{
			allManifest = Mainifest;
			apkName = getAttribution(@"application-label:'(.*?)'");
			versionName = getAttribution(@"versionName='(.*?)'");
			packageName = getAttribution(@"package: name='(.*?)'");
			sdkVersion = getAttribution(@"sdkVersion:'(.*?)'");
			targetSdkVersion = getAttribution(@"targetSdkVersion:'(.*?)'");
			versionCode= getAttribution(@"versionCode='(.*?)'");
		}

		private String getAttribution(String regex)
		{
			Regex reg = new Regex(regex);
			Match m = reg.Match(allManifest);
			if (m.Success)
			{
				return m.Groups[1].Value;
			}
			return "";
		}

	}
}
