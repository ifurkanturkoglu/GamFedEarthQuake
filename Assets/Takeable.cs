using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takeable : MonoBehaviour
{
    public void Take(){
        print("take");
        Objects.takingObjectCount++;
        gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
