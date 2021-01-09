using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    //the following is created for player's stats, including HP(Health Point)
    //                                                       Money
    //                                                       Bag Size
    public float health;
    public float Money;
    public float bagSize;
    
    void Start()
    {
        health = 10f;
        Money = 10f;
        bagSize = 6f;
    }

    // There is three situaltions: The game start in the store, after purchasing, enters the battle state
    //States
    public bool inStore;
    public bool inBattle;
    public bool isAlive;
    void Update()
    {
        if (inStore)
        {
            
        }
    }
}
