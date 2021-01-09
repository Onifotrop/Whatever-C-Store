using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    //the following is created for player's stats, including HP(Health Point)
    //                                                       Money
    //                                                       Bag Size
    public float health;
    public float money;
    public float bagSize;
    
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI bagSizeText;
    void Start()
    {
        health = 10f;
        money = 10f;
        bagSize = 6f;
    }

    // There is three situaltions: The game start in the store, after purchasing, enters the battle state
    //States
    public bool inStore;
    public bool inBattle;
    public bool isAlive;
    void Update()
    {
        healthText.text = "HP: " + health.ToString();
        moneyText.text = "Money: " + money.ToString();
        bagSizeText.text = "Bag Size: " + bagSize.ToString();
    }
}
