using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName;
    public int health;


    //Constructor
    public Player(string name, int hp)
    {
        playerName = name;
        health = hp;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(playerName + "took" + damage + "damage.Health: " + health);
    }
}
