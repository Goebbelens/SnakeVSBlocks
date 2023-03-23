using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int ObstacleHealth;
    private Renderer obstacleRenderer;
    private Game Game;
    
    public GameObject TextObjectObstacle;
    private TextMeshProUGUI textObstacle;

    public int minObstacleHP;
    public int maxObstacleHP;

    void Start()
    {
        Game = GetComponentInParent<Game>();
        obstacleRenderer = GetComponent<Renderer>();
        obstacleRenderer.material.SetFloat("_GradientFloat", ObstacleHealth * 1 / 5.0f);
        textObstacle = TextObjectObstacle.GetComponent<TextMeshProUGUI>();
        ObstacleHealth = Random.Range(minObstacleHP + 1 + 1 * Game.CurrentLevel, maxObstacleHP + 1 + 1 * Game.CurrentLevel);
        textObstacle.text = ObstacleHealth.ToString();
    }

    private void Update()
    {
        obstacleRenderer.material.SetFloat("_GradientFloat", ObstacleHealth * 1 / 5.0f);
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
