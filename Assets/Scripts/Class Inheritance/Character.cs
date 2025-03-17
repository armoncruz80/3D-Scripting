using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string name;
    public int health;

    protected int exclusivePoints;


    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public Character(int rarePoints)
    {
        this.exclusivePoints = rarePoints;
    }

    
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(name + " took " + damage + " damage.Health: " + health);


    }
}
