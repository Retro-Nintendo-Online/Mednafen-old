namespace BugGUI
{
    partial class GameDirectoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDirectoryForm));
            this.pathBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.extensionsBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Enabled = false;
            this.pathBox.Location = new System.Drawing.Point(85, 53);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(313, 20);
            this.pathBox.TabIndex = 4;
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doneButton);
            this.groupBox1.Controls.Add(this.extensionsBox);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.pathLabel);
            this.groupBox1.Controls.Add(this.pathBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Games Directory";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(176, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 13);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(14, 53);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(65, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Games Path";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(402, 53);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(29, 20);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // extensionsBox
            // 
            this.extensionsBox.Location = new System.Drawing.Point(93, 103);
            this.extensionsBox.Name = "extensionsBox";
            this.extensionsBox.Size = new System.Drawing.Size(85, 20);
            this.extensionsBox.TabIndex = 5;
            this.extensionsBox.Text = "nes;sfc;smc";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(58, 103);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(52, 20);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "NES Games";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(17, 93);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(414, 30);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.addDirectoryButton_Click);
            // 
            // GameDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 149);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameDirectoryForm";
            this.Text = "Select Games Directory";
            this.Load += new System.EventHandler(this.GameDirectoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox extensionsBox;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button browseButton;
    }
}