using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthQuakeStart : MonoBehaviour
{
    [SerializeField] GameObject camera,player;
    [SerializeField] Transform spawn1,spawn2,spawn3;
    [SerializeField]EarthquakeBag earthquakeBag;
    void Start()
    {
        Earthquake.earthquakeIsStart = true;
        Missions.Instance.missionUpdate(2);
        camera.GetComponent<CameraShake>().enabled = true;

        if(earthquakeBag.putBagPosition == spawn1){
            player.transform.localPosition= spawn1.GetChild(0).position;
        }
        else if (earthquakeBag.putBagPosition ==spawn2){
            player.transform.localPosition= spawn2.GetChild(0).position;
        }
        else if (earthquakeBag.putBagPosition ==spawn3){
            player.transform.localPosition= spawn3.GetChild(0).position;
        }
    }
}
