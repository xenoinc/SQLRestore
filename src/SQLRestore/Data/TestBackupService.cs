/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-12
 * File:    CheapTests.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-412 * Initial creation
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;

namespace Xeno.SQLRestore.Data
{
  public class TestBackupService
  {
    private readonly string _connectionString;
    private readonly string _backupFolderFullPath;
    private readonly string[] _systemDatabaseNames = { "master", "tempdb", "model", "msdb" };

    public TestBackupService(string connectionString, string backupFolderFullPath)
    {
      _connectionString = connectionString;
      _backupFolderFullPath = backupFolderFullPath;
    }

    public void BackupAllUserDatabases()
    {
      foreach (string databaseName in GetAllUserDatabases())
      {
        BackupDatabase(databaseName);
      }
    }

    public void BackupDatabase(string databaseName)
    {
      string filePath = BuildBackupPathWithFilename(databaseName);

      using (var connection = new SqlConnection(_connectionString))
      {
        var query = String.Format("BACKUP DATABASE [{0}] TO DISK='{1}'", databaseName, filePath);

        using (var command = new SqlCommand(query, connection))
        {
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }

    private IEnumerable<string> GetAllUserDatabases()
    {
      var databases = new List<String>();

      DataTable databasesTable;

      using (var connection = new SqlConnection(_connectionString))
      {
        connection.Open();

        databasesTable = connection.GetSchema("Databases");

        connection.Close();
      }

      foreach (DataRow row in databasesTable.Rows)
      {
        string databaseName = row["database_name"].ToString();

        if (_systemDatabaseNames.Contains(databaseName))
          continue;

        databases.Add(databaseName);
      }

      return databases;
    }

    private string BuildBackupPathWithFilename(string databaseName)
    {
      string filename = string.Format("{0}-{1}.bak", databaseName, DateTime.Now.ToString("yyyy-MM-dd"));

      return Path.Combine(_backupFolderFullPath, filename);
    }
  }
}
