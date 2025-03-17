using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExe : MonoBehaviour
{
    private void Start()
    {
        Player player1 = new Player("Hero", 100);
        player1.TakeDamage(20);
    }
}
