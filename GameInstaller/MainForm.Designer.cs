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
            this.OutputTextBox = new FlatUI.FlatTextBox();
            this.AlertBox = new FlatUI.FlatAlertBox();
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
            this.Skin1.Controls.Add(this.OutputTextBox);
            this.Skin1.Controls.Add(this.AlertBox);
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
            // AlertBox
            // 
            this.AlertBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.AlertBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlertBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AlertBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.AlertBox.Location = new System.Drawing.Point(16, 504);
            this.AlertBox.Name = "AlertBox";
            this.AlertBox.Size = new System.Drawing.Size(385, 42);
            this.AlertBox.TabIndex = 6;
            this.AlertBox.Text = "Succes!";
            this.AlertBox.Visible = false;
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.Color.Transparent;
            this.InstallButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.InstallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallButton.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.InstallButton.Location = new System.Drawing.Point(16, 419);
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
        private FlatUI.FlatAlertBox AlertBox;
    }
}

