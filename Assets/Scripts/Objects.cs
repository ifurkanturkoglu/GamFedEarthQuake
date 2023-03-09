using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    [SerializeField] private GameObject image;
    [SerializeField] private Image tik1;
    [SerializeField] private Image tik2;
    [SerializeField] private Image tik3;
    [SerializeField] private Image tik4;
    [SerializeField] private Image tik5;
    [SerializeField] private Image tik6;
    [SerializeField] private Image tik7;
    [SerializeField] private Image tik8;
    [SerializeField] private Image tik9;
    [SerializeField] private Image tik10;
    public static bool isTakeAllObjects;
    public static int takingObjectCount = 0;

    private void Awake()
    {
       image.SetActive(false);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            image.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            image.gameObject.SetActive(false);
        }
       if(takingObjectCount <30 ){
        isTakeAllObjects = true;
       }
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag=="su")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik1.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                

            }
        }
        if (other.gameObject.tag == "battaniye")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik2.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
        if (other.gameObject.tag == "wcKagit")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik3.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
        if (other.gameObject.tag == "gida")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik4.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
        if (other.gameObject.tag == "kalem")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik5.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
        if (other.gameObject.tag == "ilac")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik6.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
        if (other.gameObject.tag == "elma")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik7.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
        if (other.gameObject.tag == "telefon")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik8.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
        if (other.gameObject.tag == "powerbang")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik9.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
        if (other.gameObject.tag == "fener")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                takingObjectCount++;
                tik10.gameObject.SetActive(true);
                
                Destroy(other.gameObject);
                
            }
        }
    }
    
}
