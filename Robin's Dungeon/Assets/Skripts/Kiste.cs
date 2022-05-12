using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiste : Collectable
{
    public Sprite emptyChest;
    public int ectsAmount = 5;
   protected override void OnCollect()
   {
       if(!collected)
       {
           GetComponent<SpriteRenderer>().sprite = emptyChest;
           Debug.Log("Du hast: " + ectsAmount + " ECTS erhalten!");
           collected = true;
       }
     
   }
}
