using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;
    public Color Low;
    public Color High;
    Vector3 Offset;
    // Start is called before the first frame update
    public void UpdateHealthBar(float currentValue, float maxValue){
        
        
        slider.gameObject.SetActive(currentValue < maxValue);
        slider.value = currentValue;
        slider.maxValue = maxValue;
        slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low,High,slider.normalizedValue);
    }

    void Update(){
        //slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position = Offset);
    }
    
    // Update is called once per frame
    
}
