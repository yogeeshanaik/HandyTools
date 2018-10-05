using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace FastQuery
{
  /// <summary>
  /// Class handling persistent store of application settings in an XML file.
  /// There are several other techniques to do this, but they all seems to have serious drawbacks.
  /// The built in Settings from the Properties window is very nice but we can't choose where to put the file (or what to call it)...
  /// </summary>
  #if INCLUDE_DESIGN_SUPPORT
  public class Settings: Component {
  #else
  public class Settings {
  #endif
    private string file = "configuration.xml";
    private Configuration configuration = null;
    private bool doReplaceDecimalChar = false;

    /// <summary>
    /// Constructor
    /// </summary>
    public Settings() {
      CheckDecimalChar();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="file">The name of the configuration file (with or without path)</param>
    public Settings(string file) {
      this.file = file;
      CheckDecimalChar();
    }

    #if INCLUDE_DESIGN_SUPPORT
    /// <summary>
    /// The name of the configuration file (with or without path)"
    /// </summary>  
    [Category("Settings"), Description("The name of the configuration file (with or without path)")] 
    public string ConfigFile {
      get { return file; }
      set { file = value; }
    }
    #endif

    /// <summary>
    /// Open file with settings
    /// </summary>
    public void Open() {
      // Try to open the configuration file
      ExeConfigurationFileMap exeConfigurationFileMap = new ExeConfigurationFileMap();
      exeConfigurationFileMap.ExeConfigFilename = file;
      configuration = ConfigurationManager.OpenMappedExeConfiguration(exeConfigurationFileMap, ConfigurationUserLevel.None);
    }

    /// <summary>
    /// Save settings to file
    /// </summary>
    public void Save() {
      if(configuration != null) {
        try {
          configuration.Save();
        } catch(Exception) {
          Open();
          configuration.Save();
        }
      }
    }


    //********************************* Write *************************************

    /// <summary>
    /// Write string
    /// </summary>
    /// <param name="name">Name of setting</param>
    /// <param name="value">Value to store</param>
    public void Write(string name, string value) {
      WriteString(name, value);
    }

    /// <summary>
    /// Write int
    /// </summary>
    /// <param name="name">Name of setting</param>
    /// <param name="value">Value to store</param>
    public void Write(string name, int value) {
      WriteString(name, value.ToString());
    }

    /// <summary>
    /// Write bool 
    /// </summary>
    /// <param name="name">Name of setting</param>
    /// <param name="value">Value to store</param>
    public void Write(string name, bool value) {
      WriteString(name, value.ToString());
    }

    /// <summary>
    /// Write double
    /// </summary>
    /// <param name="name">Name of setting</param>
    /// <param name="value">Value to store</param>
    public void Write(string name, double value) {
      WriteString(name, DoubleToString(value));
    }

    
    //********************************* Read **************************************

    /// <summary>
    /// Read string
    /// </summary>
    /// <param name="name">Name of setting</param>
    /// <param name="defaultValue">Default value to return if missing</param>
    /// <returns>Value</returns>
    public string Read(string name, string defaultValue) {
      return ReadString(name, defaultValue);
    }

    /// <summary>
    /// Read int
    /// </summary>
    /// <param name="name">Name of setting</param>
    /// <param name="defaultValue">Default value to return if missing</param>
    /// <returns>Value</returns>
    public int Read(string name, int defaultValue) {
      return int.Parse(ReadString(name, defaultValue.ToString()));
    }

    /// <summary>
    /// Read bool
    /// </summary>
    /// <param name="name">Name of setting</param>
    /// <param name="defaultValue">Default value to return if missing</param>
    /// <returns>Value</returns>
    public bool Read(string name, bool defaultValue) {
      return bool.Parse(ReadString(name, defaultValue.ToString()));
    }

    /// <summary>
    /// Read double
    /// </summary>
    /// <param name="name">Name of setting</param>
    /// <param name="defaultValue">Default value to return if missing</param>
    /// <returns>Value</returns>
    public double Read(string name, double defaultValue) {
      return StringToDouble(ReadString(name, DoubleToString(defaultValue)));
    }


    //********************************* Misc **************************************

    // Write setting as string
    private void WriteString(string name, string value) {
      if(configuration != null) {
        KeyValueConfigurationElement key = configuration.AppSettings.Settings[name];
        if(key != null) key.Value = value;
        else configuration.AppSettings.Settings.Add(name, value);
      }
    }

    // Read setting as string
    private string ReadString(string name, string defaultValue) {
      if(configuration != null) {
        KeyValueConfigurationElement key = configuration.AppSettings.Settings[name];
        if(key != null) return key.Value;
      }
      return defaultValue;
    }

    // Get the decimal character used in current environment
    // Note! Always uses "." as double separator 
    private void CheckDecimalChar() {  
      string dummy = "" + 0.1M;
      char localDoubleChar = dummy[1];
      if(localDoubleChar == ',') doReplaceDecimalChar = true;
    }

    // Convert double to ascii representation
    private string DoubleToString(double data) {
      String dataConverted = data.ToString();
      if(doReplaceDecimalChar == true) dataConverted = dataConverted.Replace(',', '.');
      return dataConverted;
    }

    // Convert ascii representation to double
    private double StringToDouble(string data) {
      if(doReplaceDecimalChar == true) data = data.Replace('.', ',');
      return double.Parse(data);
    }
  }
}
