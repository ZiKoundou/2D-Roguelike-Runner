using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SpeedBuff")]
public class SpeedBuff : PowerupEffect
{   
    public float amount;
    public override void Apply(GameObject target){
        //get set speed value and apply new amount to it :)
        if(target.tag != "obstacle"){
            float newAmount = target.GetComponentInParent<statController>().GetMoveSpeed() + amount;
            target.GetComponentInParent<statController>().SetMoveSpeed(newAmount);
        }
        
    }
}
