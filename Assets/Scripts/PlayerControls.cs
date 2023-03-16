using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Transform Player;
    private Vector3 _previousMousePosition;
    public float MovementVelocity = 0.04f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Vector3 playerPos = Player.position;
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            Player.position = new Vector3(Player.position.x + delta.x * MovementVelocity, 0, Player.position.z + delta.y * MovementVelocity);
        }
        _previousMousePosition = Input.mousePosition;
    }
}
