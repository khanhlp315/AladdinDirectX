﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Image
{
    private string _path;

    public string Path
    {
        get
        {
            return _path;
        }
        set
        {
            _path = value;
        }
    }

    public Image Clone()
    {
        Image image = new Image();
        return image;
    }

}

