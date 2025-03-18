using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Paladin : Character
{
    public Weapon weapon;
    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatusInfo()
    {
        Debug.Log($"{this.name} - take up your {this.weapon}!");
    }
}
