/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-27
 * File:    Resource.cs
 * Description:
 *  Quick loader for embedded resources in this namespace
 *  
 * Change Log:
 *  2017-427 * Initial creation
 */

using System;
using System.IO;
using System.Reflection;

namespace Xeno.SQLRestore.Data.Database.Scripts
{
  public static class Resource
  {
    /// <summary>Load embedded resource</summary>
    /// <param name="fileName"></param>
    /// <returns>Contents of resource, otherwise an empty string on error.</returns>
    public static string Load(string fileName)
    {
      // USAGE:
      //    var buff = Data.Database.Scripts.Resource.Load("DbRestore.sql");

      string result = string.Empty;
      try
      {
        Type ns = typeof(Resource);
        var asm = Assembly.GetExecutingAssembly();
        var resName = ns.Namespace + "." + fileName;

        using (Stream stream = asm.GetManifestResourceStream(resName))
        using (StreamReader reader = new StreamReader(stream))
        {
          result = reader.ReadToEnd();
        }
      }
      catch(Exception)
      {
        //TODO: Report error for failure to load resource
        // Perhaps,  bool Load($fileName, $buffer) { T=Success, F=Failure }
      }

      return result;
    }

    /// <summary>Load embedded resource</summary>
    /// <param name="fileName">Name of resource</param>
    /// <param name="buffer">Contents of resource</param>
    /// <returns>True for success. False if encountered exception.</returns>
    public static bool Load(string fileName, out string buffer)
    {
      // USAGE:
      //    string buff;
      //    if (!Data.Database.Scripts.Resource.Load("DbRestore.sql", out buff))
      //      MessageBox.Show("Failed to load resource");

      string result = string.Empty;
      try
      {
        Type ns = typeof(Resource);
        var asm = Assembly.GetExecutingAssembly();
        var resName = ns.Namespace + "." + fileName;

        using (Stream stream = asm.GetManifestResourceStream(resName))
        using (StreamReader reader = new StreamReader(stream))
        {
          result = reader.ReadToEnd();
        }
      }
      catch (Exception)
      {
        //TODO: Report error for failure to load resource
        buffer = "";
        return false;
      }

      buffer = result;
      return true;
    }
  }
}
