using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ActionStruct
{
    public int dmgInflicted;
    public string inflicter;
    public string inflictee;
    public string deathText;
    public string itemText;
    // later add in text based on the type of the attack
}
