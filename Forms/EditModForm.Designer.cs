
namespace sourcemod_launcher.Forms
{
    partial class EditModForm
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
            this.gModInfo = new System.Windows.Forms.GroupBox();
            this.butBrowseGame = new System.Windows.Forms.Button();
            this.tableModInfo = new System.Windows.Forms.TableLayoutPanel();
            this.boxDisplayedName = new System.Windows.Forms.TextBox();
            this.labModNameLabel = new System.Windows.Forms.Label();
            this.labDisplayedNameLabel = new System.Windows.Forms.Label();
            this.labGameLabel = new System.Windows.Forms.Label();
            this.boxModName = new System.Windows.Forms.TextBox();
            this.boxDisplayedNameSecond = new System.Windows.Forms.TextBox();
            this.boxGamePath = new System.Windows.Forms.TextBox();
            this.labLaunchParamsLabel = new System.Windows.Forms.Label();
            this.boxLaunchParams = new System.Windows.Forms.TextBox();
            this.chkSteamAppID = new System.Windows.Forms.CheckBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.gModInfo.SuspendLayout();
            this.tableModInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gModInfo
            // 
            this.gModInfo.Controls.Add(this.butBrowseGame);
            this.gModInfo.Controls.Add(this.tableModInfo);
            this.gModInfo.Location = new System.Drawing.Point(12, 12);
            this.gModInfo.Name = "gModInfo";
            this.gModInfo.Size = new System.Drawing.Size(516, 178);
            this.gModInfo.TabIndex = 2;
            this.gModInfo.TabStop = false;
            this.gModInfo.Text = "Mod Info";
            // 
            // butBrowseGame
            // 
            this.butBrowseGame.Location = new System.Drawing.Point(434, 96);
            this.butBrowseGame.Name = "butBrowseGame";
            this.butBrowseGame.Size = new System.Drawing.Size(75, 23);
            this.butBrowseGame.TabIndex = 3;
            this.butBrowseGame.Text = "Browse";
            this.butBrowseGame.UseVisualStyleBackColor = true;
            this.butBrowseGame.Click += new System.EventHandler(this.butBrowseGame_Click);
            // 
            // tableModInfo
            // 
            this.tableModInfo.ColumnCount = 2;
            this.tableModInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableModInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableModInfo.Controls.Add(this.boxDisplayedName, 1, 1);
            this.tableModInfo.Controls.Add(this.labModNameLabel, 0, 0);
            this.tableModInfo.Controls.Add(this.labDisplayedNameLabel, 0, 1);
            this.tableModInfo.Controls.Add(this.labGameLabel, 0, 3);
            this.tableModInfo.Controls.Add(this.boxModName, 1, 0);
            this.tableModInfo.Controls.Add(this.boxDisplayedNameSecond, 1, 2);
            this.tableModInfo.Controls.Add(this.boxGamePath, 1, 3);
            this.tableModInfo.Controls.Add(this.labLaunchParamsLabel, 0, 5);
            this.tableModInfo.Controls.Add(this.boxLaunchParams, 1, 5);
            this.tableModInfo.Controls.Add(this.chkSteamAppID, 1, 4);
            this.tableModInfo.Location = new System.Drawing.Point(7, 20);
            this.tableModInfo.Name = "tableModInfo";
            this.tableModInfo.RowCount = 6;
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.Size = new System.Drawing.Size(421, 150);
            this.tableModInfo.TabIndex = 0;
            // 
            // boxDisplayedName
            // 
            this.boxDisplayedName.Location = new System.Drawing.Point(128, 28);
            this.boxDisplayedName.Name = "boxDisplayedName";
            this.boxDisplayedName.Size = new System.Drawing.Size(290, 20);
            this.boxDisplayedName.TabIndex = 9;
            // 
            // labModNameLabel
            // 
            this.labModNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModNameLabel.AutoSize = true;
            this.labModNameLabel.Location = new System.Drawing.Point(3, 6);
            this.labModNameLabel.Name = "labModNameLabel";
            this.labModNameLabel.Size = new System.Drawing.Size(35, 13);
            this.labModNameLabel.TabIndex = 0;
            this.labModNameLabel.Text = "Name";
            // 
            // labDisplayedNameLabel
            // 
            this.labDisplayedNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDisplayedNameLabel.AutoSize = true;
            this.labDisplayedNameLabel.Location = new System.Drawing.Point(3, 31);
            this.labDisplayedNameLabel.Name = "labDisplayedNameLabel";
            this.labDisplayedNameLabel.Size = new System.Drawing.Size(84, 13);
            this.labDisplayedNameLabel.TabIndex = 1;
            this.labDisplayedNameLabel.Text = "Displayed Name";
            // 
            // labGameLabel
            // 
            this.labGameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labGameLabel.AutoSize = true;
            this.labGameLabel.Location = new System.Drawing.Point(3, 81);
            this.labGameLabel.Name = "labGameLabel";
            this.labGameLabel.Size = new System.Drawing.Size(35, 13);
            this.labGameLabel.TabIndex = 4;
            this.labGameLabel.Text = "Game";
            // 
            // boxModName
            // 
            this.boxModName.Location = new System.Drawing.Point(128, 3);
            this.boxModName.Name = "boxModName";
            this.boxModName.Size = new System.Drawing.Size(290, 20);
            this.boxModName.TabIndex = 8;
            // 
            // boxDisplayedNameSecond
            // 
            this.boxDisplayedNameSecond.Location = new System.Drawing.Point(128, 53);
            this.boxDisplayedNameSecond.Name = "boxDisplayedNameSecond";
            this.boxDisplayedNameSecond.Size = new System.Drawing.Size(290, 20);
            this.boxDisplayedNameSecond.TabIndex = 10;
            // 
            // boxGamePath
            // 
            this.boxGamePath.Location = new System.Drawing.Point(128, 78);
            this.boxGamePath.Name = "boxGamePath";
            this.boxGamePath.Size = new System.Drawing.Size(290, 20);
            this.boxGamePath.TabIndex = 11;
            // 
            // labLaunchParamsLabel
            // 
            this.labLaunchParamsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labLaunchParamsLabel.AutoSize = true;
            this.labLaunchParamsLabel.Location = new System.Drawing.Point(3, 131);
            this.labLaunchParamsLabel.Name = "labLaunchParamsLabel";
            this.labLaunchParamsLabel.Size = new System.Drawing.Size(99, 13);
            this.labLaunchParamsLabel.TabIndex = 6;
            this.labLaunchParamsLabel.Text = "Launch Parameters";
            // 
            // boxLaunchParams
            // 
            this.boxLaunchParams.Location = new System.Drawing.Point(128, 128);
            this.boxLaunchParams.Name = "boxLaunchParams";
            this.boxLaunchParams.Size = new System.Drawing.Size(290, 20);
            this.boxLaunchParams.TabIndex = 7;
            this.boxLaunchParams.WordWrap = false;
            // 
            // chkSteamAppID
            // 
            this.chkSteamAppID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSteamAppID.AutoSize = true;
            this.chkSteamAppID.Location = new System.Drawing.Point(128, 104);
            this.chkSteamAppID.Name = "chkSteamAppID";
            this.chkSteamAppID.Size = new System.Drawing.Size(92, 17);
            this.chkSteamAppID.TabIndex = 12;
            this.chkSteamAppID.Text = "Steam App ID";
            this.chkSteamAppID.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(454, 196);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(373, 196);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // EditModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 228);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.gModInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditModForm";
            this.Text = "Edit Mod";
            this.gModInfo.ResumeLayout(false);
            this.tableModInfo.ResumeLayout(false);
            this.tableModInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gModInfo;
        private System.Windows.Forms.TableLayoutPanel tableModInfo;
        private System.Windows.Forms.Label labModNameLabel;
        private System.Windows.Forms.Label labDisplayedNameLabel;
        private System.Windows.Forms.Label labLaunchParamsLabel;
        private System.Windows.Forms.TextBox boxLaunchParams;
        private System.Windows.Forms.Label labGameLabel;
        private System.Windows.Forms.Button butBrowseGame;
        private System.Windows.Forms.TextBox boxDisplayedName;
        private System.Windows.Forms.TextBox boxModName;
        private System.Windows.Forms.TextBox boxDisplayedNameSecond;
        private System.Windows.Forms.TextBox boxGamePath;
        private System.Windows.Forms.CheckBox chkSteamAppID;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSave;
    }
}