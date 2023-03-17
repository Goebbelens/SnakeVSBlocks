using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Player Player;
    public float cameraZOffset = -20;
    public Quaternion cameraRotation;

    private Vector3 playerPosition;
    private Vector3 cameraPosition;

    void Start()
    {
        playerPosition = Player.transform.position;
        cameraPosition = new Vector3(playerPosition.x, playerPosition.y, cameraZOffset);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = Player.transform.position;
        cameraPosition = new Vector3(playerPosition.x, playerPosition.y, cameraZOffset);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
    }
}
