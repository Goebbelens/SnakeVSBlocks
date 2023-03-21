using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Food : MonoBehaviour
{
    private int Cuisine;

    public TextMeshProUGUI TextMesh;
    public GameObject TextObject;
    public Player Player;

    void Start()
    {
        TextMesh = TextObject.GetComponent<TextMeshProUGUI>();
        Cuisine = Random.Range(1, 10);
        TextMesh.text = Cuisine.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Player.Eat(Cuisine, gameObject);
    }
}
