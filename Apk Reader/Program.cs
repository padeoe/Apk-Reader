using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Apk_Reader
{
	static class Program
	{
		static String[] aapt_Argument = { "dump", "badging", "" };
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(String[] args)
		{

			/*
			///for debug
			String [] a=new String[1];
			a[0] = "C:\\Users\\padeo\\Desktop\\a.apk";
            args = a;
			*/
			if (args.Length == 1)
			{
				String Mainifest = ReadApk(args[0]);
				ApkInfo apkInfo = new ApkInfo(Mainifest);
				System.IO.File.WriteAllText("Manifest.txt", Mainifest);
				MessageBox.Show("app名称: " + apkInfo.apkName+"\n版本号: "+apkInfo.versionName+"\nsdk版本: "+apkInfo.sdkVersion+"\n包名: "+ apkInfo.packageName+"\n大小: " + showFileSize(args[0]));
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
		static String showFileSize(String filePath)
		{
			long filesize=new FileInfo(filePath).Length;
			if (filesize<=1024) { return filesize + "B"; }
			double filesize_double = filesize / 1024.0;
            if (filesize_double <= 1024) { return filesize_double + "KB"; }
			return (filesize_double/1024).ToString("#.##")+"MB("+ filesize+ "B)"; 

		}
		/// <summary>
		/// 执行aapt命令获取输出
		/// </summary>
		/// <param name="commandPath">bat的路径</param>
		/// <returns></returns>
		static String executeCommand(String[] args)
		{
			// Start the child process.
			Process p = new Process();
			// Redirect the output stream of the child process.
			p.StartInfo.UseShellExecute = false; p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.FileName = "aapt.exe";
			String argument = null;
			for (int i = 0; i < args.Length; i++) {
				argument += " " + args[i];
			}
			p.StartInfo.Arguments = argument;
			p.Start();
			String output = null;
			while (true)
			{
				String tmp = p.StandardOutput.ReadToEnd();
				if (tmp == "")
					break;
				output += tmp;
			}
			//p.WaitForExit();
			return output;
		}

		static String ReadApk(String apkPath)
		{
			aapt_Argument[2] = apkPath;
			return executeCommand(aapt_Argument);
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
