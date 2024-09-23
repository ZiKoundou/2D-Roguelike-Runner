using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthbar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    public GameObject player;
    public float offset = 0f;
    // Start is called before the first frame update
    
    // Start is called before the first frame update
    public void UpdateHealthBar(float currentValue, float maxValue){
        
        slider.value = currentValue/maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new UnityEngine.Vector3(player.transform.position.x,player.transform.position.y+offset,0);
    }
}
