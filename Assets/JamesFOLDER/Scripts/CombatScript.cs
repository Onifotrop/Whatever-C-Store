using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombatScript : MonoBehaviour
{
    // need a big encounter manager to decide which enemy the player encounters
    // get player stat
    // get enemy stat

    public PlayerSruct player;
    public EnemyStruct enemy;
    public TextMeshProUGUI combatText;

    public int bluntFactor;
    public int sharpFactor;
    public int fireFactor;
    public int aoeFactor;

    public List<ActionStruct> actions;

    private int itemNum = 0;

	private void Start()
	{
        player = GameManager.me.player;
        actions = new List<ActionStruct>();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
            GetEnemy();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            CalculateResult_player(itemNum);
            CalculateResult_enemy();
        }
	}

	public void CalculateResult_player(int whichItemPlayersUsing)
	{
        // player attack
        if (player.itemsImCarrying[whichItemPlayersUsing].durability > 0 && enemy.hp > 0 && player.hp > 0)
		{
            int dmgInflicted = player.itemsImCarrying[whichItemPlayersUsing].dmg;
            if (player.itemsImCarrying[whichItemPlayersUsing].blunt)
            {
                dmgInflicted += enemy.dp * bluntFactor;
            }
            if (player.itemsImCarrying[whichItemPlayersUsing].sharp)
            {
                dmgInflicted += enemy.sp * sharpFactor;
            }
            if (player.itemsImCarrying[whichItemPlayersUsing].fire)
            {
                dmgInflicted += enemy.AoF * fireFactor;
            }
            if (player.itemsImCarrying[whichItemPlayersUsing].aoe)
            {
                dmgInflicted += enemy.AoAOE * aoeFactor;
            }
            enemy.hp -= dmgInflicted;
            player.itemsImCarrying[whichItemPlayersUsing].durability--;
            ActionStruct thisAction = new ActionStruct();
            thisAction.dmgInflicted = dmgInflicted;
            thisAction.inflicter = "You";
            thisAction.inflictee = enemy.namae;
            actions.Add(thisAction);
            print(thisAction.inflicter + " did " + thisAction.dmgInflicted + " damage to " + thisAction.inflictee);
            if (player.itemsImCarrying[whichItemPlayersUsing].durability <= 0)
            {
                itemNum++;
                print("item broke");
            }
        }
	}

    public void CalculateResult_enemy()
	{
        if (player.hp > 0 && enemy.hp > 0)
		{
            player.hp -= enemy.dmg;
            ActionStruct thisAction = new ActionStruct();
            thisAction.dmgInflicted = enemy.dmg;
            thisAction.inflicter = enemy.namae;
            thisAction.inflictee = "you";
            actions.Add(thisAction);
            print(thisAction.inflicter + " did " + thisAction.dmgInflicted + " damage to " + thisAction.inflictee);
        }
	}

    public void GetEnemy()
	{
        enemy = GameManager.me.enemies[Random.Range(0, GameManager.me.enemies.Count)];
	}

    public void UpdatePlayer()
	{
        player = GameManager.me.player;
	}
}
