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
    public List<ItemStruct> itemsPlayersUsing;

    private bool startBattle = false;
    private int itemNum = 0;

    public float interval;
    private float timer;
    private int textNum = 0;

	private void Start()
	{
        UpdatePlayer();
        actions = new List<ActionStruct>();
        GetEnemy();
    }

	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.W))
        {
            CalculateResult_player(itemNum);
            CalculateResult_enemy();
        }
        // for debugging
        if (Input.GetKeyDown(KeyCode.H))
        {
            ItemStruct item = new ItemStruct();
            item.namae = "hammer";
            item.blunt = true;
            item.dmg = 5;
            item.durability = 3;
            itemsPlayersUsing.Add(item);
        }

        if (Input.GetKeyDown(KeyCode.S))
		{
            startBattle = true;
            UpdatePlayer();
            GetEnemy();
		}

        if (player.hp > 0 && enemy.hp > 0 && startBattle)
		{
            //if (itemsPlayersUsing.Count > 0) // this if check is only for debugging
			{
                CalculateResult_player(itemNum);
                CalculateResult_enemy();
            }
		}
        else if (player.hp<=0 || enemy.hp <= 0)
		{
            startBattle = false;
        }
        
        if (Input.GetMouseButtonDown(0))
		{
            //if (enemy.hp > 0 && player.hp > 0)
			{
                ShowText();
            }
            if (textNum < actions.Count - 1)
			{
                textNum++;
            }
			else
			{
                print("over");
			}
		}
    }

    public void ShowText()
    {
        if (actions.Count > 0)
		{
            if (actions[textNum].deathText == null && actions[textNum].itemText == null)
			{
                combatText.text += actions[textNum].inflicter + " dealt " + actions[textNum].dmgInflicted + " to " + actions[textNum].inflictee + "\n";
            }
			else if (actions[textNum].deathText != null)
			{
                combatText.text += actions[textNum].deathText;
            }
            else if (actions[textNum].itemText != null)
			{
                combatText.text += actions[textNum].itemText;
			}
        }
    }

    public void CalculateResult_player(int whichItemPlayersUsing)
	{
        // player attack
        if (itemsPlayersUsing.Count > 0)
		{
            if (itemsPlayersUsing[whichItemPlayersUsing].durability > 0 && enemy.hp > 0 && player.hp > 0)
            {
                int dmgInflicted = itemsPlayersUsing[whichItemPlayersUsing].dmg;
                if (itemsPlayersUsing[whichItemPlayersUsing].blunt)
                {
                    dmgInflicted += enemy.dp * bluntFactor;
                }
                if (itemsPlayersUsing[whichItemPlayersUsing].sharp)
                {
                    dmgInflicted += enemy.sp * sharpFactor;
                }
                if (itemsPlayersUsing[whichItemPlayersUsing].fire)
                {
                    dmgInflicted += enemy.AoF * fireFactor;
                }
                if (itemsPlayersUsing[whichItemPlayersUsing].aoe)
                {
                    dmgInflicted += enemy.AoAOE * aoeFactor;
                }
                enemy.hp -= dmgInflicted;
                itemsPlayersUsing[whichItemPlayersUsing].durability--;
                ActionStruct thisAction = new ActionStruct();
                thisAction.dmgInflicted = dmgInflicted;
                thisAction.inflicter = "You";
                thisAction.inflictee = enemy.namae;
                actions.Add(thisAction);
                print(thisAction.inflicter + " did " + thisAction.dmgInflicted + " damage to " + thisAction.inflictee);
                if (enemy.hp <= 0)
                {
                    ActionStruct deathAction = new ActionStruct();
                    deathAction.deathText = enemy.namae + " is dead";
                    actions.Add(deathAction);
                    print(enemy.namae + " is dead");
                }
                if (itemsPlayersUsing[whichItemPlayersUsing].durability <= 0)
                {
                    ActionStruct itemAction = new ActionStruct();
                    itemAction.itemText = itemsPlayersUsing[whichItemPlayersUsing].namae + " is broken\n";
                    actions.Add(itemAction);
                    print("item broke");
                    itemsPlayersUsing.RemoveAt(whichItemPlayersUsing);
                }
            }
        }
		else // if player isn't using any items(bare hands)
		{
            if (enemy.hp > 0 && player.hp > 0)
			{
                enemy.hp -= 1;
                ActionStruct thisAction = new ActionStruct();
                thisAction.dmgInflicted = 1;
                thisAction.inflicter = "You";
                thisAction.inflictee = enemy.namae;
                actions.Add(thisAction);
                print(thisAction.inflicter + " did " + thisAction.dmgInflicted + " damage to " + thisAction.inflictee);
                if (enemy.hp <= 0)
                {
                    ActionStruct deathAction = new ActionStruct();
                    deathAction.deathText = enemy.namae + " is dead";
                    actions.Add(deathAction);
                    print(enemy.namae + " is dead");
                }
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
            if (player.hp <= 0)
            {
                ActionStruct deathAction = new ActionStruct();
                deathAction.deathText = "You are dead";
                actions.Add(deathAction);
                print("the player is dead");
            }
        }
	}

    public void GetEnemy()
	{
        enemy = GameManager.me.enemies[Random.Range(0, GameManager.me.enemies.Count)];
	}

    public void UpdatePlayer()
	{
        player = GameManager.me.player;
        //! put items the player chooses to use into itemsPlayersUsing here
	}

    
}
