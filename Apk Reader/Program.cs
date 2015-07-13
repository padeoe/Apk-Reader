using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
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
            if (args.Length == 1)
			{
				String Mainifest = ReadApk(args[0]);
				ApkInfo apkInfo = new ApkInfo(Mainifest);
				System.IO.File.WriteAllText("Manifest.txt", Mainifest);
				MessageBox.Show("app名称: " + apkInfo.getApkName()+"\n版本号: "+apkInfo.getVersionName()+"\nsdk版本: "+apkInfo.getSdkVersion()+"\n包名: "+ apkInfo.getPackageName()+"\n大小: " + showFileSize(args[0]));
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
            if (filesize_double <= 1024) { return filesize_double + "B"; }
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
				argument = argument + " " + args[i];
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
			System.IO.File.WriteAllText("C:\\Users\\padeoe\\Desktop\\a.txt", output);
			return output;
		}

		static String ReadApk(String apkPath)
		{
			aapt_Argument[2] = apkPath;
			return executeCommand(aapt_Argument);
		}
	}
	class ApkInfo
	{
		String allManifest;
		String apkName;
		String versionName;
		String packageName;
		String sdkVersion;
		public ApkInfo(String Mainifest)
		{
			allManifest = Mainifest;
			searchAttribution(@"application-label:'(.*?)'", ref apkName);
			searchAttribution(@"versionName='(.*?)'", ref versionName);
			searchAttribution(@"package: name='(.*?)'", ref packageName);
			searchAttribution(@"sdkVersion:'(.*?)'", ref sdkVersion);

		}
		private void searchAttribution(String regex, ref String attributionName) {
			Regex reg = new Regex(regex);
			Match m = reg.Match(allManifest);
			if (m.Success)
			{
				attributionName = m.Groups[1].Value;
			}
		}

		public String getAllManifest()
		{
			return allManifest;
		}
		public String getVersionName()
		{
			return versionName;
		}
		public String getApkName()
		{
			return apkName;
		}
		public String getPackageName()
		{
			return packageName;
		}
		public String getSdkVersion()
		{
			return sdkVersion;
		}
	}
}
