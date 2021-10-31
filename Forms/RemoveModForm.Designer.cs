
namespace sourcemod_launcher.Forms
{
    partial class RemoveModForm
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
            this.labConfirm = new System.Windows.Forms.Label();
            this.chkDeleteFIles = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butCancel = new System.Windows.Forms.Button();
            this.butConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labConfirm
            // 
            this.labConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labConfirm.AutoSize = true;
            this.labConfirm.Location = new System.Drawing.Point(3, 6);
            this.labConfirm.Name = "labConfirm";
            this.labConfirm.Size = new System.Drawing.Size(205, 13);
            this.labConfirm.TabIndex = 0;
            this.labConfirm.Text = "Are you sure to delete the selected mods?";
            // 
            // chkDeleteFIles
            // 
            this.chkDeleteFIles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDeleteFIles.AutoSize = true;
            this.chkDeleteFIles.Location = new System.Drawing.Point(3, 29);
            this.chkDeleteFIles.Name = "chkDeleteFIles";
            this.chkDeleteFIles.Size = new System.Drawing.Size(185, 17);
            this.chkDeleteFIles.TabIndex = 1;
            this.chkDeleteFIles.Text = "Also permanently delete their files.";
            this.chkDeleteFIles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labConfirm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkDeleteFIles, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(188, 68);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(12, 68);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 4;
            this.butConfirm.Text = "Yes";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // RemoveModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 102);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RemoveModForm";
            this.Text = "Remove Mod";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labConfirm;
        private System.Windows.Forms.CheckBox chkDeleteFIles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butConfirm;
    }
}