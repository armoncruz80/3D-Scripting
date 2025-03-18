using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    
    void Start()
    {
        ////FIRST INSTANCE OF THE CLASS CHARACTER
        //Character hero = new Character();
        //hero.PrintStatusInfo();

        ////SECOND INSTANCE OF THE CLASS CHARACTER
        //Character heroine = new Character("Agatha");
        //heroine.PrintStatusInfo();

        ////EXTRA INSTANTIATE
        //Character hero2 = new Character();
        //hero2.PrintStatusInfo();

        ////INSTANTIATE USING STRUCTS
        //Weapon huntingBow = new Weapon("Hunting Bow", 105);
        //huntingBow.PrintWeaponStats();


        ////DIFFERENCE BETWEEN CLASS AND STRUCTS
        //Character hero = new Character();
        //Character villain = hero;
        //villain.name = "Sir Kane the bold";

        //hero.PrintStatusInfo();
        //villain.PrintStatusInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow Unlimited";
        warBow.damage = 255;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();


        ////ENCAPSULATION
        //hero.PrintStatusInfo();
        //heroine.PrintStatusInfo();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatusInfo();
       


    }



}
