namespace Apk_Reader
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
			this.label1 = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.versionBox = new System.Windows.Forms.TextBox();
			this.minSDKLabel = new System.Windows.Forms.Label();
			this.targetSDKLabel = new System.Windows.Forms.Label();
			this.targetSDKBox = new System.Windows.Forms.TextBox();
			this.minSDKBox = new System.Windows.Forms.TextBox();
			this.packageNameLabel = new System.Windows.Forms.Label();
			this.sizeLabel = new System.Windows.Forms.Label();
			this.installLabel = new System.Windows.Forms.Label();
			this.packageNameBox = new System.Windows.Forms.TextBox();
			this.sizeBox = new System.Windows.Forms.TextBox();
			this.nokian1CheckBox = new System.Windows.Forms.CheckBox();
			this.nexus6CheckBox = new System.Windows.Forms.CheckBox();
			this.refreshDeviceButton = new System.Windows.Forms.Button();
			this.allInstallButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 12);
			this.label1.TabIndex = 0;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.nameLabel.Location = new System.Drawing.Point(38, 9);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(37, 20);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "名称";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.versionLabel.Location = new System.Drawing.Point(38, 36);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(37, 20);
			this.versionLabel.TabIndex = 2;
			this.versionLabel.Text = "版本";
			// 
			// nameBox
			// 
			this.nameBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.nameBox.Location = new System.Drawing.Point(85, 11);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(250, 26);
			this.nameBox.TabIndex = 3;
			this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
			// 
			// versionBox
			// 
			this.versionBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.versionBox.Location = new System.Drawing.Point(85, 36);
			this.versionBox.Name = "versionBox";
			this.versionBox.Size = new System.Drawing.Size(250, 26);
			this.versionBox.TabIndex = 4;
			// 
			// minSDKLabel
			// 
			this.minSDKLabel.AutoSize = true;
			this.minSDKLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.minSDKLabel.Location = new System.Drawing.Point(12, 59);
			this.minSDKLabel.Name = "minSDKLabel";
			this.minSDKLabel.Size = new System.Drawing.Size(63, 20);
			this.minSDKLabel.TabIndex = 7;
			this.minSDKLabel.Text = "minSDK";
			// 
			// targetSDKLabel
			// 
			this.targetSDKLabel.AutoSize = true;
			this.targetSDKLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.targetSDKLabel.Location = new System.Drawing.Point(-2, 87);
			this.targetSDKLabel.Name = "targetSDKLabel";
			this.targetSDKLabel.Size = new System.Drawing.Size(77, 20);
			this.targetSDKLabel.TabIndex = 8;
			this.targetSDKLabel.Text = "targetSDK";
			// 
			// targetSDKBox
			// 
			this.targetSDKBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.targetSDKBox.Location = new System.Drawing.Point(85, 84);
			this.targetSDKBox.Name = "targetSDKBox";
			this.targetSDKBox.Size = new System.Drawing.Size(250, 26);
			this.targetSDKBox.TabIndex = 9;
			// 
			// minSDKBox
			// 
			this.minSDKBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.minSDKBox.Location = new System.Drawing.Point(85, 59);
			this.minSDKBox.Name = "minSDKBox";
			this.minSDKBox.Size = new System.Drawing.Size(250, 26);
			this.minSDKBox.TabIndex = 10;
			// 
			// packageNameLabel
			// 
			this.packageNameLabel.AutoSize = true;
			this.packageNameLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.packageNameLabel.Location = new System.Drawing.Point(38, 112);
			this.packageNameLabel.Name = "packageNameLabel";
			this.packageNameLabel.Size = new System.Drawing.Size(37, 20);
			this.packageNameLabel.TabIndex = 11;
			this.packageNameLabel.Text = "包名";
			// 
			// sizeLabel
			// 
			this.sizeLabel.AutoSize = true;
			this.sizeLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sizeLabel.Location = new System.Drawing.Point(38, 137);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(37, 20);
			this.sizeLabel.TabIndex = 12;
			this.sizeLabel.Text = "大小";
			// 
			// installLabel
			// 
			this.installLabel.AutoSize = true;
			this.installLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.installLabel.Location = new System.Drawing.Point(38, 183);
			this.installLabel.Name = "installLabel";
			this.installLabel.Size = new System.Drawing.Size(37, 20);
			this.installLabel.TabIndex = 13;
			this.installLabel.Text = "安装";
			// 
			// packageNameBox
			// 
			this.packageNameBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.packageNameBox.Location = new System.Drawing.Point(85, 109);
			this.packageNameBox.Name = "packageNameBox";
			this.packageNameBox.Size = new System.Drawing.Size(250, 26);
			this.packageNameBox.TabIndex = 14;
			// 
			// sizeBox
			// 
			this.sizeBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sizeBox.Location = new System.Drawing.Point(85, 134);
			this.sizeBox.Name = "sizeBox";
			this.sizeBox.Size = new System.Drawing.Size(250, 26);
			this.sizeBox.TabIndex = 15;
			// 
			// nokian1CheckBox
			// 
			this.nokian1CheckBox.AutoSize = true;
			this.nokian1CheckBox.Location = new System.Drawing.Point(96, 177);
			this.nokian1CheckBox.Name = "nokian1CheckBox";
			this.nokian1CheckBox.Size = new System.Drawing.Size(72, 16);
			this.nokian1CheckBox.TabIndex = 16;
			this.nokian1CheckBox.Text = "Nokia N1";
			this.nokian1CheckBox.UseVisualStyleBackColor = true;
			this.nokian1CheckBox.CheckedChanged += new System.EventHandler(this.nokian1CheckBox_CheckedChanged);
			// 
			// nexus6CheckBox
			// 
			this.nexus6CheckBox.AutoSize = true;
			this.nexus6CheckBox.Location = new System.Drawing.Point(96, 213);
			this.nexus6CheckBox.Name = "nexus6CheckBox";
			this.nexus6CheckBox.Size = new System.Drawing.Size(66, 16);
			this.nexus6CheckBox.TabIndex = 17;
			this.nexus6CheckBox.Text = "Nexus 6";
			this.nexus6CheckBox.UseVisualStyleBackColor = true;
			this.nexus6CheckBox.CheckedChanged += new System.EventHandler(this.nexus6CheckBox_CheckedChanged);
			// 
			// refreshDeviceButton
			// 
			this.refreshDeviceButton.Location = new System.Drawing.Point(215, 177);
			this.refreshDeviceButton.Name = "refreshDeviceButton";
			this.refreshDeviceButton.Size = new System.Drawing.Size(101, 23);
			this.refreshDeviceButton.TabIndex = 18;
			this.refreshDeviceButton.Text = "刷新设备列表";
			this.refreshDeviceButton.UseVisualStyleBackColor = true;
			this.refreshDeviceButton.Click += new System.EventHandler(this.refreshDeviceButton_Click);
			// 
			// allInstallButton
			// 
			this.allInstallButton.Location = new System.Drawing.Point(215, 206);
			this.allInstallButton.Name = "allInstallButton";
			this.allInstallButton.Size = new System.Drawing.Size(101, 23);
			this.allInstallButton.TabIndex = 19;
			this.allInstallButton.Text = "全部安装";
			this.allInstallButton.UseVisualStyleBackColor = true;
			this.allInstallButton.Click += new System.EventHandler(this.allInstallButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(132, 242);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(121, 30);
			this.closeButton.TabIndex = 20;
			this.closeButton.Text = "关闭";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 284);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.allInstallButton);
			this.Controls.Add(this.refreshDeviceButton);
			this.Controls.Add(this.nexus6CheckBox);
			this.Controls.Add(this.nokian1CheckBox);
			this.Controls.Add(this.sizeBox);
			this.Controls.Add(this.packageNameBox);
			this.Controls.Add(this.installLabel);
			this.Controls.Add(this.sizeLabel);
			this.Controls.Add(this.packageNameLabel);
			this.Controls.Add(this.minSDKBox);
			this.Controls.Add(this.targetSDKBox);
			this.Controls.Add(this.targetSDKLabel);
			this.Controls.Add(this.minSDKLabel);
			this.Controls.Add(this.versionBox);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.TextBox versionBox;
		private System.Windows.Forms.Label minSDKLabel;
		private System.Windows.Forms.Label targetSDKLabel;
		private System.Windows.Forms.TextBox targetSDKBox;
		private System.Windows.Forms.TextBox minSDKBox;
		private System.Windows.Forms.Label packageNameLabel;
		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.Label installLabel;
		private System.Windows.Forms.TextBox packageNameBox;
		private System.Windows.Forms.TextBox sizeBox;
		private System.Windows.Forms.CheckBox nokian1CheckBox;
		private System.Windows.Forms.CheckBox nexus6CheckBox;
		private System.Windows.Forms.Button refreshDeviceButton;
		private System.Windows.Forms.Button allInstallButton;
		private System.Windows.Forms.Button closeButton;
	}
}

