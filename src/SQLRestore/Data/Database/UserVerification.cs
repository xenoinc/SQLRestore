/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-20
 * File:    UserVerification.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-420 * Initial creation
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xeno.SQLRestore.Data.Database
{
  public static class UserVerification
  {
    public static bool CheckUserAccess(SqlConnection conn, string userName)
    {
      bool flag = false;

      SqlCommand sqlCommand = new SqlCommand("SELECT UserName FROM dbo.BT_Users WHERE UserName=@ID", conn);
      sqlCommand.Parameters.AddWithValue("@ID", (object)userName);
      SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

      if (sqlDataReader.HasRows)
        flag = true;

      sqlDataReader.Close();
      return flag;
    }

    public static void CreateUserAccess(SqlConnection conn, string userName)
    {
      SqlCommand sqlCommand = new SqlCommand("INSERT INTO BT_Users (UserName) VALUES (@ID)", conn);
      sqlCommand.Parameters.AddWithValue("@ID", (object)userName);
      sqlCommand.ExecuteNonQuery();
    }
  }
}
