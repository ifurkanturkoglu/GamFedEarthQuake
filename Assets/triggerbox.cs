using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class triggerbox : MonoBehaviour
{
    public GameObject canvas ;
  
    void OnTriggerEnter(Collider other)
   {
     
          canvas.gameObject.SetActive(true);
     
        
   }
   
        
   
}
