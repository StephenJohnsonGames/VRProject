using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Item
{

    [XmlAttribute("Name")]
    public string itemName;
    
    [XmlElement("ObjectName")]
    public string ObjectName;

    [XmlElement("Points")]
    public float itemPoints;

    [XmlElement("Cost")]
    public float itemCost; 
    
    [XmlElement("ID")]
    public float itemID;

}
