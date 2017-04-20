/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-20
 * File:    Key.cs
 * Description:
 *  Simple default sections for INI based settings.
 *  yes, yes, we'll be moving to a better format (JSON) one day
 *  
 * To Do:
 * Change Log:
 *  2017-420 * Initial creation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xeno.SQLRestore.Data.Settings
{
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
    public const string SysFileFormat = "FileFormat";

    // Database settings
    public const string SqlEngine = "Engine"; // MSSQL, MySQL, etc.
    public const string SqlHostName = "HostName";
    public const string SqlUser = "User";
    public const string SqlPassword = "Password";
  }
}
