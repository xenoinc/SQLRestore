/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-20
 * File:    IniFile
 * Description:
 *  Simple implemetion of Ini File read/writer
 *
 * Change Log:
 *  2017-420 * Initial creation
 */

using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Xeno.SQLRestore.Data.Providers
{
  public class IniFile
  {
    private const string INI_EXT = ".ini";
    private string _path;
    private string _exeName = Assembly.GetExecutingAssembly().GetName().Name;

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);

    public IniFile(string iniPath = null)
    {
      _path = new FileInfo(iniPath ?? _exeName + INI_EXT).FullName.ToString();
    }

    public string Read(string section, string key)
    {
      var retVal = new StringBuilder(255);
      GetPrivateProfileString(section ?? _exeName, key, "", retVal, 255, _path);
      return retVal.ToString();
    }

    public void Write(string section, string key, string value)
    {
      WritePrivateProfileString(section, key, value, _path);
    }

    //public void DeleteKey(string key, string section = null)
    //{
    //  Write(key, null, section ?? _exeName);
    //}
    //
    //public void DeleteSection(string section = null)
    //{
    //  Write(null, null, section ?? _exeName);
    //}
    //
    //public bool KeyExists(string key, string section = null)
    //{
    //  return Read(key, section).Length > 0;
    //}
  }
}
