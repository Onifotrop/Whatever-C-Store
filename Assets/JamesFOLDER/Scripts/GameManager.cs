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
		
	}
}
