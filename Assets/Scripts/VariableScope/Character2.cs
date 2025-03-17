using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 
{
    public string name;
    public int exp = 0;

    public Character2()
    {
        name = "Not Assigned";
        Reset();
    }
  
    public Character2(string name)
    {
        this.name = name; 
    }

    

    public virtual void PrintStatsInfo()
    {
        Debug.Log($"Hero {this.name} - {this.exp} EXP");
    }

    private void Reset()
    {
        this.name = "Not Assigned";
        this.exp = 0;
    }
    
}
