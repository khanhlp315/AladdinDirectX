﻿using System;
using System.Collections.Generic;
using System.Xml;

public class Object
{
    private int _id;
    private int _width;
    private int _height;
    private int _x;
    private int _y;
    private string _name;
    private List<Property> _properties;
    private int _type;

    public Object Clone()
    {
        Object a = new Object();
        a._width = _width;
        a._height = _height;
        a._name = _name;
        a._x = _x;
        a._y = _y;
        a._type = _type;
        a._properties = _properties;
        a._id = _id;

        return a;
    }

    public Object LoadFromXML(XmlNode node)
    {  
        if (node.HasChildNodes)
        {
            
            Property property = new Property();
            foreach (XmlNode child in node.ChildNodes)
            {
                this.Id = int.Parse(child.Attributes["id"].Value);
                this.Name = child.Attributes["name"].Value;
                this.Height = int.Parse(child.Attributes["height"].Value);
                this.Width = int.Parse(child.Attributes["width"].Value);
                this.Type = int.Parse(child.Attributes["type"].Value);
                this.X = int.Parse(child.Attributes["x"].Value);
                this.Y = int.Parse(child.Attributes["y"].Value);
                child.SelectNodes("/Map/Objects/Object/Property");
                this.Properties.Add(property.LoadFromXML(child));
            }
            return this;
        }
        return null;
    }

    public Object()
    {
        _properties = new List<Property>();
    }

    public int Type
    {
        get
        {
            return _type;
        }
        set
        {
            _type = value;
        }
    }

    public int X
    {
        get
        {
            return _x;
        }
        set
        {
            _x = value;
        }
    }

    public int Y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
        }
    }

    public int Height
    {
        get
        {
            return _height;
        }
        set
        {
            _height = value;
        }
    }

    public int Width
    {
        get
        {
            return _width;
        }
        set
        {
            _width = value;
        }
    }

    public List<Property> Properties
    {
        get
        {
            return _properties;
        }
        set
        {
            _properties = value;
        }
    }


    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
}
