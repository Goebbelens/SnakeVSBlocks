using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody SphereRigidBody;
    public float SphereXSpeed = 1.0f;
    public float SphereYSpeed = 1.0f;

    public Transform Player;
    public Transform ZoneCenter;
    private Vector3 _previousMousePosition;
    public float MovementVelocity = 0.012f;

    private void Awake()
    {
        //SphereRigidBody.velocity = new Vector3 (SphereXSpeed, SphereYSpeed, 0);
    }

    // Changed from Update to FixedUpdate
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            //Vector3 playerPos = Player.position;
            //SphereRigidBody.velocity = new Vector3(SphereXSpeed, SphereYSpeed, 0);
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            SphereRigidBody.AddForce(new Vector3(delta.x * 0.02f, delta.y * 0.02f, 0), ForceMode.Impulse);
            //Player.localPosition = new Vector3(Player.localPosition.x + delta.x * MovementVelocity, Player.localPosition.y, 0);
        }
        _previousMousePosition = Input.mousePosition;

        if (Player.localPosition.y > 10.87999)
        {
            Player.localPosition = new Vector3 (Player.localPosition.x, (float)10.87999, 0);
        }
        if (Player.localPosition.y < -10.87999)
        {
            Player.localPosition = new Vector3(Player.localPosition.x, (float)-10.87999, 0);
        }

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
