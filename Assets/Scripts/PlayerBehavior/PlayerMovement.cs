using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Vector3 targetPosition;
    private float moveSpeed = 1.5f;
    private BasicObjectInformation PlayerInfo;
	// Use this for initialization
	void Start () {
        // Basic player, 100 health
        PlayerInfo = new BasicObjectInformation("Player",100);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * moveSpeed);

	}
}
