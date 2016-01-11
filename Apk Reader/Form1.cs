using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apk_Reader
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.ActiveControl = label1;
			String Mainifest = Program.ReadApk("\"" + Program.staticArgs0 + "\"");
			Program.apkInfo = new ApkInfo(Mainifest);
			System.IO.File.WriteAllText("Manifest.txt", Mainifest);

			nameBox.Text = Program.apkInfo.apkName;
			versionBox.Text = Program.apkInfo.versionName + "(" + Program.apkInfo.versionCode + ")";
			minSDKBox.Text = Program.apkInfo.sdkVersion;
			targetSDKBox.Text = Program.apkInfo.targetSdkVersion;
			packageNameBox.Text = Program.apkInfo.packageName;
			sizeBox.Text = Program.showFileSize(Program.staticArgs0);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Console.WriteLine("hello");

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void nameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void refreshDeviceButton_Click(object sender, EventArgs e)
		{
			String connectedDevices = Program.executeCommand("adb.exe", new String[] { "devices" });
			Regex reg1 = new Regex($"{Program.NokiaN1DeviceCode}\\s*device");
			Match m1 = reg1.Match(connectedDevices);
			Regex reg2 = new Regex($"{Program.Nexus6DeviceCode}\\s*device");
			Match m2 = reg2.Match(connectedDevices);
			nokian1CheckBox.Enabled = m1.Success;
			nexus6CheckBox.Enabled = m2.Success;

		}

		private void nokian1CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (nokian1CheckBox.Checked)
			{
				Thread installThread = new Thread(this.installApk);
				installThread.Start(Program.NokiaN1DeviceCode);
			}
		}

		private void installApk(object deviceCodeString)
		{
			String installResult = Program.executeCommand("adb.exe", new String[] { "-s", (String)deviceCodeString, "install", "-r", "\"" + Program.staticArgs0 + "\"" });
		}

		private void nexus6CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (nexus6CheckBox.Checked)
			{
				Thread installThread = new Thread(this.installApk);
				installThread.Start(Program.Nexus6DeviceCode);
			}
		}

		private void allInstallButton_Click(object sender, EventArgs e)
		{
			Thread installThread2 = new Thread(this.installApk);
			installThread2.Start(Program.NokiaN1DeviceCode);
			Thread installThread1 = new Thread(this.installApk);
			installThread1.Start(Program.Nexus6DeviceCode);
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
