using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass {

	public void WarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "Meele Based Fighter";
        Stamina = 15;
        Health = 150;
    }
}
