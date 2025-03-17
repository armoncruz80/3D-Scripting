using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerV1 : MonoBehaviour
{
    private void Start()
    {
        Warrior warrior = new Warrior("Trevor", 100, 500);
        warrior.TakeDamage(50);
        warrior.Attack();
       
    }
}
