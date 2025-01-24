using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageDisplay : MonoBehaviour
{
    statController statController;
    TextMeshProUGUI Text;

    private float damage;
    // Start is called before the first frame update
    void Start()
    {
        statController = GetComponentInParent<statController>();
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        DamageUpdate();
    }

    void DamageUpdate(){
        damage = statController.GetDamage();
        Text.text = string.Format($"Damage: <color=black>{damage.ToString()}</color>");
    }
}
