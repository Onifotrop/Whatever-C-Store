using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager me;
    public PlayerSruct player;
    public List<EnemyStruct> enemies;

	private void Awake()
	{
		me = this;
	}

	private void Update()
	{
		// for debugging
		if (Input.GetKeyDown(KeyCode.H))
		{
			ItemStruct item = new ItemStruct();
			item.namae = "hammer";
			item.blunt = true;
			item.dmg = 5;
			item.durability = 3;
			player.itemsImCarrying.Add(item);
		}
	}
}
