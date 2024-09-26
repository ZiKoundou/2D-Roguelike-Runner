using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public float destroyTime = 3f;
    public Vector3 textOffset = new Vector3 (0f,0.5f,0f);

    // Start is called before the first frame update
    void Start()
    {
        
        
        Destroy(gameObject, destroyTime);
        transform.localPosition += textOffset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
