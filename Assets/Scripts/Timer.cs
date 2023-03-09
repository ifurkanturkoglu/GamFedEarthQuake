using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    private float time;
    public Text timer1;


    void Start()
    {
        time = 60;
        timer1.text = "" + time;
    }

    
    void Update()
    {
        time -= Time.deltaTime;
        timer1.text = "" + time;
        
    }
}
