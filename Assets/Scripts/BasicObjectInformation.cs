using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicObjectInformation {

    private string name;
    private string description;
    private Sprite icon;
    private float health;

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


    public BasicObjectInformation(string Name, float Health)
    {
        name = Name;
        health = Health;
    }

    public BasicObjectInformation(string Name, string Description, Sprite Icon)
    {
        name = Name;
        description = Description;
        icon = Icon;
    }

    public BasicObjectInformation(string Name, string Description, Sprite Icon, float Health)
    {
        name = Name;
        description = Description;
        icon = Icon;
        health = Health;
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

    public float Health
    {
        get { return health; }
        set { health = value; }
    }

}
