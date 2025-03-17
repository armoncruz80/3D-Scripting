using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Character2
{
    public Weapon1 weapon;
    public Paladin(string name, Weapon1 weapon): base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.Log($"Hail {this.name} - take up your {this.weapon.name}");
    }

}
