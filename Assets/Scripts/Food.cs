using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Food : MonoBehaviour
{
    private int Cuisine;
    public int minFood;
    public int maxFood;
    public Game Game;
    public TextMeshProUGUI TextMesh;

    void Start()
    {
        Game = GetComponentInParent<Game>();
        Cuisine = Random.Range(minFood + 1 + 1 * Game.CurrentLevel, maxFood + 1  + 1 * Game.CurrentLevel);
        TextMesh.text = Cuisine.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player Player))
        {
            Player.Eat(Cuisine, gameObject);
        }
    }
}
