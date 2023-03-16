using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Transform Player;
    private Vector3 _previousMousePosition;
    public float MovementVelocity = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            Player.transform.position = new Vector3(delta.x * MovementVelocity, delta.y * MovementVelocity, 0);
        }
        _previousMousePosition = Input.mousePosition;
    }
}
