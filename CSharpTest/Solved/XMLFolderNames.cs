using System;
using System.Collections.Generic;
using System.Xml;

public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        XmlDocument xDoc = new XmlDocument();
        xDoc.LoadXml(xml);
        List<string> folderNames = new List<string>();

        XmlNodeList elemlist = xDoc.GetElementsByTagName("folder");

        foreach(XmlNode node in elemlist)
        {
            XmlAttribute nameAttr = node.Attributes["name"];
            if (nameAttr != null && nameAttr.InnerText.StartsWith(startingLetter.ToString()))
            {
                folderNames.Add(nameAttr.InnerText);
            }
        }

        return folderNames;
    }

    /*
    public static void Main(string[] args)
    {
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
        Console.ReadLine();
    }
    */
}