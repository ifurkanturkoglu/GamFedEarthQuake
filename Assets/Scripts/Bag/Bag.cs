using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bag : MonoBehaviour
{
    [SerializeField]PlayerController playerController;
    [SerializeField]Text dangerText;
    bool playerIsSafe;
    void Update()
    {
        
        if(EarthquakeBag.qitFinish && playerIsSafe && playerController.isCrouch){
            dangerText.gameObject.SetActive(false);
        }
       else if(Earthquake.earthquakeIsStart){
            dangerText.gameObject.SetActive(true);
       }
       else{
            dangerText.gameObject.SetActive(false);
       }
    }
    void OnTriggerStay(Collider other)
    {
       playerIsSafe = other.gameObject.name.Equals("Player") ? true : false;
    }
    void OnTriggerExit(Collider other)
    {
        playerIsSafe = false;
    }
}
