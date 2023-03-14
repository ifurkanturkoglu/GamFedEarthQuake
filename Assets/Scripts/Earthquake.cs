using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
public class Earthquake : MonoBehaviour
{
    [SerializeField] PlayableDirector playable;
    [SerializeField] GameObject[] fallObjects;
    public static float timer = 20;
    [SerializeField]public static bool earthquakeIsStart;
    float earthquakeCount =0;
    public static bool earthquakeFinish;
    int a = 0;

    void Start()
    {
        fallObjects = GameObject.FindGameObjectsWithTag("fallObject");
        
    }


    void Update()
    {
        if(EarthquakeBag.qitFinish && !earthquakeIsStart && earthquakeCount==0){
            earthquakeCount =1;
            StartCoroutine(EarthQuakeTimer());
            playable.Play();
        }
        if (earthquakeIsStart)
        {
            timer -= Time.deltaTime;
        }
        if(timer <=0 && a==0){
            a=1;
            earthquakeFinish = true;
            Missions.Instance.missionUpdate(3);
        }

    }
    IEnumerator EarthQuakeTimer()
    {
        while (timer >= 0)
        {
            int random = Random.Range(0, fallObjects.Length);
            fallObjects[random].GetComponent<FallObject>().fall();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
