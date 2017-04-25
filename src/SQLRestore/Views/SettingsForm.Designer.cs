/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-20
 * File:    SettingsForm.Designer.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-420 * Initial creation
 */

namespace Xeno.SQLRestore.Views
{
  partial class SettingsForm
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
      this.btnSettingsCancel = new System.Windows.Forms.Button();
      this.btnSettingsSave = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSettingsBackupFolder = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSettingNameFormat = new System.Windows.Forms.TextBox();
      this.txtSettingsFolder = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.radioSqlLoginTrusted = new System.Windows.Forms.RadioButton();
      this.radioSqlLoginUser = new System.Windows.Forms.RadioButton();
      this.cmboSqlHost = new System.Windows.Forms.ComboBox();
      this.txtSqlPassword = new System.Windows.Forms.TextBox();
      this.txtSqlUser = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnSettingsCancel
      // 
      this.btnSettingsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSettingsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSettingsCancel.Location = new System.Drawing.Point(245, 290);
      this.btnSettingsCancel.Name = "btnSettingsCancel";
      this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
      this.btnSettingsCancel.TabIndex = 5;
      this.btnSettingsCancel.Text = "Cancel";
      this.btnSettingsCancel.UseVisualStyleBackColor = true;
      this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
      // 
      // btnSettingsSave
      // 
      this.btnSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSettingsSave.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnSettingsSave.Location = new System.Drawing.Point(326, 290);
      this.btnSettingsSave.Name = "btnSettingsSave";
      this.btnSettingsSave.Size = new System.Drawing.Size(75, 23);
      this.btnSettingsSave.TabIndex = 4;
      this.btnSettingsSave.Text = "Save";
      this.btnSettingsSave.UseVisualStyleBackColor = true;
      this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
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
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(389, 122);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Backup Settings";
      // 
      // btnSettingsBackupFolder
      // 
      this.btnSettingsBackupFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSettingsBackupFolder.Location = new System.Drawing.Point(329, 29);
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
      this.txtSettingNameFormat.Size = new System.Drawing.Size(374, 20);
      this.txtSettingNameFormat.TabIndex = 5;
      this.txtSettingNameFormat.Text = "RR-%yyyy%-%mmdd%_%HHMM%%IsGolden%.bak";
      // 
      // txtSettingsFolder
      // 
      this.txtSettingsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSettingsFolder.Location = new System.Drawing.Point(9, 32);
      this.txtSettingsFolder.Name = "txtSettingsFolder";
      this.txtSettingsFolder.Size = new System.Drawing.Size(314, 20);
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
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.radioSqlLoginTrusted);
      this.groupBox2.Controls.Add(this.radioSqlLoginUser);
      this.groupBox2.Controls.Add(this.cmboSqlHost);
      this.groupBox2.Controls.Add(this.txtSqlPassword);
      this.groupBox2.Controls.Add(this.txtSqlUser);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Location = new System.Drawing.Point(12, 140);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(389, 135);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "MS SQL Connection";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(18, 99);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(33, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Pass:";
      // 
      // radioSqlLoginTrusted
      // 
      this.radioSqlLoginTrusted.AutoSize = true;
      this.radioSqlLoginTrusted.Enabled = false;
      this.radioSqlLoginTrusted.Location = new System.Drawing.Point(148, 97);
      this.radioSqlLoginTrusted.Name = "radioSqlLoginTrusted";
      this.radioSqlLoginTrusted.Size = new System.Drawing.Size(118, 17);
      this.radioSqlLoginTrusted.TabIndex = 11;
      this.radioSqlLoginTrusted.Text = "Trusted Connection";
      this.radioSqlLoginTrusted.UseVisualStyleBackColor = true;
      // 
      // radioSqlLoginUser
      // 
      this.radioSqlLoginUser.AutoSize = true;
      this.radioSqlLoginUser.Checked = true;
      this.radioSqlLoginUser.Enabled = false;
      this.radioSqlLoginUser.Location = new System.Drawing.Point(57, 97);
      this.radioSqlLoginUser.Name = "radioSqlLoginUser";
      this.radioSqlLoginUser.Size = new System.Drawing.Size(71, 17);
      this.radioSqlLoginUser.TabIndex = 10;
      this.radioSqlLoginUser.TabStop = true;
      this.radioSqlLoginUser.Text = "SQL User";
      this.radioSqlLoginUser.UseVisualStyleBackColor = true;
      // 
      // cmboSqlHost
      // 
      this.cmboSqlHost.FormattingEnabled = true;
      this.cmboSqlHost.Location = new System.Drawing.Point(57, 18);
      this.cmboSqlHost.Name = "cmboSqlHost";
      this.cmboSqlHost.Size = new System.Drawing.Size(326, 21);
      this.cmboSqlHost.TabIndex = 9;
      // 
      // txtSqlPassword
      // 
      this.txtSqlPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSqlPassword.Location = new System.Drawing.Point(57, 71);
      this.txtSqlPassword.Name = "txtSqlPassword";
      this.txtSqlPassword.Size = new System.Drawing.Size(326, 20);
      this.txtSqlPassword.TabIndex = 8;
      // 
      // txtSqlUser
      // 
      this.txtSqlUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSqlUser.Location = new System.Drawing.Point(57, 45);
      this.txtSqlUser.Name = "txtSqlUser";
      this.txtSqlUser.Size = new System.Drawing.Size(326, 20);
      this.txtSqlUser.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(18, 74);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "Pass:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(19, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 13);
      this.label4.TabIndex = 1;
      this.label4.Text = "User:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 22);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Server:";
      // 
      // SettingsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(413, 325);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnSettingsCancel);
      this.Controls.Add(this.btnSettingsSave);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "SettingsForm";
      this.Text = "SettingsForm";
      this.Load += new System.EventHandler(this.SettingsForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSettingsCancel;
    private System.Windows.Forms.Button btnSettingsSave;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSettingsBackupFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSettingNameFormat;
    private System.Windows.Forms.TextBox txtSettingsFolder;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtSqlPassword;
    private System.Windows.Forms.TextBox txtSqlUser;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.RadioButton radioSqlLoginTrusted;
    private System.Windows.Forms.RadioButton radioSqlLoginUser;
    private System.Windows.Forms.ComboBox cmboSqlHost;
  }
}