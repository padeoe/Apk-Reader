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
		static String setupPath = "C:\\Program Files (x86)\\Apk Reader";
		static String aaptPath = setupPath + "\\" + "aapt.exe";
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
				System.IO.File.WriteAllText("C:\\Users\\padeoe\\Desktop\\b.txt", Mainifest);
				MessageBox.Show("app名称: " + apkInfo.getApkName()+"\n版本号: "+apkInfo.getVersionName()+"\nsdk版本: "+apkInfo.getSdkVersion()+"\n包名: "+ apkInfo.getPackageName());
			}
			//ExtractFile();

			//String output=executeCommand(aaptPath, aapt_Argument);
			//String type = ".txt";
			//         if (IsAssociated(type))
			//{
			//	MessageBox.Show(output , type+"绑定检查");
			//}
			//else
			//{
			//	MessageBox.Show(output  ,type+"绑定检查");
			//}
			//         Application.EnableVisualStyles();
			//         Application.SetCompatibleTextRenderingDefault(false);
			//         Application.Run(new Form1());

		}
		/// <summary>
		/// 安装时释放资源文件，包括aapt.exe和command.bat
		/// </summary>
		static void ExtractFile()
		{
			if (!Directory.Exists(setupPath))
			{
				Directory.CreateDirectory(setupPath);
			}

			if (!File.Exists(aaptPath))
			{
				byte[] aapt = Properties.Resources.aapt;
				FileStream aaptFile = new FileStream(aaptPath, FileMode.CreateNew);
				aaptFile.Write(aapt, 0, aapt.Length);
				aaptFile.Close();
			}
		}
		/// <summary>
		/// 检测文件格式是否关联
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		static bool IsAssociated(String type)
		{
			return Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\" + type, false) != null;
		}
		/// <summary>
		/// 执行aapt命令获取输出
		/// </summary>
		/// <param name="commandPath">bat的路径</param>
		/// <returns></returns>
		static String executeCommand(String aaptPath, String[] args)
		{
			// Start the child process.
			Process p = new Process();
			// Redirect the output stream of the child process.
			p.StartInfo.UseShellExecute = false; p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.FileName = aaptPath;
			String argument = null;
			for (int i = 0; i < args.Length; i++) {
				argument = argument + " " + args[i];
			}
			p.StartInfo.Arguments = argument;
			p.Start();
			// Do not wait for the child process to exit before
			// reading to the end of its redirected stream.
			// p.WaitForExit();
			// Read the output stream first and then wait.
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
			return executeCommand(aaptPath, aapt_Argument);
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

			
			//"package: name='com.padeoe.autoconnect'"

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
