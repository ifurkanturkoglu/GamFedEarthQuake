using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EarthquakeBag : MonoBehaviour
{
    [SerializeField]Transform putBagPosition;
    [SerializeField] GameObject bag,currentPlaceablePlace;
    [SerializeField] Material placeableMaterial;
    public List<GameObject> playerColInArea;

    public static bool placeableIsActive, qitFinish;

    void Update()
    {
        if( Objects.isTakeAllObjects && !qitFinish &&currentPlaceablePlace  && Input.GetKeyDown(KeyCode.F)){
            bag.transform.parent = putBagPosition;
            bag.transform.position = putBagPosition.position;
            Color currentPlaceableColor = currentPlaceablePlace.GetComponent<Renderer>().material.color;
            currentPlaceableColor = placeableIsActive ? Color.green : Color.red;
            currentPlaceableColor.a = .25f;
            currentPlaceablePlace.GetComponent<Renderer>().material.color = currentPlaceableColor;
            if(placeableIsActive){
                qitFinish = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
            playerColInArea.Add(other.gameObject);
    }
    void OnTriggerStay(Collider other)
    {       
        
        if(other.gameObject.tag.Equals("Placeable")){
            putBagPosition = other.gameObject.transform;
            placeableIsActive = true;
        }
        if(other.gameObject.layer.Equals(LayerMask.NameToLayer("Place"))){
            currentPlaceablePlace = other.gameObject;
            if(other.gameObject.tag.Equals("Untagged")){
                putBagPosition = bag.transform;
                placeableIsActive = false;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        playerColInArea.Remove(other.gameObject);
        putBagPosition = null;
        placeableIsActive = false;
        currentPlaceablePlace = null;
    }
}