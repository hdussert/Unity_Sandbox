using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandman : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float _min = 360;
        float _max = 720;
        float value = 540;
        float under = 0;
        float over = 1080;
        float test0 = Mathf.InverseLerp(_min, _max, value);
        float test1 = Mathf.InverseLerp(_min, _max, under);
        float test2 = Mathf.InverseLerp(_min, _max, over);
        Debug.Log(test0);
        Debug.Log(test1);
        Debug.Log(test2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
