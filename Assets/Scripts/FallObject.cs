using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    float timer;
    Vector3 direction;
    Rigidbody rb;
    bool isFall = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        bool a = Earthquake.earthquakeIsStart;
        if(a && timer<=20 && !isFall ){
            timer +=Time.deltaTime;
            int random = Random.Range(0,4);
            switch (random)
            {
                case 0:
                    direction = transform.forward;
                    break;
                case 1:
                    direction = transform.forward*-1;
                    break;
                case 2:
                    direction = transform.right;
                    break;
                case 3:
                    direction = transform.right*-1;
                    break;
            }
            float force = Random.Range(800,1000);
            rb.AddForce(direction*Time.deltaTime*force,ForceMode.Acceleration);
        }
        else if(timer>3){
            isFall = true;
        }
    }
    public void fall(){
        isFall = false;
    }
}
