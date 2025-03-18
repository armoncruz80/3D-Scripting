using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;


    public Character()
    {
        name = "Not assigned";
       
    }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatusInfo()
    {
        Debug.Log($"Hero: {this.name} - {this.exp} EXP");
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}
