using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public Transform CamTransform;

    private void Start()
    {
        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        Character2 hero = new Character2();
        Character2 villain = hero;
        villain.name = "Marvin";
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();


        Character2 heroin = new Character2("Mantha");
        heroin.PrintStatsInfo();

        Weapon1 huntingBow = new Weapon1("Hunting Bow", 105);
        Weapon1 warbow = huntingBow;
        warbow.name = "War Bow Unlimited";
        warbow.damage = 155;

        huntingBow.PrintWeaponStats();
        warbow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Marvin", huntingBow);
        knight.PrintStatsInfo();

        
    }
}
