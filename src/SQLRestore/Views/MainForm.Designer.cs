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
      this.tabBackup = new System.Windows.Forms.TabPage();
      this.button1 = new System.Windows.Forms.Button();
      this.btnSqlTest = new System.Windows.Forms.Button();
      this.btnSqlDbRefresh = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.lstAvailableDb = new System.Windows.Forms.ListBox();
      this.btnDbBackup = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.chkCompress = new System.Windows.Forms.CheckBox();
      this.chkIsGolden = new System.Windows.Forms.CheckBox();
      this.tabArchive = new System.Windows.Forms.TabPage();
      this.btnRefreshArchive = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.chkRestoreOverwrite = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnDbRestore = new System.Windows.Forms.Button();
      this.lvFileList = new System.Windows.Forms.ListView();
      this.tabExtras = new System.Windows.Forms.TabPage();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabBackup.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tabArchive.SuspendLayout();
      this.tabExtras.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsStatus,
            this.tsProgressBar});
      this.statusStrip1.Location = new System.Drawing.Point(0, 299);
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
      this.tsStatus.Size = new System.Drawing.Size(70, 17);
      this.tsStatus.Text = "Idleasdfasdf";
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
      this.tabControl1.Controls.Add(this.tabBackup);
      this.tabControl1.Controls.Add(this.tabArchive);
      this.tabControl1.Controls.Add(this.tabExtras);
      this.tabControl1.Location = new System.Drawing.Point(0, 27);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(582, 274);
      this.tabControl1.TabIndex = 2;
      // 
      // tabBackup
      // 
      this.tabBackup.Controls.Add(this.button1);
      this.tabBackup.Controls.Add(this.btnSqlTest);
      this.tabBackup.Controls.Add(this.btnSqlDbRefresh);
      this.tabBackup.Controls.Add(this.label5);
      this.tabBackup.Controls.Add(this.lstAvailableDb);
      this.tabBackup.Controls.Add(this.btnDbBackup);
      this.tabBackup.Controls.Add(this.groupBox2);
      this.tabBackup.Location = new System.Drawing.Point(4, 22);
      this.tabBackup.Name = "tabBackup";
      this.tabBackup.Padding = new System.Windows.Forms.Padding(3);
      this.tabBackup.Size = new System.Drawing.Size(574, 248);
      this.tabBackup.TabIndex = 2;
      this.tabBackup.Text = "Backup";
      this.tabBackup.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(456, 149);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(112, 23);
      this.button1.TabIndex = 13;
      this.button1.Text = "Resource Test";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnSqlTest
      // 
      this.btnSqlTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSqlTest.Location = new System.Drawing.Point(187, 6);
      this.btnSqlTest.Name = "btnSqlTest";
      this.btnSqlTest.Size = new System.Drawing.Size(121, 23);
      this.btnSqlTest.TabIndex = 12;
      this.btnSqlTest.Text = "Connection Test";
      this.btnSqlTest.UseVisualStyleBackColor = true;
      this.btnSqlTest.Click += new System.EventHandler(this.btnSqlTest_Click);
      // 
      // btnSqlDbRefresh
      // 
      this.btnSqlDbRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSqlDbRefresh.Location = new System.Drawing.Point(314, 6);
      this.btnSqlDbRefresh.Name = "btnSqlDbRefresh";
      this.btnSqlDbRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnSqlDbRefresh.TabIndex = 11;
      this.btnSqlDbRefresh.Text = "Refresh";
      this.btnSqlDbRefresh.UseVisualStyleBackColor = true;
      this.btnSqlDbRefresh.Click += new System.EventHandler(this.btnSqlDbRefresh_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 6);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(107, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Available Databases:";
      // 
      // lstAvailableDb
      // 
      this.lstAvailableDb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstAvailableDb.FormattingEnabled = true;
      this.lstAvailableDb.Location = new System.Drawing.Point(6, 32);
      this.lstAvailableDb.Name = "lstAvailableDb";
      this.lstAvailableDb.Size = new System.Drawing.Size(383, 199);
      this.lstAvailableDb.TabIndex = 7;
      // 
      // btnDbBackup
      // 
      this.btnDbBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDbBackup.Location = new System.Drawing.Point(493, 219);
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
      // tabArchive
      // 
      this.tabArchive.Controls.Add(this.btnRefreshArchive);
      this.tabArchive.Controls.Add(this.label4);
      this.tabArchive.Controls.Add(this.comboBox1);
      this.tabArchive.Controls.Add(this.chkRestoreOverwrite);
      this.tabArchive.Controls.Add(this.label3);
      this.tabArchive.Controls.Add(this.btnDbRestore);
      this.tabArchive.Controls.Add(this.lvFileList);
      this.tabArchive.Location = new System.Drawing.Point(4, 22);
      this.tabArchive.Name = "tabArchive";
      this.tabArchive.Padding = new System.Windows.Forms.Padding(3);
      this.tabArchive.Size = new System.Drawing.Size(574, 248);
      this.tabArchive.TabIndex = 0;
      this.tabArchive.Text = "Archives";
      this.tabArchive.UseVisualStyleBackColor = true;
      // 
      // btnRefreshArchive
      // 
      this.btnRefreshArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRefreshArchive.Location = new System.Drawing.Point(491, 6);
      this.btnRefreshArchive.Name = "btnRefreshArchive";
      this.btnRefreshArchive.Size = new System.Drawing.Size(75, 23);
      this.btnRefreshArchive.TabIndex = 10;
      this.btnRefreshArchive.Text = "Refresh";
      this.btnRefreshArchive.UseVisualStyleBackColor = true;
      this.btnRefreshArchive.Click += new System.EventHandler(this.btnRefreshArchive_Click);
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
      this.comboBox1.Enabled = false;
      this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(8, 219);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(443, 21);
      this.comboBox1.TabIndex = 8;
      this.comboBox1.Text = "(use listbox on Backup tab for now)";
      // 
      // chkRestoreOverwrite
      // 
      this.chkRestoreOverwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.chkRestoreOverwrite.AutoSize = true;
      this.chkRestoreOverwrite.Location = new System.Drawing.Point(457, 199);
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
      this.label3.Enabled = false;
      this.label3.Location = new System.Drawing.Point(8, 200);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Restore To:";
      // 
      // btnDbRestore
      // 
      this.btnDbRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDbRestore.Location = new System.Drawing.Point(457, 219);
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
      this.lvFileList.Location = new System.Drawing.Point(8, 35);
      this.lvFileList.Name = "lvFileList";
      this.lvFileList.Size = new System.Drawing.Size(558, 158);
      this.lvFileList.TabIndex = 3;
      this.lvFileList.UseCompatibleStateImageBehavior = false;
      this.lvFileList.View = System.Windows.Forms.View.List;
      // 
      // tabExtras
      // 
      this.tabExtras.Controls.Add(this.splitContainer1);
      this.tabExtras.Location = new System.Drawing.Point(4, 22);
      this.tabExtras.Name = "tabExtras";
      this.tabExtras.Padding = new System.Windows.Forms.Padding(3);
      this.tabExtras.Size = new System.Drawing.Size(574, 248);
      this.tabExtras.TabIndex = 3;
      this.tabExtras.Text = "Pre-Post Exections";
      this.tabExtras.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
      this.splitContainer1.Size = new System.Drawing.Size(568, 242);
      this.splitContainer1.SplitterDistance = 354;
      this.splitContainer1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.checkBox2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.checkBox1);
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(348, 236);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Backup Executions";
      // 
      // textBox2
      // 
      this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox2.Enabled = false;
      this.textBox2.Location = new System.Drawing.Point(6, 145);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(336, 85);
      this.textBox2.TabIndex = 3;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Enabled = false;
      this.checkBox2.Location = new System.Drawing.Point(6, 126);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(142, 17);
      this.checkBox2.TabIndex = 2;
      this.checkBox2.Text = "Post-Backup Executions";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Enabled = false;
      this.textBox1.Location = new System.Drawing.Point(6, 35);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(336, 85);
      this.textBox1.TabIndex = 1;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Enabled = false;
      this.checkBox1.Location = new System.Drawing.Point(6, 19);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(137, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "Pre-Backup Executions";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Location = new System.Drawing.Point(3, 3);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(207, 236);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Restore Executions";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(582, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuOptions
      // 
      this.mnuOptions.Name = "mnuOptions";
      this.mnuOptions.Size = new System.Drawing.Size(61, 20);
      this.mnuOptions.Text = "Options";
      this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 321);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "SQLRestore";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabBackup.ResumeLayout(false);
      this.tabBackup.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.tabArchive.ResumeLayout(false);
      this.tabArchive.PerformLayout();
      this.tabExtras.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel tsStatus;
    private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabArchive;
    private System.Windows.Forms.Button btnDbRestore;
    private System.Windows.Forms.ListView lvFileList;
    private System.Windows.Forms.TabPage tabBackup;
    private System.Windows.Forms.Button btnDbBackup;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox chkCompress;
    private System.Windows.Forms.CheckBox chkIsGolden;
    private System.Windows.Forms.CheckBox chkRestoreOverwrite;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ListBox lstAvailableDb;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuOptions;
    private System.Windows.Forms.Button btnSqlDbRefresh;
    private System.Windows.Forms.Button btnSqlTest;
    private System.Windows.Forms.TabPage tabExtras;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnRefreshArchive;
  }
}

