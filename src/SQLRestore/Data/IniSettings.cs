/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-12
 * File:    Settings.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-412 * Initial creation
 */

using Xeno.SQLRestore.Data.Providers;

namespace Xeno.SQLRestore.Data
{
  public static class IniSettings
  {
    private static IniFile _ini = new IniFile("SQLRestore.ini");

    public static string Get(string section, string key, string defaultValue = string.Empty)
    {
      string data = _ini.Read(section, key);
      if (data == string.Empty)
        data = defaultValue;
      return defaultValue;
    }

    public static void Set(string section, string key, string value)
    {
      _ini.Write(section, key, value);
    }

  }
}
