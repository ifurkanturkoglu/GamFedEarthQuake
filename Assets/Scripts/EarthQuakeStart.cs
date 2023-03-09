using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthQuakeStart : MonoBehaviour
{
    [SerializeField] GameObject camera;
    void Start()
    {

        Earthquake.earthquakeIsStart = true;
        camera.GetComponent<CameraShake>().enabled = true;
    }
}
