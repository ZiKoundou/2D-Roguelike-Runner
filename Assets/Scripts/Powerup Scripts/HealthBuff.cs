using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PowerupEffect
{   
    public float amount;
    
    public override void Apply(GameObject target)
    {
        float health = target.GetComponentInParent<statController>().GetHealth();
        if(target.GetComponentInParent<statController>().GetMaxHealth() != health){
            health += amount;
            target.GetComponentInParent<statController>().SetHealth(health);
        }
        
        
    }
}
