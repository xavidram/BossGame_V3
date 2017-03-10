using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour {

    private float moveSpeed = 1f;
    private BasicObjectInformation BossInformation;
    private Renderer rend;
    private GameObject Player;


	// Use this for initialization
	void Start () {
        //  Starting the boss with 200 health.
        BossInformation = new BasicObjectInformation("FinalBoss", 200);
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        Player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (rend.enabled)
        {
            if(BossInformation.Health <= 0)
            {
                rend.enabled = false;
            } else {
                transform.Translate(Player.transform.position.normalized * moveSpeed * Time.deltaTime);
            }
        }
	}
}
