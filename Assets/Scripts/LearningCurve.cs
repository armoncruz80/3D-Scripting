using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    
    void Start()
    {
        Character hero = new Character();
        Debug.Log($"Hero: {hero.name} - {hero.exp} EXP");
    }

   
    
}
