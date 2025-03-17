using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public int strength;

    public Warrior(string name, int health, int strength) :base(name,health)
    {
        this.strength = strength;
    }

    public void Attack()
    {
        Debug.Log(name + " attacks with strength " + strength);
    }

   
    
    public void DisplayRarePoints()
    {
        
    }
}
