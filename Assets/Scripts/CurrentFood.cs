using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentFood : MonoBehaviour
{
    public Player Player;
    public TMP_Text Text;
    void Start()
    {
        Text.text = Player.FoodAmount.ToString();
    }

    void Update()
    {
        Text.text = Player.FoodAmount.ToString();
    }
}
