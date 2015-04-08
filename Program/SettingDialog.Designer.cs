namespace Program
{
    partial class SettingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingDialog));
            this.GroupDefaultPath = new System.Windows.Forms.GroupBox();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryBox = new System.Windows.Forms.TextBox();
            this.FrameworkLabel = new System.Windows.Forms.Label();
            this.FrameworkBox = new System.Windows.Forms.TextBox();
            this.FrameworkPathButton = new System.Windows.Forms.Button();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupDefaultPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupDefaultPath
            // 
            this.GroupDefaultPath.Controls.Add(this.DirectoryLabel);
            this.GroupDefaultPath.Controls.Add(this.DirectoryButton);
            this.GroupDefaultPath.Controls.Add(this.DirectoryBox);
            this.GroupDefaultPath.Controls.Add(this.FrameworkLabel);
            this.GroupDefaultPath.Controls.Add(this.FrameworkBox);
            this.GroupDefaultPath.Controls.Add(this.FrameworkPathButton);
            resources.ApplyResources(this.GroupDefaultPath, "GroupDefaultPath");
            this.GroupDefaultPath.Name = "GroupDefaultPath";
            this.GroupDefaultPath.TabStop = false;
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
            // DirectoryBox
            // 
            resources.ApplyResources(this.DirectoryBox, "DirectoryBox");
            this.DirectoryBox.Name = "DirectoryBox";
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
            // 
            // FrameworkPathButton
            // 
            resources.ApplyResources(this.FrameworkPathButton, "FrameworkPathButton");
            this.FrameworkPathButton.Name = "FrameworkPathButton";
            this.FrameworkPathButton.UseVisualStyleBackColor = true;
            this.FrameworkPathButton.Click += new System.EventHandler(this.FrameworkPathButton_Click);
            // 
            // ButtonAccept
            // 
            resources.ApplyResources(this.ButtonAccept, "ButtonAccept");
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // SettingDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.GroupDefaultPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingDialog";
            this.GroupDefaultPath.ResumeLayout(false);
            this.GroupDefaultPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupDefaultPath;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.Label FrameworkLabel;
        private System.Windows.Forms.Button FrameworkPathButton;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        public System.Windows.Forms.TextBox DirectoryBox;
        public System.Windows.Forms.TextBox FrameworkBox;
    }
}