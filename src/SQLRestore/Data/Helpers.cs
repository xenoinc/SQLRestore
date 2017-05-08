/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-26
 * File:    Helpers.cs
 * Description:
 *
 * To Do:
 * Change Log:
 *  2017-426 * Initial creation
 */

using System.IO;
using System.Reflection;

namespace Xeno.SQLRestore.Data
{
  public static class Helpers
  {
    public static string GetStringFromResource(string resName)
    {
      string result = string.Empty;

      var asm = Assembly.GetExecutingAssembly();
      using (Stream stream = asm.GetManifestResourceStream(resName))
      using (StreamReader reader = new StreamReader(stream))
      {
        result = reader.ReadToEnd();
      }

      return result;
    }

    public static string[] GetAllResources()
    {
      var asm = Assembly.GetExecutingAssembly();
      string[] resNames = asm.GetManifestResourceNames();
      return resNames;

      // Alt:
      //  string[] resourceNames = this.GetType().Assembly.GetManifestResourceNames();
      //  foreach (string name in resNames)
      //    System.Diagnostics.Trace.WriteLine(name);
    }
  }
}
