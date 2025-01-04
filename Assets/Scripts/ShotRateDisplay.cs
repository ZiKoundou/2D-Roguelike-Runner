using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShotRateDisplay : MonoBehaviour
{
    statController statController;
    TextMeshProUGUI Text;
    float shotRate;
    // Start is called before the first frame update
    void Start()
    {
        statController = GetComponentInParent<statController>();
        Text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        shotRateUpdate();
    }

    void shotRateUpdate(){
         //turn text into speed string
        shotRate = statController.GetshotRate();
        //get speed in statcontroller
        Text.text = string.Format($"ShotRate: <color=black>{shotRate.ToString()}</color>");
    }
}
