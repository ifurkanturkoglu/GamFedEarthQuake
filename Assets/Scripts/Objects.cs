using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    [SerializeField] private GameObject image;
    public GameObject[] tiks;
    public static bool isTakeAllObjects;
    public static int takingObjectCount = 0;
    bool tabMenuIsOpen;


    private void Awake()
    {

        image.SetActive(false);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            tabMenuIsOpen = !tabMenuIsOpen;
            image.SetActive(tabMenuIsOpen);
        }

        if (takingObjectCount < 30)
        {
            isTakeAllObjects = true;
        }
    }

}
