using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 点击改变路径按钮的事件响应
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
		FolderBrowserDialog folderBrowserDialog= new FolderBrowserDialog();
			// Show the FolderBrowserDialog.
			DialogResult result = folderBrowserDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				String folderName = folderBrowserDialog.SelectedPath;
				TextBox pathTextbox = this.getPathTextBox();
				pathTextbox.Text = folderName+@"\Apk Reader";
            }
		}
		/// <summary>
		/// 点击next时的事件响应
		/// 将会复制aapt.exe，apk reader.exe到安装路径
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			String setupPath = this.pathTextBox.Text;
            if (Directory.Exists(setupPath))
			{
				Directory.Delete(setupPath,true);
			}
			Directory.CreateDirectory(setupPath);
			prepareFile(Properties.Resources.Apk_Reader, setupPath, "Apk Reader.exe");
			prepareFile(Properties.Resources.aapt, setupPath, "aapt.exe");
			prepareFile(Properties.Resources.adb, setupPath, "adb.exe");
			prepareFile(Properties.Resources.AdbWinApi, setupPath, "AdbWinApi.dll");
			//	System.IO.File.WriteAllText(setupPath+"\\setting.ini", setupPath);

			MessageBox.Show("All Done!");
			this.Close();
		}

		private void prepareFile(byte[] resources, String installPath, String fileName) {
			if (!File.Exists(installPath+"\\"+fileName))
			{
				extractFile(resources, installPath, fileName);
			}
		}
		private void extractFile(byte[] resources,String installPath,String fileName) {
			FileStream fileStream = new FileStream(installPath+"\\"+fileName, FileMode.CreateNew);
			fileStream.Write(resources, 0, resources.Length);
			fileStream.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure to abort installation？", "Cancel Installation", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Application.Exit();
			}

			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
