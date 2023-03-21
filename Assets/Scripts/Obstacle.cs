using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int ObstacleHealth;
    public GameObject TextObjectObstacle;
    private TextMeshProUGUI textObstacle;

    void Start()
    {
        textObstacle = TextObjectObstacle.GetComponent<TextMeshProUGUI>();
        ObstacleHealth = Random.Range(1, 15);
        textObstacle.text = ObstacleHealth.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.94f)
        {
            Debug.Log(collision.contacts[0].normal.ToString());
            if (collision.gameObject.TryGetComponent(out Player Player))
            {
                ObstacleHealth--;
                if(ObstacleHealth == 0)
                {
                    gameObject.SetActive(false);
                }
            }
        }
        textObstacle.text = ObstacleHealth.ToString();
    }
}
