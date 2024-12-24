using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreUpdater : MonoBehaviour
{
    TextMeshProUGUI Text;
    float score;
    // Start is called before the first frame update
    void Start()
    {
        Text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUpdate();
    }
    void ScoreUpdate(){
        score += Time.deltaTime * 20;
        Text.text = Mathf.FloorToInt(score).ToString();
    }
}
