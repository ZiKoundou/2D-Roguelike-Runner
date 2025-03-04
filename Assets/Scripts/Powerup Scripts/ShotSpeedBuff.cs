using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/ShotSpeedBuff")]
public class ShotSpeedBuff : PowerupEffect
{   
    public float amount;
    public override void Apply(GameObject target){
        //get set speed value and apply new amount to it :)
        if(target.tag != "obstacle"){
            float newAmount = target.GetComponentInParent<statController>().GetShotSpeed() + amount;
            target.GetComponentInParent<statController>().SetShotSpeed(newAmount);
        }
        
    }
}
