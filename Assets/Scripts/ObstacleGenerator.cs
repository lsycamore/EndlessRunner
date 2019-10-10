using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{

    public GameObject theObstacle;
    public Transform generationPoint;
    public float distanceBetween;

    private float obstacleWidth;

    // Use this for initialization
    void Start()
    {
        obstacleWidth = theObstacle.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + obstacleWidth, transform.position.y, transform.position.z);

            Instantiate(theObstacle, transform.position, transform.rotation);
        }

    }
}
