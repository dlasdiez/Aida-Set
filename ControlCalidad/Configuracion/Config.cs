using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Configuracion
{
  public class ConfigValues
  {
    public String Color = "#FFFFFF";
  }

  public static class Config
  {
    public static ConfigValues ValueConfig;

    public static Boolean ReadConfig()
    {
      ValueConfig = new ConfigValues();
      String _path;

      _path = AppDomain.CurrentDomain.BaseDirectory + "config";

      if(!System.IO.File.Exists(_path))
      {
        return false;
      }
      XmlDocument myXmlDocument = new XmlDocument();
      myXmlDocument.Load(_path);

      XmlNode node;
      node = myXmlDocument.DocumentElement;

      foreach (XmlNode node1 in node.ChildNodes)
      {
        foreach (XmlNode node2 in node1.ChildNodes)
        {
          if (node1.Name == "color")
          {
            ValueConfig.Color = node2.Value;
          }
        }
      }

      return true;
    }

    public static void SaveConfig(ref ConfigValues Values)
    {
      if (String.IsNullOrEmpty(Values.Color))
      {
        Values.Color = "#FFFFFF";
      }

      XmlTextWriter writer;
      writer = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "config", Encoding.UTF8);
      writer.Formatting = Formatting.Indented;
      writer.WriteStartDocument();
      writer.WriteStartElement("configuracion");
      writer.WriteElementString("color", Values.Color);
      writer.WriteEndElement();
      writer.WriteEndDocument();
      writer.Flush();
      writer.Close();
    }
  }
}
