using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Transform Player;
    private Vector3 _previousMousePosition;
    public float MovementVelocity = 0.012f;
    private float _previousYPlayerPos;

    public Rigidbody Rigidbody;
    public Vector3 YSphereVelocity = new(0, 1, 0);

    private void Awake()
    {
        _previousYPlayerPos = Player.position.y;
    }

    // Changed from Update to FixedUpdate
    private void FixedUpdate()
    {
        if(Player.position.y < _previousYPlayerPos)
        {
            //Player.position = new Vector3(Player.position.x, _previousYPlayerPos, 0);
        }
        Rigidbody.velocity = YSphereVelocity;
        Rigidbody.AddForce(YSphereVelocity, ForceMode.VelocityChange);
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            Player.position = new Vector3(Player.position.x + delta.x * MovementVelocity, Player.position.y, 0);
            //Rigidbody.MovePosition(new Vector3(Player.position.x + delta.x * MovementVelocity, Player.position.y, 0));
        }
        _previousMousePosition = Input.mousePosition;

        if (Player.position.x > 5.954041)
        {
            Player.position = new Vector3((float)5.954041, Player.position.y, 0);
        }
        if (Player.position.x < -5.954041)
        {
            Player.position = new Vector3((float)-5.954041, Player.position.y, 0);
        }
        //_previousYPlayerPos = Player.position.y;
    }
}
