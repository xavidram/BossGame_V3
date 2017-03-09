using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicObjectInformation {

    private string name;
    private string description;
    private Sprite icon;

    // Constructors
    public BasicObjectInformation(string Name)
    {
        name = Name;   
    }

    public BasicObjectInformation(string Name, string Description)
    {
        name = Name;
        description = Description;
    }

    public BasicObjectInformation(string Name, string Description, Sprite Icon)
    {
        name = Name;
        description = Description;
        icon = Icon;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public Sprite Icon
    {
        get { return icon; }
        set { icon = value; }
    }

}
