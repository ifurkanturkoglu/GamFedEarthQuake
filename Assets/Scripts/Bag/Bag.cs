using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Bag : MonoBehaviour
{
    [SerializeField]PlayerController playerController;
    [SerializeField]TextMeshProUGUI dangerText;
    [SerializeField]GameObject rightHand;
    public static bool playerIsSafe,bagIsTake;
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
       if(Earthquake.earthquakeFinish && other.gameObject.name.Equals("Player") && Input.GetKeyDown(KeyCode.F) && !bagIsTake){
            transform.parent = rightHand.transform;
            transform.localPosition = new Vector3(0,0.3f,0);
            transform.localRotation = new Quaternion(-180,0,0,1);
            bagIsTake = true;
            
       }
    }
    void OnTriggerExit(Collider other)
    {
        playerIsSafe = false;
    }
}
