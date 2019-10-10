using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //Stores the player
    public PlayerController thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;
	// Use this for initialization
	void Start () {
        //Finds player
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;

    }

    // Update is called once per frame
    void Update () {
        //Calculates distance for camera to move
        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
        //Transform of current object
        transform.position = new Vector3 (transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;

	}
}
 