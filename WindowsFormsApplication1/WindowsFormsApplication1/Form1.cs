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
			Directory.CreateDirectory(this.pathTextBox.Text);
			if (!File.Exists(setupPath+"\\aapt.exe"))
			{
				byte[] aapt = Properties.Resources.aapt;
				FileStream aaptFile = new FileStream(setupPath + "\\aapt.exe", FileMode.CreateNew);
				aaptFile.Write(aapt, 0, aapt.Length);
				aaptFile.Close();
			}
			if (!File.Exists(setupPath + "\\Apk Reader.exe"))
			{
				byte[] apk_Reader = Properties.Resources.Apk_Reader;
				FileStream apk_ReaderFile = new FileStream(setupPath + "\\Apk Reader.exe", FileMode.CreateNew);
				apk_ReaderFile.Write(apk_Reader, 0, apk_Reader.Length);
				apk_ReaderFile.Close();
			}
		//	System.IO.File.WriteAllText(setupPath+"\\setting.ini", setupPath);
			MessageBox.Show("安装文件拷贝成功");
		}

		private void button3_Click(object sender, EventArgs e)
		{

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
