
namespace sourcemod_launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gModList = new System.Windows.Forms.GroupBox();
            this.butExplore = new System.Windows.Forms.Button();
            this.butEditMod = new System.Windows.Forms.Button();
            this.butRemoveMod = new System.Windows.Forms.Button();
            this.butLaunchMod = new System.Windows.Forms.Button();
            this.butAddMod = new System.Windows.Forms.Button();
            this.dgvMods = new System.Windows.Forms.DataGridView();
            this.dgvcModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDisplayedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcLaunchParams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcFullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gModInfo = new System.Windows.Forms.GroupBox();
            this.tableModInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labFilePath = new System.Windows.Forms.Label();
            this.labDisplayedName = new System.Windows.Forms.Label();
            this.labModName = new System.Windows.Forms.Label();
            this.labModNameLabel = new System.Windows.Forms.Label();
            this.labDisplayedNameLabel = new System.Windows.Forms.Label();
            this.labLaunchParamsLabel = new System.Windows.Forms.Label();
            this.labLaunchParams = new System.Windows.Forms.TextBox();
            this.labGameLabel = new System.Windows.Forms.Label();
            this.labGame = new System.Windows.Forms.Label();
            this.labFilePathLabel = new System.Windows.Forms.Label();
            this.gCommonLaunchParam = new System.Windows.Forms.GroupBox();
            this.boxCommonLaunchParams = new System.Windows.Forms.TextBox();
            this.rboxDragDrop = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gModList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMods)).BeginInit();
            this.gModInfo.SuspendLayout();
            this.tableModInfo.SuspendLayout();
            this.gCommonLaunchParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // gModList
            // 
            this.gModList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gModList.Controls.Add(this.butExplore);
            this.gModList.Controls.Add(this.butEditMod);
            this.gModList.Controls.Add(this.butRemoveMod);
            this.gModList.Controls.Add(this.butLaunchMod);
            this.gModList.Controls.Add(this.butAddMod);
            this.gModList.Controls.Add(this.dgvMods);
            this.gModList.Location = new System.Drawing.Point(13, 13);
            this.gModList.Name = "gModList";
            this.gModList.Size = new System.Drawing.Size(663, 300);
            this.gModList.TabIndex = 0;
            this.gModList.TabStop = false;
            this.gModList.Text = "Mods List";
            // 
            // butExplore
            // 
            this.butExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butExplore.Location = new System.Drawing.Point(392, 271);
            this.butExplore.Name = "butExplore";
            this.butExplore.Size = new System.Drawing.Size(103, 23);
            this.butExplore.TabIndex = 4;
            this.butExplore.Text = "Show in Explorer";
            this.butExplore.UseVisualStyleBackColor = true;
            this.butExplore.Click += new System.EventHandler(this.butExplore_Click);
            // 
            // butEditMod
            // 
            this.butEditMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butEditMod.Location = new System.Drawing.Point(501, 271);
            this.butEditMod.Name = "butEditMod";
            this.butEditMod.Size = new System.Drawing.Size(75, 23);
            this.butEditMod.TabIndex = 3;
            this.butEditMod.Text = "Edit";
            this.butEditMod.UseVisualStyleBackColor = true;
            this.butEditMod.Click += new System.EventHandler(this.butEditMod_Click);
            // 
            // butRemoveMod
            // 
            this.butRemoveMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butRemoveMod.Location = new System.Drawing.Point(6, 271);
            this.butRemoveMod.Name = "butRemoveMod";
            this.butRemoveMod.Size = new System.Drawing.Size(75, 23);
            this.butRemoveMod.TabIndex = 2;
            this.butRemoveMod.Text = "Remove";
            this.butRemoveMod.UseVisualStyleBackColor = true;
            this.butRemoveMod.Click += new System.EventHandler(this.butRemoveMod_Click);
            // 
            // butLaunchMod
            // 
            this.butLaunchMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butLaunchMod.Location = new System.Drawing.Point(582, 271);
            this.butLaunchMod.Name = "butLaunchMod";
            this.butLaunchMod.Size = new System.Drawing.Size(75, 23);
            this.butLaunchMod.TabIndex = 2;
            this.butLaunchMod.Text = "Launch";
            this.butLaunchMod.UseVisualStyleBackColor = true;
            this.butLaunchMod.Click += new System.EventHandler(this.butLaunchMod_Click);
            // 
            // butAddMod
            // 
            this.butAddMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butAddMod.Location = new System.Drawing.Point(87, 271);
            this.butAddMod.Name = "butAddMod";
            this.butAddMod.Size = new System.Drawing.Size(75, 23);
            this.butAddMod.TabIndex = 1;
            this.butAddMod.Text = "Add";
            this.butAddMod.UseVisualStyleBackColor = true;
            this.butAddMod.Click += new System.EventHandler(this.butAddMod_Click);
            // 
            // dgvMods
            // 
            this.dgvMods.AllowUserToAddRows = false;
            this.dgvMods.AllowUserToDeleteRows = false;
            this.dgvMods.AllowUserToOrderColumns = true;
            this.dgvMods.AllowUserToResizeRows = false;
            this.dgvMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcModName,
            this.dgvcDisplayedName,
            this.dgvcGame,
            this.dgvcFilePath,
            this.dgvcLaunchParams,
            this.dgvcFullPath});
            this.dgvMods.Location = new System.Drawing.Point(6, 20);
            this.dgvMods.Name = "dgvMods";
            this.dgvMods.ReadOnly = true;
            this.dgvMods.RowHeadersVisible = false;
            this.dgvMods.Size = new System.Drawing.Size(650, 245);
            this.dgvMods.TabIndex = 0;
            // 
            // dgvcModName
            // 
            this.dgvcModName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcModName.HeaderText = "Mod Name";
            this.dgvcModName.Name = "dgvcModName";
            this.dgvcModName.ReadOnly = true;
            this.dgvcModName.Width = 78;
            // 
            // dgvcDisplayedName
            // 
            this.dgvcDisplayedName.HeaderText = "Displayed Name";
            this.dgvcDisplayedName.Name = "dgvcDisplayedName";
            this.dgvcDisplayedName.ReadOnly = true;
            // 
            // dgvcGame
            // 
            this.dgvcGame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcGame.HeaderText = "Game";
            this.dgvcGame.Name = "dgvcGame";
            this.dgvcGame.ReadOnly = true;
            this.dgvcGame.Width = 60;
            // 
            // dgvcFilePath
            // 
            this.dgvcFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcFilePath.HeaderText = "File Path";
            this.dgvcFilePath.Name = "dgvcFilePath";
            this.dgvcFilePath.ReadOnly = true;
            this.dgvcFilePath.Width = 68;
            // 
            // dgvcLaunchParams
            // 
            this.dgvcLaunchParams.HeaderText = "Launch Parameters";
            this.dgvcLaunchParams.Name = "dgvcLaunchParams";
            this.dgvcLaunchParams.ReadOnly = true;
            this.dgvcLaunchParams.Width = 150;
            // 
            // dgvcFullPath
            // 
            this.dgvcFullPath.HeaderText = "you shouldn\'t see this...";
            this.dgvcFullPath.Name = "dgvcFullPath";
            this.dgvcFullPath.ReadOnly = true;
            this.dgvcFullPath.Visible = false;
            // 
            // gModInfo
            // 
            this.gModInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gModInfo.Controls.Add(this.tableModInfo);
            this.gModInfo.Location = new System.Drawing.Point(13, 319);
            this.gModInfo.Name = "gModInfo";
            this.gModInfo.Size = new System.Drawing.Size(663, 165);
            this.gModInfo.TabIndex = 1;
            this.gModInfo.TabStop = false;
            this.gModInfo.Text = "Mod Info";
            // 
            // tableModInfo
            // 
            this.tableModInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableModInfo.AutoSize = true;
            this.tableModInfo.ColumnCount = 2;
            this.tableModInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableModInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableModInfo.Controls.Add(this.labFilePath, 1, 3);
            this.tableModInfo.Controls.Add(this.labDisplayedName, 1, 1);
            this.tableModInfo.Controls.Add(this.labModName, 1, 0);
            this.tableModInfo.Controls.Add(this.labModNameLabel, 0, 0);
            this.tableModInfo.Controls.Add(this.labDisplayedNameLabel, 0, 1);
            this.tableModInfo.Controls.Add(this.labLaunchParamsLabel, 0, 4);
            this.tableModInfo.Controls.Add(this.labLaunchParams, 1, 4);
            this.tableModInfo.Controls.Add(this.labGameLabel, 0, 2);
            this.tableModInfo.Controls.Add(this.labGame, 1, 2);
            this.tableModInfo.Controls.Add(this.labFilePathLabel, 0, 3);
            this.tableModInfo.Location = new System.Drawing.Point(7, 20);
            this.tableModInfo.Name = "tableModInfo";
            this.tableModInfo.RowCount = 5;
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableModInfo.Size = new System.Drawing.Size(649, 135);
            this.tableModInfo.TabIndex = 0;
            // 
            // labFilePath
            // 
            this.labFilePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labFilePath.AutoSize = true;
            this.labFilePath.Location = new System.Drawing.Point(128, 91);
            this.labFilePath.Name = "labFilePath";
            this.labFilePath.Size = new System.Drawing.Size(56, 13);
            this.labFilePath.TabIndex = 9;
            this.labFilePath.Text = "<file path>";
            // 
            // labDisplayedName
            // 
            this.labDisplayedName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDisplayedName.AutoSize = true;
            this.labDisplayedName.Location = new System.Drawing.Point(128, 41);
            this.labDisplayedName.Name = "labDisplayedName";
            this.labDisplayedName.Size = new System.Drawing.Size(92, 13);
            this.labDisplayedName.TabIndex = 3;
            this.labDisplayedName.Text = "<displayed name>";
            // 
            // labModName
            // 
            this.labModName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModName.AutoSize = true;
            this.labModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.labModName.Location = new System.Drawing.Point(128, 9);
            this.labModName.Name = "labModName";
            this.labModName.Size = new System.Drawing.Size(96, 16);
            this.labModName.TabIndex = 2;
            this.labModName.Text = "<mod name>";
            // 
            // labModNameLabel
            // 
            this.labModNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModNameLabel.AutoSize = true;
            this.labModNameLabel.Location = new System.Drawing.Point(3, 11);
            this.labModNameLabel.Name = "labModNameLabel";
            this.labModNameLabel.Size = new System.Drawing.Size(35, 13);
            this.labModNameLabel.TabIndex = 0;
            this.labModNameLabel.Text = "Name";
            // 
            // labDisplayedNameLabel
            // 
            this.labDisplayedNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDisplayedNameLabel.AutoSize = true;
            this.labDisplayedNameLabel.Location = new System.Drawing.Point(3, 41);
            this.labDisplayedNameLabel.Name = "labDisplayedNameLabel";
            this.labDisplayedNameLabel.Size = new System.Drawing.Size(84, 13);
            this.labDisplayedNameLabel.TabIndex = 1;
            this.labDisplayedNameLabel.Text = "Displayed Name";
            // 
            // labLaunchParamsLabel
            // 
            this.labLaunchParamsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labLaunchParamsLabel.AutoSize = true;
            this.labLaunchParamsLabel.Location = new System.Drawing.Point(3, 116);
            this.labLaunchParamsLabel.Name = "labLaunchParamsLabel";
            this.labLaunchParamsLabel.Size = new System.Drawing.Size(99, 13);
            this.labLaunchParamsLabel.TabIndex = 6;
            this.labLaunchParamsLabel.Text = "Launch Parameters";
            // 
            // labLaunchParams
            // 
            this.labLaunchParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labLaunchParams.Location = new System.Drawing.Point(128, 113);
            this.labLaunchParams.Name = "labLaunchParams";
            this.labLaunchParams.ReadOnly = true;
            this.labLaunchParams.Size = new System.Drawing.Size(518, 20);
            this.labLaunchParams.TabIndex = 7;
            this.labLaunchParams.WordWrap = false;
            // 
            // labGameLabel
            // 
            this.labGameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labGameLabel.AutoSize = true;
            this.labGameLabel.Location = new System.Drawing.Point(3, 66);
            this.labGameLabel.Name = "labGameLabel";
            this.labGameLabel.Size = new System.Drawing.Size(35, 13);
            this.labGameLabel.TabIndex = 4;
            this.labGameLabel.Text = "Game";
            // 
            // labGame
            // 
            this.labGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labGame.AutoSize = true;
            this.labGame.Location = new System.Drawing.Point(128, 66);
            this.labGame.Name = "labGame";
            this.labGame.Size = new System.Drawing.Size(60, 13);
            this.labGame.TabIndex = 5;
            this.labGame.Text = "<launcher>";
            // 
            // labFilePathLabel
            // 
            this.labFilePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labFilePathLabel.AutoSize = true;
            this.labFilePathLabel.Location = new System.Drawing.Point(3, 91);
            this.labFilePathLabel.Name = "labFilePathLabel";
            this.labFilePathLabel.Size = new System.Drawing.Size(48, 13);
            this.labFilePathLabel.TabIndex = 8;
            this.labFilePathLabel.Text = "File Path";
            // 
            // gCommonLaunchParam
            // 
            this.gCommonLaunchParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCommonLaunchParam.Controls.Add(this.boxCommonLaunchParams);
            this.gCommonLaunchParam.Location = new System.Drawing.Point(13, 490);
            this.gCommonLaunchParam.Name = "gCommonLaunchParam";
            this.gCommonLaunchParam.Size = new System.Drawing.Size(331, 52);
            this.gCommonLaunchParam.TabIndex = 2;
            this.gCommonLaunchParam.TabStop = false;
            this.gCommonLaunchParam.Text = "Additional Launch Paramters (applies to all mods)";
            // 
            // boxCommonLaunchParams
            // 
            this.boxCommonLaunchParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boxCommonLaunchParams.Location = new System.Drawing.Point(7, 20);
            this.boxCommonLaunchParams.Name = "boxCommonLaunchParams";
            this.boxCommonLaunchParams.Size = new System.Drawing.Size(318, 20);
            this.boxCommonLaunchParams.TabIndex = 0;
            this.boxCommonLaunchParams.TextChanged += new System.EventHandler(this.boxCommonLaunchParams_TextChanged);
            // 
            // rboxDragDrop
            // 
            this.rboxDragDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rboxDragDrop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rboxDragDrop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rboxDragDrop.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rboxDragDrop.Location = new System.Drawing.Point(350, 490);
            this.rboxDragDrop.Name = "rboxDragDrop";
            this.rboxDragDrop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rboxDragDrop.Size = new System.Drawing.Size(326, 52);
            this.rboxDragDrop.TabIndex = 3;
            this.rboxDragDrop.Text = "\n\n\nDrag and Drop files here to move them into appropriate folders";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 547);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SourceMod Launcher - by 2838 - October 2021";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rboxDragDrop);
            this.Controls.Add(this.gCommonLaunchParam);
            this.Controls.Add(this.gModInfo);
            this.Controls.Add(this.gModList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(704, 608);
            this.Name = "MainForm";
            this.Text = "SourceMod Launcher";
            this.gModList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMods)).EndInit();
            this.gModInfo.ResumeLayout(false);
            this.gModInfo.PerformLayout();
            this.tableModInfo.ResumeLayout(false);
            this.tableModInfo.PerformLayout();
            this.gCommonLaunchParam.ResumeLayout(false);
            this.gCommonLaunchParam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gModList;
        private System.Windows.Forms.DataGridView dgvMods;
        private System.Windows.Forms.Button butRemoveMod;
        private System.Windows.Forms.Button butAddMod;
        private System.Windows.Forms.GroupBox gModInfo;
        private System.Windows.Forms.Button butEditMod;
        private System.Windows.Forms.Button butLaunchMod;
        private System.Windows.Forms.TableLayoutPanel tableModInfo;
        private System.Windows.Forms.Label labLaunchParamsLabel;
        private System.Windows.Forms.Label labDisplayedName;
        private System.Windows.Forms.Label labModName;
        private System.Windows.Forms.Label labModNameLabel;
        private System.Windows.Forms.Label labDisplayedNameLabel;
        private System.Windows.Forms.Label labGameLabel;
        private System.Windows.Forms.Label labGame;
        private System.Windows.Forms.TextBox labLaunchParams;
        private System.Windows.Forms.Label labFilePath;
        private System.Windows.Forms.Label labFilePathLabel;
        private System.Windows.Forms.GroupBox gCommonLaunchParam;
        private System.Windows.Forms.TextBox boxCommonLaunchParams;
        private System.Windows.Forms.Button butExplore;
        private System.Windows.Forms.RichTextBox rboxDragDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDisplayedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcLaunchParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFullPath;
    }
}