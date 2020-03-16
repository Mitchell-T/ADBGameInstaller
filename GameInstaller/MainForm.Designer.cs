namespace GameInstaller
{
    partial class MainForm
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
            this.Skin1 = new FlatUI.FormSkin();
            this.MusicButton = new FlatUI.FlatButton();
            this.Request_Button = new FlatUI.FlatButton();
            this.OutputTextBox = new FlatUI.FlatTextBox();
            this.InstallButton = new FlatUI.FlatButton();
            this.CheckboxList = new System.Windows.Forms.CheckedListBox();
            this.AvailableGamesLabel = new FlatUI.FlatLabel();
            this.MinimizeButton = new FlatUI.FlatMini();
            this.CloseButton = new FlatUI.FlatClose();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Skin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Skin1
            // 
            this.Skin1.BackColor = System.Drawing.Color.White;
            this.Skin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Skin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.Skin1.Controls.Add(this.MusicButton);
            this.Skin1.Controls.Add(this.Request_Button);
            this.Skin1.Controls.Add(this.OutputTextBox);
            this.Skin1.Controls.Add(this.InstallButton);
            this.Skin1.Controls.Add(this.CheckboxList);
            this.Skin1.Controls.Add(this.AvailableGamesLabel);
            this.Skin1.Controls.Add(this.MinimizeButton);
            this.Skin1.Controls.Add(this.CloseButton);
            this.Skin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Skin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Skin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Skin1.HeaderMaximize = false;
            this.Skin1.Location = new System.Drawing.Point(0, 0);
            this.Skin1.Name = "Skin1";
            this.Skin1.Size = new System.Drawing.Size(433, 579);
            this.Skin1.TabIndex = 0;
            this.Skin1.Text = "Galaxy Games Game Installer";
            // 
            // MusicButton
            // 
            this.MusicButton.BackColor = System.Drawing.Color.Transparent;
            this.MusicButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MusicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MusicButton.Location = new System.Drawing.Point(3, 3);
            this.MusicButton.Name = "MusicButton";
            this.MusicButton.Rounded = false;
            this.MusicButton.Size = new System.Drawing.Size(6, 6);
            this.MusicButton.TabIndex = 9;
            this.MusicButton.Text = "Music";
            this.MusicButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.MusicButton.Click += new System.EventHandler(this.MusicButton_Click);
            // 
            // Request_Button
            // 
            this.Request_Button.BackColor = System.Drawing.Color.Transparent;
            this.Request_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Request_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Request_Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Request_Button.Location = new System.Drawing.Point(16, 430);
            this.Request_Button.Name = "Request_Button";
            this.Request_Button.Rounded = false;
            this.Request_Button.Size = new System.Drawing.Size(385, 52);
            this.Request_Button.TabIndex = 8;
            this.Request_Button.Text = "REQUEST PERMISSION";
            this.Request_Button.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Request_Button.Click += new System.EventHandler(this.Request_Button_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.Transparent;
            this.OutputTextBox.FocusOnHover = false;
            this.OutputTextBox.Location = new System.Drawing.Point(16, 229);
            this.OutputTextBox.MaxLength = 32767;
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(385, 184);
            this.OutputTextBox.TabIndex = 7;
            this.OutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OutputTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.OutputTextBox.UseSystemPasswordChar = false;
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.Color.Transparent;
            this.InstallButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.InstallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallButton.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.InstallButton.Location = new System.Drawing.Point(16, 488);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Rounded = false;
            this.InstallButton.Size = new System.Drawing.Size(385, 79);
            this.InstallButton.TabIndex = 5;
            this.InstallButton.Text = "INSTALL";
            this.InstallButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // CheckboxList
            // 
            this.CheckboxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.CheckboxList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CheckboxList.FormattingEnabled = true;
            this.CheckboxList.Location = new System.Drawing.Point(16, 75);
            this.CheckboxList.Name = "CheckboxList";
            this.CheckboxList.Size = new System.Drawing.Size(385, 148);
            this.CheckboxList.TabIndex = 4;
            // 
            // AvailableGamesLabel
            // 
            this.AvailableGamesLabel.AutoSize = true;
            this.AvailableGamesLabel.BackColor = System.Drawing.Color.Transparent;
            this.AvailableGamesLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.AvailableGamesLabel.ForeColor = System.Drawing.Color.White;
            this.AvailableGamesLabel.Location = new System.Drawing.Point(13, 59);
            this.AvailableGamesLabel.Name = "AvailableGamesLabel";
            this.AvailableGamesLabel.Size = new System.Drawing.Size(96, 13);
            this.AvailableGamesLabel.TabIndex = 3;
            this.AvailableGamesLabel.Text = "Available Games:";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.White;
            this.MinimizeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MinimizeButton.Font = new System.Drawing.Font("Marlett", 12F);
            this.MinimizeButton.Location = new System.Drawing.Point(379, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(18, 18);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "MinimizeButton";
            this.MinimizeButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CloseButton.Font = new System.Drawing.Font("Marlett", 10F);
            this.CloseButton.Location = new System.Drawing.Point(403, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "CloseButton";
            this.CloseButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 579);
            this.Controls.Add(this.Skin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Skin1.ResumeLayout(false);
            this.Skin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin Skin1;
        private FlatUI.FlatClose CloseButton;
        private FlatUI.FlatMini MinimizeButton;
        private FlatUI.FlatLabel AvailableGamesLabel;
        private System.Windows.Forms.CheckedListBox CheckboxList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlatUI.FlatButton InstallButton;
        private FlatUI.FlatTextBox OutputTextBox;
        private FlatUI.FlatButton Request_Button;
        private FlatUI.FlatButton MusicButton;
    }
}

