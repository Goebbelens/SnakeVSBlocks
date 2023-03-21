using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform TailExample;
    public float CircleDiameter;

    private List<Transform> snakeCircles = new List<Transform>();
    private List<Vector3> positions = new List<Vector3>();
    
    void Start()
    {
        positions.Add(TailExample.position);
        AddCircle();
        AddCircle();
    }

    // Update is called once per frame
    void Update()
    {
        //����������� �� ������� ��������� ������ � ������
        Vector3 direction = ((Vector3)TailExample.position - positions[0]).normalized;

        float distance = ((Vector3)TailExample.position - positions[0]).magnitude;
        
        if (distance > CircleDiameter)
        {
            positions.Insert(0, positions[0] + direction * CircleDiameter);
            positions.RemoveAt(positions.Count - 1);

            distance -= CircleDiameter;
        }

        for (int i = 0; i < snakeCircles.Count; i++)
        {
            snakeCircles[i].position = Vector2.Lerp(positions[i + 1], positions[i], distance / CircleDiameter);
        }
    }

    public void AddCircle()
    {
        Transform circle = Instantiate(TailExample, positions[positions.Count - 1], Quaternion.identity, transform);
        snakeCircles.Add(circle);
        positions.Add(circle.position);
    }
}
