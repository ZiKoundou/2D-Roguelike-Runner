using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    statController statController;
    TextMeshProUGUI text;
    private float speed;
    

    
    void Start()
    {
        statController = GetComponentInParent<statController>();
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        speedUpdate();
        //Debug.Log(statController.GetMoveSpeed().ToString());
    }

    void speedUpdate(){
         //turn text into speed string
        speed = statController.GetMoveSpeed();
        //get speed in statcontroller
        text.text = string.Format($"Speed <color=black>{speed.ToString()}</color>");
    }
}
