using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PowerupEffect
{   
    public float amount;
    public override void Apply(GameObject target)
    {
        if(target.GetComponent<PlayerHealth>().maxHealth != target.GetComponent<PlayerHealth>().Health){
            target.GetComponent<PlayerHealth>().Health += amount;
        }
        
    }
}
