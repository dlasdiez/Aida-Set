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
    public String Servidor_BD = "";
    public String Database = "Metalcaucho";
    public String Puerto = "3306";
    public String Usuario_BD = "";
    public String Password_BD = "";
    public String Usuario_Admin = "";
    public String Password_Admin = "";
    public String Runtime = "";
    public String PathDatos = "";
    public String PathWebServices = "";
    public String PathLogo = "";
    public String PathImagenes = "";
  }

  public static class Config
  {
    public static ConfigValues ValueConfig;

    public static Boolean ReadConfig()
    {
      ValueConfig = new ConfigValues();
      String _path;

      _path = AppDomain.CurrentDomain.BaseDirectory + "config";

      if (!System.IO.File.Exists(_path))
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
          switch (node1.Name)
          {
            case "ServidorBD":
              ValueConfig.Servidor_BD = node2.Value;
              break;
            case "BaseDatos":
              ValueConfig.Database = node2.Value;
              break;
            case "Puerto":
              ValueConfig.Puerto = node2.Value;
              break;
            case "Usuario":
              ValueConfig.Usuario_BD = node2.Value;
              break;
            case "Password":
              ValueConfig.Password_BD = node2.Value;
              break;
            case "Usuario_Admin":
              ValueConfig.Usuario_Admin = node2.Value;
              break;
            case "Password_Admin":
              ValueConfig.Password_Admin = node2.Value;
              break;
            case "Color":
              ValueConfig.Color = node2.Value;
              break;
            case "Runtime":
              ValueConfig.Runtime = node2.Value;
              break;
            case "RutaDatos":
              ValueConfig.PathDatos = node2.Value;
              break;
            case "Path_Webservice":
              ValueConfig.PathWebServices = node2.Value;
              break;
            case "Path_Logo":
              ValueConfig.PathLogo = node2.Value;
              break;
            case "Path_Images":
              ValueConfig.PathImagenes = node2.Value;
              break;
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
      writer.WriteElementString("ServidorBD", Values.Servidor_BD);
      writer.WriteElementString("BaseDatos", Values.Database);
      writer.WriteElementString("Puerto", Values.Puerto);
      writer.WriteElementString("Usuario", Values.Usuario_BD);
      writer.WriteElementString("Password", Values.Password_BD);
      writer.WriteElementString("Usuario_Admin", Values.Usuario_Admin);
      writer.WriteElementString("Password_Admin", Values.Password_Admin);
      writer.WriteElementString("Color", Values.Color);
      writer.WriteElementString("Runtime", Values.Runtime);
      writer.WriteElementString("RutaDatos", Values.PathDatos);
      writer.WriteElementString("Path_Webservice", Values.PathWebServices);
      writer.WriteElementString("Path_Logo", Values.PathLogo);
      writer.WriteElementString("Path_Images", Values.PathImagenes);
      writer.WriteEndElement();
      writer.WriteEndDocument();
      writer.Flush();
      writer.Close();
    }
  }
}
