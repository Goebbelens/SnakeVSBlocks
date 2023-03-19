using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Transform Player;
    public Transform ZoneCenter;
    private Vector3 _previousMousePosition;
    public float MovementVelocity = 0.012f;

    public Rigidbody Rigidbody;
    public Vector3 YSphereVelocity = new(0, 1, 0);

    private void Awake()
    {
        
    }

    // Changed from Update to FixedUpdate
    private void FixedUpdate()
    {
        Rigidbody.velocity = YSphereVelocity;
        Rigidbody.AddForce(YSphereVelocity, ForceMode.VelocityChange);
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            Player.localPosition = new Vector3(Player.localPosition.x + delta.x * MovementVelocity, 0, 0);
        }
        _previousMousePosition = Input.mousePosition;

        if (Player.localPosition.x > 5.954041)
        {
            Player.localPosition = new Vector3((float)5.954041, Player.localPosition.y, 0);
        }
        if (Player.localPosition.x < -5.954041)
        {
            Player.localPosition = new Vector3((float)-5.954041, Player.localPosition.y, 0);
        }
    }
}
