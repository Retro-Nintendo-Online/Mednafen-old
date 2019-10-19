namespace BugGUI
{
    partial class Form1
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameLabel = new System.Windows.Forms.Label();
            this.netplayCheckBox = new System.Windows.Forms.CheckBox();
            this.hostText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.nickText = new System.Windows.Forms.TextBox();
            this.gamekeyText = new System.Windows.Forms.TextBox();
            this.nickLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMednafenRNOEditonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netplayDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(10, 39);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(35, 13);
            this.gameLabel.TabIndex = 1;
            this.gameLabel.Text = "Game";
            // 
            // netplayCheckBox
            // 
            this.netplayCheckBox.AutoSize = true;
            this.netplayCheckBox.Location = new System.Drawing.Point(473, 42);
            this.netplayCheckBox.Name = "netplayCheckBox";
            this.netplayCheckBox.Size = new System.Drawing.Size(62, 17);
            this.netplayCheckBox.TabIndex = 2;
            this.netplayCheckBox.Text = "Netplay";
            this.netplayCheckBox.UseVisualStyleBackColor = true;
            this.netplayCheckBox.CheckedChanged += new System.EventHandler(this.netplayCheckBox_CheckedChanged);
            // 
            // hostText
            // 
            this.hostText.Enabled = false;
            this.hostText.Location = new System.Drawing.Point(115, 116);
            this.hostText.Name = "hostText";
            this.hostText.Size = new System.Drawing.Size(156, 20);
            this.hostText.TabIndex = 3;
            this.hostText.Text = "netplay.fobby.net";
            // 
            // portText
            // 
            this.portText.Enabled = false;
            this.portText.Location = new System.Drawing.Point(170, 116);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(63, 20);
            this.portText.TabIndex = 4;
            this.portText.Text = "4046";
            // 
            // nickText
            // 
            this.nickText.Enabled = false;
            this.nickText.Location = new System.Drawing.Point(300, 40);
            this.nickText.Name = "nickText";
            this.nickText.Size = new System.Drawing.Size(167, 20);
            this.nickText.TabIndex = 5;
            // 
            // gamekeyText
            // 
            this.gamekeyText.Enabled = false;
            this.gamekeyText.Location = new System.Drawing.Point(300, 68);
            this.gamekeyText.Name = "gamekeyText";
            this.gamekeyText.Size = new System.Drawing.Size(230, 20);
            this.gamekeyText.TabIndex = 6;
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.Location = new System.Drawing.Point(256, 43);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(38, 13);
            this.nickLabel.TabIndex = 9;
            this.nickLabel.Text = "Name:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 97);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(517, 45);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start Mednafen";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.helpToolStripMenuItem,
            this.netplayToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(548, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectGameMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // selectGameMenuItem
            // 
            this.selectGameMenuItem.Name = "selectGameMenuItem";
            this.selectGameMenuItem.Size = new System.Drawing.Size(133, 22);
            this.selectGameMenuItem.Text = "Open ROM";
            this.selectGameMenuItem.Click += new System.EventHandler(this.selectGameMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homepageToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutMednafenRNOEditonToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.homepageToolStripMenuItem.Text = "Homepage";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItem2.Text = " ──────────────";
            // 
            // aboutMednafenRNOEditonToolStripMenuItem
            // 
            this.aboutMednafenRNOEditonToolStripMenuItem.Name = "aboutMednafenRNOEditonToolStripMenuItem";
            this.aboutMednafenRNOEditonToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutMednafenRNOEditonToolStripMenuItem.Text = "About Mednafen";
            this.aboutMednafenRNOEditonToolStripMenuItem.Click += new System.EventHandler(this.aboutMednafenRNOEditonToolStripMenuItem_Click);
            // 
            // netplayToolStripMenuItem
            // 
            this.netplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netplayDiscordToolStripMenuItem,
            this.toolStripMenuItem3,
            this.updateEmulatorToolStripMenuItem});
            this.netplayToolStripMenuItem.Name = "netplayToolStripMenuItem";
            this.netplayToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.netplayToolStripMenuItem.Text = "Netplay";
            // 
            // netplayDiscordToolStripMenuItem
            // 
            this.netplayDiscordToolStripMenuItem.Name = "netplayDiscordToolStripMenuItem";
            this.netplayDiscordToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.netplayDiscordToolStripMenuItem.Text = "Netplay Discord";
            this.netplayDiscordToolStripMenuItem.Click += new System.EventHandler(this.netplayDiscordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem3.Text = "──────────────────";
            // 
            // updateEmulatorToolStripMenuItem
            // 
            this.updateEmulatorToolStripMenuItem.Name = "updateEmulatorToolStripMenuItem";
            this.updateEmulatorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.updateEmulatorToolStripMenuItem.Text = "Update Emulator";
            this.updateEmulatorToolStripMenuItem.Click += new System.EventHandler(this.updateEmulatorToolStripMenuItem_Click);
            // 
            // gameTextBox
            // 
            this.gameTextBox.Enabled = false;
            this.gameTextBox.Location = new System.Drawing.Point(48, 38);
            this.gameTextBox.Name = "gameTextBox";
            this.gameTextBox.Size = new System.Drawing.Size(172, 20);
            this.gameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Game Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameTextBox);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.gamekeyText);
            this.Controls.Add(this.nickText);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.hostText);
            this.Controls.Add(this.netplayCheckBox);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 189);
            this.MinimumSize = new System.Drawing.Size(564, 189);
            this.Name = "Form1";
            this.Text = "Mednafen - RNO Edition (10/19/19)";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.CheckBox netplayCheckBox;
        private System.Windows.Forms.TextBox hostText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.TextBox nickText;
        private System.Windows.Forms.TextBox gamekeyText;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectGameMenuItem;
        private System.Windows.Forms.TextBox gameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutMednafenRNOEditonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netplayDiscordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updateEmulatorToolStripMenuItem;
    }
}

