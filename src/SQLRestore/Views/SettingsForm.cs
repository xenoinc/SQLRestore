/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-20
 * File:    SettingsForm.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-420 * Initial creation
 */

using System;
using System.Windows.Forms;
using Xeno.SQLRestore.Data;

namespace Xeno.SQLRestore.Views
{
  public partial class SettingsForm : Form
  {
    public SettingsForm()
    {
      InitializeComponent();
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
      ReadSettings();
    }

    private void btnSettingsSave_Click(object sender, EventArgs e)
    {
      SaveSettings();
      this.Close();
    }


    private void btnSettingsCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ReadSettings()
    {
      txtSettingsFolder.Text = AppSettings.BackupFolder;
      txtSettingNameFormat.Text = AppSettings.BackupFileFormat;

      cmboSqlHost.Text = AppSettings.DbServer;
      txtSqlUser.Text = AppSettings.DbUserName;
      txtSqlPassword.Text = AppSettings.DbUserPass;
    }

    private void SaveSettings()
    {
      AppSettings.BackupFolder = txtSettingsFolder.Text;
      AppSettings.BackupFileFormat = txtSettingNameFormat.Text;

      AppSettings.DbServer = cmboSqlHost.Text;
      AppSettings.DbUserName = txtSqlUser.Text;
      AppSettings.DbUserPass = txtSqlPassword.Text;
    }

  }
}
