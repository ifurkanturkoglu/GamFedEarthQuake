using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeableObjects : MonoBehaviour, ITakeable
{
    Objects objects;
    PlayerController controller;
    public bool IsArea;
    void Start()
    {
        objects = GameObject.FindObjectOfType<Objects>();
        controller = GameObject.FindObjectOfType<PlayerController>();
    }
    void OnTriggerStay(Collider other)
    {
        if(controller.fKeyIsPush&& other.gameObject.name.Equals(controller.firstKitBag.name)){
            Take();
        }
    }
    public void Take()
    {
        for (int i = 0; i < objects.tiks.Length; i++)
        {
            if(objects.tiks[i].name == gameObject.name){
                objects.tiks[i].transform.GetChild(0).gameObject.SetActive(true);
                Objects.takingObjectCount++;
                Destroy(gameObject);
            }
        }
        AudioManager.Instance.playOneShotAudioClip("itemPickUp");
    }
}
