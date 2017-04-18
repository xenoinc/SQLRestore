/* Copyright Xeno Innovations, Inc. 2017
 * Author:  Damian Suess
 * Date:    2017-4-14
 * File:    IniFile.cs
 * Description:
 *  
 * To Do:
 * Change Log:
 *  2017-414 * Initial creation
 */


/*
  // Usage Examples

  // ------------------------------------------------
  // Open the INI file in one of the 3 following ways:

  // Creates or loads an INI file in the same directory as your executable
  // named EXE.ini (where EXE is the name of your executable)
  var ini = new IniFile();

  // Or specify a specific name in the current dir
  var ini = new IniFile("Settings.ini");

  // Or specify a specific name in a specific dir
  var ini = new IniFile(@"C:\Settings.ini");
  
  // ---------------------
  // Sample writing values:
  ini.Write("DefaultVolume", "100");
  ini.Write("HomePage", "http://www.google.com");
  
  // Output:
  [MyProg]
  DefaultVolume=100
  HomePage=http://www.google.com
  
  // -----------------------------------
  // Read the values out of the INI file:
  var DefaultVolume = IniFile.Read("DefaultVolume");
  var HomePage = IniFile.Read("HomePage");
  
  // -----------------------------------
  // Optionally, you can set [Section]'s:
  ini.Write("DefaultVolume", "100", "Audio");
  ini.Write("HomePage", "http://www.google.com", "Web");
  
  // Outputs:
  [Audio]
  DefaultVolume=100

  [Web]
  HomePage=http://www.google.com
  
  // --------------------------------
  // Check for the existence of a Key:
  if(!ini.KeyExists("DefaultVolume", "Audio"))
  {
      ini.Write("DefaultVolume", "100", "Audio");
  }
  
  // --------------------
  // You can delete a Key:
  ini.DeleteKey("DefaultVolume", "Audio");
  
  // -------------------------------------------
  // Delete a whole section (including all keys):
  ini.DeleteSection("Web");
*/

using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Xeno.SQLRestore.Data.Providers
{
  class IniFile
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

    public string Read(string key, string section = null)
    {
      var retVal = new StringBuilder(255);
      GetPrivateProfileString(section ?? _exeName, key, "", retVal, 255, _path);
      return retVal.ToString();
    }

    public void Write(string key, string value, string section = null)
    {
      WritePrivateProfileString(section ?? _exeName, key, value, _path);
    }

    public void DeleteKey(string key, string section = null)
    {
      Write(key, null, section ?? _exeName);
    }

    public void DeleteSection(string section = null)
    {
      Write(null, null, section ?? _exeName);
    }

    public bool KeyExists(string key, string section = null)
    {
      return Read(key, section).Length > 0;
    }
  }
}
