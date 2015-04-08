using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using Handy.Ini;
using Handy;

namespace Program
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // link localization resources
            LinkMainFormLocalization();

            // fill default framework path, project directory and command box
            string framework = IniManager.Read(Common.settingSection, Common.settingFramework, Common.SettingFilePath, Common.defaultFramework);
            string directory = IniManager.Read(Common.settingSection, Common.settingDirectory, Common.SettingFilePath, Common.defaultDirectory);
            this.FrameworkBox.Text = framework;
            this.DirectoryBox.Text = directory;
            string cocosFile = string.Format("python {0}\\tools\\cocos2d-console\\bin\\cocos.py", framework);
            string cocosParam = string.Format("new <ProjectName> -p com.<Domain>.<Package> -l cpp -d {0}", directory);
            this.CommandBox.Text = cocosFile + ' ' + cocosParam;
        }

        /////////////////////////////////////////////////////////////////////////////
        // common inner methods
        void LinkMainFormLocalization()
        {
            // common
            this.Text = MainFormLang.Title;

            // menuStrip items
            this.MenuProject.Text = MainFormLang.MenuProject;
            this.MenuProjectSetting.Text = MainFormLang.MenuProjectSetting;
            this.MenuProjectExit.Text = MainFormLang.MenuProjectExit;
            this.MenuHelp.Text = MainFormLang.MenuHelp;
            this.MenuHelpInfo.Text = MainFormLang.MenuHelpInfo;

            // contents
            this.FrameworkLabel.Text = MainFormLang.FrameworkLabel;
            this.NameLabel.Text = MainFormLang.NameLabel;
            this.DomainLabel.Text = MainFormLang.DomainLabel;
            this.PackageLabel.Text = MainFormLang.PackageLabel;
            this.DirectoryLabel.Text = MainFormLang.DirectoryLabel;
            this.CommandLabel.Text = MainFormLang.CommandLabel;
            this.ButtonAccept.Text = MainFormLang.ButtonAccept;
            this.ButtonCancel.Text = MainFormLang.ButtonCancel;
        }

        void CreateProject()
        {
            string framework = this.FrameworkBox.Text;
            string name = this.NameBox.Text;
            string domain = this.DomainBox.Text;
            string package = this.PackageBox.Text;
            string directory = this.DirectoryBox.Text;
            string param = string.Format
                ("{0}\\tools\\cocos2d-console\\bin\\cocos.py new {1} -p com.{2}.{3} -l cpp -d {4}",
                    framework, name, domain, package, directory);
            Process.Start("python", param);
        }
        bool IsAllTextboxEmpty()
        {
            if (this.FrameworkBox.Text != string.Empty) return false;
            else if (this.NameBox.Text != string.Empty) return false;
            else if (this.DomainBox.Text != string.Empty) return false;
            else if (this.PackageBox.Text != string.Empty) return false;
            else if (this.DirectoryBox.Text != string.Empty) return false;
            else return true;
        }
        bool IsAllTextboxFilled()
        {
            if (this.FrameworkBox.Text == string.Empty) return false;
            else if (this.NameBox.Text == string.Empty) return false;
            else if (this.DomainBox.Text == string.Empty) return false;
            else if (this.PackageBox.Text == string.Empty) return false;
            else if (this.DirectoryBox.Text == string.Empty) return false;
            else return true;
        }
        void OnFieldModified()
        {
            string framework = this.FrameworkBox.Text;
            string name = this.NameBox.Text;
            string domain = this.DomainBox.Text;
            string package = this.PackageBox.Text;
            string directory = this.DirectoryBox.Text;

            if (name == string.Empty) name = "<ProjectName>";
            if (domain == string.Empty) domain = "<Domain>";
            if (package == string.Empty) package = "<Package>";

            string param = string.Format
                ("python {0}\\tools\\cocos2d-console\\bin\\cocos.py new {1} -p com.{2}.{3} -l cpp -d {4}",
                    framework, name, domain, package, directory);
            this.CommandBox.Text = param;
        }

        /////////////////////////////////////////////////////////////////////////////
        // button event handler
        private void CancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsAllTextboxEmpty() == false)
                {
                    ConfirmDialog dialog = new ConfirmDialog("프로젝트를 생성하지 않고 프로그램을 종료합니다.");
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsAllTextboxFilled())
                {
                    throw new Exception("모든 항목에 빈 칸이 없어야 합니다.");
                }
                CreateProject();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrameworkPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.FrameworkBox.Text = dialog.SelectedPath;
            }
        }
        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.DirectoryBox.Text = dialog.SelectedPath;
            }
        }

        /////////////////////////////////////////////////////////////////////////////
        // menuBar event handler
        private void MenuProjectSetting_Click(object sender, EventArgs e)
        {
            SettingDialog dialog = new SettingDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                IniFile initInfo = new IniFile(Common.SettingFilePath);
                initInfo.Set(Common.settingSection, Common.settingFramework, dialog.FrameworkBox.Text);
                initInfo.Set(Common.settingSection, Common.settingDirectory, dialog.DirectoryBox.Text);
                initInfo.Write();
            }
        }
        private void MenuProjectExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MenuHelpInfo_Click(object sender, EventArgs e)
        {
            DeveloperDialog dialog = new DeveloperDialog();
            dialog.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////////
        // Textbox inside changed event handler
        private void NameBox_TextChanged(object sender, EventArgs e) { OnFieldModified(); }
        private void DomainBox_TextChanged(object sender, EventArgs e) { OnFieldModified(); }
        private void PackageBox_TextChanged(object sender, EventArgs e) { OnFieldModified(); }
    }
}
