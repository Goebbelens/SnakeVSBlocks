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

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Vector3 playerPos = Player.position;
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            Player.localPosition = new Vector3(Player.localPosition.x + delta.x * MovementVelocity, Player.localPosition.y + delta.y * MovementVelocity, 0);
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
