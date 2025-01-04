using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    statController statController;

    TextMeshProUGUI Text;
    private float health;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
        statController = GetComponentInParent<statController>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthUpdate();
    }

    void HealthUpdate(){
        health = statController.GetHealth();
        //get speed in statcontroller
        Text.text = string.Format($"Health: <color=black>{health.ToString()}</color>");
    }
}
