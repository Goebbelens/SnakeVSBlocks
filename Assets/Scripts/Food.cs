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
    void Start()
    {
        TextMesh = TextObject.GetComponent<TextMeshProUGUI>();
        Cuisine = Random.Range(1, 10);
        TextMesh.text = Cuisine.ToString();
    }

    
    void Update()
    {
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
