using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Handy.Ini;

namespace Program
{
    public partial class SettingDialog : Form
    {
        public SettingDialog()
        {
            InitializeComponent();

            this.GroupDefaultPath.Text = SettingDialogLang.GroupTitle;
            this.FrameworkLabel.Text = SettingDialogLang.FrameworkLabel;
            this.DirectoryLabel.Text = SettingDialogLang.DirectoryLabel;
            this.ButtonAccept.Text = SettingDialogLang.ButtonAccept;
            this.ButtonCancel.Text = SettingDialogLang.ButtonCancel;

            this.FrameworkBox.Text = IniManager.Read(Common.settingSection, Common.settingFramework, Common.SettingFilePath, Common.defaultFramework);
            this.DirectoryBox.Text = IniManager.Read(Common.settingSection, Common.settingDirectory, Common.SettingFilePath, Common.defaultDirectory);
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

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
