using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float dampingSpeed = 1.0f;
    public float shakeDuration = 0f;
    public float shakeMagnitude = 0.1f;
    void Update()
    {
        if (shakeDuration > 0)
        {
            transform.position += Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
           Earthquake.earthquakeIsStart = false;
        }
    }
}
