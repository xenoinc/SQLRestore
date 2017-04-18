/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-10
 * File:    MainForm.Designer.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-410 * Initial creation
 */

namespace Xeno.SQLRestore.Views
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
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.chkRestoreOverwrite = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnDbRestore = new System.Windows.Forms.Button();
      this.lvFileList = new System.Windows.Forms.ListView();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSettingsBackupFolder = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSettingNameFormat = new System.Windows.Forms.TextBox();
      this.txtSettingsFolder = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSettingsCancel = new System.Windows.Forms.Button();
      this.btnSettingsSave = new System.Windows.Forms.Button();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.label5 = new System.Windows.Forms.Label();
      this.lstAvailableDb = new System.Windows.Forms.ListBox();
      this.btnDbBackup = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.chkCompress = new System.Windows.Forms.CheckBox();
      this.chkIsGolden = new System.Windows.Forms.CheckBox();
      this.statusStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsStatus,
            this.tsProgressBar});
      this.statusStrip1.Location = new System.Drawing.Point(0, 254);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(582, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
      this.toolStripStatusLabel1.Text = "Status:";
      // 
      // tsStatus
      // 
      this.tsStatus.Name = "tsStatus";
      this.tsStatus.Size = new System.Drawing.Size(26, 17);
      this.tsStatus.Text = "Idle";
      // 
      // tsProgressBar
      // 
      this.tsProgressBar.Name = "tsProgressBar";
      this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(0, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(582, 244);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.comboBox1);
      this.tabPage1.Controls.Add(this.chkRestoreOverwrite);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.btnDbRestore);
      this.tabPage1.Controls.Add(this.lvFileList);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(574, 218);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Archives";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(8, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(106, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Available Snapshots:";
      // 
      // comboBox1
      // 
      this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(8, 189);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(443, 21);
      this.comboBox1.TabIndex = 8;
      // 
      // chkRestoreOverwrite
      // 
      this.chkRestoreOverwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.chkRestoreOverwrite.AutoSize = true;
      this.chkRestoreOverwrite.Location = new System.Drawing.Point(457, 169);
      this.chkRestoreOverwrite.Name = "chkRestoreOverwrite";
      this.chkRestoreOverwrite.Size = new System.Drawing.Size(109, 17);
      this.chkRestoreOverwrite.TabIndex = 7;
      this.chkRestoreOverwrite.Text = "Overwrite existing";
      this.chkRestoreOverwrite.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 170);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Restore To:";
      // 
      // btnDbRestore
      // 
      this.btnDbRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDbRestore.Location = new System.Drawing.Point(457, 189);
      this.btnDbRestore.Name = "btnDbRestore";
      this.btnDbRestore.Size = new System.Drawing.Size(109, 23);
      this.btnDbRestore.TabIndex = 5;
      this.btnDbRestore.Text = "Restore";
      this.btnDbRestore.UseVisualStyleBackColor = true;
      this.btnDbRestore.Click += new System.EventHandler(this.btnDbRestore_Click);
      // 
      // lvFileList
      // 
      this.lvFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lvFileList.Location = new System.Drawing.Point(8, 19);
      this.lvFileList.Name = "lvFileList";
      this.lvFileList.Size = new System.Drawing.Size(558, 144);
      this.lvFileList.TabIndex = 3;
      this.lvFileList.UseCompatibleStateImageBehavior = false;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.groupBox1);
      this.tabPage2.Controls.Add(this.btnSettingsCancel);
      this.tabPage2.Controls.Add(this.btnSettingsSave);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(574, 218);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Settings";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.btnSettingsBackupFolder);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtSettingNameFormat);
      this.groupBox1.Controls.Add(this.txtSettingsFolder);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(8, 15);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(558, 117);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Backup Settings";
      // 
      // btnSettingsBackupFolder
      // 
      this.btnSettingsBackupFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSettingsBackupFolder.Location = new System.Drawing.Point(498, 29);
      this.btnSettingsBackupFolder.Name = "btnSettingsBackupFolder";
      this.btnSettingsBackupFolder.Size = new System.Drawing.Size(54, 23);
      this.btnSettingsBackupFolder.TabIndex = 6;
      this.btnSettingsBackupFolder.Text = "...";
      this.btnSettingsBackupFolder.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Backup Folder:";
      // 
      // txtSettingNameFormat
      // 
      this.txtSettingNameFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSettingNameFormat.Location = new System.Drawing.Point(9, 81);
      this.txtSettingNameFormat.Name = "txtSettingNameFormat";
      this.txtSettingNameFormat.Size = new System.Drawing.Size(543, 20);
      this.txtSettingNameFormat.TabIndex = 5;
      this.txtSettingNameFormat.Text = "RR-%yyyy%-%mmdd%_%HHMM%%IsGolden%.bak";
      // 
      // txtSettingsFolder
      // 
      this.txtSettingsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSettingsFolder.Location = new System.Drawing.Point(9, 32);
      this.txtSettingsFolder.Name = "txtSettingsFolder";
      this.txtSettingsFolder.Size = new System.Drawing.Size(483, 20);
      this.txtSettingsFolder.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Name Format:";
      // 
      // btnSettingsCancel
      // 
      this.btnSettingsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSettingsCancel.Location = new System.Drawing.Point(410, 189);
      this.btnSettingsCancel.Name = "btnSettingsCancel";
      this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
      this.btnSettingsCancel.TabIndex = 3;
      this.btnSettingsCancel.Text = "Cancel";
      this.btnSettingsCancel.UseVisualStyleBackColor = true;
      // 
      // btnSettingsSave
      // 
      this.btnSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSettingsSave.Location = new System.Drawing.Point(491, 189);
      this.btnSettingsSave.Name = "btnSettingsSave";
      this.btnSettingsSave.Size = new System.Drawing.Size(75, 23);
      this.btnSettingsSave.TabIndex = 0;
      this.btnSettingsSave.Text = "Save";
      this.btnSettingsSave.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.label5);
      this.tabPage3.Controls.Add(this.lstAvailableDb);
      this.tabPage3.Controls.Add(this.btnDbBackup);
      this.tabPage3.Controls.Add(this.groupBox2);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(574, 218);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Backup";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 6);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(104, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Available Databases";
      // 
      // lstAvailableDb
      // 
      this.lstAvailableDb.FormattingEnabled = true;
      this.lstAvailableDb.Location = new System.Drawing.Point(6, 32);
      this.lstAvailableDb.Name = "lstAvailableDb";
      this.lstAvailableDb.Size = new System.Drawing.Size(285, 173);
      this.lstAvailableDb.TabIndex = 7;
      // 
      // btnDbBackup
      // 
      this.btnDbBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDbBackup.Location = new System.Drawing.Point(491, 189);
      this.btnDbBackup.Name = "btnDbBackup";
      this.btnDbBackup.Size = new System.Drawing.Size(75, 23);
      this.btnDbBackup.TabIndex = 6;
      this.btnDbBackup.Text = "Backup";
      this.btnDbBackup.UseVisualStyleBackColor = true;
      this.btnDbBackup.Click += new System.EventHandler(this.btnDbBackup_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.chkCompress);
      this.groupBox2.Controls.Add(this.chkIsGolden);
      this.groupBox2.Location = new System.Drawing.Point(395, 6);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(171, 71);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Options";
      // 
      // chkCompress
      // 
      this.chkCompress.AutoSize = true;
      this.chkCompress.Location = new System.Drawing.Point(6, 42);
      this.chkCompress.Name = "chkCompress";
      this.chkCompress.Size = new System.Drawing.Size(111, 17);
      this.chkCompress.TabIndex = 1;
      this.chkCompress.Text = "Compress backup";
      this.chkCompress.UseVisualStyleBackColor = true;
      // 
      // chkIsGolden
      // 
      this.chkIsGolden.AutoSize = true;
      this.chkIsGolden.Location = new System.Drawing.Point(6, 19);
      this.chkIsGolden.Name = "chkIsGolden";
      this.chkIsGolden.Size = new System.Drawing.Size(111, 17);
      this.chkIsGolden.TabIndex = 0;
      this.chkIsGolden.Text = "Mark as \"Golden\"";
      this.chkIsGolden.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 276);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.statusStrip1);
      this.Name = "MainForm";
      this.Text = "SQLRestore";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel tsStatus;
    private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button btnDbRestore;
    private System.Windows.Forms.ListView lvFileList;
    private System.Windows.Forms.TextBox txtSettingsFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSettingsSave;
    private System.Windows.Forms.Button btnSettingsCancel;
    private System.Windows.Forms.TextBox txtSettingNameFormat;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Button btnDbBackup;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox chkCompress;
    private System.Windows.Forms.CheckBox chkIsGolden;
    private System.Windows.Forms.CheckBox chkRestoreOverwrite;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSettingsBackupFolder;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ListBox lstAvailableDb;
  }
}

