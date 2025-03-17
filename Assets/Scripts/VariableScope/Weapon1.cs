using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon1 
{
    public string name;
    public int damage;

    public Weapon1(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.Log($"Weapon: {this.name} - {this.damage} DMG");
    }
}
