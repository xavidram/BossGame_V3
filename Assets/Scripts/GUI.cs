using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour {

    private BaseCharacterClass warrior = new BaseWarriorClass();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUILayout.Label(warrior.CharacterClassName);
        GUILayout.Label(warrior.CharacterClassDescription);
    }

}
