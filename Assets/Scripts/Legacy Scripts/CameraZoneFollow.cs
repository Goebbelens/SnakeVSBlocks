using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoneFollow : MonoBehaviour
{
    public PlayerZone ViewZoneMovement;
    public float cameraZOffset = -20;
    public Quaternion cameraRotation;

    private Vector3 playerPosition;
    private Vector3 cameraPosition;

    void Start()
    {
        playerPosition = ViewZoneMovement.transform.position;
        cameraPosition = new Vector3(playerPosition.x, playerPosition.y, cameraZOffset);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
    }

    void Update()
    {
        playerPosition = ViewZoneMovement.transform.position;
        cameraPosition = new Vector3(playerPosition.x, playerPosition.y, cameraZOffset);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
    }
}
