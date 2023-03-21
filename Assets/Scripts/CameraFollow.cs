using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public float cameraYOffset = 20;
    public float cameraZOffset = -20;
    public Quaternion cameraRotation;

    private Vector3 playerPosition;
    private Vector3 cameraPosition;
    private float _previousCameraPosition;

    void Start()
    {
        playerPosition = Player.transform.position;
        cameraPosition = new Vector3(0, playerPosition.y - cameraYOffset, cameraZOffset);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
        _previousCameraPosition = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerPosition = Player.transform.position;
        cameraPosition = new Vector3(0, playerPosition.y - cameraYOffset, cameraZOffset);
        Debug.Log("Player pos Y = " + playerPosition.y + " and Camera Pos Y = " + cameraPosition.y);
        transform.position = cameraPosition;
        if (_previousCameraPosition > transform.position.y)
        {
            transform.position = new Vector3(0, _previousCameraPosition, cameraZOffset);
        }
        transform.rotation = cameraRotation;
        _previousCameraPosition = transform.position.y;

    }
}
