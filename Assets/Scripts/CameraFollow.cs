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

    void Start()
    {
        playerPosition = Player.transform.position;
        cameraPosition = new Vector3(0, playerPosition.y - cameraYOffset, cameraZOffset);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = Player.transform.position;
        cameraPosition = new Vector3(0, playerPosition.y - cameraYOffset, cameraZOffset);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
    }
}
