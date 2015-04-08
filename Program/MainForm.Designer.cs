namespace Program
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FrameworkLabel = new System.Windows.Forms.Label();
            this.FrameworkBox = new System.Windows.Forms.TextBox();
            this.FrameworkPathButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PackageBox = new System.Windows.Forms.TextBox();
            this.PackageLabel = new System.Windows.Forms.Label();
            this.DomainLabel = new System.Windows.Forms.Label();
            this.DomainBox = new System.Windows.Forms.TextBox();
            this.DirectoryBox = new System.Windows.Forms.TextBox();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProjectSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProjectExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.CommandBox = new System.Windows.Forms.TextBox();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrameworkLabel
            // 
            resources.ApplyResources(this.FrameworkLabel, "FrameworkLabel");
            this.FrameworkLabel.Name = "FrameworkLabel";
            // 
            // FrameworkBox
            // 
            resources.ApplyResources(this.FrameworkBox, "FrameworkBox");
            this.FrameworkBox.Name = "FrameworkBox";
            this.FrameworkBox.ReadOnly = true;
            // 
            // FrameworkPathButton
            // 
            resources.ApplyResources(this.FrameworkPathButton, "FrameworkPathButton");
            this.FrameworkPathButton.Name = "FrameworkPathButton";
            this.FrameworkPathButton.UseVisualStyleBackColor = true;
            this.FrameworkPathButton.Click += new System.EventHandler(this.FrameworkPathButton_Click);
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // NameBox
            // 
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // PackageBox
            // 
            resources.ApplyResources(this.PackageBox, "PackageBox");
            this.PackageBox.Name = "PackageBox";
            this.PackageBox.TextChanged += new System.EventHandler(this.PackageBox_TextChanged);
            // 
            // PackageLabel
            // 
            resources.ApplyResources(this.PackageLabel, "PackageLabel");
            this.PackageLabel.Name = "PackageLabel";
            // 
            // DomainLabel
            // 
            resources.ApplyResources(this.DomainLabel, "DomainLabel");
            this.DomainLabel.Name = "DomainLabel";
            // 
            // DomainBox
            // 
            resources.ApplyResources(this.DomainBox, "DomainBox");
            this.DomainBox.Name = "DomainBox";
            this.DomainBox.TextChanged += new System.EventHandler(this.DomainBox_TextChanged);
            // 
            // DirectoryBox
            // 
            resources.ApplyResources(this.DirectoryBox, "DirectoryBox");
            this.DirectoryBox.Name = "DirectoryBox";
            this.DirectoryBox.ReadOnly = true;
            // 
            // DirectoryLabel
            // 
            resources.ApplyResources(this.DirectoryLabel, "DirectoryLabel");
            this.DirectoryLabel.Name = "DirectoryLabel";
            // 
            // DirectoryButton
            // 
            resources.ApplyResources(this.DirectoryButton, "DirectoryButton");
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProject,
            this.MenuHelp});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // MenuProject
            // 
            this.MenuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProjectSetting,
            this.MenuProjectExit});
            this.MenuProject.Name = "MenuProject";
            resources.ApplyResources(this.MenuProject, "MenuProject");
            // 
            // MenuProjectSetting
            // 
            this.MenuProjectSetting.Name = "MenuProjectSetting";
            resources.ApplyResources(this.MenuProjectSetting, "MenuProjectSetting");
            this.MenuProjectSetting.Click += new System.EventHandler(this.MenuProjectSetting_Click);
            // 
            // MenuProjectExit
            // 
            this.MenuProjectExit.Name = "MenuProjectExit";
            resources.ApplyResources(this.MenuProjectExit, "MenuProjectExit");
            this.MenuProjectExit.Click += new System.EventHandler(this.MenuProjectExit_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpInfo});
            this.MenuHelp.Name = "MenuHelp";
            resources.ApplyResources(this.MenuHelp, "MenuHelp");
            // 
            // MenuHelpInfo
            // 
            this.MenuHelpInfo.Name = "MenuHelpInfo";
            resources.ApplyResources(this.MenuHelpInfo, "MenuHelpInfo");
            this.MenuHelpInfo.Click += new System.EventHandler(this.MenuHelpInfo_Click);
            // 
            // ButtonAccept
            // 
            resources.ApplyResources(this.ButtonAccept, "ButtonAccept");
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CommandBox
            // 
            resources.ApplyResources(this.CommandBox, "CommandBox");
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.ReadOnly = true;
            // 
            // CommandLabel
            // 
            resources.ApplyResources(this.CommandLabel, "CommandLabel");
            this.CommandLabel.Name = "CommandLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.CommandBox);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.DirectoryBox);
            this.Controls.Add(this.DomainBox);
            this.Controls.Add(this.DomainLabel);
            this.Controls.Add(this.PackageLabel);
            this.Controls.Add(this.PackageBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FrameworkPathButton);
            this.Controls.Add(this.FrameworkBox);
            this.Controls.Add(this.FrameworkLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FrameworkLabel;
        private System.Windows.Forms.TextBox FrameworkBox;
        private System.Windows.Forms.Button FrameworkPathButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PackageBox;
        private System.Windows.Forms.Label PackageLabel;
        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.TextBox DomainBox;
        private System.Windows.Forms.TextBox DirectoryBox;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuProject;
        private System.Windows.Forms.ToolStripMenuItem MenuProjectExit;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ToolStripMenuItem MenuProjectSetting;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpInfo;
        private System.Windows.Forms.TextBox CommandBox;
        private System.Windows.Forms.Label CommandLabel;
    }
}

