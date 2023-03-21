using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int ObstacleHealth;
    private Renderer renderer;
    public GameObject TextObjectObstacle;
    private TextMeshProUGUI textObstacle;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.SetFloat("_GradientFloat", ObstacleHealth * 1 / 10.0f);
        textObstacle = TextObjectObstacle.GetComponent<TextMeshProUGUI>();
        ObstacleHealth = Random.Range(1, 15);
        textObstacle.text = ObstacleHealth.ToString();
    }

    private void Update()
    {
        renderer.material.SetFloat("_GradientFloat", ObstacleHealth * 1 / 10.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.94f)
        {
            //Debug.Log(collision.contacts[0].normal.ToString());
            if (collision.gameObject.TryGetComponent(out Player Player))
            {
                ObstacleHealth--;
                Player.FoodAmount--;
                if(ObstacleHealth == 0)
                {
                    gameObject.SetActive(false);
                }
                Player.transform.position += Vector3.down.normalized/1.5f;
                Player.Tail.RemoveCircle();
            }
        }
        textObstacle.text = ObstacleHealth.ToString();
    }
}
