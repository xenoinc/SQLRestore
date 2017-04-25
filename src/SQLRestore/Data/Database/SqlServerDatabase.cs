/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-21
 * File:    SqlServerDatabase.cs
 * Description:
 *
 * References:
 *  https://www.connectionstrings.com/sql-server/
 *
 * Change Log:
 *  2017-421 * Initial creation
 */

using System;
using System.Data;
using System.Data.SqlClient;

namespace Xeno.SQLRestore.Data.Database
{
  public struct SqlConnectionStruct 
    // : IDisposable
  {
    public bool IsTrustedConnection;
    public string Server;
    public string Database;
    public string UserName;
    public string Password;
  }

  public class SqlServerDatabase
  {
    private SqlConnection _conn;

    #region Properties

    public SqlConnection Connection { get { return _conn; } }

    public string ConnectionString
    {
      get
      {
        if (IsTrustedConection)
          return $"Server={Server};Database={Database};Trusted_Connection=True";
        else
          return $"Data Source={Server};Initial Catalog={Database};User ID={UserName};Password={Password}";
      }
    }

    public bool IsTrustedConection { get; set; }

    public string Server { get; set; }

    public string Database { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public ConnectionState State
    {
      get
      {
        return _conn.State;
      }
    }

    #endregion Properties

    #region Constructors

    public SqlServerDatabase()
    {
      IsTrustedConection = false;
    }

    public SqlServerDatabase(string host, string database, string user, string pass, bool trustedConnection = false)
    {
      IsTrustedConection = trustedConnection;
      Server = host;
      Database = database;
      UserName = user;
      Password = pass;
    }

    public SqlServerDatabase(SqlConnectionStruct connStruct)
    {
      IsTrustedConection = connStruct.IsTrustedConnection;
      Server = connStruct.Server;
      Database = connStruct.Database;
      UserName = connStruct.UserName;
      Password = connStruct.Password;
    }

    //private System.ComponentModel.IContainer _components = null;
    //
    ///// <summary>Clean up any resources being used.</summary>
    ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && (_components != null))
    //  {
    //    _components.Dispose();
    //  }
    //  base.Dispose(disposing);
    //}

    #endregion Constructors

    #region Methods

    public void Connect()
    {
      try
      {
        _conn = new SqlConnection(ConnectionString);
        _conn.Open();
      }
      catch(Exception)
      {
        throw;
      }
    }

    public async void ConnectAsync()
    {
      _conn = new SqlConnection(ConnectionString);
      await _conn.OpenAsync();
    }

    public void Disconnect()
    {
      _conn.Close();
    }

    /// <summary>Execute query while maintaining an active connection</summary>
    /// <param name="query"></param>
    public void ExecuteQuery(string query)
    {
      SqlCommand cmd = new SqlCommand(query, _conn);
      cmd.ExecuteNonQuery();
    }

    /// <summary>Execute query without maintaining an active connection</summary>
    /// <param name="query"></param>
    public void ExecuteQueryOnce(string query)
    {
      using (SqlConnection connection = new SqlConnection(ConnectionString))
      {
        connection.Open();
        SqlCommand command = new SqlCommand(query, connection);
        command.ExecuteNonQuery();
      }
    }

    public SqlDataReader DataReader(string query)
    {
      //using (SqlDataReader reader = command.ExecuteReader())
      //{
      //  Console.WriteLine("FirstColumn\tSecond Column\t\tThird Column\t\tForth Column\t");
      //  while (reader.Read())
      //  {
      //    Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}",
      //        reader[0], reader[1], reader[2], reader[3]));
      //  }
      //}
      SqlCommand cmd = new SqlCommand(query, _conn);
      SqlDataReader dr = cmd.ExecuteReader();
      return dr;
    }

    public DataSet SelectQuery(string query)
    {
      DataSet dSet = new DataSet();

      try
      {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
          connection.Open();
          SqlDataAdapter DA = new SqlDataAdapter(query, connection);
          DA.Fill(dSet);
        }
      }
      catch (Exception)
      {
        // Log the error
      }
      return dSet;
    }

    #endregion Methods
  }
}
