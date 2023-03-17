using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    public static GameObject image;
    public GameObject[] tiks;
    public static bool isTakeAllObjects;
    public static int takingObjectCount = 0;
    public static bool tabMenuIsOpen;

    void Awake()
    {
        image = GameObject.Find("Inventory");
    }
    void Start()
    {
        image.SetActive(false);
    }

    private void Update()
    {
        if (takingObjectCount < 10)
        {
            isTakeAllObjects = true;
            Missions.Instance.missionUpdate(1);
        }
    }

}
