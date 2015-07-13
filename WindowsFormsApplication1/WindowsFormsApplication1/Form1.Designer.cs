namespace WindowsFormsApplication1
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.pathTextBox = new System.Windows.Forms.TextBox();
			this.changePath = new System.Windows.Forms.Button();
			this.nextButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.tipsLabel = new System.Windows.Forms.Label();
			this.PathLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pathTextBox
			// 
			this.pathTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pathTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
			this.pathTextBox.Location = new System.Drawing.Point(34, 89);
			this.pathTextBox.Name = "pathTextBox";
			this.pathTextBox.Size = new System.Drawing.Size(254, 21);
			this.pathTextBox.TabIndex = 0;
			this.pathTextBox.TabStop = false;
			this.pathTextBox.Text = "C:\\Program Files (x86)\\Apk Reader";
			this.pathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// changePath
			// 
			this.changePath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.changePath.Location = new System.Drawing.Point(294, 89);
			this.changePath.Name = "changePath";
			this.changePath.Size = new System.Drawing.Size(65, 23);
			this.changePath.TabIndex = 1;
			this.changePath.Text = "change";
			this.changePath.UseVisualStyleBackColor = true;
			this.changePath.Click += new System.EventHandler(this.button1_Click);
			// 
			// nextButton
			// 
			this.nextButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.nextButton.Location = new System.Drawing.Point(210, 130);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(80, 25);
			this.nextButton.TabIndex = 2;
			this.nextButton.Text = "Next";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cancelButton.Location = new System.Drawing.Point(100, 130);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(80, 25);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.button3_Click);
			// 
			// tipsLabel
			// 
			this.tipsLabel.AutoSize = true;
			this.tipsLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tipsLabel.Location = new System.Drawing.Point(30, 25);
			this.tipsLabel.Name = "tipsLabel";
			this.tipsLabel.Size = new System.Drawing.Size(321, 20);
			this.tipsLabel.TabIndex = 4;
			this.tipsLabel.Text = "Apk Reader will be installed on your computer";
			this.tipsLabel.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// PathLabel
			// 
			this.PathLabel.AutoSize = true;
			this.PathLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PathLabel.Location = new System.Drawing.Point(30, 65);
			this.PathLabel.Name = "PathLabel";
			this.PathLabel.Size = new System.Drawing.Size(122, 20);
			this.PathLabel.TabIndex = 5;
			this.PathLabel.Text = "Installation Path:";
			this.PathLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 181);
			this.Controls.Add(this.PathLabel);
			this.Controls.Add(this.tipsLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.nextButton);
			this.Controls.Add(this.changePath);
			this.Controls.Add(this.pathTextBox);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Apk Reader Installer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox pathTextBox;
		private System.Windows.Forms.Button changePath;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label tipsLabel;
		private System.Windows.Forms.Label PathLabel;

		public System.Windows.Forms.TextBox getPathTextBox()
		{
			return pathTextBox;
        }
	}
}

