using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/DamageBuff")]

public class DamageBuff : PowerupEffect
{
    public float amount;
    public override void Apply(GameObject target){
        //get set speed value and apply new amount to it :)
        if(target.tag == "Player"){
            float newAmount = target.GetComponentInParent<statController>().GetDamage() + amount;
            target.GetComponentInParent<statController>().SetDamage(newAmount);
        }
        
    }
}
