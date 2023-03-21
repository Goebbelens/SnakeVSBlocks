using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int FoodAmount = 1;
    public SnakeTail Tail;
    void Awake()
    {
        
    }

    void Update()
    {
        //Debug.Log(FoodAmount);
    }

    public void Eat(int Cuisine, GameObject Food)
    {
        FoodAmount += Cuisine;
        Destroy(Food);
        //Tail.AddCircle(Cuisine, gameObject);
    }


}
