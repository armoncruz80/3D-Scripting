using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public struct Weapon 
{
  
    public string name;
    public int damage;
 

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.Log($"Weapon: {this.name} - {this.damage} DMG");
    }
}
