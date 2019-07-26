using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private Transform playerTransform;

    public float offset;

    void Start() {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

     void LateUpdate () {

        // we store current camera's position in variable temp - temporary position
        Vector3 temp = transform.position;

        // we set the camera's position x to b equal to the player's position x
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        // this will add the offset value to the temporary camera x position
        temp.x += offset;

        // we set back the camera's temp position to the camera's current position
        transform.position = temp;

    }


        
} // class































