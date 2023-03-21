using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int FoodAmount = 1;
    public SnakeTail Tail;
    public PlayerControls PlayerControls;
    public enum State
    {
        Playing,
        Lost,
        Won
    }
    public State CurrentState { get; private set; }
    void Awake()
    {
        
    }

    void Update()
    {
        Debug.Log(FoodAmount);
        if (FoodAmount == 0)
        {
            Die();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            FoodAmount--;
            Tail.RemoveCircle();
        }
    }

    public void Eat(int Cuisine, GameObject Food)
    {
        FoodAmount += Cuisine;
        for (int i = 0; i < Cuisine; i++)
        {
            Tail.AddCircle();
        }
        Destroy(Food);
    }

    public void Die()
    {
        if(CurrentState != State.Playing) return;
        gameObject.SetActive(false);
        CurrentState = State.Lost;
        PlayerControls.enabled = false;

    }
}
