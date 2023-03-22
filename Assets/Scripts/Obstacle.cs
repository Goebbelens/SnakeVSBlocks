using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int ObstacleHealth;
    private Renderer obstacleRenderer;
    
    public GameObject TextObjectObstacle;
    private TextMeshProUGUI textObstacle;

    public int minObstacleHP = 1;
    public int maxObstacleHP = 15;

    void Start()
    {
        obstacleRenderer = GetComponent<Renderer>();
        obstacleRenderer.material.SetFloat("_GradientFloat", ObstacleHealth * 1 / 10.0f);
        textObstacle = TextObjectObstacle.GetComponent<TextMeshProUGUI>();
        ObstacleHealth = Random.Range(minObstacleHP, maxObstacleHP);
        textObstacle.text = ObstacleHealth.ToString();
    }

    private void Update()
    {
        obstacleRenderer.material.SetFloat("_GradientFloat", ObstacleHealth * 1 / 10.0f);
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
                Player.AddScore();
                if(ObstacleHealth == 0)
                {
                    Player.ObstacleDestroyed();
                    gameObject.SetActive(false);
                }
                Player.transform.position += Vector3.down.normalized/1.5f;
                Player.Tail.RemoveCircle();
            }
        }
        textObstacle.text = ObstacleHealth.ToString();
    }

}
