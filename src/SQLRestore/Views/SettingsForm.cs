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
using Xeno.SQLRestore.Data.Settings;

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
      txtSettingsFolder.Text = IniSettings.Get(Section.System, Key.SysBackupFolder);
      txtSettingNameFormat.Text = IniSettings.Get(Section.System, Key.SysFileFormat);

      cmboSqlHost.Text = IniSettings.Get(Section.Database, Key.SqlEngine);
      txtSqlUser.Text = IniSettings.Get(Section.Database, Key.SqlUser);
      txtSqlPassword.Text = IniSettings.Get(Section.Database, Key.SqlPassword);
    }

    private void SaveSettings()
    {
      IniSettings.Set(Section.System, Key.SysBackupFolder, txtSettingsFolder.Text);
      IniSettings.Set(Section.System, Key.SysFileFormat, txtSettingNameFormat.Text);

      IniSettings.Set(Section.Database, Key.SqlEngine, cmboSqlHost.Text);
      IniSettings.Set(Section.Database, Key.SqlUser, txtSqlUser.Text);
      IniSettings.Set(Section.Database, Key.SqlPassword, txtSqlPassword.Text);
    }

  }
}
