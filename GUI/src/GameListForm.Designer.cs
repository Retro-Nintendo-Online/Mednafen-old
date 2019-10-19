namespace BugGUI
{
    partial class GameListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameListForm));
            this.directoryList = new System.Windows.Forms.ComboBox();
            this.addDirectoryButton = new System.Windows.Forms.Button();
            this.removeDirectoryButton = new System.Windows.Forms.Button();
            this.gamesGridView = new System.Windows.Forms.DataGridView();
            this.editDirectoryButton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.gamesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryList
            // 
            this.directoryList.FormattingEnabled = true;
            this.directoryList.Location = new System.Drawing.Point(12, 13);
            this.directoryList.Name = "directoryList";
            this.directoryList.Size = new System.Drawing.Size(226, 21);
            this.directoryList.TabIndex = 1;
            this.directoryList.Text = "Directory Name";
            this.directoryList.SelectedIndexChanged += new System.EventHandler(this.directoryList_SelectedIndexChanged);
            // 
            // addDirectoryButton
            // 
            this.addDirectoryButton.Location = new System.Drawing.Point(244, 13);
            this.addDirectoryButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.addDirectoryButton.Name = "addDirectoryButton";
            this.addDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.addDirectoryButton.TabIndex = 2;
            this.addDirectoryButton.Text = "Add";
            this.addDirectoryButton.UseVisualStyleBackColor = true;
            this.addDirectoryButton.Click += new System.EventHandler(this.addDirectoryButton_Click);
            // 
            // removeDirectoryButton
            // 
            this.removeDirectoryButton.Location = new System.Drawing.Point(406, 13);
            this.removeDirectoryButton.Name = "removeDirectoryButton";
            this.removeDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.removeDirectoryButton.TabIndex = 3;
            this.removeDirectoryButton.Text = "Remove";
            this.removeDirectoryButton.UseVisualStyleBackColor = true;
            this.removeDirectoryButton.Click += new System.EventHandler(this.removeDirectoryButton_Click);
            // 
            // gamesGridView
            // 
            this.gamesGridView.AllowUserToAddRows = false;
            this.gamesGridView.AllowUserToDeleteRows = false;
            this.gamesGridView.AllowUserToResizeColumns = false;
            this.gamesGridView.AllowUserToResizeRows = false;
            this.gamesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gamesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gamesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gamesGridView.Location = new System.Drawing.Point(12, 42);
            this.gamesGridView.MultiSelect = false;
            this.gamesGridView.Name = "gamesGridView";
            this.gamesGridView.ReadOnly = true;
            this.gamesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gamesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gamesGridView.Size = new System.Drawing.Size(469, 396);
            this.gamesGridView.TabIndex = 4;
            this.gamesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gamesGridView_CellContentClick);
            // 
            // editDirectoryButton
            // 
            this.editDirectoryButton.Location = new System.Drawing.Point(325, 13);
            this.editDirectoryButton.Name = "editDirectoryButton";
            this.editDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.editDirectoryButton.TabIndex = 5;
            this.editDirectoryButton.Text = "Edit";
            this.editDirectoryButton.UseVisualStyleBackColor = true;
            this.editDirectoryButton.Click += new System.EventHandler(this.editDirectoryButton_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(451, 52);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 374);
            this.vScrollBar1.TabIndex = 6;
            // 
            // GameListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.editDirectoryButton);
            this.Controls.Add(this.gamesGridView);
            this.Controls.Add(this.removeDirectoryButton);
            this.Controls.Add(this.addDirectoryButton);
            this.Controls.Add(this.directoryList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 489);
            this.MinimumSize = new System.Drawing.Size(515, 489);
            this.Name = "GameListForm";
            this.Text = "Select a Game";
            ((System.ComponentModel.ISupportInitialize)(this.gamesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox directoryList;
        private System.Windows.Forms.Button addDirectoryButton;
        private System.Windows.Forms.Button removeDirectoryButton;
        private System.Windows.Forms.DataGridView gamesGridView;
        private System.Windows.Forms.Button editDirectoryButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}