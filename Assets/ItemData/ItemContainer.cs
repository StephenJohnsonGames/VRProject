using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;

[XmlRoot("ItemCollection")]
public class ItemContainer
{

    [XmlArray("Items")]
    [XmlArrayItem("Item")]

    public List<Item> items = new List<Item>();

    public static ItemContainer Load(string path)
    {

        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(ItemContainer));

        StringReader reader = new StringReader(_xml.text);

        ItemContainer items = serializer.Deserialize(reader) as ItemContainer;

        reader.Close();

        return items;

    }
}
