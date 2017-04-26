/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-26
 * File:    SqlConnectionStruct.cs
 * Description:
 *  SqlServerDatabase Connection Structure
 * Change Log:
 *  2017-426 * Initial creation
 */

namespace Xeno.SQLRestore.Data.Database
{
  public struct SqlConnectionStruct
  {
    public bool IsTrustedConnection;
    public string Server;
    public string Database;
    public string UserName;
    public string Password;
  }
}
