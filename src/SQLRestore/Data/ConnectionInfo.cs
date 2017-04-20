/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-12
 * File:    ConnectionInfo.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-412 * Initial creation
 */

namespace Xeno.SQLRestore.Data
{
  public class ConnectionInfo
  {
    public string Host { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    private readonly string _baseConnection = "Data Source={0};Initial Catalog={1};User Id={2};Password={3}";

    public string ConnectoinString
    {
      get
      {
        return "";
      }
    }
    public ConnectionInfo(string host, string user, string pass)
    {
      Host = host;
      UserName = user;
      Password = pass;
    }
  }
}
