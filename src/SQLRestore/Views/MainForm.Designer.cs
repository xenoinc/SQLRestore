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
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.chkCompress = new System.Windows.Forms.CheckBox();
      this.chkIsGolden = new System.Windows.Forms.CheckBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.lvFileList = new System.Windows.Forms.ListView();
      this.btnBackup = new System.Windows.Forms.Button();
      this.btnRestore = new System.Windows.Forms.Button();
      this.btnSettingsSave = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSettingsFolder = new System.Windows.Forms.TextBox();
      this.btnSettingsCancel = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSettingNameFormat = new System.Windows.Forms.TextBox();
      this.statusStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tabPage2.SuspendLayout();
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
      this.tabControl1.Location = new System.Drawing.Point(0, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(582, 244);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnRestore);
      this.tabPage1.Controls.Add(this.btnBackup);
      this.tabPage1.Controls.Add(this.lvFileList);
      this.tabPage1.Controls.Add(this.groupBox2);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(574, 218);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Archives";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.chkCompress);
      this.groupBox2.Controls.Add(this.chkIsGolden);
      this.groupBox2.Location = new System.Drawing.Point(395, 6);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(171, 71);
      this.groupBox2.TabIndex = 2;
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
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.txtSettingNameFormat);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.btnSettingsCancel);
      this.tabPage2.Controls.Add(this.txtSettingsFolder);
      this.tabPage2.Controls.Add(this.label1);
      this.tabPage2.Controls.Add(this.btnSettingsSave);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(574, 218);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Settings";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // lvFileList
      // 
      this.lvFileList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lvFileList.Location = new System.Drawing.Point(8, 6);
      this.lvFileList.Name = "lvFileList";
      this.lvFileList.Size = new System.Drawing.Size(284, 206);
      this.lvFileList.TabIndex = 3;
      this.lvFileList.UseCompatibleStateImageBehavior = false;
      // 
      // btnBackup
      // 
      this.btnBackup.Location = new System.Drawing.Point(491, 159);
      this.btnBackup.Name = "btnBackup";
      this.btnBackup.Size = new System.Drawing.Size(75, 23);
      this.btnBackup.TabIndex = 4;
      this.btnBackup.Text = "Backup";
      this.btnBackup.UseVisualStyleBackColor = true;
      // 
      // btnRestore
      // 
      this.btnRestore.Location = new System.Drawing.Point(491, 188);
      this.btnRestore.Name = "btnRestore";
      this.btnRestore.Size = new System.Drawing.Size(75, 23);
      this.btnRestore.TabIndex = 5;
      this.btnRestore.Text = "Restore";
      this.btnRestore.UseVisualStyleBackColor = true;
      // 
      // btnSettingsSave
      // 
      this.btnSettingsSave.Location = new System.Drawing.Point(491, 189);
      this.btnSettingsSave.Name = "btnSettingsSave";
      this.btnSettingsSave.Size = new System.Drawing.Size(75, 23);
      this.btnSettingsSave.TabIndex = 0;
      this.btnSettingsSave.Text = "Save";
      this.btnSettingsSave.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Backup Folder:";
      // 
      // txtSettingsFolder
      // 
      this.txtSettingsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSettingsFolder.Location = new System.Drawing.Point(9, 35);
      this.txtSettingsFolder.Name = "txtSettingsFolder";
      this.txtSettingsFolder.Size = new System.Drawing.Size(557, 20);
      this.txtSettingsFolder.TabIndex = 2;
      // 
      // btnSettingsCancel
      // 
      this.btnSettingsCancel.Location = new System.Drawing.Point(410, 189);
      this.btnSettingsCancel.Name = "btnSettingsCancel";
      this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
      this.btnSettingsCancel.TabIndex = 3;
      this.btnSettingsCancel.Text = "Cancel";
      this.btnSettingsCancel.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 94);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Name Format:";
      // 
      // txtSettingNameFormat
      // 
      this.txtSettingNameFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSettingNameFormat.Location = new System.Drawing.Point(11, 110);
      this.txtSettingNameFormat.Name = "txtSettingNameFormat";
      this.txtSettingNameFormat.Size = new System.Drawing.Size(557, 20);
      this.txtSettingNameFormat.TabIndex = 5;
      this.txtSettingNameFormat.Text = "RR-%yyyy%-%mmdd%_%HHMM%%IsGolden%.bak";
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
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
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
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox chkCompress;
    private System.Windows.Forms.CheckBox chkIsGolden;
    private System.Windows.Forms.Button btnRestore;
    private System.Windows.Forms.Button btnBackup;
    private System.Windows.Forms.ListView lvFileList;
    private System.Windows.Forms.TextBox txtSettingsFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSettingsSave;
    private System.Windows.Forms.Button btnSettingsCancel;
    private System.Windows.Forms.TextBox txtSettingNameFormat;
    private System.Windows.Forms.Label label2;
  }
}

