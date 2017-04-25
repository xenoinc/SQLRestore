/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-12
 * File:    MSSqlHelpers.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-412 * Initial creation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xeno.SQLRestore.Data
{
  public class MSSqlHelpers
  {
    //private ConnectionInfo _connInfo;

    public MSSqlHelpers()
    {
      //_connInfo = new ConnectionInfo(".", "", "");
    }

    public bool TestConnection()
    {
      

      return false;
    }

    public List<string> GetAvailableDatabases()
    {
      List<string> list = new List<string>();
      string query = "select * from sys.databases;";

      return list;
    }
  }
}
