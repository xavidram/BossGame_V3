using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass {

    private string characterClassName;
    private string characterClassDescription;
    //Stats
    private int health;
    private int stamina;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }
}
