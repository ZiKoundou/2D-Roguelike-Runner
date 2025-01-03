using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SpeedBuff")]
public class SpeedBuff : PowerupEffect
{   
    public float amount;
    public override void Apply(GameObject target){
        //get set speed value and apply new amount to it :)
        float newAmount = target.GetComponent<statController>().GetMoveSpeed() + amount;
        target.GetComponent<statController>().SetMoveSpeed(newAmount);
    }
}
