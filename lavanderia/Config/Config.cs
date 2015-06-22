using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace lavanderia
{
    public static class Config
    {
        public static String Runtime = "c:\\aidaroot\\lavcamps\\wrun32 -b -c c:\\aidaroot\\lavcamps\\config.acu -f";
        public static String PathDatos = "c:\\aidaroot\\lavcamps\\fich0001";
        public static String PathWebServices = "c:\\aidaroot\\lavcamps\\";
        public static String Color = "#FFFFFF";
        public static String Terminal = "001";

        public static Boolean ReadConfig()
        {
            try
            {
                XmlDocument myXmlDocument = new XmlDocument();
                myXmlDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "config");

                XmlNode node;
                node = myXmlDocument.DocumentElement;

                foreach (XmlNode node1 in node.ChildNodes)
                {
                    foreach (XmlNode node2 in node1.ChildNodes)
                    {
                        if (node1.Name == "runtime")
                        {
                            Config.Runtime = node2.Value;
                        }

                        if (node1.Name == "ruta_datos")
                        {
                            Config.PathDatos = node2.Value;
                        }

                        if (node1.Name == "ruta_webservices")
                        {
                            Config.PathWebServices = node2.Value;
                        }

                        if (node1.Name == "color")
                        {
                            Config.Color = node2.Value;
                        }

                        if (node1.Name == "terminal")
                        {
                            Config.Terminal = node2.Value;
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void SaveConfig(String Run_Time = "", String Path_Datos = "", String Path_Werbservices = "", String Color_save = "", String Terminal_save = "")
        {
            if (String.IsNullOrEmpty(Run_Time))
            {
                Run_Time = "c:\\aidaroot\\lavcamps\\wrun32 -b -c c:\\aidaroot\\lavcamps\\config.acu -f";
            }

            if (String.IsNullOrEmpty(Path_Datos))
            {
                Path_Datos = "c:\\aidaroot\\lavcamps\\fich0001";
            }

            if (String.IsNullOrEmpty(Path_Werbservices))
            {
                Path_Werbservices = "c:\\aidaroot\\lavcamps\\";
            }

            if (String.IsNullOrEmpty(Color_save))
            {
                Color_save = "#FFFFFF";
            }

            if (String.IsNullOrEmpty(Terminal_save))
            {
                Terminal_save = "001";
            }

            Runtime = Run_Time;
            PathDatos = Path_Datos;
            PathWebServices = Path_Werbservices;
            Color = Color_save;
            Terminal = Terminal_save;


            XmlTextWriter writer;
            writer = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "config", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("configuracion");
            writer.WriteElementString("runtime", Runtime);
            writer.WriteElementString("ruta_datos", PathDatos);
            writer.WriteElementString("ruta_webservices", PathWebServices);
            writer.WriteElementString("color", Color);
            writer.WriteElementString("terminal", Terminal);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

    }
}
