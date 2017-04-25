/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-12
 * File:    AppSettings.cs
 * Description:
 *  Quick and dirty settings class
 *  Go ahead and laugh at this 7th grader format
 *
 * To Do:
 *  [ ] Move to a JSON or XML format system, so we can store multiple credientials
 *
 * Change Log:
 *  2017-0424 * Renamed from Settings to AppSettings to not conflict w/ PROJ.Properties.Settings
 *  2017-0412 * Initial creation
 */

using Xeno.SQLRestore.Data.Providers;

namespace Xeno.SQLRestore.Data
{
  public static class AppSettings
  {
    private static IniFile _ini = new IniFile("SQLRestore.ini");

    #region Manual get and set

    public static string Get(string section, string key, string defaultValue = "")
    {
      string data = _ini.Read(section, key);
      if (data == string.Empty)
        data = defaultValue;

      return data;
    }

    public static void Set(string section, string key, string value)
    {
      _ini.Write(section, key, value);
    }

    #endregion Manual get and set

    #region Settings

    /// <summary>Backup folder</summary>
    public static string BackupFolder
    {
      get { return Get(Section.System, Key.SysBackupFolder); }
      set { Set(Section.System, Key.SysBackupFolder, value); }
    }

    /// <summary>Backup file format</summary>
    public static string BackupFileFormat
    {
      get { return Get(Section.System, Key.SysBackupFileFormat); }
      set { Set(Section.System, Key.SysBackupFileFormat, value); }
    }

    /// <summary>Hostname</summary>
    public static string DbServer
    {
      get { return Get(Section.Database, Key.SqlEngine); }
      set { Set(Section.Database, Key.SqlEngine, value); }
    }

    /// <summary>User name</summary>
    public static string DbUserName
    {
      get { return Get(Section.Database, Key.SqlUser); }
      set { Set(Section.Database, Key.SqlUser, value); }
    }

    /// <summary>Password</summary>
    public static string DbUserPass
    {
      get { return Get(Section.Database, Key.SqlPassword); }
      set { Set(Section.Database, Key.SqlPassword, value); }
    }

    /// <summary>Trusted Database Connection</summary>
    public static bool DbConnIsTrusted
    {
      get
      {
        string val = Get(Section.Database, Key.SqlConnIsTrusted, "0");
        if (val == "0") return false; else return true;
      }

      set
      {
        if (value == true)
          Set(Section.Database, Key.SqlConnIsTrusted, "1");
        else
          Set(Section.Database, Key.SqlConnIsTrusted, "0");
      }
    }

    #endregion Settings

  }

  public static class Section
  {
    public const string System = "System";
    public const string Account = "Account";
    public const string Database = "Database";
  }

  public static class Key
  {
    // System
    public const string SysBackupFolder = "BackupPth";
    public const string SysBackupFileFormat = "FileFormat";

    // Database settings
    public const string SqlEngine = "Engine"; // MSSQL, MySQL, etc.
    public const string SqlHostName = "HostName";
    public const string SqlUser = "User";
    public const string SqlPassword = "Password";
    public const string SqlConnIsTrusted = "ConnIsTrusted";
  }
}
