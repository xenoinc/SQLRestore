/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-10
 * File:    MainForm.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-410 * Initial creation
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Xeno.SQLRestore.Data;
using Xeno.SQLRestore.Data.Database;
using System.IO;
using System.Collections;
using System.Linq;

namespace Xeno.SQLRestore.Views
{
  public partial class MainForm : Form
  {
    #region Attributes & Properties
    
    public string Status
    {
      get { return tsStatus.Text; }
      set
      {
        if (string.IsNullOrEmpty(value))
          tsStatus.Text = "Idle";
        else
          tsStatus.Text = value;
      }
    }

    public int Progress
    {
      get { return tsProgressBar.Value; }
      set { tsProgressBar.Value = value; }
    }


    #endregion Attributes & Properties

    #region UI Events

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // later
      //RefreshBackupList();

      //RefreshDatabaseList();

      //this.Status = "";
    }

    private void btnSqlTest_Click(object sender, EventArgs e)
    {
      this.ConnectionTest();
    }

    private void btnDbBackup_Click(object sender, EventArgs e)
    {
      string folder = AppSettings.BackupFolder;
      string file = AppSettings.BackupFileFormat;
      string dbName = string.Empty;
      //if (!System.IO.Directory.Exists(folder))
      //{
      //  this.Status = "Missing output directory.";
      //  MessageBox.Show("Missing output directory.");
      //  return;
      //}

      //if (string.IsNullOrEmpty(file))
      //{
      //  this.Status = "Missing output file format.";
      //  MessageBox.Show("Missing output file format.");
      //  return;
      //}

      //int index = lstAvailableDb.SelectedIndex;
      //if (index == -1)
      //{
      //  this.Status = "Must select a DB to begin.";
      //  MessageBox.Show("Must select a DB to begin.");
      //  return;
      //}
      //dbName = lstAvailableDb.SelectedItem.ToString();

      DbBackup(dbName, folder, file);
    }

    private void btnDbRestore_Click(object sender, EventArgs e)
    {
      int index = lstAvailableDb.SelectedIndex;
      if (index > -1)
      {
        string dbName = lstAvailableDb.SelectedItem.ToString();
        DbRestore(dbName);
      }
      else
      {
        MessageBox.Show("Select a DB to backup.");
      }
    }

    private void btnSqlDbRefresh_Click(object sender, EventArgs e)
    {
      RefreshDatabaseList();
    }

    private void mnuOptions_Click(object sender, EventArgs e)
    {
      Form frm = new Views.SettingsForm();
      if (frm.ShowDialog(this) == DialogResult.OK)
      {

      }
      frm.Dispose();

    }

    #endregion UI Events

    #region Private Methods

    private SqlConnectionStruct DbConnStruct(string defaultDatabase)
    {
      return new SqlConnectionStruct
      {
        IsTrustedConnection = false,
        Server = AppSettings.DbServer,
        Database = defaultDatabase,
        UserName = AppSettings.DbUserName,
        Password = AppSettings.DbUserPass
      };
    }

    private void ConnectionTest()
    {
      this.Status = "Testing connection...";
      try
      {
        SqlServerDatabase db = new Data.Database.SqlServerDatabase(DbConnStruct(""));
        db.Connect();
        db.Disconnect();

        this.Status = "Connection OK!";
      }
      catch(Exception)
      {
        this.Status = "Connection failed";
      }
    }

    private void RefreshDatabaseList()
    {
      try
      {
        lstAvailableDb.Items.Clear();
        using (SqlServerDatabase db = new Data.Database.SqlServerDatabase(DbConnStruct("")))
        {
          db.Connect();

          //string query = "select * from master.sys.databases";
          DataTable databases = db.Connection.GetSchema("Databases");
          foreach (DataRow row in databases.Rows)
          {
            string dbName = row.Field<string>("database_name");
            short dbId = row.Field<short>("dbid");
            DateTime dttm = row.Field<DateTime>("create_date");

            lstAvailableDb.Items.Add(dbName);
          }
          //db.Disconnect();

        }
        
        //con.Open();
        //DataTable databases = con.GetSchema("Databases");
        //foreach (DataRow database in databases.Rows)
        //{
        //  String databaseName = database.Field<String>("database_name");
        //  short dbID = database.Field<short>("dbid");
        //  DateTime creationDate = database.Field<DateTime>("create_date");
        //}


        this.Status = "";
      }
      catch(Exception e)
      {
        this.Status = "Failed to connect.";
        //Log(LogType.Error, "RefreshDatabase() " + e.Message);
        MessageBox.Show(e.Message);
      }
    }

    private void RefreshBackupList()
    {
      //MessageBox.Show("feature not implemented");
    }

    private void DbBackup(string dbName, string folder, string fileFormat)
    {

      //foreach (var assemblyName in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
      //{
      //  Assembly assembly = Assembly.Load(assemblyName);
      //  foreach (var type in assembly.GetTypes())
      //  {
      //    Console.WriteLine(type.Name);
      //  }
      //}

      //var asm = Assembly.GetExecutingAssembly();
      //var resourceName = "Xeno.Data.Database.Scripts.GetServerList.sql";
      //MessageBox.Show(asm.GetManifestResourceNames().ToString());

      //using (Stream stream = asm.GetManifestResourceStream(resourceName))
      //using(StreamReader reader = new StreamReader(stream))
      //{
      //  string result = reader.ReadToEnd();
      //
      //  MessageBox.Show(result);
      //}

    }


    private void DbRestore(string fileName)
    {
      //MessageBox.Show("feature not implemented");
    }

    #endregion Private Methods

    #region Tests
    private void button1_Click(object sender, EventArgs e)
    {
      TestGetResources();
    }

    private void TestGetResources()
    {
      //string[] resourceNames = this.GetType().Assembly.GetManifestResourceNames();

      //string[] resourceNames = Helpers.GetAllResources();
      //foreach (string resourceName in resourceNames)
      //{
      //  System.Diagnostics.Trace.WriteLine(resourceName);
      //}

      //  Xeno.SQLRestore.Properties.Resources.resources
      //  Xeno.SQLRestore.Views.MainForm.resources
      //  Xeno.SQLRestore.Views.SettingsForm.resources
      //  Xeno.SQLRestore.Data.Database.Scripts.DbRestore.sql
      //  Xeno.SQLRestore.Data.Database.Scripts.DbBackup.sql
      //  Xeno.SQLRestore.Data.Database.Scripts.GetServerList.sql

      var buff = Helpers.GetStringFromResource("Xeno.SQLRestore.Data.Database.Scripts.DbRestore.sql");

      var sql = string.Format(buff, "mypath", "usecopyonly");
      MessageBox.Show(sql);

    }

    #endregion Tests

  }
}
